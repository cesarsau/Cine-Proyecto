using System;
using Cine.Data;
using Cine.iOS.Data;
using CoreFoundation;
using SystemConfiguration;
using Xamarin.Forms;

[assembly: Dependency(typeof(NetworkConnection))]

namespace Cine.iOS.Data
{
    public class NetworkConnection : INetworkConnection
    {
        public bool IsConnected { get; set; }

        public void CheckNetworkConnection()
        {
            InternetStatus();
        }

        public bool InternetStatus()
        {
            NetworkReachabilityFlags flags;
            bool DefaultNetworkAvailable = IsNetworkAvailable(out flags);
            if (DefaultNetworkAvailable && ((flags & NetworkReachabilityFlags.IsDirect) != 0))
            {
                return false;
            }
            else if ((flags & NetworkReachabilityFlags.IsWWAN) != 0)
            {
                return true;
            }
            else if (flags == 0)
            {
                return false;
            }
            return true;
        }

        private event EventHandler ReachabilityChanged;
        private void OnChange(NetworkReachabilityFlags flags)
        {
            var h = ReachabilityChanged;
            if (h != null)
                h(null, EventArgs.Empty);
        }

        private NetworkReachability DefaultReachability;
        public bool IsNetworkAvailable(out NetworkReachabilityFlags flags)
        {
            if (DefaultReachability == null)
            {
                DefaultReachability = new NetworkReachability(new System.Net.IPAddress(0));
                DefaultReachability.SetNotification(OnChange);
                DefaultReachability.Schedule(CFRunLoop.Current, CFRunLoop.ModeDefault);
            }
            if (!DefaultReachability.TryGetFlags(out flags))
            {
                return false;
            }
            return IsReachableWithoutRequiringConnection(flags);
        }

        private bool IsReachableWithoutRequiringConnection(NetworkReachabilityFlags flags)
        {
            bool IsReachable = (flags & NetworkReachabilityFlags.Reachable) != 0;
            bool NoConnectionRequired = (flags & NetworkReachabilityFlags.ConnectionRequired) == 0;

            if ((flags & NetworkReachabilityFlags.IsWWAN) != 0)
                NoConnectionRequired = true;
            return IsReachable && NoConnectionRequired;
        }
    }
}
using Cine.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Cine.ViewModels
{
    public class Validarviewmodels
    {
        public ObservableCollection<Validar> Peliculas { get; set; }
        public Validarviewmodels()
        {
            Peliculas = new ObservableCollection<Validar>
            {
                    new Validar
                    {
                       Nombre="Cesar Sauceda",
                       Direccion="Potrerillos",
                       Correo="cesarsauceda@unitec.edu",
                       Telefono="96392673",
                       Sobre="Ver peliculas seria mi pasatiempo si tuviera tiempo para uno",                      
                       opcion1="Comedia",
                       opcion2="Accion",
                       opcion3="Drama",
                       
                    },
                   

                    
             };
        }
    }
}

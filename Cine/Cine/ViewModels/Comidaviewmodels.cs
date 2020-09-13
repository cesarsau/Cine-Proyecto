using Cine.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Cine.ViewModels
{
    public class Comidaviewmodels
    {
        public ObservableCollection<Comida> Comida { get; set; }
        public Comidaviewmodels()
        {
            Comida = new ObservableCollection<Comida>
            {
                    new Comida
                    {
                        comida="Combo 1",
                        precio=135.50 ,
                        imagen="combo1.png"
                    },

                    new Comida
                    {
                        comida="Combo 2",
                        precio=155.50,
                        imagen="combo2.png"
                    },
                    new Comida
                    {
                        comida="Combo 3",
                        precio=85.50,
                        imagen="combo3.png"
                    },
                    new Comida
                    {
                        comida="extras",
                        imagen="hotdog.png"
                    }
             };
        }
    }
}

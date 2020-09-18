using Cine.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Cine.ViewModels
{
    public class Peliculasviewmodels
    {
        
        public ObservableCollection<Peliculas> Peliculas { get; set; }
        public Peliculasviewmodels()
        {
            Peliculas = new ObservableCollection<Peliculas>
            {
                    new Peliculas
                    {
                        Nombre="Mujer Maravilla",
                        Año=2020,
                        Categoria="Accion",
                        Imagen="maravilla.jpg"
                    },

                    new Peliculas
                    {
                        Nombre="Mision Rescate",
                        Año=2020,
                        Categoria="Accion y Aventura",
                        Imagen="mision.jpg"
                    },
                    new Peliculas
                    {
                        Nombre="Malefica 2",
                        Año=2019,
                        Categoria="Drama",
                        Imagen="malefica.jpg"
                    },
                     new Peliculas
                    {
                        Nombre="Avenger: End Game",
                        Año=2019,
                        Categoria="Accion",
                        Imagen="end.jpg"
                    },
                      new Peliculas
                    {
                        Nombre="John Wick 3",
                        Año=2019,
                        Categoria="Accion",
                        Imagen="jonh.jpg"
                    },
                    
                    new Peliculas
                    {
                        Nombre="El Rey Leon (Accion Live)",
                        Año=2019,
                        Categoria="Drama",
                        Imagen="leon.jpg"
                    },

                    new Peliculas
                    {
                        Nombre="Mulan",
                        Año=2020,
                        Categoria="Romance y Drama",
                        Imagen="mulan.jpg"
                    },
                    new Peliculas
                    {
                        Nombre="Animales Fantasticos 2",
                        Año=2019,
                        Categoria="Fantasia",
                        Imagen="animales.jpg"
                    },
                     new Peliculas
                    {
                        Nombre="Joker",
                        Año=2019,
                        Categoria="Accion y Drama",
                        Imagen="joker.jpg"
                    },
                      new Peliculas
                    {
                        Nombre="El tunel",
                        Año=2019,
                        Categoria="Suspenso",
                        Imagen="tunel.jpg"
                    }

             };
        }

      
    }
}

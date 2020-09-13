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
                        Nombre="El Enemigo Invisible",
                        Año=1912,
                        Categoria="Accion",
                        Imagen="enemigoinvisible.jpg",
                        Link="https://www.youtube.com/watch?v=hco-9OOgTOc"
                    },

                    new Peliculas
                    {
                        Nombre="El Valor del Trigo",
                        Año=1909,
                        Categoria="Romance y Drama",
                        Imagen="elvalordeltrigo.jpg",
                        Link="https://www.youtube.com/watch?v=jk15T8ghbtI"
                    },
                    new Peliculas
                    {
                        Nombre="La Sirena",
                        Año=1904,
                        Categoria="Accion y Fantasia",
                        Imagen="accionyfantasia.jpg"
                    },
                     new Peliculas
                    {
                        Nombre="El Beso",
                        Año=1886,
                        Categoria="Romance",
                        Imagen="elbeso.jpg"
                    },
                      new Peliculas
                    {
                        Nombre="Erase Un Tonto",
                        Año=1915,
                        Categoria="Drama",
                        Imagen="eraseuntonto.jpg"
                    },
                    
                    new Peliculas
                    {
                        Nombre="Amantes",
                        Año=2008,
                        Categoria="Romance",
                        Imagen="amantes.jpg"
                    },

                    new Peliculas
                    {
                        Nombre="Tormento",
                        Año=1964,
                        Categoria="Romance y Drama",
                        Imagen="tormento.jpg"
                    },
                    new Peliculas
                    {
                        Nombre="La Pantera Rosa",
                        Año=1963,
                        Categoria="Comedia",
                        Imagen="pantera.jpg"
                    },
                     new Peliculas
                    {
                        Nombre="Charlot, Artista de Cine",
                        Año=1914,
                        Categoria="Comedia",
                        Imagen="artista.jpg"
                    },
                      new Peliculas
                    {
                        Nombre="Fuego",
                        Año=1901,
                        Categoria="Drama",
                        Imagen="fuego.jpg"
                    }

             };
        }

      
    }
}

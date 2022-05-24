using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_classes
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Color CarColor { get; set; }
        public bodyStyle CarStyle { get; set; }

        public Car(string make, string model, int year, Color carColor, bodyStyle carStyle)
        {
            Make = make;
            Model = model;
            Year = year;
            CarColor = carColor;
            CarStyle = carStyle;

        }
        public Car() {}
    }
    public class Movie
    {
        //Class OBJECT

        public string Title { get; set; } //PROPERTY
        public string DirectorName { get; set; }
        public int Stars { get; set; }
        public Rating MovieRating { get; set; }
        public Genre MovieGenre { get; set; }

        //FULL CONSTRUCTOR
        public Movie(string title, string directorName, int stars, Rating movieRating, Genre movieGenre)
        {
            Title = title;
            DirectorName = directorName;
            Stars = stars;
            MovieRating = movieRating;
            MovieGenre = movieGenre;
        }


        //EMPTY CONSTRUCTOR
        public Movie() {}
    }

    public enum Rating {G, PG, PG_13, R, MA}
    public enum Genre { Action, Comedy, Drama, Horror, Romance, RomCom, Thriller, SciFi_Fantasy }


        
    public enum Color {red, green, blue, silver, black, yellow}
    public enum bodyStyle {coupe, sedan, hatchback, sport_car, minivan, suv, convertible}
}
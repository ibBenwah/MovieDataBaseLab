using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    internal class Movie
    {
       // Constructors 
        public Movie(string argTitle, string  argCategory)
        {
            Title = argTitle;
            Category = argCategory;
        }

        public Movie() { }
       

        //  Properties
        public string Title { get; set; }
        public string Category { get; set; }


        public void PrintMovieDetails()
        {
            Console.WriteLine(String.Format("{0, -15} {1, -15}", "Movie Name", Title));
            Console.WriteLine(String.Format("{0, -15} {1, -15}", "Category", Category));
        }    
    }
}

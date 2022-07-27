using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    internal class Category
    {
            public Category(Movie argMovie)
            {
            Movie = argMovie;
            }
            // Properties
            public Movie Movie { get; set; }
            

        }
    }

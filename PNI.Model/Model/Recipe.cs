using PNI.Model.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNI.Model.Model
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Time { get; set; }
        public Difficulty Difficulty { get; set; }
        public Rating Rating { get; set; }
        public string Discription { get; set; }
        public bool IsValidated { get; set; }


        public List<Category> Category { get; set; }
        public User User { get; set; }
        public Comment Comment { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}

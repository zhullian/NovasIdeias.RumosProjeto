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
        public string Discription { get; set; }
        public TimeSpan Time { get; set; }
        public Difficulty Difficulty { get; set; }
        public Rating Rating { get; set; }
        
        public bool IsValidated { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
        public Comment Comment { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Title}, {Discription}, {Time}, {Difficulty}, {Rating}, {IsValidated}, {Category}";
        }

        public Recipe()
        {

        }

        public Recipe(int id, string title, string discription,TimeSpan time, Difficulty difficulty, Rating rating, Category category,bool isValidated)
        {
            Id = id;
            Title = title;
            Discription = discription;
            Time = time;
            Difficulty = difficulty;
            Rating = rating;
            Category = category;
            IsValidated = isValidated;
        }

        public Recipe(string title, string discription, TimeSpan time, Difficulty difficulty, Category category)
        {
            Title = title;
            Discription = discription;
            Time = time;
            Difficulty = difficulty;
            Category = category;
        }
    }
}

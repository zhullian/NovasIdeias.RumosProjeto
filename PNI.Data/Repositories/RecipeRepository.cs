using PNI.Model.Model;
using PNI.Model.Model.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNI.Data.Repositories
{
    class RecipeRepository
    {
        private static string _cs = ConfigurationManager.ConnectionStrings["NovasIdeias"].ConnectionString;

        private static int _colRecipeId = 0;
        private static int _colRecipeTitle = 1;
        private static int _colRecipeTime = 2;
        private static int _colRecipeDifficulty = 3;
        private static int _colRecipeRating = 4;
        private static int _colRecipeDiscription = 5;
        private static int _colRecipeIsValidated = 6;
        

        public List<Recipe> GetAll()
        {
            List<Recipe> temp = new List<Recipe>();

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGet";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipe Recipe = new Recipe()
                    {
                        Id = dr.GetInt32(0),
                        Title = dr.GetString(1),
                        Time = dr.GetTimeSpan(2),
                        Difficulty = (Difficulty)dr.GetByte(3),
                        Rating = (Rating)dr.GetByte(4),
                        Discription = dr.GetString(5),
                        IsValidated = dr.GetBoolean(6)
                    };

                    temp.Add(Recipe);
                }
                return temp;
            }
        }

        public Recipe GetById(int id)
        {
            return null;
        }

        public void Add(Recipe recipe)
        {
            
        }
        public void Update(Recipe recipe)
        {

        }

        public void Remove(Recipe recipe)
        {

        }
    }
}

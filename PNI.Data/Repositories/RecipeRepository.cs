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
        private static int _colRecipeDiscription = 2;
        private static int _colRecipeTime = 3;
        private static int _colRecipeDifficulty = 4;
        private static int _colRecipeRating = 5;
        private static int _colRecipeIsValidated = 6;
        private static int _colRecipeCategory = 7;
        private static int _colRecipeIdUser = 8;
        

        public List<Recipe> GetAll()
        {
            List<Recipe> temp = new List<Recipe>();

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetAllRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipe Recipe = new Recipe()
                    {
                        Id = dr.GetInt32(0),
                        Title = dr.GetString(1),
                        Discription = dr.GetString(2),
                        Time = dr.GetTimeSpan(3),
                        Difficulty = (Difficulty)dr.GetByte(4),
                        Rating = (Rating)dr.GetByte(5),
                        IsValidated = dr.GetBoolean(6),
                        Category = (Category)dr.GetByte(7),
                        //User.Id = dr.GetInt32(8)
                    };

                    temp.Add(Recipe);
                }
                return temp;
            }
        }
        public List<Recipe> GetAllRecipesIsValidated()
        {
            List<Recipe> temp = new List<Recipe>();

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetRecipevalidated";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipe Recipe = new Recipe()
                    {
                        Id = dr.GetInt32(0),
                        Title = dr.GetString(1),
                        Discription = dr.GetString(2),
                        Time = dr.GetTimeSpan(3),
                        Difficulty = (Difficulty)dr.GetByte(4),
                        Rating = (Rating)dr.GetByte(5),
                        IsValidated = dr.GetBoolean(6),
                        Category = (Category)dr.GetByte(7),
                        //User.Id = dr.GetInt32(8)
                    };

                    temp.Add(Recipe);
                }
                return temp;
            }
        }

        public List<Recipe> GetRecipeNonValidated()
        {
            List<Recipe> temp = new List<Recipe>();

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetRecipeNonValidated";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipe recipe = new Recipe()
                    {
                        Id = dr.GetInt32(0),
                        Title = dr.GetString(1),
                        Discription = dr.GetString(2),
                        Time = dr.GetTimeSpan(3),
                        Difficulty = (Difficulty)dr.GetByte(4),
                        Rating = (Rating)dr.GetByte(5),
                        IsValidated = dr.GetBoolean(6),
                        Category = (Category)dr.GetByte(7),
                        //User.Id = dr.GetInt32(8)
                    };

                    temp.Add(recipe);
                }
                return temp;
            }
        }

        public Recipe GetById(int id)
        {
            SqlParameter Idparameter;


            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetRecipeId";
                cmd.CommandType = CommandType.StoredProcedure;

                Idparameter = new SqlParameter("@Id", id);
                Idparameter.Direction = ParameterDirection.Input;

                Idparameter.DbType = DbType.Int32;
                cmd.Parameters.Add(Idparameter);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                Recipe recipe = null;

                while (dr.Read())
                {
                    recipe = new Recipe();

                    recipe.Id = dr.GetInt32(0);
                    recipe.Title = dr.GetString(1);
                    recipe.Discription = dr.GetString(2);
                    recipe.Time = dr.GetTimeSpan(3);
                    recipe.Difficulty = (Difficulty)dr.GetByte(4);
                    recipe.Rating = (Rating)dr.GetByte(5);
                    recipe.IsValidated = dr.GetBoolean(6);
                    recipe.Category = (Category)dr.GetByte(7);
                }
                return recipe;
            }
        }

        public List<Recipe> GetByUserId(int id)
        {
            SqlParameter Idparameter;

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                List<Recipe> temp = new List<Recipe>();

                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetRecipeUserId";
                cmd.CommandType = CommandType.StoredProcedure;

                Idparameter = new SqlParameter("@UserId", id);
                Idparameter.Direction = ParameterDirection.Input;

                Idparameter.DbType = DbType.Int32;
                cmd.Parameters.Add(Idparameter);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                Recipe recipe = null;

                while (dr.Read())
                {
                    recipe = new Recipe();

                    recipe.Id = dr.GetInt32(0);
                    recipe.Title = dr.GetString(1);
                    recipe.Discription = dr.GetString(2);
                    recipe.Time = dr.GetTimeSpan(3);
                    recipe.Difficulty = (Difficulty)dr.GetByte(4);
                    recipe.Rating = (Rating)dr.GetByte(5);
                    recipe.IsValidated = dr.GetBoolean(6);
                    recipe.Category = (Category)dr.GetByte(7);

                    temp.Add(recipe);
                }
                return temp;
            }
        }

        public List<Recipe> GetByCategory(int category)
        {
            SqlParameter Idparameter;

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                List<Recipe> temp = new List<Recipe>();

                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetrecipeCategory";
                cmd.CommandType = CommandType.StoredProcedure;

                Idparameter = new SqlParameter("@Category", category);
                Idparameter.Direction = ParameterDirection.Input;

                Idparameter.DbType = DbType.Int32;
                cmd.Parameters.Add(Idparameter);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                Recipe recipe = null;

                while (dr.Read())
                {
                    recipe = new Recipe();

                    recipe.Id = dr.GetInt32(0);
                    recipe.Title = dr.GetString(1);
                    recipe.Discription = dr.GetString(2);
                    recipe.Time = dr.GetTimeSpan(3);
                    recipe.Difficulty = (Difficulty)dr.GetByte(4);
                    recipe.Rating = (Rating)dr.GetByte(5);
                    recipe.IsValidated = dr.GetBoolean(6);
                    recipe.Category = (Category)dr.GetByte(7);

                    temp.Add(recipe);
                }
                return temp;
            }
        }

        public List<Recipe> GetByName(string name)
        {
            SqlParameter Idparameter;

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                List<Recipe> temp = new List<Recipe>();

                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetrecipeName";
                cmd.CommandType = CommandType.StoredProcedure;

                Idparameter = new SqlParameter("@Name", name);
                Idparameter.Direction = ParameterDirection.Input;

                Idparameter.DbType = DbType.Int32;
                cmd.Parameters.Add(Idparameter);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                Recipe recipe = null;

                while (dr.Read())
                {
                    recipe = new Recipe();

                    recipe.Id = dr.GetInt32(0);
                    recipe.Title = dr.GetString(1);
                    recipe.Discription = dr.GetString(2);
                    recipe.Time = dr.GetTimeSpan(3);
                    recipe.Difficulty = (Difficulty)dr.GetByte(4);
                    recipe.Rating = (Rating)dr.GetByte(5);
                    recipe.IsValidated = dr.GetBoolean(6);
                    recipe.Category = (Category)dr.GetByte(7);

                    temp.Add(recipe);
                }
                return temp;
            }
        }

        public void Add(Recipe recipe)
        {
            using (SqlConnection con = new SqlConnection(_cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = ""
            }
        }
        public void Update(Recipe recipe)
        {

        }

        public void Remove(Recipe recipe)
        {

        }
    }
}

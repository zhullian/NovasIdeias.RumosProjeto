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
    public class UserRepository
    {
        
        private static string _cs = ConfigurationManager.ConnectionStrings["NovasIdeiasCs"].ConnectionString;

        private static int _colUserId = 0;
        private static int _colUserFirstName = 1;
        private static int _colUserMiddleName = 2;
        private static int _colUserLastName = 3;
        private static int _colUserBirthDate = 4;
        private static int _colUserEmail = 5;
        private static int _colUserGender = 6;
        private static int _colUserIsAdmin = 7;


        //GET ALL USERS FROM DB
        public List<User> GetAll()
        {
           
            List<User> allUser = new List<User>();
            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_cs))
            {
                //GIVE THE COMMAND
                SqlCommand cmd = connection.CreateCommand();

                //SQL QUERY TO SELECT ALL USERS FROM DB
                cmd.CommandText = "spGetAllUsers";
                cmd.CommandType = CommandType.StoredProcedure;

                //EXECUTE
                connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User();

                    user.Id = dr.GetInt32(_colUserId);
                    user.FirstName = dr.GetString(_colUserFirstName);
                    user.MiddleName = dr.IsDBNull(_colUserMiddleName) ? null : dr.GetString(_colUserMiddleName);
                    user.LastName = dr.GetString(_colUserLastName);
                    user.BirthDate = dr.GetDateTime(_colUserBirthDate);
                    user.Email = dr.GetString(_colUserEmail);
                    var genero = user.Gender = (Gender)dr.GetByte(_colUserGender);
                    if ((byte)genero == 0)
                    {
                        Gender gender = Gender.Male;

                        user.Gender = gender;
                    }
                    else if ((byte)genero == 1)
                    {
                        Gender gender = Gender.Female;

                            user.Gender = gender;
                    }
                    else
                    {
                        Gender gender = Gender.Other;
                            user.Gender = gender;
                    }


                    user.IsAdmin = dr.GetBoolean(_colUserIsAdmin);

                    allUser.Add(user);
                }
                 
            }
            return allUser;
        }

        public User GetById(int id)
        {
            SqlParameter idParameter;
            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_cs))
            {
                //GIVE COMMAND
                //SqlCommand cmd = new SqlCommand("spGetUserById", connection);
                SqlCommand cmd = connection.CreateCommand();


                //SQL QUERY SELECT * FROM User_tbl WHERE IdUser = @IdUser
                cmd.CommandText = "spGetUserById";
                cmd.CommandType = CommandType.StoredProcedure;


                /*No idParameter estamos a criar um parametro vazio
                 * Neste idParameter em baixo indicado estamos a dizer que o parametro em cima invocado
                 * vai ter como parametros "@IdUser e = id"(substitui em linguagem de C#)
                 * Estamos a dizer que a direccao do parametro é igual ao da SP
                 * Por fim estamos a dizer que o tipo de dado do id que está na tabela do SP é int32
                 */
                idParameter = new SqlParameter("@IdUser", id);
                idParameter.Direction = ParameterDirection.Input;
                idParameter.DbType = DbType.Int32;
                cmd.Parameters.Add(idParameter);
                //EXECUTE
                connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                User user = null;
               
                while (dr.Read())
                    
                {
                   user = new User();

                   user.Id = dr.GetInt32(_colUserId);
                   user.FirstName = dr.GetString(_colUserFirstName);
                   user.MiddleName = dr.IsDBNull(_colUserMiddleName) ? null : dr.GetString(_colUserMiddleName);
                   user.LastName = dr.GetString(_colUserLastName);
                   user.BirthDate = dr.GetDateTime(_colUserBirthDate);
                   user.Email = dr.GetString(_colUserEmail);
                    var genero = user.Gender = (Gender)dr.GetByte(_colUserGender);
                    if ((byte)genero == 0)
                    {
                        Gender gender = Gender.Male;

                        user.Gender = gender;
                    }
                    else if ((byte)genero == 1)
                    {
                        Gender gender = Gender.Female;

                        user.Gender = gender;
                    }
                    else
                    {
                        Gender gender = Gender.Other;
                        user.Gender = gender;
                    }
                    user.IsAdmin = dr.GetBoolean(_colUserIsAdmin);
                }

                return user;
            }
           
        }

        public void Add(User user)
        {

            using (SqlConnection connection = new SqlConnection(_cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "spInsertUser";

                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", user.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                //cmd.Parameters.AddWithValue("@IdAccount", user.Account);

                SqlParameter outParam = new SqlParameter();
                outParam.ParameterName = "@IdUser";
                outParam.SqlDbType = SqlDbType.Int;
                outParam.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(outParam);

                connection.Open();

                int id = (int)cmd.ExecuteScalar();
                user.Id = id;
                Console.WriteLine(id);
            }

        }
        public void Update(User user)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                //string query = "UPDATE User_tbl SET" +
                //    //"FirstName =  "
                                
            }
        }

        public void Remove(User user)
        {

        }
    }
}


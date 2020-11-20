using PNI.Model.Model;
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
    public class AccountRepository
    {
        private static string _cs = ConfigurationManager.ConnectionStrings["NovasIdeiasCs"].ConnectionString;
        private static int _colAccountId = 0;
        private static int _colaccountAccountUsername = 1;
        private static int _colaccountAccountPassword = 2;


        public AccountRepository()
        {
            
        }

        public List<Account> GetAll()
        {
            List<Account> accounts = new List<Account>();

            using (SqlConnection connection = new SqlConnection(_cs))
            {
                SqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "spGetAllAccounts";
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Account account = new Account();

                    account.Id = dr.GetInt32(_colAccountId);
                    account.Username = dr.GetString(_colAccountUsername);
                    account.Password = dr.GetString(_colAccountPassword);

                    accounts.Add(account);
                }
            }
            return accounts;
        }

        public Account GetById(int id)
        {
            SqlParameter idParameter;
            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_cs))
            {
                
                SqlCommand cmd = connection.CreateCommand();


                cmd.CommandText = "spGetAccountById";
                cmd.CommandType = CommandType.StoredProcedure;

                idParameter = new SqlParameter("@Idaccount", id);
                idParameter.Direction = ParameterDirection.Input;
                idParameter.DbType = DbType.Int32;
                cmd.Parameters.Add(idParameter);
              
                connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                account account = null;

                while (dr.Read())

                {
                    account = new account();

                    account.Id = dr.GetInt32(_colaccountId);
                    account.FirstName = dr.GetString(_colaccountFirstName);
                    account.MiddleName = dr.IsDBNull(_colaccountMiddleName) ? null : dr.GetString(_colaccountMiddleName);
                    account.LastName = dr.GetString(_colaccountLastName);
                    account.BirthDate = dr.GetDateTime(_colaccountBirthDate);
                    account.Email = dr.GetString(_colaccountEmail);
                    var genero = account.Gender = (Gender)dr.GetByte(_colaccountGender);
                    if ((byte)genero == 0)
                    {
                        Gender gender = Gender.Male;

                        account.Gender = gender;
                    }
                    else if ((byte)genero == 1)
                    {
                        Gender gender = Gender.Female;

                        account.Gender = gender;
                    }
                    else
                    {
                        Gender gender = Gender.Other;
                        account.Gender = gender;
                    }
                    account.IsAdmin = dr.GetBoolean(_colaccountIsAdmin);
                }

                return account;
            }
        }

        public void Add(Account Account)
        {
           
        }
        public void Update(Account Account)
        {
            
        }

        public void Remove(Account Account)
        {
            
        }

        public bool accountnameCheck (string accountname )
        {
            using (SqlConnection connection = new SqlConnection(_cs))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "SELECT count(Idaccount) FROM Account " +
                       "WHERE accountname == " + accountname;

                object obj = cmd.ExecuteScalar();
                int count = (int)obj;

                if (count > 0)
                    return true;


            }
            return false;
        }

    }
}


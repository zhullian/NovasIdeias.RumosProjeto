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
        private static string _cs;
        private static int _colAccountId = 0;
        private static int _colAccountUsername = 1;
        private static int _colAccountPassword = 2;
        private static int _colUserID = 3;


        public AccountRepository()
        {
            _cs = ConfigurationManager.ConnectionStrings["NovasIdeiasCs"].ConnectionString;
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

                Account account = null;

                while (dr.Read())

                {
                    account = new Account();

                    account.Id = dr.GetInt32(_colAccountId);
                    account.Username = dr.GetString(_colAccountUsername);
                    account.Password = dr.GetString(_colAccountPassword);
                    
                    
                }

                return account;
            }
        }

        public void Add(Account account)
        {
            using (SqlConnection connection = new SqlConnection(_cs))
            {
                //COMMAND
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spInsertAccount";

                cmd.Parameters.AddWithValue("@UserName", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@UserId", account.User.Id);

                SqlParameter idParam = new SqlParameter();
                idParam.ParameterName = "@IdAccount";
                idParam.SqlDbType = SqlDbType.Int;
                idParam.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(idParam);

                //EXECUTE
                connection.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                int id = (int)idParam.Value;
                account.Id = id;
            }
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


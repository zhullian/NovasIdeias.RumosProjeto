using PNI.Model.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNI.Model.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public Account Account { get; set; }
        public List<Comment> Comment { get; set; }



        public List<Recipe> OwnRecipes {
            get
            {
                return _OwnRecipes;
            }

            set
            {
                _OwnRecipes = value;
            } 
        
        }
        private List<Recipe> _OwnRecipes { get; set; }
        public List<Recipe> FavouriteList { get; set; }

        public User()
        {

        }

        public User(int id, string firstName, string middleName, string lastName, 
            DateTime birthDate, Gender gender, string email, bool isAdmin, Account account, 
            List<Comment> comment, List<Recipe> ownRecipes,  List<Recipe> favouriteList)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
            IsAdmin = isAdmin;
            Account = account;
            Comment = comment;
            OwnRecipes = ownRecipes;
            FavouriteList = favouriteList;
        }

        public User(string firstName, string middleName, string lastName,
                    DateTime birthDate, Gender gender, string email)
        {
           
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Id} {FirstName} {MiddleName} {LastName} {BirthDate.ToShortDateString()} {Gender} {Email} {IsAdmin} {Account}";

        }
    }
}

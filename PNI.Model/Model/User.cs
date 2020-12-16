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
        public  bool Blocked { get; set; }
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
        public List<Recipe> FavoriteRecipes { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, {FirstName}, {LastName}, {BirthDate.ToShortDateString()}, {Gender}, {Email}, IsAdmin: {IsAdmin}, Blocked: {Blocked}, Account: {Account}";
        }

        //Create builders to generate users
        public User()
        {

        }

        public User(int idUser, string firstName, string lastName, DateTime birthDate, Gender gender, string email, bool isAdmin, bool blocked, Account account, List<Recipe> ownRecipies, List<Recipe> favoriteRecipies)
        {
            Id = idUser;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
            IsAdmin = isAdmin;
            Blocked = blocked;
            Account = account;
            OwnRecipes = ownRecipies;
            FavoriteRecipes = favoriteRecipies;
        }

        public User(int idUser, string firstName, string lastName, DateTime birthDate, string email, bool isAdmin, bool blocked, Account account)
        {
            Id = idUser;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
            Blocked = blocked;
            Account = account;
            IsAdmin = isAdmin;
        }

        public User(string firstName, string lastName, DateTime birthDate, Gender gender, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
        }

        public User(string firstName, string lastName, DateTime birthDate, Gender gender, string email, bool isAdmin)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
            IsAdmin = isAdmin;
        }

        public User(string firstName, string lastName, DateTime birthDate, Gender gender, string email, bool isAdmin, bool blocked)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
            IsAdmin = isAdmin;
            Blocked = blocked;
        }
    }
}

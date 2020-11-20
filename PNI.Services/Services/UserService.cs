using PNI.Data.Repositories;
using PNI.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNI.Services.Services
{
    public class UserServices
    {

        private UserRepository _repo;
        //private AccountRepository _accountRepo;

        public UserServices()
        {
            _repo = new UserRepository();
            //_accountRepo = new AccountRepository();
        }

        public List<User> GetAll()
        {
            return _repo.GetAll();
        }

        public User GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(User user)
        {
            if (user == null)
                throw new Exception("you must be an registered user");
            //if (user.Account == null)
            //    throw new Exception("é obrigatório ter uma account");
            //if (_accountRepo.UsernameCheck(user.Account.Username))
            //    throw new Exception("Username already exists");

            _repo.Add(user);
        }
        public void Update(User user)
        {
            _repo.Update(user);
        }

        public void Remove(User user)
        {
            _repo.Remove(user);
        }
    }
}


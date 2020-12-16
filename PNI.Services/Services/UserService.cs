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
        private AccountRepository _accountRepo;

        public UserServices()
        {
            _repo = new UserRepository();
            _accountRepo = new AccountRepository();
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
                throw new Exception("User can't be null");

            if (user.FirstName == null)
                throw new Exception("User Name can't be null");

            _repo.Add(user);

            user.Account.User = user;
            Console.WriteLine(user);
            _accountRepo.Add(user.Account);
        }

        public void AddAdmin(User user)
        {
            if (user == null)
                throw new Exception("User can't be null");

            if (user.FirstName == null)
                throw new Exception("User Name can't be null");

            _repo.AddAdmin(user);

            user.Account.User = user;

            _accountRepo.Add(user.Account);

        }
        


    }
}


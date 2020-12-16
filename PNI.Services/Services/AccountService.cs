using PNI.Data.Repositories;
using PNI.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNI.Services.Services
{
    public class AccountService
    {
        private AccountRepository _repo;

        //Create builders to generate AccountService
        public AccountService()
        {
            _repo = new AccountRepository();
        }

        public List<Account> GetAll()
        {
            return _repo.GetAll();
        }

    }
}

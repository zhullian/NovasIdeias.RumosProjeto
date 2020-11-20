using PNI.Data.Repositories;
using PNI.Model.Model;
using PNI.Model.Model.Util;
using PNI.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PNI.ConsoleApp
{
    class Program
    {
        private static UserServices _userService = new UserServices();
        


        static void Main(string[] args)
        {
            List<User> users = _userService.GetAll();
            //Console.WriteLine(Digite o numero de ID pretendido: );
            //int numero = int.Parse(Console.ReadLine());

           
            foreach(User user in  users)
            {
                Console.WriteLine(user);
            }
            User newUser = new User();


            newUser.FirstName = "Manuel";
            newUser.MiddleName = "Ricardo";
            newUser.LastName = "Mateus";
            newUser.BirthDate = new DateTime(1990, 03, 04);
            newUser.Email = "exemplo@google.com";
            newUser.Gender = Gender.Male;


            
               

            _userService.Add(newUser);
            


            //foreach (var item in users)
            //{
            //    Console.WriteLine(item);
            //}            



            //User user = userService.GetById(numero);
            //Console.WriteLine(${user.Id},{user.FirstName},{user.LastName},{user.Email},Admin:{user.IsAdmin} );




        }
        
    }
}

    


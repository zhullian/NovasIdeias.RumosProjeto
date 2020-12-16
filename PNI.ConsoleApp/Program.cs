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

            UserServices userService = new UserServices();
            AccountService accountService = new AccountService();
            RecipeService recipeService = new RecipeService();
            IngredientService ingredientService = new IngredientService();

            //=====================
            //==    Ingredient   ==
            //=====================

            //Insert
            /*Ingredient ingredient = new Ingredient("Ovos");
            ingredientService.Insert(ingredient);
            */

            //GetAll
            List<Ingredient> ingredients = new List<Ingredient>();

            ingredients = ingredientService.GetAll();

            foreach (Ingredient ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }


            //=====================
            //==      Recipe     ==
            //=====================

            //GetAll
            List<Recipe> recipes = recipeService.GetAll();

            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine(recipe);
            }

            //Get Recipe By Id
            //Insert Recipe
            //Get Recipe by User Id

            //Get recipe by category
            /*List<Recipe> recipes = new List<Recipe>();
            
            recipes = recipeService.GetRecipesByCategory(3);
            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine(recipe);
            }*/

            //Get recipe by name 
            /*List<Recipe> recipes = new List<Recipe>();
            recipes = recipeService.GetRecipesByName("Teste");
            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine(recipe);
            }*/
            //=====================
            //==     Account     ==
            //=====================

            //GetAll
            /*List<Account> accounts = accountService.GetAll();
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }*/

            //Get Account by id            
            //Insert Account            


            //=====================
            //==      USER       ==
            //=====================

            //Get User by id
            /*User user = userService.GetById(36);
            Console.WriteLine(user);*/

            //Get User by FirstName
            /*User user = userService.GetByFirstName("Liliana");
            Console.WriteLine(user);*/

            //Insert User
            /*int year = 1977;
            int month = 8;
            int day = 3;
            User user = new User("Diogo", "Pinto", new DateTime(year, month, day), Gender.Male, "exemplo@exemplo.pt");
            userService.Insert(user);*/

            //Insert Admin
            /*int year = 1987;
            int month = 8;
            int day = 16;
            User user = new User("Ruben", "Sousa", new DateTime(year, month, day), Gender.Male, "exemplo@exemplo.pt", true);
            userService.InsertAdmin(user);*/


            //GetAll
            Console.WriteLine("==== User GetAll() ====");
            List<User> users = userService.GetAll();
            foreach (User item in users)
            {
                Console.WriteLine(item);
            }

        }
        
    }
}

    


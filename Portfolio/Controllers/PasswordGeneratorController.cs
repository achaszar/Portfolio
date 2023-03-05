using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class PasswordGeneratorController : Controller
    {
        //Create an instance of the model
        private GenPasswordViewModel passwordModel = new GenPasswordViewModel();

        public IActionResult Index()
        {
            return View(passwordModel);
        }
        public IActionResult GeneratePassword(int length, bool wantUpper, bool wantSymbols)
        {
            const string UpperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string DefaultPassword = "abcdefghijklmnopqrstuvwxyz01234567899876543210";
            const string Symbols = ".?!+-[]{}@$*.?!+-[]{}@$*";

            string myPassword = "";
            string passwordResult = "";

            if (wantUpper && wantSymbols)
            {
                myPassword = DefaultPassword + UpperLetters + Symbols;
            }
            
            else if (wantSymbols)
            {
                myPassword = DefaultPassword + Symbols;
            }

            else if (wantUpper)
            {
                myPassword = DefaultPassword + UpperLetters;
            }

            else
            {
                myPassword = DefaultPassword;
            }
                        
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                char letter = myPassword[random.Next(0, myPassword.Length)];
                passwordResult += letter;
            }
            passwordModel.PasswordResult = passwordResult;
            return View("Index", passwordModel);

        }
    }
}

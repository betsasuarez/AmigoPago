using AmigoPago.Models;
using AmigoPago.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoPago.Services
{
    public class LoginService : ILoginService
    {
        public async Task<bool> LoginAsync(string usuario, string password)
        {
           
            var result = false;

            if (string.IsNullOrEmpty(usuario))
            {
                return result;
            }
            if (string.IsNullOrEmpty(password))
            {
                return result;
            }
            await Task.Delay(250);
           
            string[] emailArray = Settings.EmailList.Split(',');
            var emailList = new List<KeyValuePair< int , string>>();
            
            for  (int i = 0; i < emailArray.Length; i++)
            {
                emailList.Add(new(i, emailArray[i]));
            }


            string[] passwordArray = Settings.PasswordList.Split(',');
            var passwordList = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < emailArray.Length; i++)
            {
                passwordList.Add(new(i, passwordArray[i]));
            }

            var loginDataEmail = emailList.FirstOrDefault( x => x.Value == usuario);
            if (loginDataEmail.Equals(default(KeyValuePair<string, string>))) 
            {
                return result;
            }
            var loginDatapassword = passwordList.FirstOrDefault(x => x.Key== loginDataEmail.Key);
            if (loginDatapassword.Equals(default(KeyValuePair<string, string>)))

            { 
                return result;
            }
            if (loginDatapassword.Value != password) 
            { 
                return result;
            }
            return true;
        }
        
    }
}

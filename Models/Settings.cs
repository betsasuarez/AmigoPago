using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoPago.Models
{
    internal class Settings
    {
        public static bool IsAuthenticated
        {
            get => Preferences.Default.Get(nameof(IsAuthenticated), false);
            set => Preferences.Default.Set(nameof(IsAuthenticated), value);
        }

        public static string EmailList
        {
            get => Preferences.Default.Get(nameof(EmailList), string.Empty);
            set => Preferences.Default.Set(nameof(EmailList), value);

        }
        public static string PasswordList
        {
            get => Preferences.Default.Get(nameof(PasswordList), string.Empty);
            set => Preferences.Default.Set(nameof(PasswordList), value);
        }
    }
}


    


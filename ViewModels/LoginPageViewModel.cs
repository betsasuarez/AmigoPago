using AmigoPago.Models;
using AmigoPago.Services.Interfaces;
using CommunityToolkit.Maui.Alerts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoPago.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly ILoginService loginService;

        public string Usuario { get; set; }
        public string Password { get; set; }
        public Command LoginCommand { get; set; }
        public LoginPageViewModel (ILoginService loginService)

        {  
            this.loginService = loginService;
            LoginCommand = new Command(LoginAsync);
            Settings.EmailList = "betsabesuarez1@outlook.es,mail@mail.com";
            Settings.PasswordList = "1234,4321";
        }
        private async void LoginAsync()
        {
            var validar = await loginService.LoginAsync(Usuario, Password);
            if(validar == false) 
            {
                await ShowToastAsync("NO FUE POSIBLE INICIAR SECCION");
                return;
            }
        }

        private async Task ShowToastAsync(string message)
        {
            // implement your logic here
            var toast = Toast.Make(message);
            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
            await toast.Show(cts.Token);
        }
    }
}
      






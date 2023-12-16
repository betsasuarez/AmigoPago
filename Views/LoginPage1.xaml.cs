using AmigoPago.ViewModels;

namespace AmigoPago.Views;

public partial class LoginPage1 : ContentPage
{
	public LoginPage1(LoginPageViewModel loginPageViewModel)
	{
		InitializeComponent();
		BindingContext = loginPageViewModel;
	}
}
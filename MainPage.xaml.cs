using Microsoft.Maui.Controls;

namespace TRINCA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            // Implementar lógica de autenticação
            // Exemplo:
            if (username == "admin" && password == "admin")
            {
                // Navegar para a próxima página ou exibir uma mensagem de sucesso
                DisplayAlert("Login", "Login bem-sucedido!", "OK");
            }
            else
            {
                // Exibir uma mensagem de erro
                DisplayAlert("Login", "Usuário ou senha inválidos.", "OK");
            }
        }

        private void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            // Navegar para a página de recuperação de senha
            // Navigation.PushAsync(new ForgotPasswordPage());
        }
    }
}

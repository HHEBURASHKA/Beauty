using System.Windows;

namespace BeautyShop
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        // Пример обработчика кнопки "Войти"
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Ваш код для проверки логина и пароля
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            // Для примера просто проверим, если поля не пустые
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ErrorMessage.Visibility = Visibility.Visible;
                ErrorMessage.Text = "Пожалуйста, заполните все поля.";
            }
            else
            {
                // Если все заполнено корректно, можно закрыть окно
                this.Close();
            }
        }
    }
}

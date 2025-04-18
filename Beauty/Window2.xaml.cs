using System.Windows;

namespace BeautyShop
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        // Пример обработчика кнопки "Зарегистрироваться"
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем введенные данные
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;
            string confirmPassword = ConfirmPasswordBox.Password;

            // Проверяем, что все поля заполнены и пароли совпадают
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                ErrorMessage.Visibility = Visibility.Visible;
                ErrorMessage.Text = "Пожалуйста, заполните все поля.";
            }
            else if (password != confirmPassword)
            {
                ErrorMessage.Visibility = Visibility.Visible;
                ErrorMessage.Text = "Пароли не совпадают.";
            }
            else
            {
                // Регистрация успешна (можно закрыть окно)
                // Для примера, просто закроем окно
                MessageBox.Show("Регистрация успешна!");
                this.Close();
            }
        }
    }
}

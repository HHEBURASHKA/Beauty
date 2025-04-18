using System.Windows;

namespace BeautyShop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Кнопка "Вход"
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
        }

        // Кнопка "Регистрация"
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.ShowDialog();
        }

        // Кнопка "Услуги"
        private void Services_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Раздел 'Услуги' пока в разработке.");
        }

        // Кнопка "Мастера"
        private void Masters_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Раздел 'Мастера' пока в разработке.");
        }

        // Кнопка "Запись"
        private void Booking_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Раздел 'Запись' пока в разработке.");
        }
    }
}

using System.Windows;
using System.Windows.Navigation;

namespace QUIZJUANPAEZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            frameMain.NavigationService.Navigate(new Login());
        }

    }
}

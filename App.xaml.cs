using MercatorisAdiutor.View;
using MercatorisAdiutor.ViewModel;
using System.Windows;

namespace MercatorisAdiutor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            Window view = new MainWindow();
            BaseViewModel viewModel = new MainViewModel();

            view.DataContext = viewModel;
            MainWindow = view;
            view.Show();
        }
    }
}

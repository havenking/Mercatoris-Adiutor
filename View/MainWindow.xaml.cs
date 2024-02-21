using MercatorisAdiutor.Model;
using MercatorisAdiutor.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MercatorisAdiutor.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel mainViewModel;

        public MainWindow()
        {
            InitializeComponent();

            mainViewModel = new MainViewModel();

            DataContext = mainViewModel;
            PlannerTab.DataContext = mainViewModel.PlannerViewModel;
            CatalogTab.DataContext = mainViewModel.CatalogViewModel;
            DetailsTab.DataContext = mainViewModel.DetailsViewModel;
        }
    }
}
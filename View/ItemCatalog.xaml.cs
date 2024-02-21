using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace MercatorisAdiutor.View
{
    public partial class ItemCatalog : UserControl
    {
        public ItemCatalog()
        {
            InitializeComponent();
        }

        private void NumericOnly(object sender, TextCompositionEventArgs e)
        {
            Regex reg = new Regex("[^0-9]");

            e.Handled = reg.IsMatch(e.Text);
        }
    }
}

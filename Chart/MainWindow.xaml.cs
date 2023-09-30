using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PodatociMVVM podatoci;

        public MainWindow()
        {
            InitializeComponent();

            podatoci = new PodatociMVVM();

            DataContext = podatoci;

            Item item = new Item { Col = "Col1", Value = 100};
            Item item2 = new Item { Col = "Col2", Value = 123 };
            Item item3 = new Item { Col = "Col3", Value = 78 };

            chtSummary.Series.Add(item);
            chtSummary.Series.Add(item2);
            chtSummary.Series.Add(item3);
        }
    }
}

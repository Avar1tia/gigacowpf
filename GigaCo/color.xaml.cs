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

namespace GigaCo
{
    /// <summary>
    /// Логика взаимодействия для color.xaml
    /// </summary>
    public partial class color : Page
    {
        public color()
        {
            InitializeComponent();
        }

        private void colors(object sender, RoutedEventArgs e)
        {
            string url = "https://github.com/Avar1tia/ColorPy";
            System.Diagnostics.Process.Start(url);
        }
    }
}

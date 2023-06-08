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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void siz(object sender, RoutedEventArgs e)
        {
            
                string url = "https://detect.roboflow.com/?model=hard-hat-sample-vsmw1&version=2&api_key=YMEWSICY2Hg8cmm0IQzU";
                System.Diagnostics.Process.Start(url);
            
        }
    }
}

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
    /// Логика взаимодействия для danger.xaml
    /// </summary>
    public partial class danger : Page
    {
        public danger()
        {
            InitializeComponent();
        }

        private void Danger(object sender, RoutedEventArgs e)
        {
            string url = "https://github.com/theAIGuysCode/yolov4-deepsort";
            System.Diagnostics.Process.Start(url);
        }
    }
}

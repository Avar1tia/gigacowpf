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
    /// Логика взаимодействия для detail.xaml
    /// </summary>
    public partial class detail : Page
    {
        public detail()
        {
            InitializeComponent();
        }

        private void detali_roboflow(object sender, RoutedEventArgs e)
        {
            string url = "https://universe.roboflow.com/ututduldtul/individual-xl4i2"; // Замените ссылкой на фактический URL вашего сайта
            System.Diagnostics.Process.Start(url);
        }

        private void poisk_detali(object sender, RoutedEventArgs e)
        {
            string url = "https://colab.research.google.com/drive/1kQ-ZN5I9L9k2pR597iqDkVnStrzTNs2E?usp=sharing"; // Замените ссылкой на фактический URL вашего сайта
            System.Diagnostics.Process.Start(url);
        }
    }
}

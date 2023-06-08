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
    /// Логика взаимодействия для kontrol_kachestva.xaml
    /// </summary>
    public partial class kontrol_kachestva : Page
    {
        public kontrol_kachestva()
        {
            InitializeComponent();
        }

        private void kontrol(object sender, RoutedEventArgs e)
        {
            string url = "https://github.com/Avar1tia/DeffectPy"; // Замените ссылкой на фактический URL вашего сайта
            System.Diagnostics.Process.Start(url);
        }
    }
}

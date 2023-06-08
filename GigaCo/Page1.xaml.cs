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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
          
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           менеджер._NavigationFrame.Navigate(new Page2());
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            //  var Window1 = new Window1(); //create your new form.
            //  Window1.Show(); //show the new form.
            //  this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            менеджер._NavigationFrame.Navigate(new Page3());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            менеджер._NavigationFrame.Navigate(new color());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            менеджер._NavigationFrame.Navigate(new danger());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            менеджер._NavigationFrame.Navigate(new kontrol_kachestva());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            менеджер._NavigationFrame.Navigate(new detail());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
          менеджер._NavigationFrame.Navigate(new qrcode());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            менеджер._NavigationFrame.Navigate(new razmer());
        }
    }
}

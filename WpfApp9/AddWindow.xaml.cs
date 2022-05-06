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
using System.Windows.Shapes;

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public Monitor MonitorMy { get; set; }
        public AddWindow()
        {
            InitializeComponent();
            MonitorMy = new Monitor();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            try
            {
                MonitorMy.Name = NameMonitor.Text;

                MonitorMy.Price = double.Parse(PriceMonitor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

    }
}
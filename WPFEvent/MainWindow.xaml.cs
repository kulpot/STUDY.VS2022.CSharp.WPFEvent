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

namespace WPFEvent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button = (Button)this.FindName("button");
            button.Click += button_MyOtherClick;
        }

        private void button_MyOtherClick(object sender, RoutedEventArgs e)
        {
            // code to execute when button is clicked
            myOtherLabel.Content = "My other click event";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Content = "Hello world";
        }
    }
}

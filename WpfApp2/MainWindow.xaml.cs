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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Show(object sender, RoutedEventArgs e)
        {
            //txt.Visibility = Visibility.Visible;
            if (true)
            {
                txt.Visibility = Visibility.Visible;
                ShowN.Visibility = Visibility.Hidden;
                HideN.Visibility = Visibility.Visible;
                pix.Visibility = Visibility.Visible;
            }
        }

        private void Hide(object sender, RoutedEventArgs e)
        {
            txt.Visibility = Visibility.Hidden;
            if (true)
            {
                ShowN.Visibility = Visibility.Visible;
                HideN.Visibility = Visibility.Hidden;
                pix.Visibility = Visibility.Hidden;
            } 
        }

        
        private void Toggle(object sender, RoutedEventArgs e)
        {


            if (true && txt.Visibility == Visibility.Visible)
            {
                txt.Visibility = Visibility.Hidden;
                pix.Visibility = Visibility.Hidden;
                //HideN.Visibility = Visibility.Visible;
                ShowN.Visibility = Visibility.Visible;
            }
            else
            {
                txt.Visibility = Visibility.Visible;
                pix.Visibility = Visibility.Visible;
                HideN.Visibility = Visibility.Hidden;
                ShowN.Visibility = Visibility.Hidden;
            }
            if (true && ShowN.Visibility == Visibility.Visible)
            {
                HideN.Visibility = Visibility.Hidden;
            }
        }   
    }
}
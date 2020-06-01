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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           string name =  textBox1.Text  ;
            labelName.Visibility = Visibility.Visible;
            labelName.Content = name;
          //  MessageBox.Show("Hello Muhammed");
        }

        private void CBmuhammed(object sender, RoutedEventArgs e)
        {
            labelName.Content = "Muhammed";
        }

        private void CBOmer(object sender, RoutedEventArgs e)
        {
            labelName.Content  += " Omer";
        }

        private void CBwalid(object sender, RoutedEventArgs e)
        {
            labelName.Content  += " Walid";
        }

        private void UNmuhammed(object sender, RoutedEventArgs e)
        {
            string name = labelName.Content.ToString();
            var myList = name.Split(' ').ToList();
            if (myList.Contains ( "Muhammed" ) )
            {
                myList.Remove("Muhammed");
                string newList = string.Join(" ", myList);
                labelName.Content = newList;
            }
            
        }

        private void UNomer(object sender, RoutedEventArgs e)
        {
            string name = labelName.Content.ToString();
            var myList = name.Split(' ').ToList();
            if (myList.Contains("Omer"))
            {
                myList.Remove("Omer");
                string newList = string.Join(" ", myList);
                labelName.Content = newList;
            }
        }

        private void UNwalid(object sender, RoutedEventArgs e)
        {
            string name = labelName.Content.ToString();
            var myList = name.Split(' ').ToList();
            if (myList.Contains("Walid"))
            {
                myList.Remove("Walid");
                string newList = string.Join(" ", myList);
                labelName.Content = newList;
            }
        }

      

        private void RDhassan(object sender, RoutedEventArgs e)
        {
            labelName.Content = "Hassan";
        }

        private void RDjasim(object sender, RoutedEventArgs e)
        {
            labelName.Content = "Jassim";
        }

        private void RDemad(object sender, RoutedEventArgs e)
        {
            labelName.Content = "Emad";
        }
    }
}

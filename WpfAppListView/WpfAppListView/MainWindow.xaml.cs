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

namespace WpfAppListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<User> items = new List<User>();
            items.Add(new User() { name = "Muhammed" , age=36});
            items.Add(new User() { name = "Ali", age = 22 });
            items.Add(new User() { name = "Essa", age = 44 });
            items.Add(new User() { name = "Omer", age = 55 });
            listViewSelect.ItemsSource = items;
        }

        private void ClickMe(object sender, RoutedEventArgs e)
        {
            labelShow.Content = listViewSelect.SelectedItem.ToString();

        }
    }


public class User
    {
        public string name { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return "Name: "+ this.name + " " +" Age: "+ this.age ;
        }
    }


}

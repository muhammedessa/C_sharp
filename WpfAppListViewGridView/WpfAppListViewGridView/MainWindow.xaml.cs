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

namespace WpfAppListViewGridView
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
            items.Add(new User() { Name = "Muhammed Essa", Age = 36, Mail = "muhammed.essa@gmail.com" });
            items.Add(new User() { Name = "Ahmed Samir", Age = 12, Mail = "muhammed.essa@gmail.com" });
            items.Add(new User() { Name = "Omer Ali", Age = 44, Mail = "muhammed.essa@gmail.com" });
            items.Add(new User() { Name = "Salim Hassan", Age = 22, Mail = "muhammed.essa@gmail.com" });
            items.Add(new User() { Name = "Shakir Khalid", Age = 77, Mail = "muhammed.essa@gmail.com" });
            UsersListView.ItemsSource = items;
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }

    }
}

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

namespace WpfAppDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Student> student = new List<Student>();
            student.Add(new Student() { ID = 1000 , Name ="Muhammed Essa",Age=36 , Birthday = new DateTime(1984, 10,14)});
            student.Add(new Student() { ID = 1001, Name = "Ahmed Ali", Age = 22, Birthday = new DateTime(1993, 02, 12) });
            student.Add(new Student() { ID = 1002, Name = "Hassan Omer", Age = 18, Birthday = new DateTime(1972, 04, 15) });
            student.Add(new Student() { ID = 1003, Name = "Khalid Hayder", Age = 24, Birthday = new DateTime(1999, 11, 22) });
            student.Add(new Student() { ID = 1004, Name = "Yousif Walid", Age = 14, Birthday = new DateTime(2004, 12, 17) });
            DataGridStudent.ItemsSource = student;
        }
    }
     
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
    }

}

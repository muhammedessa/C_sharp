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
using System.Configuration;

namespace Emplyees_Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();
        public MainWindow()
        {
            InitializeComponent();

            DataGridView1.ItemsSource = employeeRepository.GetAll();

        }

        private void saveEmployeeBtn(object sender, RoutedEventArgs e)
        {

            if(!string.IsNullOrEmpty(firstNameTxt.Text) &&
                !string.IsNullOrEmpty(lastNameTxt.Text))
            {
                employeeRepository.Add(new Employee
                {
                    FirstName = firstNameTxt.Text,
                    LastName = lastNameTxt.Text,
                });

                firstNameTxt.Text = string.Empty;
                lastNameTxt.Text = string.Empty;
                DataGridView1.ItemsSource = employeeRepository.GetAll();
            }
          
        }

        private void ClickCellItem(object sender, SelectionChangedEventArgs e)
        {

            if(DataGridView1.SelectedItems.Count > 0)
            {
                var row = DataGridView1.SelectedItems[0];
                var employee = (Employee)row;
                editID.Content = employee.id.ToString();
                editFirstNameTxt.Text = employee.FirstName;
                editLastNameTxt.Text = employee.LastName;
            }
             
        }

        private void UpdateBtn(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(editFirstNameTxt.Text) &&
             !string.IsNullOrEmpty(editLastNameTxt.Text))
            {
                employeeRepository.Update(new Employee
                {
                    id = int.Parse(editID.Content.ToString().Trim()),
                    FirstName = editFirstNameTxt.Text.Trim(),
                    LastName = editLastNameTxt.Text.Trim() 
                });

                editFirstNameTxt.Text = string.Empty;
                editLastNameTxt.Text = string.Empty;
                DataGridView1.ItemsSource = employeeRepository.GetAll();
            }
        }

        private void DeleteBtn(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(editID.Content.ToString().Trim()) )
            {
                employeeRepository.Delete(int.Parse(editID.Content.ToString().Trim()));

                editFirstNameTxt.Text = string.Empty;
                editLastNameTxt.Text = string.Empty;
                DataGridView1.ItemsSource = employeeRepository.GetAll();
            }
        }
    }
     

    }

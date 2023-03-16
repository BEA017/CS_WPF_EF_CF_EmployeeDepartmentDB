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

namespace WPF_EF_CF_EmployeeDepartmentDB.Models
{
    /// <summary>
    /// Interaction logic for Add_employee.xaml
    /// </summary>
    public partial class Add_employee : Window
    {
        MainWindow mw;
        MyDataContext dc;
        public Add_employee(MainWindow mw, MyDataContext dc)
        {
            InitializeComponent();
            this.mw = mw;
            this.dc = dc;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Parse(age_tb.Text);
                Employee entity = new Employee
                {
                    FirstName = firstName_tb.Text,
                    LastName = lastName_tb.Text,
                    Age = dt,
                    Address=address_tb.Text,
                    PhotoPath = photo_tb.Text
                };

                dc.Employees.Add(entity);

                dc.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mw.RefreshEmployees();
        }

        private void btn_choisePhoto_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "jpg Files (jpg)|*.jpg|png Files (png)|*.png|bmp Files (bmp)|*.bmp";
            dlg.Multiselect = false;

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                photo_tb.Text = dlg.FileName;
            }
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
using static Azure.Core.HttpHeader;

namespace WPF_EF_CF_EmployeeDepartmentDB.Models
{
    /// <summary>
    /// Interaction logic for Edit_Employee.xaml
    /// </summary>
    public partial class Edit_Employee : Window
    {
        MainWindow mw;
        MyDataContext dc;
        int eid;
        public Edit_Employee(MainWindow mw, MyDataContext dc)
        {
            InitializeComponent();
            this.dc= dc;
            this.mw = mw;
            fillTextboxes();
        }

        public void fillTextboxes()
        {
             MyEmployee selectedRow = mw.dataGridEmployees.SelectedItem as MyEmployee;
             
             eid = Convert.ToInt32(selectedRow.EmployeeId);
            firstName_tb.Text = selectedRow.FirstName;
            lastName_tb.Text = selectedRow.LastName;
            age_tb.Text = selectedRow.Age.ToString();
            address_tb.Text = selectedRow.Address;
            photo_tb.Text = selectedRow.PhotoPath;
        }
        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure?", " ", MessageBoxButton.YesNo);

            // Process message box results
            switch (result)
            {
                case MessageBoxResult.Yes:
                    //хранимая процедура возвращает количество самолетов у производителя

                    try
                    {
                        Employee del_employee = (from t in dc.Employees
                                                 where t.EmployeeId == eid
                                                 select t).FirstOrDefault();

                        if (del_employee == null)
                            return;

                        dc.Employees.Remove(del_employee);

                        dc.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("DELETED");
                        mw.RefreshEmployees();
                    }
                    this.Close();

                    break;

                    case MessageBoxResult.No:
                    this.Close();
                    break;

            }
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            //Take referense on object from DB   
            var selectedEntityDB = (from t in dc.Employees
                                    where t.EmployeeId == eid
                                    select t).First();

            if (selectedEntityDB == null)
                return;

            //update data from table to BD       
            selectedEntityDB.FirstName = firstName_tb.Text;
            selectedEntityDB.LastName = lastName_tb.Text;
            selectedEntityDB.Age = Convert.ToDateTime(age_tb.Text);
            selectedEntityDB.Address = address_tb.Text;
            selectedEntityDB.PhotoPath = photo_tb.Text;


            //sinchronize
            dc.SaveChanges();

            //Read data again from DB to table
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

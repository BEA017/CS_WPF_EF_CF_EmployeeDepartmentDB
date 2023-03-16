using System;
using System.Collections.Generic;
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

namespace WPF_EF_CF_EmployeeDepartmentDB.Models
{
    /// <summary>
    /// Interaction logic for Edit_Department.xaml
    /// </summary>
    public partial class Edit_Department : Window
    {
        MainWindow mw;
        MyDataContext dc;
        int did;
        public Edit_Department(MainWindow mw, MyDataContext dc)
        {
            InitializeComponent();
            this.dc = dc;
            this.mw = mw;
            fillTextboxes();
        }
        public void fillTextboxes()
        {
            MyDepartment selectedRow = mw.dataGridDepartment.SelectedItem as MyDepartment;

            did = Convert.ToInt32(selectedRow.DepartmentId);
            title_tb.Text = selectedRow.Title;
            headId_tb.Text = selectedRow.HeadId.ToString();
            address_tb.Text = selectedRow.Address;
            phone_tb.Text = selectedRow.PhoneNumber;
         }


        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Take referense on object from DB   
                var selectedEntityDB = (from t in dc.Departments
                                        where t.DepartmentId == did
                                        select t).First();

                if (selectedEntityDB == null)
                    return;

                //update data from table to BD       
                selectedEntityDB.Title = title_tb.Text;
                selectedEntityDB.HeadId = Convert.ToInt32(headId_tb.Text);
                selectedEntityDB.Address = address_tb.Text;
                selectedEntityDB.PhoneNumber = phone_tb.Text;


                //sinchronize
                dc.SaveChanges();

                //Read data again from DB to table
                mw.RefreshDepartment();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                        Department Del_department = (from t in dc.Departments
                                                   where t.DepartmentId == did
                                                 select t).FirstOrDefault();

                        if (Del_department == null)
                            return;

                        dc.Departments.Remove(Del_department);

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
    }
}

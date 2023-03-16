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
    /// Interaction logic for Edit_DE.xaml
    /// </summary>
    public partial class Edit_DE : Window
    {
        MainWindow mw;
        MyDataContext dc;
        int eidDE;
        int didDE;
        public Edit_DE(MainWindow mw, MyDataContext dc)
        {
            InitializeComponent();
            this.mw = mw;
            this.dc = dc;
            fillTextboxes();
        }
        public void fillTextboxes()
        {
            MyDepartmentEmployees selectedRow= mw.dataGridDepartmentEmployees.SelectedItem as MyDepartmentEmployees;
            eidDE = selectedRow.EmployeeId;
            didDE= selectedRow.DepartmentId;
            emplId_tb.Text = eidDE.ToString();
            deprtId_tb.Text = didDE.ToString();
        }


        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {

            try
            { //Take referense on object from DB   

                var selectedEntityDB = (from t in dc.DepartmentsEmployees
                                        where t.EmployeeId == eidDE
                                        select t).First();

                if (selectedEntityDB == null)
                    return;

                //update data from table to BD       
                selectedEntityDB.EmployeeId = Convert.ToInt32(emplId_tb.Text);
                selectedEntityDB.DepartmentId = Convert.ToInt32(deprtId_tb.Text);


                //sinchronize
                dc.SaveChanges();

                //Read data again from DB to table
                mw.RefreshDepartment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelBtn_click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure?", " ", MessageBoxButton.YesNo);

            // Process message box results
            switch (result)
            {
                case MessageBoxResult.Yes:
                    //хранимая процедура возвращает количество самолетов у производителя

                    try
                    {
                       /* Department Del_departmentEmpl = (from t in dc.DepartmentsEmployees
                                                     where t.EmployeeId == eidDE
                                                     select t).FirstOrDefault();

                        if (Del_departmentEmpl == null)
                            return;

                        dc.DepartmentsEmployees.Remove(Del_departmentEmpl);

                        dc.SaveChanges();*/

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

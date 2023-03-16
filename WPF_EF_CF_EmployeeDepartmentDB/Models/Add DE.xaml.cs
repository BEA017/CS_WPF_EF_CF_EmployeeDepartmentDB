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
    /// Interaction logic for Add_DE.xaml
    /// </summary>
    public partial class Add_DE : Window
    {
        MainWindow mw;
        MyDataContext dc;
        public Add_DE(MainWindow mw, MyDataContext dc)
        {
            InitializeComponent();
            this.mw = mw;
            this.dc = dc;
            
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                 DepartmentsEmployee entity = new DepartmentsEmployee
                 {
                    DepartmentId = Convert.ToInt32(deprtId_tb.Text),
                    EmployeeId = Convert.ToInt32(emplId_tb.Text)
                     
                };

                dc.DepartmentsEmployees.Add(entity);

                dc.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mw.RefreshEmployees();
        }
    }
}

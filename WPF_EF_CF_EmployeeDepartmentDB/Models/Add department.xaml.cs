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
    /// Interaction logic for Add_department.xaml
    /// </summary>
    public partial class Add_department : Window
    {
        MainWindow mw;
        MyDataContext dc;
        public Add_department(MainWindow mw, MyDataContext dc)
        {
            InitializeComponent();
            this.mw = mw;
            this.dc = dc;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                 Department entity = new Department
                 {
                    Title = title_tb.Text,
                    HeadId = Convert.ToInt32(headId_tb.Text),
                    Address = address_tb.Text,
                    PhoneNumber = phone_tb.Text,
                 };

                dc.Departments.Add(entity);

                dc.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mw.RefreshDepartment();
        }
    }
}

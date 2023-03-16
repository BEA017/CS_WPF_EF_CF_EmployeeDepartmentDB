using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_EF_CF_EmployeeDepartmentDB.Models;

namespace WPF_EF_CF_EmployeeDepartmentDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyDataContext dataContext = new MyDataContext();

        public MainWindow()
        {
            InitializeComponent();
        }
       
        public void RefreshDepartment()
        {           
            dataGridDepartment.ItemsSource = null;

            var results = from t in dataContext.Departments
                          select new MyDepartment
                          {
                             DepartmentId = t.DepartmentId,
                             Title =  t.Title,
                             HeadId = t.HeadId,
                             Address = t.Address,
                             PhoneNumber = t.PhoneNumber
                          };
            ObservableCollection<MyDepartment> observableCollection = new ObservableCollection<MyDepartment>(results);

            CollectionViewSource collection = new CollectionViewSource() { Source = observableCollection };
 
            dataGridDepartment.ItemsSource = collection.View;
        }

        public void RefreshEmployees()
        {
            dataGridEmployees.ItemsSource = null;

            var results = from t in dataContext.Employees
                          select new MyEmployee
                          {
                              EmployeeId = t.EmployeeId,
                              FirstName = t.FirstName,
                              LastName = t.LastName,
                              Age = t.Age,
                              Address = t.Address,
                              PhotoPath = t.PhotoPath
                          };
            ObservableCollection<MyEmployee> observableCollection = new ObservableCollection<MyEmployee>(results);

            CollectionViewSource collection = new CollectionViewSource() { Source = observableCollection };

            dataGridEmployees.ItemsSource = collection.View;
        }

        public void RefreshDE()
        {
            dataGridDepartmentEmployees.ItemsSource = null;

            var results = from t in dataContext.DepartmentsEmployees
                          select new MyDepartmentEmployees
                          {
                              EmployeeId = t.EmployeeId,
                              DepartmentId = t.DepartmentId,
                          };
            ObservableCollection<MyDepartmentEmployees> observableCollection = new ObservableCollection<MyDepartmentEmployees>(results);

            CollectionViewSource collection = new CollectionViewSource() { Source = observableCollection };

            dataGridDepartmentEmployees.ItemsSource = collection.View;
        }


        private void ShowDepBtn_Click(object sender, RoutedEventArgs e)
        {
            RefreshDepartment();
        }

        private void ShowEmpBtn_Click(object sender, RoutedEventArgs e)
        {
            RefreshEmployees();
        }

        private void ShowDE_Click(object sender, RoutedEventArgs e)
        {
            RefreshDE();
        }
        private void AddDepBtn_Click(object sender, RoutedEventArgs e)
        {
            Add_department adw = new Add_department(this, dataContext);
            adw.ShowDialog();
            adw.Focus();
        }

        private void AddEmpBtn_Click(object sender, RoutedEventArgs e)
        {
            Add_employee aew = new Add_employee(this, dataContext);
            aew.ShowDialog();
            aew.Focus();
        }
        private void AddDEBtn_Click(object sender, RoutedEventArgs e)
        {
            Add_DE ade = new Add_DE(this, dataContext);
            ade.ShowDialog();
            ade.Focus();
        }
        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (tableTabControl.SelectedItem == tableTabControl.Items[1] && dataGridEmployees.Items.Count!=0)
            {
                Edit_Employee eew= new Edit_Employee(this, dataContext);
                eew.ShowDialog();
                eew.Focus();
            }
            if (tableTabControl.SelectedItem == tableTabControl.Items[0] && dataGridDepartment.Items.Count!=0)
            {
                Edit_Department edw=new Edit_Department(this, dataContext);
                edw.ShowDialog();
                edw.Focus();
            }
            if (tableTabControl.SelectedItem == tableTabControl.Items[2] && dataGridDepartmentEmployees.Items.Count!=0)
            {
                Edit_DE edde = new Edit_DE(this, dataContext);
                edde.ShowDialog();
                edde.Focus();
            }
        }

        private void ConsolidTableBtn_Click(object sender, RoutedEventArgs e)
        {
           /* var result = (from em in dataContext.Employees
                          join emdp in dataContext.DepartmentsEmployees on em.EmployeeId equals emdp.EmployeeId
                          join d in dataContext.Departments on emdp.DepartmentId equals d.DepartmentId
                          select new MyConsolidateTable
                          {
                              EmployeeId = em.EmployeeId,
                              FirstName=em.FirstName,
                              LastName=em.LastName,
                              Title=d.Title,
                              DepartmentId=d.DepartmentId
                          });
            ConsolidateTableDG.ItemsSource = result;*/

          /*
            // Команда SQL для выполнения на сервере
          
            SqlCommand cmd2 = new SqlCommand("ConsolidateTable");

            

            // Исполнение хранимой процедуры на сервере
          SqlDataReader select=  cmd2.ExecuteReader();

            while (select.Read())
            {
                string str = select["FirtsName"] + "\t" + select["LadtName"] + "\t" + select["Tiyle"] ;
                dataGridDepartmentEmployees.Items.Add(str);
            }
             
          */
        }

        private void FindBtn_Click(object sender, RoutedEventArgs e)
        {
           string searchText= searchTb.Text;
            if (tableTabControl.SelectedItem == tableTabControl.Items[1])
            {
                foreach (var item in dataGridEmployees.Items)
                {
                    MyEmployee selectedRow = item as MyEmployee;
                    if (selectedRow != null)
                    {                       
                        if (selectedRow.EmployeeId.ToString()==searchText)
                        {
                            dataGridEmployees.SelectedItem= selectedRow;
                        }
                        if (selectedRow.FirstName == searchText)
                        {
                            dataGridEmployees.SelectedItem = selectedRow;
                        }
                        if (selectedRow.LastName == searchText)
                        {
                            dataGridEmployees.SelectedItem = selectedRow;
                        }
                        if (selectedRow.Age.ToString() == searchText)
                        {
                            dataGridEmployees.SelectedItem = selectedRow;
                        }
                        if (selectedRow.Address == searchText)
                        {
                            dataGridEmployees.SelectedItem = selectedRow;
                        }
                        if (selectedRow.PhotoPath == searchText)
                        {
                            dataGridEmployees.SelectedItem = selectedRow;
                        }
                    }
                } 
            }
            if (tableTabControl.SelectedItem == tableTabControl.Items[0])
            {
                foreach (var item in dataGridDepartment.Items)
                {
                    MyDepartment selectedRow = item as MyDepartment;
                    if (selectedRow != null)
                    {
                        if (selectedRow.DepartmentId.ToString() == searchText)
                        {
                            dataGridDepartment.SelectedItem = selectedRow;
                        }
                        if (selectedRow.Title == searchText)
                        {
                            dataGridDepartment.SelectedItem = selectedRow;
                        }
                        if (selectedRow.HeadId.ToString() == searchText)
                        {
                            dataGridDepartment.SelectedItem = selectedRow;
                        }
                        if (selectedRow.Address == searchText)
                        {
                            dataGridDepartment.SelectedItem = selectedRow;
                        }
                        if (selectedRow.PhoneNumber == searchText)
                        {
                            dataGridDepartment.SelectedItem = selectedRow;
                        }
                        
                    }
                }
            }
            if (tableTabControl.SelectedItem == tableTabControl.Items[2])
            {
                foreach (var item in dataGridDepartmentEmployees.Items)
                {
                    MyDepartmentEmployees selectedRow = item as MyDepartmentEmployees;
                    if (selectedRow != null)
                    {
                        if (selectedRow.DepartmentId.ToString() == searchText)
                        {
                            dataGridDepartmentEmployees.SelectedItem = selectedRow;
                        }
                        if (selectedRow.EmployeeId.ToString() == searchText)
                        {
                            dataGridDepartmentEmployees.SelectedItem = selectedRow;
                        }
                        
                    }
                }
            }
            
        }

        private void dataGridDepartment_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                var cnt = dataContext.Departments.Select(t => t).Count();
              
                if (dataGridDepartment.SelectedIndex >= cnt)
                {//add element

                  MyDepartment selectedRow = dataGridDepartment.SelectedItem as MyDepartment;

                    MyDepartment ai = new MyDepartment
                    {                         
                        Title = selectedRow.Title,
                        HeadId = selectedRow.HeadId,
                        Address = selectedRow.Address,
                        PhoneNumber = selectedRow.PhoneNumber
                    };

                    // Синхронизация с БД
                    dataContext.SaveChanges();

                    RefreshDepartment();
                    //
                    
                    
                }
                else//edit element
                {
                    //selected string in table with NEW data ( UpdateSourceTrigger=PropertyChanged)
                    MyDepartment selectedRow = dataGridDepartment.SelectedItem as MyDepartment;

                    // Take selected item id
                    int selectedId = selectedRow.DepartmentId;

                    //Take referense on object from DB   
                    var selectedEntityDB = (from t in dataContext.Departments
                                         where t.DepartmentId == selectedId
                                         select t).First();
                     
                    if (selectedEntityDB == null)
                        return;

                    //update data from table to BD       
                    selectedEntityDB.Title = selectedRow.Title;
                    selectedEntityDB.HeadId = selectedRow.HeadId;
                    selectedEntityDB.Address = selectedRow.Address;
                    selectedEntityDB.PhoneNumber = selectedRow.PhoneNumber;
                   

                    //sinchronize
                    dataContext.SaveChanges();

                    //Read data again from DB to table
                    RefreshDepartment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridEmployees_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
           try
           {
                var cnt = dataContext.Employees.Select(t => t).Count();

                if (dataGridEmployees.SelectedIndex >= cnt)
                {//add element
                     
                }
                else//edit element
                {
                    //selected string in table with NEW data ( UpdateSourceTrigger=PropertyChanged)
                    MyEmployee selectedRow = dataGridEmployees.SelectedItem as MyEmployee;

                    // Take selected item id
                    int selectedId = selectedRow.EmployeeId;

                    //Take referense on object from DB   
                    var selectedEntityDB = (from t in dataContext.Employees
                                            where t.EmployeeId == selectedId
                                            select t).First();

                    if (selectedEntityDB == null)
                        return;

                    //update data from table to BD
                     selectedEntityDB.FirstName = selectedRow.FirstName;
                    selectedEntityDB.LastName = selectedRow.LastName;
                    selectedEntityDB.Age = selectedRow.Age;
                    selectedEntityDB.Address = selectedRow.Address;
                    selectedEntityDB.PhotoPath = selectedRow.PhotoPath;


                    //sinchronize
                    dataContext.SaveChanges();

                    //Read data again from DB to table
                    RefreshDepartment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridDE_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                var cnt = dataContext.DepartmentsEmployees.Select(t => t).Count();

                if (dataGridDepartmentEmployees.SelectedIndex >= cnt)
                {//add element

                }
                else//edit element
                {
                    //selected string in table with NEW data ( UpdateSourceTrigger=PropertyChanged)
                    MyDepartmentEmployees selectedRow = dataGridDepartmentEmployees.SelectedItem as MyDepartmentEmployees;

                     // Take selected item id
                    int selectedId = selectedRow.EmployeeId;

                    //Take referense on object from DB   
                    var selectedEntityDB = (from t in dataContext.DepartmentsEmployees
                                            where t.EmployeeId == selectedId
                                            select t).First();

                    if (selectedEntityDB == null)
                        return;

                    //update data from table to BD       
                    selectedEntityDB.DepartmentId = selectedRow.DepartmentId;                    


                    //sinchronize
                    dataContext.SaveChanges();

                    //Read data again from DB to table
                    RefreshDepartment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeeItem_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            MyEmployee selectedRow = dataGridEmployees.SelectedItem as MyEmployee;
            if (selectedRow==null)
            {
                return;
            }      
            string selectedPathThoto = selectedRow.PhotoPath;
            if (selectedPathThoto!=null|| selectedPathThoto != "")
            {
                try
                {
                    ImageEmployee.Source = new BitmapImage(new Uri(selectedPathThoto));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                }
            }
          
        }

     
      
    }
}

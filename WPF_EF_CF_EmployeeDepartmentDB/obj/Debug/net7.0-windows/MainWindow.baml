   M S B A M L   `   `   `  ����Y  UWPF_EF_CF_EmployeeDepartmentDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:WPF_EF_CF_EmployeeDepartmentDBWPF_EF_CF_EmployeeDepartmentDB  5   	   /    )WPF_EF_CF_EmployeeDepartmentDB.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:WPF_EF_CF_EmployeeDepartmentDB     5   	     � Title$  
MainWindow��5   	   $	��450��6   $
��1099��6)   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $
��929* �6   6.   �� 5      $
��170* �6   6.   .+�5   
   �� -   5         ��Name$ tableTabControl��5      $��0��6.   $��	10,35,0,0q�6?   .@�5      �� $��
Department��6   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridDepartment��5      $��0,0,0,0q�68      AutoGenerateColumns$ False��6}      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ DepartmentId��6-      
IsReadOnly$
 True��6i      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6{   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6C   �� 
 �� Path$
 DepartmentId�6{     5      $ Title��6-   $
 auto 6�   	 6<   �� $
 Title� �� UpdateSourceTrigger$ PropertyChanged=�6�     5      $ HeadId��6-   $
 auto 6�   	 6=   �� $
 HeadId�$ PropertyChanged=�6�     5      $ Address��6-   $
 auto 6�   	 6>   �� $
 Address�$ PropertyChanged=�6�     5      $ Phone��6-   $
 auto 6�   	 6<   �� $
 PhoneNumber�$ PropertyChanged=�6�   5      5      �� 5      $��	Employees��6   .��5        -   5        $ dataGridEmployees��5      $��0,0,0,0q�67   $ False��6{    5!        5"      $ 
EmployeeId��6-   $
 True��6e   $
 Auto 6w   	 6A   �� $
 
EmployeeId�6w     5#      $ 
First name��6-   $
 Auto 6�   	 6A   �� $
 	FirstName�$ PropertyChanged=�6�     5$      $ 	Last name��6-   $
 auto 6�   	 6@   �� $
 LastName�$ PropertyChanged=�6�     5%      $	 Age��6-   $
 auto 6|   	 6:   �� $	
 Age�$ PropertyChanged=�6|     5&      $ Address��6-   $
 auto 6�   	 6>   �� $
 Address�$ PropertyChanged=�6�     5'      $ 	PhotoPath��6-   $
 auto 6�   	 6@   �� $
 	PhotoPath�$ PropertyChanged=�6�   5*      5+      �� 5,      $��Department-employees��6   .��5-        -   5        $! dataGridDepartmentEmployees��5-      $��0,0,0,0q�6A   $ False��6}    5/        50      $ 
EmployeeId��6-   $
 True��6e   $
 auto 6w   	 6A   �� $
 
EmployeeId�6w     51      $ DepartmentId��6-   $
 Auto 6�   	 6C   �� $
 DepartmentId�$ PropertyChanged=�6�   54      55      5B      �� 5D   
   -   5        $��0��5D      $��Update departments��6!   $
��Left=�6>   $��	10,10,0,0q�6Y   $	��Top=�6l   $	��113��6�   $��20��6�   
�������
�������6�   �� 5E   
   -   5        $��0��5E      $��Update employees��6!   $
��Left=�6<   $��
128,10,0,0q�6W   $	��Top=�6k   $	��105��6�   $��20��6�   
�������
�������6�   �� 5F   
   -   5        $��Add department��5F      $
��Left=�6*   $��
432,10,0,0q�6E   $	��Top=�6Y   $��94��6q   $��20��6�   
�������
�������6�   �� 5G   
   -   5        $��0��5G      $��Add employee��6!   $
��Left=�68   $��
530,10,0,0q�6S   $	��Top=�6g   $��85��6   $��20��6�   
�������
�������6�   �� 5H   
   -	   5        $��0��5H      $
��Edit��6!   $
��Left=�60   $��
704,10,0,0q�6K   $	��Top=�6_   $��57��6w   $��20��6�   
������
�������6�   �� 5I   
   -
   5        $��0��5I      $ ��Update department-employee��6!   $
��Left=�6F   $��
238,10,0,0q�6a   $	��Top=�6u   $��20��6�   $	��174��6�   
�������
�������6�   �� 5K   
   -   5         ��Name$ searchTb��5K   "   $��1��6   $��Center=�64   $��0,46,0,0q�6Q    �� TextWrapping$
 Wrap=�6c   $	��Top=�6y   $	��150��6�   $��21��6�   �� 5L   
   -   5        $��1��5L      $
��Find��6!   $
��Left=�60   $��
119,72,0,0q�6K   $	��Top=�6_   
����ح�
����ح�$��41��6�   6�   �� 5M   
   -   5         ��Name$ ImageEmployee��5M      $��1��6'   $
��Left=�68    K� ZIndex$ 5��6S   $	��180��6d   $��
17,137,0,0q�6q   $	��Top=�6�   $	��140��6�   �� 5N   
   -   5        $��Add DE��5N      $
��Left=�6"   $��
620,10,0,0q�6=   $	��Top=�6Q   $��79��6i   
�������
�������6�   5R      5S      
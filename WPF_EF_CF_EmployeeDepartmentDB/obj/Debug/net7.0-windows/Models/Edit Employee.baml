   M S B A M L   `   `   `  ����Y  UWPF_EF_CF_EmployeeDepartmentDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:WPF_EF_CF_EmployeeDepartmentDB.Models%WPF_EF_CF_EmployeeDepartmentDB.Models  5   	   9    3WPF_EF_CF_EmployeeDepartmentDB.Models.Edit_Employee   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:WPF_EF_CF_EmployeeDepartmentDB.Models     5   	     � Title$  Edit employee��5   	   $	��350��6   $	��295��6,    � 
ResizeMode$ NoResize=�68   .��5	      � $	��340��6   $	��Top=�6   $��0,0,10,0q�60   .+�5   
   �� $��10,10,-15,10q�6   .+�5      �� $��First name:��6   $��20��6+   $
��auto��67   $��0,0,186,214q�6D   �� 5      $��
Last name:��6   $��20��6+   $��0,40,185,174q�67   �� 5      $
��Age:��6   $��20��6%   $
��auto��61   
 �� Top$ 80��6>   �� 5      $��Address:��6   $��20��6)   $
��auto��65   $��0,120,185,94q�6B   �� 5      -   5         ��Name$ firstName_tb��5      $��20��6,   $ 20��68   $	��250��6H   �� 5      -   5        $ lastName_tb��5      $��20��6,   $ 60��68   $	��250��6H   �� 5      -   5        $ age_tb��5      $��20��6&   $	 100��62   $	��250��6C   �� 5      -   5        $ 
address_tb��5      $��20��6+   $	 140��67   $	��250��6H   �� 5      $��Photo:��6   $��20��6'   $
��auto��63   $
��Left=�6@   $	 202��6[   $��Center=�6l    �� Left$ 1��6�   �� 5      -   5        $ photo_tb��5      $��20��6(   $	 222��64   $	��250��6E   $��Center=�6Q   $	��Top=�6n   �� 5      -   5         ��Name$ btn_choisePhoto��5      $	��...��6.   $ 40��6<   $	 197��6M   $
��Left=�6^   $	��Top=�6y   $��40��6�   6�   �� 5      -   5        $ btn_add��5      $
��Edit��6&   $
��Left=�65   $��22��6P   $	��Top=�6\   $	��130��6t   $	 120��6�   $	 258��6�   �� 5      -   5        $��Delete��5      $ 10��6&   $	 259��67   
���  ��6Y   5      5      5      
   M S B A M L   `   `   `  ����L  HEmplyees Database, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Emplyees_DatabaseEmplyees_Database  5   	   "    Emplyees_Database.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Emplyees_Database     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��5* �6   �� 5      $	��48* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridView1��5      $
��Left=�6*   $	��342��6E   $��	38,37,0,0q�6R   $	��Top=�6e   $	��374��6}   $��2��6�   6�   �� 5   
   $��Add Employee��6   $��1��6'   $
��Left=�67   $��
473,37,0,0q�6R   $	��Top=�6f   $��31��6~   $	��172��6�   �� 5   
   -   5         ��Name$ firstNameTxt��5      $��1��6(   $
��Left=�68   $��23��6S   $��
473,73,0,0q�6_    �� TextWrapping$
 Wrap=�6s   $��
First name��6�   $	��Top=�6�   $	��191��6�   �� 5   
   -   5        $ lastNameTxt��5      $��1��6'   $
��Left=�67   $��24��6R   $��473,110,0,0q�6^   $
 Wrap=�6s   $��	Last name��6�   $	��Top=�6�   $	��191��6�   �� 5   
   $��Delete or Update��6   $��1��6+   $
��Left=�6;   $��473,220,0,0q�6V   $	��Top=�6k    J� RenderTransformOrigin$ 	0.513,0.5&�6�   $	��139��6�   $��24��6�   �� 5   
   -   5        $ editFirstNameTxt��5      $��1��6,   $
��Left=�6<   $��22��6W   $��473,288,0,0q�6c   $
 Wrap=�6x   $��
first name��6�   $	��Top=�6�   $	��172��6�   �� 5   
   -   5        $ editLastNameTxt��5      $��1��6+   $
��Left=�6;   $��22��6V   $��473,324,0,0q�6b   $
 Wrap=�6w   $��	last name��6�   $	��Top=�6�   $	��172��6�   �� 5   
   -   5         ��Name$ editID��5      $��id��6    $��1��6-   $
��Left=�6=   $��473,259,0,0q�6X   $	��Top=�6m   $ 	0.513,0.5&�6�   $	��139��6�   $��24��6�   �� 5   
   -   5         ��Name$ addBtn��5      $
��Save��6!   $��1��60   $
��Left=�6@   $��473,152,0,0q�6[   $	��Top=�6p   $	��191��6�   6�   �� 5   
   -   5        $ 	updateBtn��5      $��Update��6$   $��1��65   $
��Left=�6E   $��473,364,0,0q�6`   $	��Top=�6u   $��75��6�   6�   �� 5   
   -	   5        $ 	deleteBtn��5      $��Delete��6$   $��1��65   $
��Left=�6E   $��570,364,0,0q�6`   $	��Top=�6u   $��75��6�   6�   5      5      
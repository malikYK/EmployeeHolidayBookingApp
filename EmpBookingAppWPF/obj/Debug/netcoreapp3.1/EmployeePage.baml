   M S B A M L   `   `   `  ����K  GEmpBookingAppWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:EmpBookingAppWPFEmpBookingAppWPF  5      #    EmpBookingAppWPF.EmployeePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:EmpBookingAppWPF     5        N� Title$  EmployeePage��5      $	��436��6   $	��849��6)   .��5
      � .+�5   
   �� $��EMPLOYEE PAGE��6   $	��Top=�6)   $
��Left=�6A   $��24(�6\   $��	10,10,0,0q�6j   �� 5   
   $��Managers��6   $
��Left=�6#   $��467,117,0,0q�6>   $	��Top=�6S   $��44��6k   $��72��6w   
�������6�   �� 5   
   $��Holiday��6   $
��Left=�6"   $��467,168,0,0q�6=   $	��Top=�6R   
�������6j   �� 5   
   -   5         ��Name$ ManagersComboBox��5      $
��Left=�6-   $��544,121,0,0q�6H   $	��Top=�6]   $	��193��6u   $��29��6�   �� 5   
   -   5        $ Holiday_typecomboBox��5      $
��Left=�61   $��544,168,0,0q�6L   $	��Top=�6a   $	��193��6y   $��26��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ StartDatePicker��5      $
��Left=�6.   $��544,223,0,0q�6I   $	��Top=�6^   $	��193��6v     5   
   -   5        $ EndDatePicker��5      $
��Left=�6,   $��544,265,0,0q�6G   $	��Top=�6\   $	��193��6t   �� 5   
   -   5        $��Make Request��5      $
��Left=�6(   $��544,331,0,0q�6C   $	��Top=�6X   $��48��6p   $	��168��6|   $
��Bold"�6�   ��5      �� 5       �� ImageSource$< 6/beautiful-color-ui-gradients-backgrounds-roseanna.png��6   5      �� 5   
   -   5         ��Name$ RequestListBox��5      $��10,47,425,10q�6*   
�������$
��Bold"�6i   ��6@   Z� 6i   �� 5   
   $��
Start Date��6   $
��Left=�6%   $��467,223,0,0q�6@   $	��Top=�6U   
�������6m   �� 5   
   $��End Date��6   $
��Left=�6#   $��467,264,0,0q�6>   $	��Top=�6S   
�������6k   �� 5   
   $��	Employees��6   $
��Left=�6$   $��
467,55,0,0q�6?   $	��Top=�6S   $��44��6k   $��72��6w   
�������6�   �� 5   
   -   5        $ emplpoyessComboBox��5      $
��Left=�6/   $��
544,59,0,0q�6J   $	��Top=�6^   $	��193��6v   $��29��6�   5      5      
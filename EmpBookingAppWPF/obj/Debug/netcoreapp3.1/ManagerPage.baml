   M S B A M L   `   `   `  ����K  GEmpBookingAppWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:EmpBookingAppWPFEmpBookingAppWPF  5      "    EmpBookingAppWPF.ManagerPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:EmpBookingAppWPF     5        N� Title$  ManagerPage��5      $	��478��6   $	��849��6(   .��5
      � .+�5   
   �� $��Manager Page��6   $
��Left=�6(   $	��Top=�6C   $��24(�6[   $��	21,21,0,0q�6i   �� 5   
   $��Managers��6   $
��Left=�6#   $��437,123,0,0q�6>   $	��Top=�6S   $��52��6k   $	��107��6w   
�������$
��Bold"�6�   $��16(�6�   �� 5   
   $��Holiday��6   $
��Left=�6"   $��437,184,0,0q�6=   $	��Top=�6R   
�������$��31��6}   $��75��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   $��
Start Date��6   $
��Left=�6%   $��437,249,0,0q�6@   $	��Top=�6U   
�������$��31��6�   $��93��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   $��End Date��6   $
��Left=�6#   $��437,298,0,0q�6>   $	��Top=�6S   
�������$��31��6~   $��86��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   $��	Employees��6   $
��Left=�6$   $��
437,49,0,0q�6?   $	��Top=�6S   $��52��6k   $	��107��6w   
�������$
��Bold"�6�   $��16(�6�   �� 5   
   -   5         ��Name$ EmployeesTB��5      $
��Left=�6'   $��
590,49,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��177��6�   $��21��6�   $
��Bold"�6�   $��16(�6�   ${�False��6�   �� 5   
   -   5        $ 
HolidaysTB��5      $
��Left=�6&   $��590,128,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��177��6�   $��21��6�   $
��Bold"�6�   $��16(�6�   ${�False��6�   �� 5   
   -   5        $ 
ManagersTB��5      $
��Left=�6'   $��590,191,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��177��6�   $��21��6�   $
��Bold"�6�   $��16(�6�   ${�False��6�   �� 5   
   -   5        $ StartDateTB��5      $
��Left=�6'   $��590,254,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��177��6�   $��21��6�   $
��Bold"�6�   $��16(�6�   ${�False��6�   �� 5   
   -   5        $ 	EndDateTB��5      $
��Left=�6%   $��590,307,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��177��6�   $��22��6�   $
��Bold"�6�   $��16(�6�   ${�False��6�   �� 5   
   -   5         ��Name$ ConfirmButton��5      $��Confirm Request��6(   $
��Left=�6B   $��595,420,0,0q�6]   $	��Top=�6r   $��30��6�   $	��162��6�   $
��Bold"�6�   
���   ���5      �� 5       �� ImageSource$< 6/beautiful-color-ui-gradients-backgrounds-roseanna.png��6   5      �� 5   
   -   5         ��Name$ StatusComboBox��5      $
��Left=�6+   $��595,364,0,0q�6F   $	��Top=�6[   $	��169��6s    J� RenderTransformOrigin$ 1.296,0.528&�6   $��27��6�   .@�5      �� 
�������$��Approved��6.   $
��Bold"�6A   $��14(�6S   �� 5      
�������$��Denied��6.   $
��Bold"�6?   $��14(�6Q   5      �� 5"   
   -   5         ��Name$ RequestList��5"      $��21,75,442,28q�6(    �� View 5#      �� 5$      .P�5%      �� 5&      5(      �� 5)   
   $��Status��6   $
��Left=�6!   $��437,360,0,0q�6<   $	��Top=�6Q   
�������$��31��6|   $��86��6�   $
��Bold"�6�   $��16(�6�   5*      5+      
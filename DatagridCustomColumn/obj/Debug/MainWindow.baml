   M S B A M L   `   `   `  ����O  KDatagridCustomColumn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DatagridCustomColumnDatagridCustomColumn  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   %    DatagridCustomColumn.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:DatagridCustomColumn     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  Data Grid Basic��5
   	   $��368.608��6!   $��1134.766��62   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� -   5        $��ButtonShowSelected��5   B   $��0��6   $��10q�6   $��Show Selected��6*   $	��100��5   8   $��30��6D   $��Right=�6P   &   System.Windows.Controls.DataGrid  5   
   -   5        $��DataGridBasic��5      $��10q�6(      AutoGenerateColumns .     HeadersVisibility$ Column=�5   9      AlternatingRowBackground
 �����
����iA�   FrozenColumnCount$ 2��5      $
��1200��6)      CanUserAddRows .  $��1��5   *      SelectionMode$ Single=�67      SelectionUnit$ FullRow=�6N   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
First Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	FirstName+  5      $
 	Last Name��6%   $ * 68    6C   �� *
LastName+  5      $
 Email��6%   $ * 64    6?   �� *Email+4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $
 	Is Active��6)   $ 80 6<      SortMemberPath$ 	FirstName��5   )    5   G   �� *
IsActive+5   )   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Date of Birth��6)   $ * 6@   $ DateOfBirth��6J      CellTemplate 5      �� 5      .R�5       (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *DateOfBirth+5!      5#        5$      $
 Date Accepted��6)   $ * 6@   $ DateAccepted��5%   )    5&      �� 5'      .R�5(         6)   �� *DateAccepted+5)      5+      5	  /System.Windows.Controls.DataGridHyperlinkColumn	  5,      $	
 Url��6*   $ * 6O    67   �� *Url+6O   4
  .System.Windows.Controls.DataGridComboBoxColumn
  5-      -   5        ColumnCountry��$
 Country��5-   @   $ * 6Q    
  SelectedItemBinding 5.   )   �� *	Country+ 
  DisplayMemberPath 5/   )   �� *	Country+ 
  ItemsSource 50      -  'System.Windows.Data.CompositeCollection  51      ��52      	Indonesia��64   ��53      Malaysia��63   ��54      	Singapore��64   ��55      	Australia��64   ��56      USA��6.   ��57      UK��6-   58      5;        5<      $ * 6)   $
 Technologies��63    5=      �� 5>      .R�5?      ��  �� SelectedIndex$ 0��6L   ��6'   �� *Technologies+6L   5@      5B      5D      5E      5F      
   M S B A M L   `   `   `  ����M  IBasicCustomCommand, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BasicCustomCommandBasicCustomCommand  5   	   #    BasicCustomCommand.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BasicCustomCommand     5   	     � Title$  
MainWindow��5   	   $	��329��6   $	��453��6)    � DataContext 5	      !   BasicCustomCommand.NameList  5
   
   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��
First Name��6   $��5q�6&   $��Center=�61   �� 5   
   $��1��6   $��5q�6"   $��4q�6-   $��18(�69   ��5      �� *	FirstName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��1��6   $��	Last Name��6!   $��5q�62   $��Center=�6=   �� 5   
   $��1��6   $��1��6   $��5q�6/   $��4q�6:   $��18(�6F   ��5      �� *
LastName+$ TwoWay=�$ PropertyChanged=�� 5    
    � Orientation$ 
Horizontal=�6   $��1��6-   $��2��6=   $��Right=�6J   .+�5!      �� $	��Add��6   $��80��6#   $��5q�6.   ��69   �� *
AddCommand+��6X   �� �� 5"      $��Remove��6   $��80��6&   $��5q�61   ��6<   �� *RemoveCommand+��6^   �� �� 5#      $��Remove Selected��6   $	��120��6/   $��5q�6;   ��6F   �� *RemoveSelectedCommand+��6p   ��  �� ElementName$ ListBoxData�� �� Path$ SelectedItems�5%      �� 5'   
   $��Names��6   $��5q�6!   $��3��6,   �� 5(   
   -   5        $��ListBoxData��5(      $��3��6%   	 �� SelectionMode$	 Extended=�62   $��1��5)      $��5q�6"   ��6-   �� *Names+
 �� SelectedItem
 6K   �� *SelectedName+�� 5*   
   $
��Info��6   $��1��6    $��5q�60   $��4��5+      $��80��6   $��Right=�6)   ��5*   ;   �� *InfoCommand+��6[   �� $ ListBoxData��$ SelectedItem�5+   )   5,      5-      
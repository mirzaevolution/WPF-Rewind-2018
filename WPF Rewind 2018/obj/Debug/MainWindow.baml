   M S B A M L   `   `   `  ����J  FWPF Rewind 2018, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPF_Rewind_2018WPF_Rewind_2018  5   	        WPF_Rewind_2018.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WPF_Rewind_2018     5   	     � Icon$  computer.ico��5       � Title$ Simple Form��5   	   $	��259��6   $��423.333��6*   $	��259��6:   $	��430��6J   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��100 �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��
First Name��6   $��10q�6&   $��Center=�62   �� 5   
   -   5        $��textBoxFirstName��5      $��10q�6*   $��3q�66   $��1��6B   �� 5   
   $��	Last Name��6   $��10q�6%   $��Center=�61   $��1��6L   �� 5   
   -   5        $��textBoxLastName��5      $��10q�6)   $��3q�65   $��1��6A   $��1��6Q   �� 5   
   $��Date Of Birth��6   $��10q�6)   $��Center=�65   $��2��6P   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��datePickerDateOfBirth��5      $��10q�62   $��1��6>   $��2��6N   $��Center=�6[   �� 5   
   $	��Sex��6   $��10q�6   $��Center=�6+   $��3��6F   �� 5   
   $��1��6   $��3��6%    �� Orientation$ 
Horizontal=�62   .+�5       	� -   5        $��radioButtonMale��5    *    	� 	GroupName$	 sex��6   $
��Male��6A   $��10q�6P   $��Center=�6\    d� 	IsChecked$
 TrueY�6w   	� 5!      -   5        $��radioButtonFemale��5!   *   $	 sex��6   $��Female��6C   $��10q�6T   $��Center=�6`   5#      �� 5$   
   -   5        $��buttonShowJson��5$      $��1��6'   $��4��67   $	��120��6D   $��5q�6P   $��Right=�6[   .��5%   -   	Show Json5'      5)      5*      
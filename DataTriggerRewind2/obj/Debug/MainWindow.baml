   M S B A M L   `   `   `  ����M  IDataTriggerRewind2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DataTriggerRewind2DataTriggerRewind2  5   	   #    DataTriggerRewind2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DataTriggerRewind2     5   	     � Title$  
MainWindow��5   	   $��207.66��6   $��388.51��6,    � 	Resources 5	      *   $DataTriggerRewind2.EmptyBoxConverter   EmptyBoxConverter �� 
TargetType  ButtonLogin �� Triggers ^� 
Conditions �� Binding �� 	Converter �� Value �� Property	 �� Value��%!  &	        &	      7   7     5
   
   6"   �� 5   
   " ��6    5      ^� 5       5      �� 5       6$   �� *
EmployeeID+8    06p   �� 5       6$   �� *Email+8   06k   0�5      �� 5       � {�	 .  66   5      5      5      .��5      �� .+�5   
   �� -   5        
 ��Name$
 LabelEmployeeID��5      $��Employee ID��6)    �� Left$ 21��6?   
 �� Top$ 31��6P   �� 5   
   -   5         ��Name$ TextBoxEmployeeID��5      $��23��6-    �� TextWrapping$
 Wrap=�69   $	��234��6M   $	 102��6Y   $ 35��6k   ��5      �� *
EmployeeID+ �� Mode$ TwoWay=��� 5   
   -   5        $
 
LabelEmail��5      $��Email��6$   $ 21��64   $ 77��6E   �� 5   
   -   5        $ TextBoxEmail��5      $��23��6(   $
 Wrap=�64   $	��234��6H   $	 102��6T   $ 80��6f   ��5       �� *Email+$ TwoWay=��� 5"   
   -   5         ��Name$ ButtonValidate��5"      $��Validate��6)   $��75��6<   $	 175��6G   $	 132��6Y   #��[ 5#   .   �� 5$   
   -   5        $ ButtonCancel��5$      $��Cancel��6'   $��75��68   $	 261��6C   $	 132��6U   5%      5(      5)      
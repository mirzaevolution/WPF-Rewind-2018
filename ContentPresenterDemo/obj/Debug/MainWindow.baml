   M S B A M L   `   `   `  ����O  KContentPresenterDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ContentPresenterDemoContentPresenterDemo  5   	   %    ContentPresenterDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ContentPresenterDemo     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5
         ButtonStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value N� EnterActions		 �� To
 g� Duration �� TargetProperty N� ExitActions ]� 
Conditions �� Property �� Value  ButtonTemplate �� 
TargetType � Cursor��%D  &	        &	 {    �� 5   
   " ��6$   .�5      ��  � �� �#4446+   �� 5       � ��
 �����6+    5      P� 5       �@J�IsMouseOver .  5      �� 5      .��5      �� .��5   "   �� $
	 #222X�61   $
 0:0:0.3D�6;   $ Background.Color�5   =   5      5       5      �� 5      .��5      �� .��5   "   �� $
	 #444X�61   $
 0:0:0.3D�6;   $ Background.Color�5   =   5      5      5       ]� 5!       5"      �� 5#       �@J�IsMouseOver . 6;   �� 5$       � �� . 69   /�5&      �� 5'       � ��
 �   �67   5)      5+      �� 5,   
   " ��61   .R�5-      � $
 Hand��6   .+�5.      A� #��z��5/      #��z��50      #��z��51      53      �� 54      $��Center=�6#   55      56      57      .��58      � .+�59   
   �� -   5        $��Center=�59      $��Center=�6/   #��[  5:   '   $	��100��5;      $	��100��6   #��[ 6*   .��5<      ��  �� Orientation$ 
Horizontal=�6   .+�5=      �� $��30��6   $��30��6$   $��/mgr21-ico.ico��6/   $��2q�6G   �� 5>      $��Launch��6   $��2q�6*   $��Center=�65   5?      5@      5A      5B      
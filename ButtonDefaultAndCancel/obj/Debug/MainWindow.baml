   M S B A M L   `   `   `  ����Q  MButtonDefaultAndCancel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ButtonDefaultAndCancelButtonDefaultAndCancel  5   	   '    !ButtonDefaultAndCancel.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ButtonDefaultAndCancel     5   	     � Title$  
MainWindow��5   	   $��240.643��6   $��387.852��6-    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '�� }     'G� �     '�� e    �� 5
   
   " ��6   �5      �� 5       � ��$ 0,3,5,5q�6+   �� 5       � ��$
 Bold"�6/   5      �� 5   
   " ��6   �5      �� 5       � ��$ 5q�6+   �� 5       � ��$ 3q�6,   5      �� 5   
   " G�6   �5      �� 5       � ��$ 5q�6+   �� 5       � ��$ 3q�6,   5      �� 5   
   " ��6   �5      �� 5       � ��$ 5q�6+   �� 5       � ��$ 4q�6,   �� 5        � ��$ 70��6*   �� 5!       � ��
 �����6/   �� 5"       � ��
 ��iA�60   �� 5#       � ��$ 1q�64   �� 5$       � ��
 ��  �6/   �� 5%       �@�Cursor$
 Hand��6+   5'      5)      .��5*      � .+�5+   
   �� $��Center=�6   $��10q�5,      $��Center=�5-      
�������$��1q�5/      $��10q�6%   ��50      �� 51       �� Orientation$ 
Horizontal=�6   .+�52      �� $��Webdings)�6   $��17(�62   .��6@   Ï6C   �� 53      $��Black"�6   .��6/   Login66   54      .��56      �  � RowDefinitions 57      �� 58      $
��auto �6$   �� 59      $
��auto �6$   �� 5:      $
��auto �6$    � ColumnDefinitions 5<      �� 5=      $
��auto �6'   �� 5>      $	��250 �6'   .+�5@      �� $��Username��6   $��0��6,   $��0��6<   �� 5A      -   5        $��TextBoxUserName��5A      $��1��61   $��0��6A   �� 5B      $��Password��6   $��0��6,   $��1��6<   G� 5C      -   5        $��TextBoxPassword��5C      $��1��65   $��1��6E   �� 5E      $��1��6   $��2��6-   $ 
Horizontal=�5F      $��Right=�66   .+�5G      �� -   5        $��ButtonLogin��5G      $��Login��60    �� 	IsDefault . 6Q   �� 5H      -   5        $��ButtonCancel��5H      $��Cancel��61   	 �� IsCancel	 . 6R   5I      5J      5K      5L      5M      
   M S B A M L   `   `   `  ����G  CMultiBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MultiBindingMultiBinding  5   	       MultiBinding.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MultiBinding     5   	     � Title$  
MainWindow��5      $	��350��6   $��391.5��6$    � 	Resources 5	         MultiBinding.RGBConverter   RGBConverter��%   &	          5
   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��auto �6   .+�5   
   �� 
���   �$	��1.5q�6%   ._�5      �� -   5        $��CanvasDrawing��5      ��5      `� 5       `� 	Converter# [  6#    �� FallbackValue$ 255,255,255��6M   .1�5      ��  �� ElementName$ 	SliderRed��6"    �� Path$ Value�6:   �� 5      $ SliderGreen��6"   $ Value�6<   �� 5      $ 
SliderBlue��6"   $ Value�6;   5      5      5      �� 5   
   $��1��6   $��10q�6"   .+�5      ]� $��3q�6   .+�5      �� 
���  ��$��10��6*   $
��Left=�65   �� 5      $	��Red��6   $��80��6'   $��4q�62   $
��Left=�6>   �� 5       -   5        $��TextRedValue��5       $��4q�6y   $��Right=�6�   ��60   �� $ 	SliderRed��$ Value� �� StringFormat$ ({0})��6�   �� 5!      -   5        $��	SliderRed��5!      $��4q�6*    � Maximum$	 255Q�65   	 � Minimum$	 0Q�6C   
 �� IsSnapToTickEnabled
 .  �� TickPlacement$ TopLeft=�5"      $��Right=�61   5#      ]� 5$      $��3q�6   .+�5%      �� 
��� � �$��10��6,   �� 5&      $��Green��6   $��80��6)   $��4q�64   �� 5'      -   5        $��TextGreenValue��5'      $��4q�6}   $��Right=�6�   ��62   �� $ SliderGreen��$ Value�$ ({0})��6�   �� 5(      -   5        $��SliderGreen��5(      $��4q�6,   $	 255Q�67   $	 0Q�6E   
 . $ TopLeft=�5)      5*      ]� 5+      $��3q�6   .+�5,      �� 
����  �$��10��6+   �� 5-      $
��Blue��6   $��80��6(   $��4q�63   �� 5.      -   5        $��TextBlueValue��5.      $��4q�6{   $��Right=�6�   ��61   �� $ 
SliderBlue��$ Value�$ ({0})��6�   �� 50      -   5        $��
SliderBlue��50      $��4q�6+   $	 255Q�66   $	 0Q�6D   
 . $ TopLeft=�51      52      53      54      55      
   M S B A M L   `   `   `  ����P  LRenderTransformRewind, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:RenderTransformRewindRenderTransformRewind  5   	   &     RenderTransformRewind.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:RenderTransformRewind     5   	     � Title$  
MainWindow��5   	   $��214.516��6   $��356.672��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��2��6    �� Orientation$ 
Horizontal=�6)   $��Center=�6B   .+�5      �� $��20q�6   $	��100��5   	   $��22��6   $
��Left=�5   	   $	��Top=�6$   .��6<   z�5      �� 5       �� CenterX$ 40Q�5       �� CenterY$ 11Q�6    �� ScaleX 5   %   ��  �� ElementName$ XSlider�� �� Path$ Value�	 �� ScaleY	 5      �� $ YSlider��$ Value�5      .��5   +   5       �� 5!      $��22��6   $	��Top=�6!   $
��0 20q�69   .��6G   OK6K   5"      �� 5#   
   $��1��6   $��2��6"   $ 
Horizontal=�66   $��Center=�6O   .+�5$      �� $��20q�6   $	��100��6"   $��22��6.   $
��Left=�5%   	   $	��Top=�6$   .��6<   
 � LayoutTransform
 5&      �� 5'      $ 40Q�5)      $ 11Q�6    5'   %   �� $ XSlider��$ Value�	 5(      �� $ YSlider��$ Value�5)      .��5*   +   5+      �� 5,      $��22��6   $	��Top=�6!   $
��0 20q�69   .��6G   OK6K   5-      �� 5.   
   $��2��6   .��6   ScaleX6%   �� 5/   
   -   5        $��XSlider��5/      $��2��6    $��2��60    � Minimum$	 0.5Q�50       � Maximum$ 2Q�6    � Value$ 1Q�6+   �� 52   
   $��3��6   .��6   ScaleY6%   �� 53   
   -   5        $��YSlider��53      $��2��6    $��3��60   $	 0.5Q�54      $ 2Q�6   $ 1Q�6+   55      56      
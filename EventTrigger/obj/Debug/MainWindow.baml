   M S B A M L   `   `   `  ����G  CEventTrigger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:EventTriggerEventTrigger  5   	       EventTrigger.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:EventTrigger     5   	     � 
ResizeMode$  CanMinimize=�5       � Title$ 
MainWindow��5   	   $	��206��6   $	��323��6)    � 	Resources 5	       �� 
TargetType   UserNameStyle �� Triggers :� RoutedEvent	 �� To g� Duration �� TargetProperty��%�  &	        �� 5
   
   " ��6    5      :� 5      $ GotFocus��6   .[�5      �� .��5      �� .��5      �� $ 	LightBlueX�6-   $ 0:0:1D�6<   $ Background.Color�6M   5      5      5      :� 5      $ 	LostFocus��6   .[�5      �� .��5      �� .��5      �� $ WhiteX�6-   $ 0:0:1D�68   $ Background.Color�6I   5      5      5      5      5      .��5      �� .+�5   
   �� -   5        	 ��Name$	 	textBlock��5      
 �� Left$
 16��6'   $
��Wrap=�68   $��	User Name��6L   
 �� Top$ 43��6]   �� 5   
   -   5         ��Name$ textBox��5      $��23��6#   $
 87��6/   #��[  6@    �� TextWrapping$
 Wrap=�5       $�� ��6&   $ 40��6.   $	��199��6>   �� 5!   
   -   5        $	 
textBlock1��5!      $
��Wrap=�6(   $��Password��6<   $
 25��6L   $ 85��6]   �� 5"   
   -   5        $ textBox_Copy��5"      $��23��6(   $
 87��64   $
 Wrap=�6E   $�� ��6Y   $ 85��6a   $	��199��6q   �� 5#   
   -   5         ��Name$ button��5#      $��Login��6!   $��76��61   $	
 120��6<   $	 134��6N   �� 5$   
   -   5        $ button_Copy��5$      $��Cancel��6&   $��76��67   $	
 210��6B   $	 134��6T   5&      5'      
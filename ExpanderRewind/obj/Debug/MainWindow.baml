   M S B A M L   `   `   `  ����I  EExpanderRewind, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ExpanderRewindExpanderRewind  5   	       ExpanderRewind.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ExpanderRewind     5   	     � Title$  Expander Sample��5   	   $��256.833��6!   $��355.466��65   $��355.466��6H   $��256.833��6X    � 
ResizeMode$ CanMinimize=�5	   	   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��	Wingdings)�6   $��40(�6'   $��N��65   �� 5   
   $��1��6   $��15(�6    $
��Bold"�6.   $��Center=�6@   .��6[   Your password is invalid5      9� 5   
   -   5        $��expanderTest��5   0   $��1��6   $��1��6     9� ExpandDirection$
 Down=�6D   ��5      �� 5      Show �� 5      -   5        $
��Bold"�5   %   .�6O   more6U    information5      .��5       �� $��24 6 0 0q�6   1/Passwords must meet the following requirements.�� 5!   A   *(1. Length must be 12 characters or more.�� 5"   :   /-2. Must include letters, numbers and symbols.�� 5#   ?   /-3. Must include upper and lower case letters.5%      5&      ]� 5'   
   $��2��6   $��1��6!   ��.  .+�5(      �� -   5        $��Bottom=�5(      $��Right=�6-   $��10q�5)      $	��110��6!   $��25��6-   $��Toggle Expander��5*      61   5+      5,      5-      
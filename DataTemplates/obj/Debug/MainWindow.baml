   M S B A M L   `   `   `  ����H  DDataTemplates, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DataTemplatesDataTemplates  5   	       DataTemplates.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DataTemplates     5   	     � Title$  
MainWindow��5   	   $	��368��5	   
   $	��406��5
   	   .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� 
Contacts6   �� 5   
   $��1��6   $��2q�6"   ��6-   �� *
Contacts+��5      �� 5      .R�5      �� .+�5      �� $
��Bold"�6$   $��13(�66   $��0,2,2,2q�6Z   ��6D   �� *Name+6Z   �� 5      $��12(�6$   $��0,2,2,2q�6I   ��62   �� *Phone+6I   �� 5      $��12(�6$   $��0,2,2,2q�6I   ��62   �� *Email+6I   5       5!      5#      �� 5%   
   $��1��6   $��2q�6!   $��Center=�6,   Name6M   �� 5&   
   $��1��6   $��1��6   $��22��6/   $��2q�6;   ��6F   �� *EditableContact.Name+ �� Mode$ TwoWay=��� 5(   
   $��2��6   $��2q�6!   $��Center=�6,   Telephone Number6Y   �� 5)   
   $��2��6   $��1��6   $��22��6/   $��2q�6;   ��6F   �� *EditableContact.Phone+$ TwoWay=��� 5+   
   $��3��6   $��2q�6!   $��Center=�6,   Email Address6V   �� 5,   
   $��3��6   $��1��6   $��22��6/   $��2q�6;   ��6F   �� *EditableContact.Email+$ TwoWay=��� 5.   
   -   5        $��	ButtonAdd��5/   9   $��4��5.      $��1��6   $��Right=�6.   $��22��5/      $��50��6   $��0,5,0,0q�6(   .��6h   Add6m   50      51      
   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5   	       WPF.EntryWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:WPF     5   	     � WindowStartupLocation$  CenterScreen=�5   	   $
��Auto=�5	   	   ! �� IsDeferredScrollingEnabled .    WindowStyle#��[  5   	    � WindowState$ 	Maximized=�5   	   $
��1300��5   	   ���#1f2227.��5      � -   5         �Name$ MainGrid��5       � ColumnDefinitions 5   
   �� 5      -   5         ��Name$ MainColumn1��5      $��* �5      6+   �� 5      $
��.55* �6   6.    � RowDefinitions 5   
   �� 5      $��50 �6   6+   �� 5      -   5         ��Name$ MainRow2��5      $	��550 �5      6+   �� 5      $��* �6   6)   .+�5&   
   �� -   5        $��0��5&      $��1��5'      $��Right=�5(      $��40��5)      
������ $��
0,12,0,548q�5-      $��2��5/      .��51      �� $��icons/x-mark-3-xxl.png��6   52      �� 54   
   $��1��6   $��0��55      $!��ادخال البيانات��56      $��27(�57        newfont#��[ 58      
�������$��Center=�5:      $��Stretch=�5;      6.    � 5>   
   -   5          �Name$ 	DataFrame��5>      $��1��5?      $��1��5@      5A       � 5E   
   -   5        $ DataGridViewFrame��5E      $��1��5F      $��0��5G      $��5,2,2,0q�5H      5I      �� 5L   
   $��0,5,0,0q�6   $��2��5M      $��0��5N      $��2��5O      ���#54c0ff���#1f2227$��0,2,0,0q�5R      ._�5T       � -   5        $��BottomPageFrame��5T      $��2��5U      $��2��5V      5W      5X      5Z      5[      
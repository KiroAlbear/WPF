   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:WPF.ComponentPages.TabPagesWPF.ComponentPages.TabPages  5      ,    &WPF.ComponentPages.TabPages.StreetsTab   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:WPF.ComponentPages.TabPages     5        N� Title$  ResponsiblePriestTab��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��3* �6   6,   �� 5      $��* �6   6+   .+�5   
   �� -   5        $��FreeSpaceButton��5      $��2��5      $��10��5       J� Opacity$ 0Q�5      �� 5    
   $��الشارع��6   $��0��5!         SearchLabelStyl#��[  5"      
���   �$��1��5$      �� 5%   
   $��االمنطقة��6   $��1��5&      #��[  5'      
���   �$��1��5)      �� 5*   
   $!��الشارع الرئيسى��6   $��2��5+      #��[  5,      
���   �$��1��5.      �� 5/   
   -   5        $��RegionComboBox��5/      $��1��50       �� 
IsEditable . $��RightToLeft=�52      61   �� 54      -   5        $��MainStreetComboBox��54      $��2��55       . $��RightToLeft=�57      61   �� 59   
   -   5        $��NameComboBox��59      $��0��5:       . $��RightToLeft=�5<      61   � 5>   
   -   5        $��ThreeButtonGrid��5?      $��5��5>       5@      �� 5A      6%   �� 5B      6%   �� 5C      6%   .+�5E      �� -   5        $��RemoveButton��5E      $��0��5F      $��حذف��5G        InformButton#��[ 5H      5I   2   �� 5J      -   5        $��
EditButton��5J      $��1��5K      $��
تعديل��5L      #��[ 5M      5N   0   �� 5O      -   5        $��
SaveButton��5O      $��2��5P      #��[ 5Q      $��حفظ��5R      5S   0   5T      5U      5V      
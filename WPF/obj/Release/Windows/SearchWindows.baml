   M S B A M L   `   `   `  ���� >  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF.WindowsWPF.Windows      WPF.Windows.SearchWindows   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6fsxaml#http://github.com/fsprojects/FsXaml     U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;Controls,http://metro.mahapps.com/winfx/xaml/controls  %localclr-namespace:WPF.Windows    � WindowState$  	Maximized=� � WindowStartupLocation$ CenterScreen=�   WindowStyle#��[    
EntryBrush#��[  � Title$ SearchWindows��$
��auto��$
��auto��(  "MahApps.Metro.Controls.MetroWindow   Flyouts +  %MahApps.Metro.Controls.FlyoutsControl  -     Name$ flyoutsControl��.@�#  MahApps.Metro.Controls.Flyout  -     Name$ GlobalSearchFlyout��$��بَحث��   Position$ Right=�.��� $��Stretch=�
������� � ColumnDefinitions �� $
��2.5* ��� $��* ��� $
��2.5* ��� $��* � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� -   	 ��Name$	 FatherTextBox��$��0��$��4��$��0��$��اسم رب الاسرة��  SearchTextBoxStyle#��[ �� -   $��NameTextBox��$��1��$��0��$��
الاسم��$��4��#��[ �� -   $��EmailTextBox��$��2��$��Email,الايميل��$��2��$��2��#��[ �� -   $��PhoneNumberTextBox��$��2��$��0��$��2��$��رقم التليفون��#��[ �� -   $��QualificationTextBox��$��3��$��2��$��2��$��المؤهل��#��[ � -   $��PersonsGrid��$��3�� �� $��8* ��� $��4* ��� $��8* ��� $��4* �.+��� -	   $��PersonFromTextBox��$
��من��$��2��#��[ $��2���� -
   $��PersonToTextBox��#��[ $��إلى��$��2��$��0���� -   $��
JobTextBox��$��4��$��الوظيفة��$��2��$��2��#��[ �� -   $��ServiceTextBox��$��4��$��0��$��2��$��الخدمة��#��[ �� -   $��NationalIDTextBox��$��5��$��2��$��ألرقم القومى��$��2��#��[ �� -   $��LivingTypeTextBox��$��5��$��نوع السكن��$��0��$��2��#��[ �� -   $��PabtismTextBox��$��6��$��نوع المعمودية��$��2��$��2��#��[ �� -   $��DiseaseTextBox��$��6��$��نوع المرض��$��0��$��2��#��[ �� -   $��HouseNumberTextBox��$��7��$��رقم المنزل��$��2��$��2��#��[ � -   $��LastVisitDateGrid��$��0��$��8��$��3�� �� $��8* ��� $
��1.5* ��� $��8* ��� $
��1.5* �.+��� -   $��LastVisitFromTextBox��$��2��$��2��$��ابتداء من    ��#��[ �� -   $��LastVisitToTextBox��$��0��$��2��$��انتهاء الى    ��#��[ �� -   $��StartPersonCounterLabel��$��1��$��8��  SearchLabelStyl#��[ �� -   $��EndPersonCounterLabel��$��الافراد��$��0,4,5,0q�$��1��$��3��#��[ 
 J� RenderTransformOrigin$
 0.014,0.949&�$��2���� -   $��BirthDateSectionBorder��$��9��$��0��$��4��$��4��$��0,0,0,0q�
�������$��8,0,8,0q� �� Padding$ 0,5,0,0q�._�� -   $��BirthDateSectionGrid�� �� $	��15* ��� $
��300* ��� $	��68* ��� $
��300* ��� $	��48* ��� $	��68* ��� $
��200* � �� �� �� �� .+��� -   $"��BirthDateTitlesSectionBorder��$��	1.5,0,0,0q�
�������$��0��$��6��$��4��$��0,2,0,3q�._�� -   $ ��BirthDateTitlesSectionGrid��$��0��$��4��$��4�� �� �� �� �� .+��� -   $��BirthDateLabel��$��0��$��3��$��ت الميلاد��#��[ �� -   $��DayBirthLabel��$��3��$��1��$��يوم��#��[ �� -   $��MonthBirthLabel��$��3��$��2��$��شهر��#��[ �� -   $��YearBirthLabel��$��3��$��3��$��سنة��#��[ �� -   $��BirhtDateFromTextBox��$��ابتداء من��#��[ $��3��$��3���� -    $��BirhtDateToTextBox��$��انتهاء الى��#��[ $��0��$��3���� -!   $��BirhtDayFromTextBox��$��ابتداء من ��#��[ $��3��$��1��$��3���� -"   $��BirhtDayToTextBox��$��أنتهاء الى ��#��[ $��0��$��1��$��3���� -#   $��BirhtMonthFromTextBox��$��ابتداء من  ��#��[ $��3��$��2��$��3���� -$   $��BirhtMontToTextBox��#��[ $��0��$��انتهاء الى  ��$��2��$��3���� -%   $��BirhtYearFromTextBox��$��ابتداء من   ��#��[ $��3��$��3��$��3���� -&   $��BirhtYearToTextBox��#��[ $��0��$��انتهاء الى   ��$��3��$��3���� $��8��$��3��$��الزيارة��#��[ � -'   $��ButtonsGrid��$��13��$��4��$��4��$��0,8,0,0q� �� �� �� ��  �� �� .+�� -(   $��FourButtonsGrid��$��2��$��4�� �� �� �� ��  �� �� .+��� -)   $��SearchStreetButton��$��2��$��1��$��الشوارع��  InformButton#��[ �� -*   $��SearchPriestButton��$��2��$!��الكاهن المسئول��#��[ �� -+   $��SearchConfisionButton��$��1��$��3��$��أب الاعتراف��#��[ �� -,   $��SearchSocialButton��$��3��$'��!الحالة الاجتماعية��#��[ �� --   $��SearchButton��$��0��$��0��$��2��$��بحث��#��[ �� -.   $��PrintButton��$��1��$��0��#��[ $��2��$��اطبع��  -/   $��StreetFlyOut��$
 Left=�$��LeftToRight=�$��بحث الشوارع��  StreetFlyoutBrush#��[ .��� -0    �Name$ StreetTwoListGrid�� �� $��* ��� $��1.11* � �� $��* ��� $	��16* �.+�� -1   $ StreetFirstRightGrid��$��0��$��2��$��Stretch=� �� $��3* ��� $��* ��� $��* �.+��� -2   $	 StreetSearchListTextBox��$��0��
�������
���   �$��5,3,20,0q�� -3   $$ StreetSelectAllRadioButtonGrid��$��1�� �� $��4* ��� $��* �.+�	� -4    	�Name$  StreetSelectAllRadioButton��$��1��
��������� -5    ��Name$ SelectAllLabl��$��تحديد الكل��  	LabelStyl#��[ 
�������$��20(�� -6   $��StreetDeSelectAllGrid��$��2�� �� $��4* ��� $��* �.+�	� -7   $" StreetDeSelectAllRadioButton��$��1��
��������� -8   $ StreetDeSelectAllLabl��$��الغاء الكل��$��20(�#��[ 
�������� -9   $ StreetRightGrid��$��0��$��1�� �� $��* �.+��� -:    ��Name$ StreetAllListView��$��0��$��1��$��	0,10,5,10q�
��������� -;   $ StreetSelectedListView��$��1��$��	7,10,7,10q�$��2��
�������  -<   $��ConfisionFlyout��$
 Left=�$��LeftToRight=�$"��بحث أب ألأعتراف��#��[ .��� -=   $ ConfisionTwoListGrid�� �� $��* ��� $��1.11* � �� $��* ��� $	��16* �.+�� ->   $ ConfisionFirstRightGrid��$��0��$��2��$��Stretch=� �� $��3* ��� $��* ��� $��* �.+��� -?   $ 	 ConfisionSearchListTextBox��$��0��
�������
���   �$��5,3,20,0q�� -@   $' !ConfisionSelectAllRadioButtonGrid��$��1�� �� $��4* ��� $��* �.+�	� -A   $# ConfisionSelectAllRadioButton��$��1��
��������� -B   $ ConfisionSelectAllLabel��$��تحديد الكل��#��[ 
�������$��20(�� -C   $��ConfisionDeSelectAllGrid��$��2�� �� $��4* ��� $��* �.+�	� -D   $% ConfisionDeSelectAllRadioButton��$��1��
��������� -E   $ ConfisionDeSelectAllLabl��$��الغاء الكل��$��20(�#��[ 
�������� -F   $ ConfisionRightGrid��$��0��$��1�� �� $��* �.+��� -G   $ ConfisionAllListView��$��0��$��1��$��	0,10,5,10q�
��������� -H   $ ConfisionSelectedListView��$��1��$��	7,10,7,10q�$��2��
�������  -I   $��PriestFlyout��$
 Left=�$��LeftToRight=�$&�� بحث الكاهن المسؤل��#��[ .��� -J   $ PriestTwoListGrid�� �� $��* ��� $��1.11* � �� $��* ��� $	��16* �.+�� -K   $ PriestFirstRightGrid��$��0��$��2��$��Stretch=� �� $��3* ��� $��* ��� $��* �.+��� -L   $	 PriestSearchListTextBox��$��0��
�������
���   �$��5,3,20,0q�� -M   $$ PriestSelectAllRadioButtonGrid��$��1�� �� $��4* ��� $��* �.+�	� -N   $  PriestSelectAllRadioButton��$��1��
��������� -O   $ PriestSelectAllLabel��$��تحديد الكل��#��[ 
�������$��20(�� -P   $��PriestDeSelectAllGrid��$��2�� �� $��4* ��� $��* �.+�	� -Q   $" PriestDeSelectAllRadioButton��$��1��
��������� -R   $ PriestDeSelectAllLabl��$��الغاء الكل��$��20(�#��[ 
�������� -S   $ PriestRightGrid��$��0��$��1�� �� $��* �.+��� -T   $ PriestAllListView��$��0��$��1��$��	0,10,5,10q�
��������� -U   $ PriestSelectedListView��$��1��$��	7,10,7,10q�$��2��
�������  -V   $��SocialFlyout��$
 Left=�$��LeftToRight=�$.��(بحث الحالة الاجتماعية��#��[ .��� -W   $ SocialTwoListGrid�� �� $��* ��� $��1.11* � �� $��* ��� $	��16* �.+�� -X   $ SocialFirstRightGrid��$��0��$��2��$��Stretch=� �� $��3* ��� $��* ��� $��* �.+��� -Y   $	 SocialSearchListTextBox��$��0��
�������
���   �$��5,3,20,0q�� -Z   $$ SocialSelectAllRadioButtonGrid��$��1�� �� $��4* ��� $��* �.+�	� -[   $  SocialSelectAllRadioButton��$��1��
��������� -\   $ SocialSelectAllLabel��$��تحديد الكل��#��[ 
�������$��20(�� -]   $��SocialDeSelectAllGrid��$��2�� �� $��4* ��� $��* �.+�	� -^   $" SocialDeSelectAllRadioButton��$��1��
��������� -_   $ SocialDeSelectAllLabl��$��الغاء الكل��$��20(�#��[ 
�������� -`   $ SocialRightGrid��$��0��$��1�� �� $��* �.+��� -a   $ SocialAllListView��$��0��$��1��$��	0,10,5,10q�
��������� -b   $ SocialSelectedListView��$��1��$��	7,10,7,10q�$��2��
�������.���  �� $��* � �� $��.055* ��� $��* �.+�� -c   $ FlyOutButtonGrid��$��0�� �� �� �� �� �� �� �� �� .+��� -d    ��Name$ SearchFlyOutButton��$��7��$��بحث��  ButtonStyle#��[ ���� � -e   $��GridViewGrid��$��1�� �� $��2* ��� $
��0.5* �.+� � -f   $��	GridFrame�� � -g     �Name$ FloatingFrame��$��0��$��3��$��2��$��0��
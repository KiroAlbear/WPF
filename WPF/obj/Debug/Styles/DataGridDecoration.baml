   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF.Styles
WPF.Styles  5      #    WPF.Styles.DataGridDecorationR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089*  $System.Windows.Controls.DataGridCell  �� 
TargetType   DataGridCellStyle �� Property �� Value �� Color �� Opacity  RowFontBrush  DataGRidLinesBrush �� Triggers P� Property P� Value  CellMouseHoverBrush)  #System.Windows.Controls.DataGridRow  DataGridRowStyle �� 
TargetType	 ��Name
 J� SnapsToDevicePixels �� TextAlignment �� CornerRadius?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenterA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility:  4System.Windows.Controls.Primitives.DataGridRowHeader$   SelectiveScrollingOrientation7  1System.Windows.Controls.DataGridHeadersVisibility
   Row �� ConverterParameter&   System.Windows.Controls.DataGrid!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorType J� Effect3	  -System.Windows.Media.Effects.DropShadowEffect 	  ShadowDepth 	  Color 	  Opacity �� Triggers �� 
TargetName  DataGRidRowHoverColorBrush=
  7System.Windows.Controls.Primitives.DataGridColumnHeader  DataGridColumnHeaderStyle  ColumnHeaderBrush2 J� 	AllowDrop 
  SeparatorVisibility ��Name  DataGridRowStyle1   5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      "localclr-namespace:WPF.Styles  5      %J  &	        7  7  7  &	 �    7  &	 S    7  7  &	 �    '  %    �� 5      "   6   .�5   
   ��  � �� 5      �� 5	      $	 Red��6"   $ 0Q�6.   5      �� 5   
    � ��8   5   9   �� 5   
    � ��8  5   ?   �� 5   
    � ��$ 0.5,0,0.5,0q�6,   �� 5   
    �@J�Opacity$	 0.9Q�5      �� 5   
    � ��$ 20(�5      6    5   
   P� 5       �@J�IsMouseOver . . �5      ��  � ��8  5   H   5      5      �� 5!      "   6   .�5#   
   ��  � ��$ 4q�6#   �� 5%   
    �@ ValidationErrorTemplate 5&      �� 5'      5)      5+      �� 5,   
    � �� 5-      �� 5.      "  6"   .R�56      �� $	 
DGR_Border��6   #��z��57      #��z��58      #��z��59      
 . $��2q�5;      $��50��5<      $ Center=�5=      $ 1,1,1,1��5>      ._�5?        $��Stretch=�61   $��0,3,0,3q�6M   $ Center=�6^    5A      �� 5B   "   $
��Auto �63   �� 5C   "   $��* �63    5E      �� 5F   "   $��* �60   �� 5G   "   $
��Auto �60   .+�5I        $��1��65   $ Center=�5J   5     5K      $��1��67   $��1��5L   3   #y�z 5N   3   $��Center=�6d   $��Center=�6   5O        5P      $��2��60   $ Vertical=�5Q   ,   $��Center=�5R   0   $��Center=�5S   0   y�5T   ,   �� *HeadersVisibility+# Z # Z  �� "  5V      5W       5Y      	  5[      $ 2Q�6/   $ LightSlateGray��6?   $	 0.8Q�6V   5_       5a      P� 5x       �@J�IsMouseOver . . �5z      �� $ 
DGR_Border��6%   8    � ��5|   !   5~      P� 5       �@ 
IsSelected . . �5�      �� $ 
DGR_Border��6%    � ��
 �����5�   !   5�      5�      5�       5�   
   P� 5�       �@J�IsMouseOver . . �5�      ��  � ��
 ��+��6D   �� 5�       � ��$	 -20q�6,   6:   5�      5�      �� 5�      "  
 6   .�5�   
   ��  � ��$ 0,0,5,0q�6#   -   5        �� 5�   
    � ��$
 auto��5�      �� 5�   
    � ��8   5�   ?   �� 5�   
    � ��$ 1q�5�      6   �� 5�   
    � ��$ 26(�5�      5�      �� 5�   
    � ��$ 50��5�      6   �� 5�   
    � ��
 �   �5�   !   �� 5�   
    � �� 5�      �� 5�      " 
 6"   .R�5�      �� $��1q�6   #��z��61    . $
��auto��6n   $
��auto��6{   ._�5�         5�      �� 5�   "   $
��Auto �60   5�   '   �� 5�   &   $��* �64   5�   '   .+�5�        $��1��67   #y�z 6D   $��Center=�6w   $��Center=�6�   5�      � 5�      $��1��6#   ��5�   "   �� 5�   &   $
 Aqua��66   $ 0Q�6C   6Q    5�   "   �� 5�   &   69   �� 5�   &   69   �� 5�   &   69   �� 5�   &   69   .+�5�   "   �� $ 
ImageArrow��6�   $0��*pack://application:,,,/Icons/whitspace.png��6(   $��3��6]   $��50��6m   $��20��6y   6�   5�      5�      5�       5�      P� 5�       �@J�IsMouseOver . . �5�      �� 8   � ��5�   H   5�      5�      5�      5�      �� 5�      "   6   .�5�   
   ��  � ��$ 1q�6#   6/   �� 5�   
    � ��$
 auto��6"   �� 5�   
    � ��$
 auto��6#   �� 5�   
    � �� 5�      �� 5�      .R�5�      �� $	 Bd��5�      
 . $��Center=�5�      
����ح�$	��0.7q�5�      
����+��5�      5�      5�       5�   
   5     �� 5     "   6   DataGridCellStyle1�� 5  
   P� 5      �@ 
IsSelected . . �5     ��  � �� �	#ff66ccff5     �� 5      � ��
 ���� 5     �� 5       � ��
 �   �5!     5"     P� 5#      �@J�	IsFocused . . �5%     ��  � �� �	#ff66ccff5&     �� 5'      � ��
 �   �5(     �� 5)      � ��$ 1q�5*     �� 5+      � ��
 �   �5,     5-     5A     5�     
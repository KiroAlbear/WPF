   M S B A M L   `   `   `  ���� >  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WPF.Styles.BottomPageWPF.Styles.BottomPage  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089*   $System.Windows.Controls.DataGridCell  �� 
TargetType   BottomGridCellStyle �� Property �� Value �� Color �� Opacity  RowFontBrush  DataGRidLinesBrush �� Triggers P� Property P� Value  CellMouseHoverBrush)  #System.Windows.Controls.DataGridRow  BottomGridRowStyle �� 
TargetType	 ��Name
 J� SnapsToDevicePixels �� TextAlignment �� CornerRadius?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenterA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility:  4System.Windows.Controls.Primitives.DataGridRowHeader$   SelectiveScrollingOrientation7  1System.Windows.Controls.DataGridHeadersVisibility
   Row �� ConverterParameter&   System.Windows.Controls.DataGrid!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorType J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Color   Opacity �� Triggers �� 
TargetName  DataGRidRowHoverColorBrush=	  7System.Windows.Controls.Primitives.DataGridColumnHeader  BottomGridColumnHeaderStyle  ColumnHeaderBrush2 J� 	AllowDrop 	  SeparatorVisibility ��Name�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     -local#clr-namespace:WPF.Styles.BottomPage  %n  &	        7  7  7  &	 �     7  &	     7  7  �� "    .���  � �� �� $	 Red��$ 0Q���  � ��8   ��  � ��8  ��  � ��$ 0.5,0,0.5,0q���  �@J�Opacity$	 0.9Q���  � ��$ 20(� P�  �@J�IsMouseOver . . ���  � ��8  �� "   .���  � ��$ 4q���  �@ ValidationErrorTemplate �� ��  � �� �� "  .R��� $	 
DGR_Border��#��z��#��z��#��z��
 . $��2q�$��50��$ Center=�$ 1,1,1,1��._�  $��Stretch=�$��0,3,0,3q�$ Center=� �� $
��Auto ��� $��* � �� $��* ��� $
��Auto �.+�  $��1��$ Center=�  $��1��$��1��#y�z $��Center=�$��Center=�  $��2��$ Vertical=�$��Center=�$��Center=�y��� *HeadersVisibility+# Z # Z  �� "     $ 2Q�$ LightSlateGray��$	 0.8Q� P�  �@J�IsMouseOver . . ��� $ 
DGR_Border��8    � ��P�  �@ 
IsSelected . . ��� $ 
DGR_Border�� � ��
 ����� P�  �@J�IsMouseOver . . ���  � ��
 ��+����  � ��$	 -20q��� "  	 .���  � ��$ 0,0,2,0q���  � ��$
 auto����  � ��$
 auto����  � ��8   ��  � ��$ 1q���  � ��$ 15(���  � ��
 �   ���  � �� �� " 	 .R��� $��1q�#��z�� . $
��auto��$
��auto��._�   �� $
��Auto ��� $��* �.+�  $��1��#y�z $��Center=�$��Center=�� $��1������ $
 Aqua��$ 0Q� �� �� �� �� .+��� $ 
ImageArrow��$0��*pack://application:,,,/Icons/whitspace.png��$��3��$��50��$��20�� P�  �@J�IsMouseOver . . ��� 8   � ��
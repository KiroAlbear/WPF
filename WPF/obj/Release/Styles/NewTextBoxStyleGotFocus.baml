   M S B A M L   `   `   `  ���� >  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF.Styles
WPF.Styles  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   NewTextBoxStyleGotFocus �� Property �� Value �� Color �� Opacity �� 
TargetType � RowDefinitions ��Name J� SnapsToDevicePixels	 J� Opacity
 ��Name �Name �� Triggers :� RoutedEvent ��Name W�Name �� 
TargetName �� TargetProperty	 W� To g� Duration g� AutoReverse�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     "localclr-namespace:WPF.Styles  %2  &	        �� "  ��.���  � ��$ Stretch=���  � ��$ Stretch=���  �@��TextAlignment$
 Left=���  � ��$ 17(���  � ��$ 0,0,7,4q���  � �� �� $
 Aqua��$ 1Q���  � ��$
 Bold"���  � ��$ 	8,10,10,0q���  � ��UnderLineTemplate�� �� " ��.R��  �� $	��20* ��� $��* �.+��� $ Bd�� . 
���   �$��0��$		 0.7Q�$��0,0,0,0q�._��� $
 PART_ContentHost��# z $��Right=�$��Center=�� $ linegrid��$��1�����#1184b2$
��1000�� :� $ GotFocus��.[��� .���� $ GotFocusStoryBoard��.��W� $ DoubleAnimation1��$ linegrid��$ (Grid.Width)�$ 10X�$ 0:0:0D� .  W� $ DoubleAnimation��$ linegrid��$ (Grid.Width)�$	 500X�$ 0:0:0.7D� .  :� $ 	LostFocus��.[��� .���� 
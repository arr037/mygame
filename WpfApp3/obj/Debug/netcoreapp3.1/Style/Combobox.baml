   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ComboBoxNormalBorderBrush  �� Color ! ComboBoxNormalBackgroundBrush # ComboBoxDisabledForegroundBrush # ComboBoxDisabledBackgroundBrush  ComboBoxDisabledBorderBrush �� 
TargetType   ComboBoxToggleButtonTemplate � ColumnDefinitions �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value  ComboBoxFlatStyle
 �� 
TargetType  RobotoRegular �� 	ClickMode d� 	IsChecked �� Path �� RelativeSource �� Mode J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate �� 
IsReadOnly �� 
IsReadOnly �� Padding � AllowsTransparency �� IsDropDownOpen J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight-   'System.Windows.Input.KeyboardNavigation    DirectionalNavigation�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %@  &	        &	 #     &	 A     &	 _     &	 }     &	 �     7   7  7  7  7  7  7  &	     7  7   7  �� 5      $  	#FFCCCCCC��68   �� 5      $
  #fff��6:   �� 5      $
  #888��6<   �� 5      $
  #eee��6<   �� 5      $
  #888��68   �� 5	      " d�6   .R�5
      �  5      �� 5   
   �� 5   
   $��20 �6   .+�5      �� $��Border��6#   $��2��6   8��  $ 0��5      $��
1, 1, 1, 1q�6    8�� 5      �� 5      $��ButtonBorder��6F   $��1��6   $��
1, 1, 1, 1q�6   ���#444$ 
0, 0, 0, 0��5      $��
0, 0, 0, 0q�6)   8�� 5      F� 5      $��Arrow��6   $��1��6   =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	$��Center=�5      ���#444$��Center=�5      5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5   
   �� $ ButtonBorder��6-    � ��
	 �����6G   5   	   P� 5        �@d�	IsChecked$
 TrueY�62   . �5!   
   �� $ ButtonBorder��6-    � ��
	 �����6G   �� 5"   
   $ Arrow��6'    � ��	 �	#FF8D979E6:   5#   	   P� 5$       � {�$ False��6/   . �5%   
   �� $ Border��6-   8	   � ��6A   �� 5&   
   $ ButtonBorder��6-   8	   � ��6G   �� 5'   
   $ ButtonBorder��6/   8	   � ��6I   �� 5(   
   8	   � ��63   �� 5)   
   $ Arrow��6'    � ��	 �#9996:   5*   	   5,      �� 5.      "
 ��6%   .�5/      ��  �@J�SnapsToDevicePixels$
	 True��66   �� 50       �@�OverridesDefaultStyle$
	 True��6?   �� 51       � ��$
	 Auto=�6C   �� 52       � ��$
	 Auto=�6A   �� 53       � ��$
	 True��66   �� 54       � ��$	 16(�6-   �� 55       � ��#	 �  6/   �� 56       � ��$	 5 0 0 0q�6   61   �� 57       �@�FocusVisualStyle	 6:   Z� �� 58       � ��	 59      �� 5:   
   " ��6   .R�5;      � .+�5<      d� $��ToggleButton��6   $��2��6/   $ Press=�5=      $|�False��6#   8��   5>      �� $ IsDropDownOpen� �� *TemplatedParent+$ TwoWay=�5?      �� 5A      $��ContentSite��6   $��5, 3, 23, 3q�62   $ False��6G   $
��Left=�5B      $��Center=�6:   #��z 5C      #��z 5D      #��z��5E      �� 5F      $��PART_EditableTextBox��6   $��3, 3, 23, 3q�65   # z 5G      $y�Hidden=�5H      
������ $
��Left=�5J      $��Center=�61   $
|�True��5K      .��6'   ��5L      �� 5M      " ��6"   .R�5N      �� $��PART_ContentHost��6)   $	 2 4q�6   $|�False��6A   5O      5P      .��5Q   "   5R      � 5T      $��Popup��6   $��Bottom=�6!   $|�False��5U      $
 True��6&   #��z 5V      $��Slide=�5W      .��5X      � $��DropDown��6   $
 True��6%   #��z 5Y      #��z 5Z      .+�5[      �� $��DropDownBorder��6   
�������$��
0, 1, 0, 0q�6B   $ 0��5\      $��1,1,1,1q�6*   8�� 5]      �� 5^      $��4q�6   $
 True��6*   .��5_      �� $ 	Contained=�6#   5`      5a      5b      5c       5d      P� 5e       �@��HasItems$ False��67   . �5f      �� $ DropDownBorder��6=    � ��$	 95��6Y   5g      P� 5h       � {�$ False��65   . �5i      �� 8	   � ��69   5j      P� 5k       �@��
IsGrouping$
 True��69   . �5l      ��  � ��$	 False��6@   5m      P� 5n       �@��
IsEditable$
 True��65   . �5o      ��  �@  	IsTabStop$	 False��6?   �� 5p      $ PART_EditableTextBox��67    � y�$	 Visible=�6Y   �� 5q      $ ContentSite��67    � y�$	 Hidden=�6P   5r      5t      5v      5w      5y      
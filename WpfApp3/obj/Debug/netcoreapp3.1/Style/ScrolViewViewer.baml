   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollBarThumb  �� 
TargetType �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels �� CornerRadius �� RelativeSource �Name	 �� Padding
 ]�Name J� IsMouseOver ]� DecreaseRepeatButton J� Opacity �� PageUpCommand ]� IncreaseRepeatButton �� PageDownCommand ]� Thumb �� Triggers P� Property P� Value �� PageLeftCommand �� PageRightCommand � ColumnDefinitions � RowDefinitions ��Name ��Name %� 
ScrollUnit �� CanContentScroll �� CanHorizontallyScroll �� CanVerticallyScroll ��Name4   .System.Windows.Automation.AutomationProperties     AutomationId! � Cursor" �� ScrollableHeight# � Maximum$ � Minimum*% �� #ComputedVerticalScrollBarVisibility& �� ViewportHeight' �� ViewportSize( � Value) �� Mode* �� ScrollableWidth+ �� Orientation,, �� %ComputedHorizontalScrollBarVisibility- �� ViewportWidth. �� Triggers/ :� RoutedEvent	0 W� To1 g� Duration2 �� 
TargetName3 �� TargetProperty�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�  &	        '�� �    7   7   '�� Y    �� 5      "  n�6#   .�5   
   ��  �@�OverridesDefaultStyle$ false��62   �� 5   
    � ��$ false��6&   �� 5   
    �@%�
ScrollUnit$
 Item=�6>   �� 5   
    � �� 5	      �� 5
      " n�6"   .R�5      �� $ 	rectangle��6   $
 True��5   !   ���	#BE000000$ 3��5   !   #��z��5   !   #��z��5   !   5      5      5      �� 5      "  ��6   .�5   
   ��  �@��IsPressAndHoldEnabled$ false��69   �� 5   
    �@��IsFlicksEnabled$ false��63   �� 5   
    � ��$ 14��6"   �� 5   
    � ��$ 	-14 0 0 0q�6#   �� 5   
    � �� 6%   �� *Width+ �� *Self+�� 5   
    �@%�
ScrollUnit$
 Item=�6>   �� 5   
    � �� 5      �� 5       " ��6"   .R�5!      � $ Bg��6   $
 true��6'   
������ .+�5#      �� $		 0 4q�6!   ._�5$      ]� $
 
PART_Track��6$   $
��true��5%       #{�z 5&       $��6��5'       $��Center=�5(        5)   "   �� 5*   &   $ 0Q�63   #��Z 6?    5,   "   �� 5-   &   $ 0Q�63   #��Z 6?    5/   "   n� 50   &   8��  6,   52      53      54      55      57       58   
   P� 59       �@��Orientation$ 
Horizontal=�6-   . �5:      ��  � ��$
 Auto��6*   �� 5;       � ��$ 0��6-   �� 5<       � ��$ 14��6+   �� 5=       � �� 6.   �� *Height+ �� *Self+�� 5>       � ��$ 	0 -14 0 0q�6+   �� 5?       �@%�
ScrollUnit$
 Item=�6F   �� 5@       � �� 5A      �� 5B      " ��6*   .R�5C      � $ Bg��6#   $
 true��6/   .+�5D   "   ]� $
 
PART_Track��6(   #{�z 5E   %   $��6��5F   %    5H   &   �� 5I   *   $ 0Q�67   #��Z 6C    5K   &   �� 5L   *   $ 0Q�67   #��Z 6C    5N   &   n� 5O   *   8�� 60   5Q   #   5R      5S      5U      5V      5X      �� 5Z      "  ��6   .�5[   
   ��  �@%�
ScrollUnit$
 Item=�6>   �� 5\   
    � �� 5]      �� 5^      " ��6"   .R�5_      � $
 Grid��6   #��z��6)    5`      �� 5a      $��* �6/   �� 5b      $
��Auto �6/    5d      �� 5e      $��* �6,   �� 5f      $
��Auto �6,   .+�5h      �� $ Corner��6$   $��1��64   #��� ��6D   $��1��6�   �� 5i      $! PART_ScrollContentPresenter��6Z   $
 Item=�61   # z��6   $ False��6�   $ False��6�   #��z��6�   #��z��6#  $��0��6G  #��z��6W  $��0��6z  �� 5k      $ PART_VerticalScrollBar��6$   $
 Item=�5l   !   $	 0.2Q�5m   $   $��0 0 0 0q�5n   $   $  VerticalScrollBar��5o   $   $! Arrow��5p   $   $��1��5q   $   ## z" 5r   $   $$ 0Q�5s   $   $��0��5t   $   #y�z% 5u   $   #' z& 5w   $   ( 5v   $   �� *VerticalOffset+$) OneWay=� �� *TemplatedParent+5w   $   �� 5y      $ PART_HorizontalScrollBar��6$   $	 0.2Q�5z   $   $  HorizontalScrollBar��5{   $   $! Arrow��5|   $   $��0��5}   $   ## z* 5~   $   $$ 0Q�5   $   $+ 
Horizontal=�5�   $   $��1��5�   $   #y�z, 5�   $   #' z- 5�   $   ( 5�   $   �� *HorizontalOffset+$) OneWay=� �� *TemplatedParent+5�   $   5�      . 5�      :� 5�      $/ 
MouseEnter��6'   .[�5�      �� .��5�   "   �� .��5�   &   W� 0 0.666   $1 0:0:0.3D�6?   $2 PART_VerticalScrollBar��6R   $3 Opacity�6�   W� 5�   &   0 0.666   $1 0:0:0.3D�6?   $2 PART_HorizontalScrollBar��6R   $3 Opacity�6�   5�   #   5�      5�      :� 5�      $/ 
MouseLeave��6'   .[�5�      �� .��5�   "   �� .��5�   &   W� 0 0.466   $1 0:0:0.3D�6?   $2 PART_VerticalScrollBar��6R   $3 Opacity�6�   W� 5�   &   0 0.466   $1 0:0:0.3D�6?   $2 PART_HorizontalScrollBar��6R   $3 Opacity�6�   5�   #   5�      5�      5�      5�      5�      5�      
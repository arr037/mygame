   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfApp3.Views.PagesWpfApp3.Views.Pages  5      ?$clr-namespace:WpfApp3.ViewModel.BaseWpfApp3.ViewModel.Base  5      +clr-namespace:WpfApp3.CoreWpfApp3.Core  5      5clr-namespace:WpfApp3.Core.ModeWpfApp3.Core.Mode  5	      5clr-namespace:WpfApp3.ConverterWpfApp3.Converter  5
      #    WpfApp3.Views.Pages.StartPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:WpfApp3.Views.Pages     5      8overlay$clr-namespace:WpfApp3.ViewModel.Base     5      +coreclr-namespace:WpfApp3.Core     5      0modeclr-namespace:WpfApp3.Core.Mode     5	      5	converterclr-namespace:WpfApp3.Converter     5
        � 	Resources  5      %   WpfApp3.Converter.EnumConverter   converts  OverlayService S� 
MethodName S� 
ObjectType+   %WpfApp3.ViewModel.Base.OverlayService��%^   &	        &	        5   
   6"   S� 5   
   $ GetInstance��5      "  5      5      .��5      �� ._�5   
   � .+�5      �� $
��Auto=�6   $
��Auto=�6>   .��5      �� $��Center=�5      $��Center=�5       �� TextAlignment$ Center=�5      .+�5       �� 
������� �� CornerRadius$ 10��5!       �� Padding$ 15q�5"      $	��330��5#      $��50q�5$      ._�5%      �  � ColumnDefinitions 5&      �� 5'   !   $
��Auto �62   �� 5(   !   $��* �62    � RowDefinitions 5*      �� 5+   "   �� 5,   "   �� 5-   "   �� 5.   "   .+�51      �� $��0��6(   $��0��65   $��Имя 1 игрока:��6E     TextBlockStyle#��[ 6[   �� 52      $��1��6(   $��0��65   $��Имя 2 игрока:��6E   #��[ 6[   �� 53      $��2��6(   $��0��65   $��Режим игры:��6E   #��[ 6Y   �� 55      $��1��6o   $��0��6     TextBoxStyle#��[ 6�   ��6&   �� *	Player1+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 56      $��1��6o   $��1��6   #��[ 6�   ��6&   �� *	Player2+$ TwoWay=�$	 PropertyChanged=�6�   �� 58      $��1��6'   $��2��59   '   $��16(�5:   '     ComboBoxFlatStyle#��[ 5<   '   ��5;   '   �� 
 �� Source
 $   WpfApp3.Core.EnumToItemsSource  *M� *mode:GameMode++ �� SelectedValue 5=   '   �� *
GameMode+ �� 	Converter# [   �� ConverterParameter    WpfApp3.Core.Mode.GameMode"  �� 5?      $��2��6B   $��0��6V   $��3��6f   $��Начать игру��6s     ButtonStyle#��[ 6�   ��6%   �� *
GetClick+6�   5A      5B      5C      5D      �� 5F      -   5        $��bg��5F   3   ���	#B4000000$
��Auto=�6=   $
��Auto=�6`   ��5G      �� 5H       �� 
TargetType" ��6    �� Triggers 5I      �� 5J       �� Binding 6*   ��  �� ElementName$
 text�� �� Path$
 Text� �� Value  6Y   .a�5K   "   ��  �� Property � y� �� Value$ 	Collapsed=�6?   5L      5N      .��5P      �� $	��Top=�5Q      $��Center=�5R      $ Center=�5S      .+�5T      �� 
�������$ 10��5U      $ 15q�5V      $	��330��5W      $��50 10 50 50q�5X      z�5Y      V� 5Z      .~�5[   "   T� 5\        5^       N� EnterActions W� From	 W� To �� TargetProperty W� EasingFunction0  *System.Windows.Media.Animation.ElasticEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode   Oscillations��%�  '��       �� 5_      " ��6$    5`   "   �� 5a   &    62   �� $ bg��$ 
Visibility� Visible6e    5b   *   �� 5c   .   .��5d   2   �� .��5e   6   W�  -406F    106Q   $U O(UIElement.RenderTransform).(TransformGroup.Children)[0].(TranslateTransform.Y)�6Y    5f   :     5g   >   $ EaseOut=�6J   $ 2��6_   5i   7   5j   3   5k   /   5m   '   5o      5p      ._�5r      � .+�5s      ��  �� Orientation$ Vertical=�6(   .+�5t   !   �� -   5        $
��text��5t   +   $
 Left=�67   $��WrapWithOverflow=�6L   #��[ 6�   ��6l   �� #
 [ $
 Text�6�   �� 5v   !   $��Хорошо��6I   #��[ 6Z   ��6(   �� *CloseErrors+6Z   5x      5y      5z      5{      5|      5~      5      5�      
   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	   5clr-namespace:WpfApp3.ViewModelWpfApp3.ViewModel  5   	   ?$clr-namespace:WpfApp3.ViewModel.BaseWpfApp3.ViewModel.Base  5   	       WpfApp3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	   5	viewModelclr-namespace:WpfApp3.ViewModel     5   	   6model$clr-namespace:WpfApp3.ViewModel.Base     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 	Resources 5         OverlayService S� 
MethodName S� 
ObjectType+   %WpfApp3.ViewModel.Base.OverlayService��%A   &	        S� 5   
   $ GetInstance��5      "  5      5       � DataContext 5      +   %WpfApp3.ViewModel.MainWindowViewModel  5   
   .��5      �� ���#3099c4._�5   
   � ��5      �� 5       j� TileMode$
 Tile=�6    j� ViewportUnits$ Absolute=�6-    j� Viewport$ 0 0 500 500�6F    �� ImageSource$) #../Style/Image/emoji-background.png��6]   .+�5      �� ��6   �� *CurrentPage+� 5      $��2��5       ���	#7F302E31y�5      �� 	 �� Source#	 [  
 �� Path$
 
Visibility�.+�5"      �� $	��500��5#      $	��300��5$      $��Center=�5%      $��Center=�5&      
������� �� CornerRadius$ 7��5(      ._�5)      � .+�5*      �� $��Center=�6%   .+�5+      �� $��30(�5,   !   $"��Идет загрузка...��5-   !    �� TextAlignment$ Center=�5.   !   � 5/      $��20��50   !   $��20q�51   !   
��� � �$��0q�53   !   
���/��� � IsIndeterminate$
 True��55   !   56      57      58      59      5:      5;      5<      
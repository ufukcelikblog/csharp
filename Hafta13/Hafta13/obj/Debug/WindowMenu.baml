   M S B A M L   `   `   `  ����B  >Hafta13, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Hafta13Hafta13  5   	       Hafta13.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Hafta13     5   	   $	��450��5      $	��800��6'     � 
ResizeMode$  NoResize=�63    � WindowStyle$
 None=�6I    � 	Resources 5         	MenuKapat �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction/  )System.Windows.Media.Animation.BounceEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode 
 MenuAc  
AnasayfaAc  KayitAc��%  &	        &	 -    &	 Z    &	 ;    �� 5	   
   .��5
      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ StackPanelMENU��6�   .\�5        $ 0��6'   $ 0Q�63    5        5      $ EaseOut=�6%   5        5      $ 0:0:1��6'   $
 -145Q�67    5        5      $ EaseOut=�6%   5      5      U� 5      $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6,   $ buttonAC��6�   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:1��6'   $ 1Q�67   5      U� 5      $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6,   $ buttonKAPAT��6�   .\�5        $ 0��6'   $ 1Q�63     5      $ 0:0:1��6'   $ 0Q�67   5      5      �� 5   
   .��5       U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ StackPanelMENU��6�   .\�5!        $ 0��6'   $
 -144Q�63    5"        5#      $ EaseOut=�6%   5%        5&      $ 0:0:1��6'   $ 0Q�67    5'        5(      $ EaseOut=�6%   5*      5+      U� 5,      $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6,   $ buttonKAPAT��6�   .\�5-        $ 0��6'   $ 0Q�63     5.      $ 0:0:1��6'   $ 1Q�67   5/      U� 50      $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6,   $ buttonAC��6�   .\�51        $ 0��6'   $ 1Q�63     52      $ 0:0:1��6'   $ 0Q�67   53      54      �� 55   
   .��56      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ GridANASAYFA��6�   .\�57        $ 0��6'   $ 0Q�63     58      $ 0:0:1��6'   $ 394.5Q�67   59      U� 5:      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ 	GridKAYIT��6�   .\�5;        $ 0��6'   $	 396Q�63     5<      $ 0:0:1��6'   $	 792Q�67   5=      5>      �� 5?   
   .��5@      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ 	GridKAYIT��6�   .\�5A        $ 0��6'   $ 0Q�63     5B      $ 0:0:1��6'   $ 391.5Q�67   5C      U� 5D      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ 	GridKAYIT��6�   .\�5E        $ 0��6'   $ 0Q�63     5F      $ 0:0:1��6'   $ 0Q�67   5G      U� 5H      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ GridANASAYFA��6�   .\�5I        $ 0��6'   $	 396Q�63     5J      $ 0:0:1��6'   $	 795Q�67   5K      U� 5L      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ GridANASAYFA��6�   .\�5M        $ 0��6'   $ 3Q�63     5N      $ 0:0:1��6'   $ 3Q�67   5O      5P      5Q      	 � Triggers	 5R      :� 5S   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ buttonKAPAT��66   .[�5T      �� #��[  6   5U      :� 5V   
   $
 ButtonBase.Click��6   $ buttonAC��66   .[�5W      �� #��[ 6   5X      :� 5Y   
   $
 FrameworkElement.Loaded��6   .[�5Z      �� -   5         ��Name$  AnasayfaAc_BeginStoryboard��5Z      #��[ 6B   5[      :� 5\   
   $
 ButtonBase.Click��6   $ buttonANASAYFA��66   .[�5]      �� -   5        $! AnasayfaAc_BeginStoryboard1��5]      #��[ 6C   5^      :� 5_   
   $
 ButtonBase.Click��6   $ buttonKAYIT��66   .[�5`      �� -   5        $ KayitAc_BeginStoryboard1��5`      #��[ 6@   5a      .��5c      � ���	#FFE6E6E6.+�5d   
   � -   5         �Name$ GridANASAYFA��5d      $
��Left=�6%   $��379.107��6@   $��205,-330.607,0,0q�6Q   $	��Top=�6k   $	��585��6�   ���	#FFCDF0EE J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5e      V� 5f      .~�5g      �� �� 5h      �� 5i      T� 5j      5k      .+�5m      �� -   5         ��Name$ label��5m      $��ANASAYFA��6#   $
��Left=�66   $��66��6Q   $��	10,10,0,0q�6]   $	��Top=�6p   $��259.5��6�   $��36(�6�   �� 5n      $
��Left=�6   $��202.5��63   $��291.5,90.607,0,0q�6B   
���   �$	��Top=�6k   $��217.5��6�   ��5o      �� 5p       �� ImageSource$ elma.jpg��6!   5r      5s      � 5t   
   -   5        $ 	GridKAYIT��5t      $
��Left=�6"   $��379.107��6=   $��205,-330.607,0,0q�6N   $	��Top=�6h   $	��585��6�   ���	#FF33ECE1$ 0.5,0.5&�6�   z�5u      V� 5v      .~�5w      �� �� 5x      �� 5y      T� 5z      5{      .+�5}      �� -   5        $ label1��5}      $��KAYIT��6$   $
��Left=�64   $��66��6O   $��	10,10,0,0q�6[   $	��Top=�6n   $��259.5��6�   $��36(�6�   &   System.Windows.Controls.Calendar  5~      $
��Left=�6   $��396,201.14,0,0q�62   $	��Top=�6J   5      � 5�   
   -   5        $ GridUST��5�      $
��Left=�6    $��55.893��6;   $��10,0,0,0q�6K   $	��Top=�6]   $��785.983��6u   ���	#FF066C83.+�5�      �� -	   5         ��Name$ buttonKapat��5�      $��X��6*   $
��Left=�66   $��55.893��6Q   $��721.983,0,0,0q�6a   $	��Top=�6x   $��54��6�   
�������$��36(�6�   ��6�   Z� 6�   5�      �� 5�   
   -
   5         ��Name$ StackPanelMENU��5�      $
��Left=�6-   $	��450��6H   $	��Top=�6U   $	��200��6m   $ 0.5,0.5&�6y   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      ��5�      �� 5�       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5�      �  � Color$ Black��6#   � 5�      $ 	#FF0499A8��6#    � Offset$ 1Q�65   5�      .+�5�      � $��80��6   $	��Top=�6   $
��Left=�67   $	��200��6R   
�������.+�5�      �� -   5        $ buttonAC��5�      $��>��6+   $
��Left=�6:   $��60��6U   $��152.333,10,0,0q�6a   $	��Top=�6y   $��37.667��6�   $
��Bold"�6�   $��48(�6�   $��Arial Black)�6�   $ 0.5,0.5&�6�   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      5�      �� 5�      -   5        $ buttonKAPAT��5�      $��<��6.   $
��Left=�6=   $��60��6X   $��152.333,10,0,0q�6d   $	��Top=�6|   $��37.667��6�   $
��Bold"�6�   $��48(�6�   $��Arial Black)�6�   $ 0.5,0.5&�6�   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      5�      5�      �� 5�      -   5        $ buttonANASAYFA��5�      $��ANASAYFA��6-   $
��Left=�6@   $��48��6[   $��10,0,0,0q�6g   $	��180��6y   ���	#FFBDC50A$��16(�6�   $
��Bold"�6�   $
��Left=�6�    J� Effect 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�      5�      �� 5�      -   5        $ buttonKAYIT��5�      $��KAYIT��6*   $
��Left=�6:   $��48��6U   $��10,0,0,0q�6a   $	��180��6s   ���	#FFBDC50A$��16(�6�   $
��Bold"�6�   $
��Left=�6�    5�        5�      5�      �� 5�      -   5        $ buttonRAPOR��5�      $��RAPOR��6*   $
��Left=�6:   $��48��6U   $��10,0,0,0q�6a   $	��180��6s   ���	#FFBDC50A$��16(�6�   $
��Bold"�6�   $
��Left=�6�    5�        5�      5�      5�      5�      5�      
   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      l hXceed.Wpf.Toolkit.LiveExplorer, Version=2.2.5318.21602, Culture=neutral, PublicKeyToken=3e4669d2f30244f4O,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorerXceed.Wpf.Toolkit.LiveExplorer 5      �Kclr-namespace:Xceed.Wpf.Toolkit.LiveExplorer.Samples.RangeSlider.Converters=Xceed.Wpf.Toolkit.LiveExplorer.Samples.RangeSlider.Converters 5      X TXceed.Wpf.Toolkit, Version=2.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4pJclr-namespace:Xceed.Wpf.Toolkit.Core.Converters;assembly=Xceed.Wpf.Toolkit!Xceed.Wpf.Toolkit.Core.Converters 5      N   HXceed.Wpf.Toolkit.LiveExplorer.Samples.RangeSlider.Views.RangeSliderView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      6sys&clr-namespace:System;assembly=mscorlib     5      >local,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorer     5      \convKclr-namespace:Xceed.Wpf.Toolkit.LiveExplorer.Samples.RangeSlider.Converters     5      _xctkconvJclr-namespace:Xceed.Wpf.Toolkit.Core.Converters;assembly=Xceed.Wpf.Toolkit     5      4xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      -  'Xceed.Wpf.Toolkit.LiveExplorer.DemoView    Title$  RangeSlider��5       � 	Resources 5      Z  TXceed.Wpf.Toolkit.LiveExplorer.Samples.RangeSlider.Converters.IntegerToBoolConverter   IntegerToBoolConverterG  AXceed.Wpf.Toolkit.Core.Converters.SolidColorBrushToColorConverter # SolidColorBrushToColorConverter  LowerRangeStyle1 �� 
TargetType �� Property �� Value �� 
TargetType �Name ��Name J� Opacity	 �� Triggers
 P� Property P� Value �� 
TargetName �� Value �� Binding �� RelativeSource �� Path  LowerRangeStyle2 A�Name  LowerRangeStyle3 ��Name �� Orientation ��Name �� AncestorType#  Xceed.Wpf.Toolkit.RangeSlider �� StringFormat  RangeStyle1  RangeStyle2  RangeStyle3  HigherRangeStyle1 	 HigherRangeStyle2 
 HigherRangeStyle3��%�!  &	        &	      &	 &     &	 �    &	 Z    &	 q    &	 �    &	 �    &	 �    &		 �    &	
 1      5      6$     5      61   �� 5      " ��5       .�5"      ��  � �� 5#      �� 5$      " ��6"   .R�5%      � $ MainGrid��6   $��10��5&      .+�5'      �� 
���   �6!   �� 5(      $ 
MainBorder��6!   #��z��5)   !   $ 1Q�5*   !   5+      	 5,      P� 5-      
 �@J�IsMouseOver . . �5/      �� $ 
MainBorder��6!    �@J�Opacity$
 0.75Q�51   !   52      �� 53      $ Vertical��54   #    53   #   ��  �� *TemplatedParent+$ Orientation�.a�55      �� $ MainGrid��56   !    � ��$
 Auto��57   !   �� 58      $ MainGrid��59   !    � ��$ 10��5:   !   5;      5=      5?      5A   	   �� 5C      " ��5D      .�5E      ��  � �� 5F      �� 5G      " ��6!   .R�5H      � $ MainGrid��6   $��10��5I      .+�5J      A� 
���   �6   A� 5K      $ 
MainBorder��6   #��z��5L      $ 1Q�5M      5N      	 5O      P� 5P      
 �@J�IsMouseOver . . �5R      �� $ 
MainBorder��6!    �@J�Opacity$
 0.75Q�5T   !   5U      �� 5V      $ Vertical��5W   #    5V   #   ��  �� *TemplatedParent+$ Orientation�.a�5X      �� $ MainGrid��5Y   !    � ��$
 Auto��5Z   !   �� 5[      $ MainGrid��5\   !    � ��$ 10��5]   !   5^      5a      5c      5d   	   �� 5f      " ��5g      .�5h      ��  � �� 5i      �� 5j      " ��6!   .R�5k      � $ MainGrid��6   $��19��5l      .+�5m      �� 
���   �6!   �� 5n      $ 
MainBorder��6!   #��z��5o   !   $ 1Q�5p   !   �� 5q      $ HorizontalContentPanel��6"   $ 
Horizontal=�5r   "   $��Center=�5s   "   $��Center=�5t   "   .+�5u      �� $ TextContentMin��6$   
�������$��Center=�5x   $   $��Center=�5y   $   ��5v   $   ��  �� "  $ Minimum�$ 	{0:00.00}��5y   $   �� 5z      $	�� - ��6%   
�����@�$��Center=�5|   %   $��Center=�5}   %   �� 5~      $ TextContentLower��6$   
�������$��Center=�5�   $   $��Center=�5�   $   ��5   $   ��  �� "  $ 
LowerValue�$ 	{0:00.00}��5�   $   5�      �� 5�      $ VerticalContentPanel��6"   $ Vertical=�5�   "   $y�	Collapsed=�5�   "   $��Center=�5�   "   .+�5�      �� $��L��6$   
�������5�   $   5�      5�      	 5�      P� 5�      
 �@J�IsMouseOver . . �5�      �� $ 
MainBorder��6!    �@J�Opacity$
 0.75Q�5�   !   5�      �� 5�      $ Vertical��5�   #    5�   #   ��  �� *TemplatedParent+$ Orientation�.a�5�      �� $ MainGrid��5�   !    � ��$
 Auto��5�   !   �� 5�      $ MainGrid��5�   !    � ��$ 30��5�   !   �� 5�      $ VerticalContentPanel��5�   !    � y�$ Visible=�5�   !   �� 5�      $ HorizontalContentPanel��5�   !    � y�$ 	Collapsed=�5�   !   5�      5�      5�      5�   	   �� 5�      " ��5�      .�5�      ��  � �� 5�      �� 5�      " ��6"   .R�5�      � $ MainGrid��6   $��10��5�      .+�5�      �� 
���   �6!   �� 5�      $ 
MainBorder��6!   #��z��5�   !   $ 1Q�5�   !   5�      	 5�      �� 5�      $ Vertical��5�   #    5�   #   ��  �� *TemplatedParent+$ Orientation�.a�5�      �� $ MainGrid��5�   !    � ��$
 Auto��5�   !   �� 5�      $ MainGrid��5�   !    � ��$ 10��5�   !   5�      5�      5�      5�   	   �� 5�      " ��5�      .�5�      ��  � �� 5�      �� 5�      " ��6!   .R�5�      � $ MainGrid��6   $��10��5�      .+�5�      A� 
���   �6   A� 5�      $ 
MainBorder��6   #��z��5�      5�      	 5�      �� 5�      $ Vertical��5�   #    5�   #   ��  �� *TemplatedParent+$ Orientation�.a�5�      �� $ MainGrid��5�   !    � ��$
 Auto��5�   !   �� 5�      $ MainGrid��5�   !    � ��$ 10��5�   !   5�      5�      5�      5�   	   �� 5�      " ��5�      .�5�      ��  � �� 5�      �� 5�      " ��6!   .R�5�      � $ MainGrid��6   $��19��5�      .+�5�      �� 
���   �6!   �� 5�      $ 
MainBorder��6!   #��z��5�   !   $ 1Q�5�   !   �� 5�      $ HorizontalContentPanel��6"   $ 
Horizontal=�5�   "   $��Center=�5�   "   $��Center=�5�   "   .+�5�      �� $ TextContentLower��6$   
�������$��Center=�5�   $   $��Center=�5�   $   ��5�   $   ��  �� "  $ 
LowerValue�$ 	{0:00.00}��5�   $   �� 5�      $	�� - ��6%   
�����@�$��Center=�5�   %   $��Center=�5�   %   �� 5�      $ TextContentHigher��6$   
�������$��Center=�5�   $   $��Center=�5�   $   ��5�   $   ��  �� "  $ HigherValue�$ 	{0:00.00}��5�   $   5�      �� 5      $ VerticalContentPanel��6"   $ Vertical=�5  "   $y�	Collapsed=�5  "   $��Center=�5  "   .+�5     �� $��R��6$   
�������5  $   5     5     	 5     P� 5	     
 �@J�IsMouseOver . . �5     �� $ TextContentLower��6!    � ��
 �� ��5  !   �� 5     $ TextContentHigher��6!    � ��
 �� ��5  !   5     �� 5     $ Vertical��5  #    5  #   ��  �� *TemplatedParent+$ Orientation�.a�5     �� $ MainGrid��5  !    � ��$
 Auto��5  !   �� 5     $ MainGrid��5  !    � ��$ 30��5  !   �� 5     $ VerticalContentPanel��5  !    � y�$ Visible=�5  !   �� 5     $ HorizontalContentPanel��5  !    � y�$ 	Collapsed=�5   !   5!     5$     5&     5'  	   �� 5)     " ��5*     .�5+     ��  � �� 5,     �� 5-     " ��6"   .R�5.     � $ MainGrid��6   $��10��5/     .+�50     �� 
���   �6!   �� 51     $ 
MainBorder��6!   #��z��52  !   $ 1Q�53  !   54     	 55     P� 56     
 �@J�IsMouseOver . . �58     �� $ 
MainBorder��6!    �@J�Opacity$
 0.75Q�5:  !   5;     �� 5=     $ Vertical��5>  #    5=  #   ��  �� *TemplatedParent+$ Orientation�.a�5?     �� $ MainGrid��5@  !    � ��$
 Auto��5A  !   �� 5B     $ MainGrid��5C  !    � ��$ 10��5D  !   5E     5G     5I     5J  	   �� 5L     " ��5M     .�5N     ��  � �� 5O     �� 5P     " ��6!   .R�5Q     � $ MainGrid��6   $��10��5R     .+�5S     A� 
���   �6   A� 5T     $ 
MainBorder��6   #��z��5U     $ 1Q�5V     5W     	 5X     P� 5Y     
 �@J�IsMouseOver . . �5[     �� $ 
MainBorder��6!    �@J�Opacity$
 0.75Q�5]  !   5^     �� 5`     $ Vertical��5a  #    5`  #   ��  �� *TemplatedParent+$ Orientation�.a�5b     �� $ MainGrid��5c  !    � ��$
 Auto��5d  !   �� 5e     $ MainGrid��5f  !    � ��$ 10��5g  !   5h     5k     5m     5n  	   �� 5p     " ��5q     .�5r     ��  � �� 5s     �� 5t     " ��6!   .R�5u     � $ MainGrid��6   $��19��5v     .+�5w     �� 
���   �6!   �� 5x     $ 
MainBorder��6!   #��z��5y  !   $ 1Q�5z  !   �� 5{     $ HorizontalContentPanel��6"   $ 
Horizontal=�5|  "   $��Center=�5}  "   $��Center=�5~  "   .+�5     �� $ TextContentHigher��6$   
�������$��Center=�5�  $   $��Center=�5�  $   ��5�  $   ��  �� "  $ HigherValue�$ 	{0:00.00}��5�  $   �� 5�     $	�� - ��6%   
�����@�$��Center=�5�  %   $��Center=�5�  %   �� 5�     $ TextContentMax��6$   
�������$��Center=�5�  $   $��Center=�5�  $   ��5�  $   ��  �� "  $ Maximum�$ 	{0:00.00}��5�  $   5�     �� 5�     $ VerticalContentPanel��6"   $ Vertical=�5�  "   $y�	Collapsed=�5�  "   $��Center=�5�  "   .+�5�     �� $��H��6$   
�������5�  $   5�     5�     	 5�     P� 5�     
 �@J�IsMouseOver . . �5�     �� $ 
MainBorder��6!    �@J�Opacity$
 0.75Q�5�  !   5�     �� 5�     $ Vertical��5�  #    5�  #   ��  �� *TemplatedParent+$ Orientation�.a�5�     �� $ MainGrid��5�  !    � ��$
 Auto��5�  !   �� 5�     $ MainGrid��5�  !    � ��$ 30��5�  !   �� 5�     $ VerticalContentPanel��5�  !    � y�$ Visible=�5�  !   �� 5�     $ HorizontalContentPanel��5�  !    � y�$ 	Collapsed=�5�  !   5�     5�     5�     5�  	   5�        Description 5�     J� 5�     $��14(�6   $��Segoe)�5�     .*�6%   ��The RangeSlider control let you sets a range with 2 slider thumbs. The lower limit is marked with the right side of the left thumb while the higher limit is marked with the left side of the right thumb.5�  	   .��5�     �  � RowDefinitions 5�     �� 5�     $
��Auto �6   �� 5�     $	��300 �6   .+�5�     �� $��Features��6   $��0��5�     $��5q�5�     .��5�     � $��5q�6    5�     �� 5�     $
��Auto �6   �� 5�     $
��Auto �6   �� 5�     $
��Auto �6   �� 5�     $
��Auto �6   �� 5�     $
��Auto �6   �� 5�     $
��Auto �6    � ColumnDefinitions 5�     �� 5�     $��75 �6"   �� 5�     $	��100 �6"   �� 5�     $	��160 �6"   �� 5�     $	��100 �6"   �� 5�     $	��118 �6"   �� 5�     $	��100 �6"   .+�5�     �� $��Minimum:��6   $��Center=�5�     $  Xceed.Wpf.Toolkit.DoubleUpDown  5�     $��1��6    �  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   FormatString$
 0.00��5�      $��Center=�5�      $��5q�5�      �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 5�      �� *	Minimum+ �� ElementName$ _rangeSlider��   	Increment 5�      �� *Step+$ _rangeSlider��5�      �� 5�     $��Maximum:��6   $��1��5�     $��Center=�5�       5�     $��1��5�      $��1��5�      $
 0.00��5�      $��Center=�5�      $��5q�5�       5�      �� *	Maximum+$ _rangeSlider�� 5�      �� *Step+$ _rangeSlider��5�      �� 5�     $��Lower Value:��6   $��2��5�     $��Center=�5�       5�     $��2��5�      $��1��5�      $
 0.00��5�      $��Center=�5�      $��5q�5�       5�      �� *
LowerValue+$ _rangeSlider�� 5�      �� *Step+$ _rangeSlider��5�      �� 5�     $��Higher Value:��6   $��3��5�     $��Center=�5�       5�     $��3��5�      $��1��5�      $
 0.00��5       $��Center=�5      $��5q�5       5�      �� *HigherValue+$ _rangeSlider�� 5      �� *Step+$ _rangeSlider��5      �� 5     $��Step:��6   $��4��5     $��Center=�5       5     $��4��5	      $��1��5
      $
 0.00��5      $��Center=�5      $��5q�5       5      �� *Step+$ _rangeSlider��5      �� 5     $��Orientation:��6   $��5��5     $��Center=�5     �� 5     $��5��6   $��1��5      �� SelectedIndex$ 0��5      �� SelectedValuePath$ Content��5     $��Center=�5     $��5q�5       �� SelectedValue  5     �� *Orientation+$ _rangeSlider��.@�5     �� $��
Horizontal��6   �� 5     $��Vertical��6   5     �� 5     $��Lower Thumb Background:��6   $��2��5     $��Center=�5      $��10,5,5,5q�5!     #  Xceed.Wpf.Toolkit.ColorPicker  5"     $��3��6   $��Center=�5$     $��5q�5%     !   SelectedColor! 5#     �� *LowerThumbBackground+$ _rangeSlider��" �� 	Converter#" [ 5%     �� 5'     $��Higher Thumb Background:��6   $��1��5(     $��2��5)     $��Center=�5*     $��10,5,5,5q�5+       5,     $��1��6   $��3��5-     $��Center=�5/     $��5q�50     ! 5.     �� *HigherThumbBackground+$ _rangeSlider��#" [ 50     �� 52     $��Lower Range Background:��6   $��2��53     $��2��54     $��Center=�55     $��10,5,5,5q�56       57     $��2��6   $��3��58     $��Center=�5;     $��5q�5<     {�59     �� *SelectedIndex+$ lowerRangeStyleComboBox��#" [  ! 5:     �� *LowerRangeBackground+$ _rangeSlider��#" [ 5<     �� 5>     $��Range Background:��6   $��3��5?     $��2��5@     $��Center=�5A     $��10,5,5,5q�5B       5C     $��3��6   $��3��5D     $��Center=�5G     $��5q�5H     {�5E     �� *SelectedIndex+$ rangeStyleComboBox��#" [  ! 5F     �� *RangeBackground+$ _rangeSlider��#" [ 5H     �� 5J     $��Higher Range Background:��6   $��4��5K     $��2��5L     $��Center=�5M     $��10,5,5,5q�5N       5O     $��4��6   $��3��5P     $��Center=�5S     $��5q�5T     {�5Q     �� *SelectedIndex+$ higherRangeStyleComboBox��#" [  ! 5R     �� *HigherRangeBackground+$ _rangeSlider��#" [ 5T     �� 5W     $��Lower Range Style:��6   $��4��5X     $��Center=�5Y     $��10,5,5,5q�5Z     �� 5[     -   5        # ��Name$# lowerRangeStyleComboBox��5[     $��5��5\     $ 0��5]     $	 Tag��5_     $��Center=�5`     $��5q�5a       5^     �� *LowerRangeStyle+$ _rangeSlider��.@�5b     �� $��Default��6   
$ � Tag$ 5c     Z� �� 5d     $��Style 1��6   #$ [ 5e     �� 5f     $��Style 2��6   #$ [ 5g     �� 5h     $��Style 3��6   #$ [ 5i     5j     �� 5l     $��Range Style:��6   $��1��5m     $��4��5n     $��Center=�5o     $��10,5,5,5q�5p     �� 5q     -   5        $# rangeStyleComboBox��5q     $��1��5r     $��5��5s     $ 0��5t     $	 Tag��5v     $��Center=�5w     $��5q�5x       5u     �� *
RangeStyle+$ _rangeSlider��.@�5y     �� $��Default��6   $ 5z     Z� �� 5{     $��Style 1��6   #$ [ 5|     �� 5}     $��Style 2��6   #$ [ 5~     �� 5     $��Style 3��6   #$ [ 5�     5�     �� 5�     $��Higher Range Style:��6   $��2��5�     $��4��5�     $��Center=�5�     $��10,5,5,5q�5�     �� 5�     -   5        $# higherRangeStyleComboBox��5�     $��2��5�     $��5��5�     $ 0��5�     $	 Tag��5�     $��Center=�5�     $��5q�5�       5�     �� *HigherRangeStyle+$ _rangeSlider��.@�5�     �� $��Default��6   $ 5�     Z� �� 5�     $��Style 1��6   #$ [ 5�     �� 5�     $��Style 2��6   #$ [	 5�     �� 5�     $��Style 3��6   #$ [
 5�     5�     5�     5�  	   �� 5�     $��1��6   $��10q�5�     .+�5�     �� $��Usage:��6    
 Header#��[ 5�       5�     -   5        %  Name$% _rangeSlider��5�     $��Center=�5�     $��Center=�5�     &   Minimum$& 0Q�5�     '   Maximum$	' 100Q�5�     (   
LowerValue$( 30Q�5�     )   HigherValue$) 70Q�5�     *   Step$* 1Q�5�     $	��600��5�     $	��225��5�     +   Orientation$+ 
Horizontal=�5�     ,   LowerThumbBackground, �	#FFF0F0F0-   HigherThumbBackground- �	#FFF0F0F0.   RangeBackground
. �   �/   HigherRangeBackground
/ ��  �0   LowerRangeBackground
0 ��  �1   HigherRangeStyle1 5�     Z� 2   
RangeStyle2 5�     Z� 3   LowerRangeStyle3 5�     Z� 5�  	   5�     5�     
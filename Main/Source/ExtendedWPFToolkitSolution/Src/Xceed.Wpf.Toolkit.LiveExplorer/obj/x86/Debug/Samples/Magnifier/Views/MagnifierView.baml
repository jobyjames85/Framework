   M S B A M L   `   `   `  ����l  hXceed.Wpf.Toolkit.LiveExplorer, Version=2.2.5318.21602, Culture=neutral, PublicKeyToken=3e4669d2f30244f4O,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorerXceed.Wpf.Toolkit.LiveExplorer  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      �Iclr-namespace:Xceed.Wpf.Toolkit.LiveExplorer.Samples.Magnifier.Converters;Xceed.Wpf.Toolkit.LiveExplorer.Samples.Magnifier.Converters  5      J    DXceed.Wpf.Toolkit.LiveExplorer.Samples.Magnifier.Views.MagnifierView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      >local,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorer     5      X TXceed.Wpf.Toolkit, Version=2.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      0sys&clr-namespace:System;assembly=mscorlib  5      TconvIclr-namespace:Xceed.Wpf.Toolkit.LiveExplorer.Samples.Magnifier.Converters  5      -   'Xceed.Wpf.Toolkit.LiveExplorer.DemoView    Title$  	Magnifier��5         Description 5      J� 5   
   $��14(�6   $��Segoe)�6"   .*�65   KIThe Magnifier control allows the user to magnify parts of an application.5       � 	Resources 5      P  JXceed.Wpf.Toolkit.LiveExplorer.Samples.Magnifier.Converters.ColorConverter   colorConverterU  OXceed.Wpf.Toolkit.LiveExplorer.Samples.Magnifier.Converters.VisibilityConverter  visibilityConverter$  Xceed.Wpf.Toolkit.RtfFormatter  rtfFormatter  enumData S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%�   &	        &	      &	 &     &	 9       5    
   6     5!   
   6#     5"   
   6   S� 5$   
   $ 	GetValues��6.   "  6E    5%      M� 5&      $ xctk:FrameType��6   5(      5)      .��5+      �  � RowDefinitions 5,   
   �� 5-      $
��Auto �6   �� 5.      $
��Auto �6   .+�51   
   �� $��Features��6   $��0��6%   $��5q�62   .��52      � $��5q�6   $
��Left=�6    53      �� 54      $
��Auto �6$   �� 55      $
��Auto �6$   �� 56      $
��Auto �6$    � ColumnDefinitions 58      �� 59      $
��Auto �6'   �� 5:      $��* �6'   �� 5;      $��* �6'   �� 5<      $��* �6'   .+�5>      �� $��Zoom Factor:��6   $��Center=�60   $��5q�6K   $  Xceed.Wpf.Toolkit.DoubleUpDown  5?      -   5        	  Name$	 _zoomFactor��5?   $   $��1��69   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]
   Value$	
 0.4X�6I      Minimum$ 0X�6U   �  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   	Increment$	 0.1X�6a      Maximum$ 3X�6q      FormatString$ N1��6}   $	��150��6�   $��5q�6�   �� 5@      $��Border Thickness:��6   $��1��65   $��Center=�6B   $��5q�6]   %	  Xceed.Wpf.Toolkit.IntegerUpDown	  5A      -   5         	 Name$ _borderThickness��5A   %   $��1��6?   $��1��6L   �
  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]] 
  Value$ 2X�6\    
  Minimum$ 0X�6f    
  Maximum$ 20X�6r   $	��150��6   $��5q�6�   �� 5B      $��Border Brush:��6   $��2��61   $��Center=�6>   $��5q�6Y   #  Xceed.Wpf.Toolkit.ColorPicker  5C      -   5          Name$ _colorPicker��5C   #   $��2��69   $��1��6F   $	��150��6V   $��5q�6b      SelectedColor$ 	#FFEFAC27��6m   �� 5D      $��2��6   $��Frame Type:��6,   $��Center=�6?   $��10,0,0,0q�6Z   �� 5E      -   5         ��Name$ 
_frameType��5E       �� SelectedIndex$ 0��6/   $��3��6z   $	��150��6�   $��5q�6�   ��6A   ��  �� Source# [ 6�   �� 5F      $��Radius:��6   $��1��6+   $��2��68   $��Center=�6�   $��10,0,0,0q�6�   y�6H   ��  �� ElementName$ 
_frameType�� �� Path$ SelectedItem� �� 	Converter# [  �� ConverterParameter$ 0��6�     5G      -   5        $	 _radius��5G   $   $��1��6�   $��3��6�   $
 80X�6�   $ 0X�6�   $	 150X�6�   $	��150��6�   $��5q�6  y�65   �� $ 
_frameType��$ SelectedItem�# [ $ 0��6  �� 5H      $��RectangleWidth:��6   $��1��63   $��2��6@   $��Center=�6�   $��10,0,0,0q�6�   y�6P   �� $ 
_frameType��$ SelectedItem�# [ $ 1��6�     5I      -   5        $	 _width��5I   $   $��1��64   $��3��6A   $	
 160X�6Q   $ 0X�6^   $	 300X�6j   $	��150��6�   $��5q�6  y�6x   �� $ 
_frameType��$ SelectedItem�# [ $ 1��6  �� 5J      $��RectangleHeight:��6   $��2��64   $��2��6A   $��Center=�6�   $��10,0,0,0q�6�   y�6Q   �� $ 
_frameType��$ SelectedItem�# [ $ 1��6�     5K      -   5        $	 _height��5K   %   $��2��66   $��3��6C   $	
 160X�6S   $ 0X�6`   $	 300X�6l   $	��150��6  $��5q�6  y�6z   �� $ 
_frameType��$ SelectedItem�# [ $ 1��6  5L      5M      �� 5O   
   $��1��6   $��10q�6"   $
��Left=�6.   .+�5P      �� $��Usage:��6    
 Header#��[ 6&   #  Xceed.Wpf.Toolkit.RichTextBox  5Q      -   5          Name$ _txtContent��5Q       �� 
IsReadOnly .    TextFormatter# [ 5S      $��10(�5T      (  "Xceed.Wpf.Toolkit.MagnifierManager   	Magnifier 5U      !  Xceed.Wpf.Toolkit.Magnifier  5V      -	   5           Name$  
_magnifier��5V   )   
�������!   Radius! 5X   )   ��  %  System.Windows.Markup.Reference  *	_radius+$ Value�"   
ZoomFactor" 5Y   )   ��    *_zoomFactor+$ Value�#   	FrameType# 5Z   )   ��    *
_frameType+$ SelectedItem���5[   )   ��    *_colorPicker+$ SelectedColor�# [  ��5\   )   ��    *_borderThickness+$ Value���5]   )   ��    *_width+$ Value�$ �� Mode$$ TwoWay=���5^   )   ��    *	_height+$ Value�$$ TwoWay=�5`      5a      5b      5c      
   M S B A M L   `   `   `  ����l  hXceed.Wpf.Toolkit.LiveExplorer, Version=2.2.5318.21602, Culture=neutral, PublicKeyToken=3e4669d2f30244f4O,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorerXceed.Wpf.Toolkit.LiveExplorer  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      �Hclr-namespace:Xceed.Wpf.Toolkit.LiveExplorer.Samples.DateTime.Converters:Xceed.Wpf.Toolkit.LiveExplorer.Samples.DateTime.Converters  5      H    BXceed.Wpf.Toolkit.LiveExplorer.Samples.DateTime.Views.DateTimeView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      X TXceed.Wpf.Toolkit, Version=2.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      8local,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorer  5      0sys&clr-namespace:System;assembly=mscorlib  5      SconvHclr-namespace:Xceed.Wpf.Toolkit.LiveExplorer.Samples.DateTime.Converters  5      -   'Xceed.Wpf.Toolkit.LiveExplorer.DemoView    Title$  DateTime��5         Description 5      J� 5   
   $��14(�6   $��Segoe)�6"   .*�65   ��The DateTimePicker and TimePicker controls let you select the date and the time in several ways. The TimePicker is used in the DateTimePicker.5       � 	Resources 5      \   VXceed.Wpf.Toolkit.LiveExplorer.Samples.DateTime.Converters.DateTimeToTimeSpanConverter   dateTimeToTimeSpanConverter\  VXceed.Wpf.Toolkit.LiveExplorer.Samples.DateTime.Converters.CustomFormatToBoolConverter  CustomFormatToBoolConverter  enumTimeFormatData S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName  enumDateFormatData  enumVisibility��%�  &	        &	      &	 &     &	 �     &	       5       6)     5!      6)   S� 5#      $ 	GetValues��66   "  6M    5$      M� 5%      $ xctk:TimeFormat��6   5'      S� 5(      $ 	GetValues��66   "  6M    5)      M� 5*      $ xctk:DateTimeFormat��6   5,   	   S� 5-   
   $ 	GetValues��64   "  6K    5.      M� 5/      $ 
Visibility��6   51      52      .��53      �  � RowDefinitions 54   
   �� 55      $
��Auto �6   �� 56      $
��Auto �6    � ColumnDefinitions 58   
   �� 59      $��* �6   �� 5:      $��* �6   .+�5=      �� $��Features��6   $��2��6#   $��Stretch=�67   .��5>      �  5?      �� 5@      $
��Auto �6   �� 5A      $
��Auto �6   �� 5B      $
��Auto �6   �� 5C      $
��Auto �6   �� 5D      $
��Auto �6   �� 5E      $
��Auto �6    5G      �� 5H      $
��Auto �6"   �� 5I      $
��Auto �6"   �� 5J      $
��Auto �6"   �� 5K      $
��Auto �6"   .+�5N      �� $��Format:��6   $��0��6'   $��0��64   $��Center=�6D   �� 5O      -   5        	 ��Name$	 _format��5O      $��0��6(   $��1��65   
 �� SelectedIndex$
 1��6E   $	��190��6�   $��5,5,25,5q�6�   ��6W   ��  �� Source# [ 6�   �� 5P      $��FormatString:��6   $��1��6-   $��0��6:   $��Center=�6J     DisableGrayText#��[ 6�   {�6e   �� *	IsEnabled+ �� ElementName$ _formatString��6�   �� 5Q      -   5         ��Name$ _formatString��5Q      $��1��6-   $��1��6:   $��	yy MMM dd��6J   $	��190��6[   $��5,5,25,5q�6�   {�6g   ��  %  System.Windows.Markup.Reference  *	_format+ �� Path$ SelectedItem� �� 	Converter# [ 6�   �� 5R      $��
Watermark:��6   $��2��6*   $��0��67   $��Center=�6G   �� 5S      -   5        $ 
_watermark��5S      $��2��6*   $��1��67   $��
Enter Text��6G   $	��190��6Y   $��Center=�6e   $��5,5,25,5q�6�   �� 5T      $��AutoCloseCalendar:��6   $��3��62   $��0��6?   $��Center=�6O   �� 5U      -   5         ��Name$ _autoCloseCalendar��5U      $��3��63   $��1��6@    d� 	IsChecked$ FalseY�6P   $��Center=�6b   $��5,5,25,5q�6}   �� 5V      $��ClipValueToMinMax:��6   $��4��62   $��0��6?   $��Center=�6O   �� 5W      -   5        $ _clipValueToMinMax��5W      $��4��63   $��1��6@   $ FalseY�6P   $��Center=�6b   $��5,5,25,5q�6}   �� 5X      $��TimePickerVisibility:��6   $��5��65   $��0��6B   $��Center=�6R   �� 5Y      -   5        $	 _timePickerVisibility��5Y      $��5��66   $��1��6C   $
 0��6S   $	��190��6�   $��5,5,25,5q�6�   ��6e   �� # [ 6�   �� 5[      $��TimeFormat:��6   $��0��6+   $��2��68   $��Center=�6H   �� 5\      -   5        $	 _timeFormat��5\      $��0��6,   $��3��69   $
 1��6I   $	��190��6�   $��5q�6�   ��6[   �� # [ 6�   �� 5]      $��Time FormatString:��6   $��1��62   $��2��6?   $��Center=�6O   #��[ 6�   {�6j   �� *	IsEnabled+$ _timeFormatString��6�   �� 5^      -   5        $ _timeFormatString��5^      $��1��61   $��3��6>   $
��H:mm��6N   $	��190��6Z   $��5q�6�   {�6g   ��    *_timeFormat+$ SelectedItem�# [ 6�   �� 5_      $��TimeWatermark:��6   $��2��6.   $��2��6;   $��Center=�6K   �� 5`      -	   5        $ _timeWatermark��5`      $��2��6.   $��3��6;   $��
Enter Text��6K   $	��190��6]   $��Center=�6i   $��5q�6�   �� 5a      $��Minimum:��6   $��3��6(   $��2��65   $��Center=�6E   &   Xceed.Wpf.Toolkit.DateTimeUpDown  5b      -
   5          Name$ _minimum��5b   "   $��3��64   $��3��6A      Format$ Custom=�6Q      FormatString$ yyyy/MM/dd HH:mm��6a   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value$ 2010/01/01T12:00X�6�   $	��190��6�   $��Center=�6�   $��5q�6�   �� 5c      $��Maximum:��6   $��4��6(   $��2��65   $��Center=�6E     5d      -   5        $ _maximum��5d   "   $��4��64   $��3��6A   $ Custom=�6Q   $ yyyy/MM/dd HH:mm��6a   $ 2015/12/31T12:00X�6�   $	��190��6�   $��Center=�6�   $��5q�6�   5e      5f   	   �� 5h      $��1��6   $��0��6    $
��Left=�60   .+�5i      �� $��DateTimePicker Usage: ��6   $��0,10,0,0q�66    
 Header#��[ 6H   &   Xceed.Wpf.Toolkit.DateTimePicker  5j      -   5          Name$ _datetimePicker��5j   "   $	��300��5k   "   $	��Top=�5l   "   ,	  &Xceed.Wpf.Toolkit.Primitives.InputBase 	  
IsReadOnly .   5n   "   ��    *	_format+$ SelectedItem� 5o   "   �� *Text+$ _formatString�� 	  	Watermark 5p   "   ��    *
_watermark+$
 Text�   
TimeFormat 5q   "   ��    *_timeFormat+$ SelectedItem�   TimeFormatString 5r   "   �� *Text+$ _timeFormatString��   TimeWatermark 5s   "   ��    *_timeWatermark+$
 Text�   AutoCloseCalendar 5t   "   �� *	IsChecked+$ _autoCloseCalendar��   ClipValueToMinMax 5u   "   �� *	IsChecked+$ _clipValueToMinMax��   TimePickerVisibility 5v   "   ��    *_timePickerVisibility+$ SelectedItem�   Minimum 5w   "   �� *Value+$ _minimum��    Maximum  5x   "   �� *Value+$ _maximum��5y      �� 5{   
   $��1��6   $��1��6"   $��Stretch=�62   .+�5|      �� $��TimePicker Features��6   $��0,15,0,0q�64   .��5}      �  5~      �� 5      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(    5�      �� 5�      $
��Auto �6+   �� 5�      $
��Auto �6+   .+�5�      �� $��
StartTime:��6    $��Center=�62     5�      -   5        $ 
_startTime��5�   *   $��1��6>   $ 	ShortTime=�6N   $
 9:00X�6a   $	��100��6n   $��5q�6z   �� 5�      $��EndTime:��6    $��1��60   $��Center=�6=     5�      -   5        $ _endTime��5�   *   $��1��6<   $��1��6I   $ 	ShortTime=�6Y   $ 17:00X�6l   $	��100��6z   $��5q�6�   �� 5�      $��TimeInterval:��6    $��2��65   $��Center=�6B     5�      -   5        $ _timeInterval��5�   *   $��2��6A   $��1��6N   $ Custom=�6^   $
 H:mm��6n   $
 0:30X�6�   $	��100��6�   $��5q�6�   5�      5�      �� 5�      .+�5�      �� $��TimePicker Usage: ��6   #��[ 66   "
  Xceed.Wpf.Toolkit.TimePicker
  5�      -   5        ! 
 Name$! _timePicker��5�   "   $	��Top=�5�   "   " 
  Format" 5�   "   ��    *_timeFormat+$ SelectedItem�# 
  FormatString# 5�   "   �� *Text+$ _timeFormatString��$ 
  	Watermark$ 5�   "   ��    *_timeWatermark+$
 Text�% 
  	StartTime% 5�   "   ��    *
_startTime+$ Value�# [  & 
  EndTime& 5�   "   ��    *
_endTime+$ Value�# [  ' 
  TimeInterval' 5�   "   ��    *_timeInterval+$ Value�# [  ( 
  ClipValueToMinMax( 5�   "   �� *	IsChecked+$ _clipValueToMinMax��) 
  Minimum) 5�   "   �� *Value+$ _minimum��* 
  Maximum* 5�   "   �� *Value+$ _maximum��5�      5�      5�      5�      
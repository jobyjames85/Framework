   M S B A M L   `   `   `  ����l  hXceed.Wpf.Toolkit.LiveExplorer, Version=2.2.5318.21602, Culture=neutral, PublicKeyToken=3e4669d2f30244f4O,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorerXceed.Wpf.Toolkit.LiveExplorer  5      H    BXceed.Wpf.Toolkit.LiveExplorer.Samples.TimeSpan.Views.TimeSpanView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      X TXceed.Wpf.Toolkit, Version=2.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      8local,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorer  5      -   'Xceed.Wpf.Toolkit.LiveExplorer.DemoView    Title$  TimeSpanUpDown��5         Description 5      J� 5   
   $��14(�6   $��Segoe)�5      .*�6'   |zThe TimeSpanUpDown controls let you increment or decrement a time over 24 hours. The Format is Days.Hours:Minutes:Seconds.5      .��5      �  � RowDefinitions 5    
   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   .+�5%   
   �� $��Features��6   $��Stretch=�5&      .��5'      �  5(      �� 5)      $
��Auto �6$   �� 5*      $
��Auto �6$   �� 5+      $
��Auto �6$    � ColumnDefinitions 5-      �� 5.      $
��Auto �6'   �� 5/      $
��Auto �6'   �� 50      $
��Auto �6'   �� 51      $
��Auto �6'   .+�54      �� $��
Watermark:��6   $��Center=�55      �� 56      -   5         ��Name$ 
_watermark��56      $��1��57      $	��190��59      $
��Left=�5:      $��5,5,25,5q�5;      ��58      �� *	Watermark+ �� ElementName$ _timeSpanUpDown��5;      �� 5<      $��1��6   $��ClipValueToMinMax:��5=      $��Center=�5>      �� 5?      -   5         ��Name$ _clipValuetoMinMax��5?      $��1��5@      $��1��5A      $
��Left=�5C      $��Center=�5D      $��5,5,25,5q�5E       d� 	IsChecked 5B      �� *ClipValueToMinMax+$ _timeSpanUpDown��5E      �� 5G      $��2��6   $��DefaultValue:��5H      $��Center=�5I      $��5q�5J      &   Xceed.Wpf.Toolkit.TimeSpanUpDown  5K      -   5          Name$ _defaultValue��5K   &   $��3��5L   &   $	��100��5N   &   $
��Left=�5O   &   $��Center=�5P   &   $��5,5,25,5q�5Q   &   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]	   Value	 5M   &   �� *DefaultValue+$ _timeSpanUpDown��5Q   &   �� 5R      $��1��6   $��2��5S      $��Minimum:��5T      $��Center=�5U      $��5q�5V        5W      -   5        $ _minimum��5W   &   $��1��5X   &   $��3��5Y   &   $	��100��5[   &   $
��Left=�5\   &   $��Center=�5]   &   $��5,5,25,5q�5^   &   	 5Z   &   �� *	Minimum+$ _timeSpanUpDown��5^   &   �� 5_      $��2��6   $��2��5`      $��Maximum:��5a      $��Center=�5b      $��5q�5c        5d      -   5        $ _maximum��5d   &   $��2��5e   &   $��3��5f   &   $	��100��5h   &   $
��Left=�5i   &   $��Center=�5j   &   $��5,5,25,5q�5k   &   	 5g   &   �� *	Maximum+$ _timeSpanUpDown��5k   &   5l      5m      �� 5o   
   $��1��6   $
��Left=�5p      .+�5q      �� $��Usage: ��6   $��0,10,0,0q�5r       
  Header#��[  5s        5t      -   5        $ _timeSpanUpDown��5t   "   $	��300��5u   "   $	��Top=�5v   "   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase
   
IsReadOnly
 .     	Watermark$ 
Enter text��5x   "      DefaultValue$ 00:00:00X�5y   "      Maximum$ 
5.00:00:00X�5z   "      Minimum$ 00:00:00X�5{   "      ClipValueToMinMax .  5|   "   5}      5~      5      
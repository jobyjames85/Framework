   M S B A M L   `   `   `  ����P  LFramework.devControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Framework.devControlsFramework.devControls  5      $    Framework.devControls.HomePage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      4fdev#clr-namespace:Framework.devControls     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      G COdyssey, Version=1.4.22.21520, Culture=neutral, PublicKeyToken=null(odchttp://schemas.odyssey.com/wpf  5        N� Title$  HomePage��5	       � 	Resources 5
         TreeViewItemFocusVisual �� Property �� Value*   $Framework.devControls.TreeViewItemEx �� 
TargetType �� Path �� RelativeSource �� AncestorType  ForgroundForTreeViewItem �� 
TargetType	 � ColumnDefinitions
 � RowDefinitions ��Name �� CornerRadius J� SnapsToDevicePixels �� Padding d�Name  ExpandCollapseToggleStyle �� 	ClickMode d� 	IsChecked $  ForgroundForAreaPageTreeViewItem ��Name ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName P� 
SourceName��%(  &	        '  n     7   �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� 5      5      5      �� 5   
   "  6   .�5      ��  � ��
 ���� 6+   �� 5       � �� 6;   �� $  HorizontalContentAlignment� �� " ���� 5       � �� 69   �� $ VerticalContentAlignment� �� " ���� 5       � ��$ 2q�6(   �� 5       � ��# �  6+   �� 5       �@�FocusVisualStyle8   61   �� 5       � �� 5      �� 5      " Q�6&   .R�5      � 	 5      �� 5    "   $��10��63   $
��Auto �6A   �� 5!   "   $
��Auto �63   �� 5"   "   $��* �63   
 5$      �� 5%   "   $
��Auto �60   �� 5&   "   .+�5(      �� $ Bd��6%   $��3��62   $ 2��6F    . #��z��6s   #��z��5)   /   $��1q�6\   # z��6p   ._�5*   "   � $
��Left=�6'   	 5+   &   �� 5,   *   $��19��6;   $
��Auto �6I   �� 5-   *   .+�5/   &   d� $ Expander��63   #���  6E   $ Press=�50   3    5/   y   �� $ 
IsExpanded� �� *TemplatedParent+50   3   �� 51   &   $��	underline��6S   $��1��60   $��	0,-1,0,-2q�6@   #���  6d   �� 52   "   $ PART_Header��53   3   #��z��52   4   # z 53   H   $��Header��6�   54   '   �� 56   &   $ FocusElement��6@   $��1��60   6X   57   #   58      �� 59      $ 	ItemsHost��6-   $��1��6@   $��0q�6P   $��3��6[   $��1��6o   5:       5;      P� 5<       �@Q�
IsExpanded .  . �5=   "   �� $ 	ItemsHost��6?    � y�$ 	Collapsed=�6V   5>      P� 5?       �@��HasItems .  . �5@   "   �� $ Expander��6?    � y�$ Hidden=�6U   5A      P� 5B      $ PART_Header��6J    �@J�IsMouseOver . . �5C   "   �� $ 	underline��6)    � ��$ 	Underline{�6[   5D      P� 5E       �@Q�
IsSelected . 5F      P� 5G       �@J�	IsFocused . . �5H   "   �� $ FocusElement��6)    � ��
 �����6U   �� 5I   "   $ FocusElement��6)    �@��StrokeDashArray$	 2 2R�6^   5J      5L      5N      5O      5P      .��5R      � 	 5S   
   �� 5T      $��* �6   �� 5U      $��* �6   .+�5W   
   "  Odyssey.Controls.ExplorerBar  -   5          Name$ layoutGroup1��5W      $��0��60   
������ $��Stretch=�6Y   $��Stretch=�6w     5X   
   -   5        $ layoutGroup2��5X      $��1��60   
������ $��Stretch=�6Y   $��Stretch=�6w   5Y      5Z      
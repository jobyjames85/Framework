   M S B A M L   `   `   `  ����G  COdyssey, Version=1.4.22.21520, Culture=neutral, PublicKeyToken=nullD/clr-namespace:Odyssey.Controls;assembly=OdysseyOdyssey.Controls  5   	   P LFramework.devControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\Bclr-namespace:Framework.devControls;assembly=Framework.devControlsFramework.devControls 5   	   D @Framework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Framework	Framework 5   	      Framework.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   =odc/clr-namespace:Odyssey.Controls;assembly=Odyssey    5   	   PfdvBclr-namespace:Framework.devControls;assembly=Framework.devControls    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ^ ZMicrosoft.Windows.Shell, Version=3.0.1.0, Culture=neutral, PublicKeyToken=64e92ee0932fdddcKshell?http://schemas.microsoft.com/winfx/2006/xaml/presentation/shell  5   	   #localclr-namespace:Framework  5   	   M IFabTab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=292626629a736ae0$tabhttp://fabtab.codeplex.com  5   	     � WindowStartupLocation$  CenterScreen=�5   /    � Title$ 
MainWindow��5	   	   $	��600��6   $	��800��6)    � 	Resources 5
         	TreeArrow  
GlyphBrush �� Color  
ListBorder  TreeViewItemFocusVisual �� Property �� Value �� 
TargetType �� Path �� RelativeSource	 �� AncestorType  ForgroundForTreeViewItem
 �� 
TargetType � ColumnDefinitions � RowDefinitions ��Name �� CornerRadius J� SnapsToDevicePixels �� Padding d�Name  ExpandCollapseToggleStyle �� 	ClickMode d� 	IsChecked $  ForgroundForAreaPageTreeViewItem ��Name ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName P� 
SourceName  treeviewStyle  BackGroundForMouseOver 	 BorderForMouseOver 
 BackGroundForSelected  BorderForSelected  FabTab.FabTabItem �� Orientation �� Triggers N� EnterActions"  FabTab.EasingMarginAnimation g� Duration  t� From	! t� To" �� TargetProperty#   Equation��%�  &	        &	 *     &	 H     &	 i     'Q� �     7  &	 y    7  '  `    B� 5   
   $��M0,0 L0,6 L6,0 zC�6)   �� 5   
   $
 #444��6-   �� 5   
   $ #828790��6-   �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� 5      5      5      �� 5!   
   " Q�6   .�5"      ��  � ��
 ���� 6+   �� 5#       � �� 6;   �� $  HorizontalContentAlignment� �� "	 ���� 5$       � �� 69   �� $ VerticalContentAlignment� �� "	 ���� 5%       � ��$ 2q�6(   �� 5&       � ��# �  6+   �� 5'       �@�FocusVisualStyle8   61   �� 5(       � �� 5)      �� 5*      "
 Q�6&   .R�5+      �  5,      �� 5-   "   $��10��63   $
��Auto �6A   �� 5.   "   $
��Auto �63   �� 5/   "   $��* �63    51      �� 52   "   $
��Auto �60   �� 53   "   .+�55      �� $ Bd��6%   $��3��62   $ 2��6F    . #��z��6s   #��z��56   /   $��1q�6\   # z��6p   ._�57   "   � $
��Left=�6'    58   &   �� 59   *   $��19��6;   $
��Auto �6I   �� 5:   *   .+�5<   &   d� $ Expander��63   #���  6E   $ Press=�5=   3    5<   y   �� $ 
IsExpanded� �� *TemplatedParent+5=   3   �� 5>   &   $��	underline��6S   $��1��60   $��	0,-1,0,-2q�6@   #���  6d   �� 5?   "   $ PART_Header��5@   3   #��z��5?   4   # z 5@   H   $��Header��6�   5A   '   �� 5C   &   $ FocusElement��6@   $��1��60   6X   5D   #   5E      �� 5F      $ 	ItemsHost��6-   $��1��6@   $��0q�6P   $��3��6[   $��1��6o   5G       5H      P� 5J       �@Q�
IsExpanded .  . �5K   "   �� $ 	ItemsHost��6?    � y�$ 	Collapsed=�6V   5L      P� 5M       �@��HasItems .  . �5N   "   �� $ Expander��6?    � y�$ Hidden=�6U   5O      P� 5P      $ PART_Header��6J    �@J�IsMouseOver . . �5S   "   �� $ 	underline��6)    � ��$ 	Underline{�6[   5T      P� 5U       �@Q�
IsSelected . 5W      P� 5X       �@J�	IsFocused . . �5Y   "   �� $ FocusElement��6)    � ��
 �����6U   �� 5Z   "   $ FocusElement��6)    �@��StrokeDashArray$	 2 2R�6^   5[      5]      5_      5`      �� 5a   
   " Q�6&   .�5b      ��  � ��
 ���� 6+   �� 5c       � �� 6;   �� $  HorizontalContentAlignment� �� "	 ���� 5d       � �� 69   �� $ VerticalContentAlignment� �� "	 ���� 5e       � ��$ 2q�6(   �� 5f       � ��# �  6+   �� 5g       �@�FocusVisualStyle8   61   �� 5h       � �� 5i      �� 5j      "
 Q�6&   .R�5k      �  5l      �� 5m   "   $��10��63   $
��Auto �6A   �� 5n   "   $
��Auto �63   �� 5o   "   $��* �63    5q      �� 5r   "   $
��Auto �60   �� 5s   "   .+�5u      �� $ Bd��6%   $��3��62   $ 2��6F    . #��z��6s   #��z��5v   /   $��1q�6\   # z��6p   ._�5w   "   �  5x   &   �� 5y   *   $��19��6;   $
��Auto �6I   �� 5z   *   .+�5|   &   d� $ Expander��63   #���  6E   $ Press=�5}   3    5|   y   �� $ 
IsExpanded� �� *TemplatedParent+5}   3   �� 5~   &   $ PART_Header��5   3   $��1��5~   7   $��	0,-1,0,-2q�6G   #��z��6Z   # z 5   H   $��Header��6�   5�   #   5�      �� 5�      $ 	ItemsHost��6-   $��1��6@   $��0q�6P   $��3��6[   $��1��6o   5�       5�      P� 5�       �@Q�
IsExpanded .  . �5�   "   �� $ 	ItemsHost��6?    � y�$ 	Collapsed=�6V   5�      P� 5�       �@��HasItems .  . �5�   "   �� $ Expander��6?    � y�$ Hidden=�6U   5�      P� 5�      $ PART_Header��6J    �@J�IsMouseOver . . �5�   "   �� $ Bd��6?   # �  6P    � ���� 5�   "   $ Bd��6@   # � 	 6P    � ��5�      P� 5�       �@Q�
IsSelected . . �5�   "   �� $ Bd��6?   # � 
 6O    � ���� 5�   "   $ Bd��6A   # �  6Q    � ��5�      5�      5�      5�      �� 5�   
   "  6   .�5�      ��  � �� 5�      �� 5�      .R�5�      �� $ 
Horizontal=�6%   $��0,0,4,0q�6>   .+�5�      �� $��CharacterEllipsis=�69   ��6(   �� 69   5�      5�      5�       5�      P� 5�       �@��
IsSelected .  5�      �� 5�      .��5�      �� .��5�   "     $ 0:0:0.7D�6<   $  	500,0,0,0X�6O   $! 0,0,0,0X�6`   $" Content.Margin�5�   :   $# BounceEaseIn=�5�   <   5�      5�      5�      5�      5�      .��5�      �  5�   
   �� 5�      $
��Auto �6   $	��300��6,   �� 5�      $��* �6   .+�5�   
   o� $	��Top=�6   $��Right=�6(   $��2��6D   $��0,-25,100,0q�6T   *  $Microsoft.Windows.Shell.WindowChrome$   IsHitTestVisibleInChrome$ . .@�5�      m� $��Settings��6   % m� Icon% 5�      �� 5�      $H��Bpack://application:,,,/Framework;component/Images/settingsgear.png��6   .@�5�      m� $��Language��6   .@�5�      m� $��English��6   m� 5�      $��Japanese��6   5�      m� 5�      $��Theme��6   .@�5�      m� $
��Blue��6   m� 5�      $��Purple��6   5�      5�      5�      !   Odyssey.Controls.OutlookBar  5�   
   -   5        &  Name$& NavigationBar��5�      $��Outlook Bar��60   '   MaxNumberOfButtons$' 2��6E   $��0��6]   (   IsCloseButtonVisible( .  )   SelectedSectionIndex$) 0��5�   3   $��4,4,0,4q�5�      $��0��6'   $
��Left=�64   *   IsButtonSplitterVisible* . +   IsOverflowVisible+ . ,   IsPopupVisible, .  -   ShowSideButtons- . .   ShowButtons. . /   OverflowMenuItems/ 5     0   OptionButtons0 5     5       FabTab.FabTabControl  5  
   -   5        1  Name$1 
tabControl��5  ,   $��1��6   $	��300��6@   %2   ShowDefaultTransitionAnimation2 .  3   ShowTabCloseButtons3 .  4   ShowToolTipImages4 .  @�5     (  "Framework.devControls.DevTabItemEx  5     -   5        5  Name$
5 Tab1��5  #   $��myview1��61     5     $��	My View 2��6%   .��5     � 6   5       5     $��	My View 3��6%   .��5      � 6   5!     5%     5'     5(     
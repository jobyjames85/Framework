   M S B A M L   `   `   `  ����K  GFramework.Themes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Framework.ThemesFramework.Themes  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZMicrosoft.Windows.Shell, Version=3.0.1.0, Culture=neutral, PublicKeyToken=64e92ee0932fdddcR NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   frameLayout  �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius  maxBorderBorderBrush  maxborderThickness  MaxBorderBackGround  innerBorderBrush  innerBorderThickness �Name � RowDefinitions  titlebarBackground � ColumnDefinitions	 �� RelativeSource
 �� AncestorType �� AncestorLevel �� Path �� Mode �� UpdateSourceTrigger%    Framework.Themes.CaptionButtons*  $Microsoft.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome    IsMaximizeVisible    IsMinimizeVisible  sepratorBorderBrush  sepratorBackground 	 StyleSeprator 
 StyleClientAreaGrid  StyleClientAreaBorder  StyleInnerGrid  	rect1Fill  	rect2Fill  CustSkin   CaptionHeight   ResizeBorderThickness   CornerRadius   GlassFrameThickness ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    Kshell?http://schemas.microsoft.com/winfx/2006/xaml/presentation/shell  5      %ftclr-namespace:Framework.Themes  5      :x,http://schemas.microsoft.com/winfx/2006/xaml     5      %�	  &	        &	      7   �� 5      "  ��6    .�5   
   ��  � �� 5      �� 5	      " ��6"   .R�5
      �� .u�5      �� $ borderforMaximize��6!   $ 0��6<   #���  6M   #���  5      #���  6T   ._�5      �� $ Innerborder��6%   #���  6:   #���  5      ._�5   "   � $ gridforMaximize��6'    5   &   �� 5   *   $��41 �68   �� 5   *   $	��0.5 �68   �� 5   *   $��* �68   �� 5   *   $
��Auto �68   .+�5   &   �� $ PART_TitleBar��6;   $��0��6.   #���  6R   ._�5   *   � $
 grid��6/   $��1q�6=    5   .   �� 5   2   $
��auto �6C   �� 5   2   $
��auto �6C   �� 5   2   $
��auto �6C   �� 5   2   $
��Auto �6C   �� 5   2   $
��Auto �6C   �� 5   2   $��* �6C   �� 5   2   $
��auto �6C   .+�5"   .   �� $��0��64   $��	12,-2,0,0q�6E   $��25��6�   ��6X   �� 	 �� *FindAncestor+$
 WindowL�$ 1��$ 
TitleWidth�$ TwoWay=�$ PropertyChanged=���6  �� 	 �� *FindAncestor+$
 WindowL�$ 1��$ 	TitleIcon��� 5$   .   
�������$��1��6L   $��5,7,0,0q�6]   $��30��6n   $	��250��6z   ��6�   �� 	 �� *FindAncestor+$
 WindowL�$ 1��$ 	TitleText�   5&   .    .  .   .  $��5��5'   8   $��0,6,0,0q�6H   $��Right=�6Y   $	��Top=�6u   5(   +   5)   '   �� 5*   &   $ SepratorBorder��6:   $��1��6-   #���  6R   #���  5+   )   #��� 	 6[   5,   '   � 5-   &   $ ContentPresentergrid��68   $��2��6+   #��� 
 6V   .+�5.   *   �� $ ContentPresenterborder��61   #���  6Q   ._�5/   .   � $ ContentPresenterInnerGrid��63   #���  6V   .+�50   2   �� #���  6<   51   3   �� 52   2   #���  6<   53   3   �� 54   2   55   /   56   +   57   '   58   #   59      5:      5;      5<      5>      5?      �� 5A      "  �6   .�5B   
   ��  �@�WindowStyle$
 None=�6(   �� 5C   
    � ��# � ��6&   �� 5D   
    �@ WindowChrome 5E        5F      $ 35Q�6%   $ 6q�68   $ 0��6R   $ -1q�6c   5H      �� 5I   
    � �� 5J      �� 5K      " �6"   .R�5L      �� $ PART_CustomFrame��6%   8��  .��5M      � .+�5N      �� $ 
ClientArea��6/   5O      5P       5Q      P� 5R       �@�WindowState$ 	Maximized=�6@   . �5T      �� $ PART_CustomFrame��6%    6U   �� 	 �� *TemplatedParent+$= 7(shell:WindowChrome.WindowChrome).ResizeBorderThickness� � ��5V      5X      5Z      5[      5]      
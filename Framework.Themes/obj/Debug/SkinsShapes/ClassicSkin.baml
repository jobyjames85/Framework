   M S B A M L   `   `   `  ����K  GFramework.Themes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Framework.ThemesFramework.Themes  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZMicrosoft.Windows.Shell, Version=3.0.1.0, Culture=neutral, PublicKeyToken=64e92ee0932fdddcR NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"    Framework.Themes.OSConverter   	osDetails  frameLayout  �� 
TargetType �� Property �� Value �� 
TargetType ��Name  maxBorderBorderBrush  maxborderThickness  MaxBorderBackGround �� CornerRadius �� RelativeSource �� Mode �� 	Converter  innerBorderBrush  innerBorderThickness	 �Name
 � RowDefinitions  titlebarBackground � ColumnDefinitions ��Name �� AncestorType �� AncestorLevel �� Path  titleSepratorBackground ��Name 	 displaynameTextForeground �� UpdateSourceTrigger ��Name 
 ShutDownControlStyle*  $Microsoft.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome%   Framework.Themes.CaptionButtons  sepratorBorderBrush  sepratorBackground  StyleSeprator  StyleClientAreaGrid  StyleClientAreaBorder  StyleInnerGrid  	rect1Fill  	rect2Fill  CustSkin   CaptionHeight   ResizeBorderThickness   GlassFrameThickness ��Name � UseLayoutRounding ��Name �� Triggers P� Property P� Value �� 
TargetName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    Kshell?http://schemas.microsoft.com/winfx/2006/xaml/presentation/shell  5      %ftclr-namespace:Framework.Themes  5      :x,http://schemas.microsoft.com/winfx/2006/xaml     5      %  &	        &	      7   &	 A
    7     5      6   �� 5      "  ��6    .�5   
   ��  � �� 5      �� 5      " ��6"   .R�5      �� .u�5      �� $ borderforMaximize��6!   #���  6�   #���  5      #���  6T    5   <   ��  �� $
 Self=�8   ._�5      �� $ Innerborder��6%   $ 6��6:   #���  6K   #���  5      ._�5   "   � $	 gridforMaximize��6'   
 5   &   �� 5   *   $��41 �68   �� 5   *   $	��0.5 �68   �� 5   *   $��* �68   �� 5   *   $
��Auto �68   .+�5   &   �� $ PART_TitleBar��6;   $��0��6.   $ 6��6R   #���  6c   ._�5   *   � $
	 grid��6/   $��1q�6=    5   .   �� 5   2   $
��auto �6C   �� 5   2   $
��auto �6C   �� 5    2   $
��auto �6C   �� 5!   2   $
��Auto �6C   �� 5"   2   $
��Auto �6C   �� 5#   2   $��* �6C   �� 5$   2   $
��auto �6C   �� 5%   2   $
��auto �6C   �� 5&   2   $
��auto �6C   .+�5(   .   �� $ titleBarImage��64   $��
12,-10,0,0q�6K   $
��Auto��6_   $��11��6l   ��6x   ��  �� *FindAncestor+$ WindowL�$ 1��$ ThemesTitleIcon��� 5*   .   $ titleBarImageSeprator��6E   $��2��65   $��	10,-9,7,0q�6e   $��Stretch=�6x   $��Stretch=�6�   $��0q�5+   1   $��1��6E   $��16��6O   #���  6[   5,   /   �� 5-   .   $ titleBartextblock��6H   $��3��68   #��� 	 6c   $��4,5,0,0q�6�   $��14(�6�   ��5.   /   ��  �� *FindAncestor+$ WindowL�$ 1��$ DisplayName�$ PropertyChanged=��� 50   .   $ logoffButton��6u   #��� 
 65   $��4��6d    . 6�   �� 51   .   $ txtVersionName��6H   $��6��68   
�������$��14(�6s   $��0,2,12,0q�6�   $��Arial Black)�6�   $��Right=�53   a   ��52   8   ��  �� *FindAncestor+$ WindowL�$ 1��$ VersionName�$ PropertyChanged=�53   a   �� 54   .   $ txtDatabaseName��6H   $��7��68   #��� 	 6a   $��14(�6�   $��0,0,40,0q�6�   $��Right=�56   a   ��55   ;   ��  �� *FindAncestor+$ WindowL�$ 1��$ DatabaseName�$ PropertyChanged=�56   a     57   .    . $��8��6s   $��0,1,0,0q�58   <   $��Right=�6M   $	��Top=�6i   59   +   5:   '   �� 5;   &   $ SepratorBorder��6:   $��1��6-   #���  6R   #���  5<   )   #���  6[   6�   � 5=   &   $	 ContentPresentergrid��68   $��2��6+   #���  6V   .+�5>   *   �� $ ContentPresenterborder��61   #���  6Q   ._�5?   .   � $	 ContentPresenterInnerGrid��63   #���  6V   .+�5@   2   �� #���  6<   5A   3   �� 5B   2   #���  6<   5C   3   �� 5D   2   5E   /   5F   +   5G   '   5H   #   5I      5J      5K      5L      5N      5O      �� 5Q      "  �6   .�5R   
   ��  �@�WindowStyle$
 None=�6(   �� 5S   
    � ��# � ��6&   �� 5T   
    �@ WindowChrome 5U        5V      $ 35Q�6%   $ 6q�68   $ 8,50,8,8q�6S   5X      �� 5Y   
    � �� 5Z      �� 5[      " �6"   .R�5\      �� $ PART_CustomFrame��6%   8��   . .��5]      � .+�5^      �� $ 
ClientArea��6/   5_      5`       5a      P� 5b       �@�WindowState$ 	Maximized=�6@   . �5d      �� $ PART_CustomFrame��6%    6U   ��  �� *TemplatedParent+$= 7(shell:WindowChrome.WindowChrome).ResizeBorderThickness� � ��5f      5h      5j      5k      5m      
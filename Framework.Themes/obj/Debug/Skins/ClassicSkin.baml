   M S B A M L   `   `   `  ����K  GFramework.Themes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Framework.ThemesFramework.Themes  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZMicrosoft.Windows.Shell, Version=3.0.1.0, Culture=neutral, PublicKeyToken=64e92ee0932fdddcR NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"    Framework.Themes.OSConverter   	osDetails  ShutDownControlStyle  �� 
TargetType �� Property �� Value ��Name �� CornerRadius J� Opacity � ColumnDefinitions ��Name �� Triggers	 P� 
SourceName
 P� Property P� Value �� 
TargetName  shutDownBackground  frameLayout �� 
TargetType  maxBorderBorderBrush  maxborderThickness  MaxBorderBackGround �� RelativeSource �� Mode �� 	Converter  innerBorderBrush  innerBorderThickness �Name � RowDefinitions 	 titlebarBackground ��Name �� AncestorType �� AncestorLevel �� Path 
 titleSepratorBackground  displaynameTextForeground �� UpdateSourceTrigger ��Name*  $Microsoft.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome%   Framework.Themes.CaptionButtons  sepratorBorderBrush  sepratorBackground  StyleSeprator  StyleClientAreaGrid  StyleClientAreaBorder  StyleInnerGrid  	rect1Fill  	rect2Fill  CustSkin   CaptionHeight   ResizeBorderThickness   GlassFrameThickness ��Name � UseLayoutRounding ��Name�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    Kshell?http://schemas.microsoft.com/winfx/2006/xaml/presentation/shell  5      %ftclr-namespace:Framework.Themes  5      :x,http://schemas.microsoft.com/winfx/2006/xaml     5      %&  &	        &	      &	     7   7  &	 I    7     5      6   �� 5      "  ��6)   .�5   
   ��  � ��$
 Left=�60   6?   �� 5	   
    � ��$	 Top=�6.   6<   �� 5
   
    � ��$ 22��6#   60   �� 5   
    � ��$ 70��6"   6/   �� 5   
    � ��$ 4,4,0,0q�6#   65   �� 5   
    � �� 5      �� 5      .R�5      �� $ border��6   
������ $ 4��6G   $��20��6X   $
��Auto��6d   $��Center=�5      $��Center=�6:   $	 0.8Q�6U   ._�5      � $��Center=�6   $��Center=�6:   $
��Auto��6W   $
��Auto��6e    5      �� 5   "   $
��auto �63   �� 5   "   $
��auto �63   .+�5      �� $��20��6$   $��0��60   $��Center=�6@   $<��6/ActySystem.Telas.Themes;component/Images/Logoff32.png��5      $��19��5   $   $��Center=�6/   5      �� 5      $ LogOff��68   $��1��6(   
�������$��Center=�6[   $��Center=�5   (   $��2,0,0,0q�6F   $��Logoff��6W   $��12(�6e   5      5       5      P� 5       $	 border��6F   
 �@J�IsMouseOver . . �5!      �� $ border��6E    �@J�Opacity$
 0.75Q�68   6E   �� 5"      $ border��6J    � ��$ 1q�6@   6J   �� 5#      $ border��6J    � ��
 ������� 5$      $ border��6<   # �  6P    � ��5%      5&      5(      5*      5+      �� 5/      "  ��6    .�50   
   ��  � �� 51      �� 52      " ��6"   .R�53      �� .u�54      �� $ borderforMaximize��6!   #���  6�   #���  55      #���  6T    54   <   ��  �� $
 Self=�8   ._�56      �� $ Innerborder��6%   $ 6��6:   #���  6K   #���  57      ._�58   "   � $ gridforMaximize��6'    59   &   �� 5:   *   $��41 �68   �� 5;   *   $	��0.5 �68   �� 5<   *   $��* �68   �� 5=   *   $
��Auto �68   .+�5?   &   �� $ PART_TitleBar��6;   $��0��6.   $ 6��6R   #��� 	 6c   ._�5@   *   � $
 grid��6/   $��1q�6=    5A   .   �� 5B   2   $
��auto �6C   �� 5C   2   $
��auto �6C   �� 5D   2   $
��auto �6C   �� 5E   2   $
��Auto �6C   �� 5F   2   $
��Auto �6C   �� 5G   2   $��* �6C   �� 5H   2   $
��auto �6C   �� 5I   2   $
��auto �6C   �� 5J   2   $
��auto �6C   .+�5L   .   �� $ titleBarImage��64   $��
12,-10,0,0q�6K   $
��Auto��6_   $��11��6l   ��6x   ��  �� *FindAncestor+$ WindowL�$ 1��$ ThemesTitleIcon��� 5N   .   $ titleBarImageSeprator��6E   $��2��65   $��	10,-9,7,0q�6e   $��Stretch=�6x   $��Stretch=�6�   $��0q�5O   1   $��1��6E   $��16��6O   #��� 
 6[   5P   /   �� 5Q   .   $ titleBartextblock��6H   $��3��68   #���  6c   $��4,5,0,0q�6�   $��14(�6�   ��5R   /   ��  �� *FindAncestor+$ WindowL�$ 1��$ DisplayName�$ PropertyChanged=��� 5T   .   $ logoffButton��6t   8�� $��4��6c    . $��Close��6�   �� 5U   .   $ txtVersionName��6H   $��6��68   
�������$��14(�6s   $��0,2,12,0q�6�   $��Arial Black)�6�   $��Right=�5W   a   ��5V   8   ��  �� *FindAncestor+$ WindowL�$ 1��$ VersionName�$ PropertyChanged=�5W   a   �� 5X   .   $ txtDatabaseName��6H   $��7��68   #���  6a   $��14(�6�   $��0,0,40,0q�6�   $��Right=�5Z   a   ��5Y   ;   ��  �� *FindAncestor+$ WindowL�$ 1��$ DatabaseName�$ PropertyChanged=�5Z   a     5[   .    . $��8��6s   $��0,1,0,0q�5\   <   $��Right=�6M   $	��Top=�6i   5]   +   5^   '   �� 5_   &   $ SepratorBorder��6:   $��1��6-   #���  6R   #���  5`   )   #���  6[   6�   � 5a   &   $ ContentPresentergrid��68   $��2��6+   #���  6V   .+�5b   *   �� $ ContentPresenterborder��61   #���  6Q   ._�5c   .   � $ ContentPresenterInnerGrid��63   #���  6V   .+�5d   2   �� #���  6<   5e   3   �� 5f   2   #���  6<   5g   3   �� 5h   2   5i   /   5j   +   5k   '   5l   #   5m      5n      5o      5p      5r      5s      �� 5u      "  �6   .�5v   
   ��  �@�WindowStyle$
 None=�6(   �� 5w   
    � ��# � ��6&   �� 5x   
    �@ WindowChrome 5y        5z      $ 35Q�6%   $ 6q�68   $ 8,50,8,8q�6S   5|      �� 5}   
    � �� 5~      �� 5      " �6"   .R�5�      �� $ PART_CustomFrame��6%   8��   . .��5�      � .+�5�      �� $ 
ClientArea��6/   5�      5�       5�      P� 5�      
 �@�WindowState$ 	Maximized=�6@   . �5�      �� $ PART_CustomFrame��6%    6U   ��  �� *TemplatedParent+$= 7(shell:WindowChrome.WindowChrome).ResizeBorderThickness� � ��5�      5�      5�      5�      5�      
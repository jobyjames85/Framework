   M S B A M L   `   `   `  ����D  @Demos, Version=1.0.0.21521, Culture=neutral, PublicKeyToken=nullclr-namespace:DemosDemos  5          Demos.ExplorerBar   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      #localclr-namespace:Demos    5      G COdyssey, Version=1.4.22.21520, Culture=neutral, PublicKeyToken=null(odchttp://schemas.odyssey.com/wpf  5        � Title$  Odyssey Demo��5      $	��517��6   $	��577��6'    � 	Resources 5       �� DataType   Demos.FolderItem%  Odyssey.Controls.BreadcrumbItem �� 
TargetType �� Property �� Value��%�   (��       5      *, +)'  G     �� 6
   "  6   .R�5	      �� ��6   �� *Folder+5
      �� 5   
   "  6   .�5      ��  �@ Image$ Web.png��6&   5      5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��40 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   $  Odyssey.Controls.BreadcrumbBar  -   5          Name$	 bar��5      |�. $��8q�5      $��2��5      	   Path$	 Computer\C:\��5      
   TraceBinding
 5      �� *Folder+   ImageBinding 5      �� *Image+   Buttons 5!      �� 5"      -   5        .��5"   .   	Animate67   �� 5#      -   5        .��5#   9   
Breadcrumb6E      DropDownItems 5%      �� 5&      $��
C:\Windows��6   �� 5'      $��C:\Windows\System32��6   �� 5(      $��C:\Users��6      Root. 5*           Header$ Desktop��6!   .@�5+        $ Computer��6%     5,      $ Network��6%     5-      $ Control Panel��6%     5.      $ Recylce bin��6%   5/      50      "  Odyssey.Controls.ExplorerBar  51   
   -   5          Name$ explorerBar��51   7   $��1��6   $��0��6'   .@�52      "  Odyssey.Controls.OdcExpander  -   5          Name$ 	expander1��52   ]   $��System Tasks��6      Image$&  AlignTableCellMiddleCenterHS.png��64      
IsExpanded . .��53      ��  J� SnapsToDevicePixels . .+�54      �� -   5         ��Name$ text1��54   d   $��View system information��6    $
��Wrap=�6?   $��0,0,0,4q�6S   6d   �� 55      -   5        $ text2��55   c   $��Add or remove programs��6    $
��Wrap=�6>   $��0,4,0,4q�6R   6c   �� 56      -   5        $ text3��56   \   $��Change Settings��6    $
��Wrap=�67   $��0,4,0,4q�6K   6\   �� 57      �� 58      $��0,4,0,0q�6G   ��6    �� *Path+ �� ElementName$	 bar��6G   59      5:        5;      -	   5        $ 	expander2��5;   ,   $
��Test��6      HeaderBackground
 � ���$&  AlignTableCellMiddleCenterHS.png��5=      .��5>      �� .+�5?      �� -
   5         K� ZIndex$ 1��5?   4   .��6E   	Show/Hide6P   �� 5@      -   5        .��5@   4   Resize System Tasks6I   5A      5B        5C      $��
Multi Anim��6   .��5D      �� .+�5E      �� -   5        $��0,0,0,4q�5E   3   .��6D   	Animate 16O   �� 5F      -   5        $��0,4,0,0q�5F   3   .��6D   	Animate 26O   5G      5H      5I      �� 5J   
   $��1��6   $��1��6"   .+�5K        $��My Expander��6   .��5L      �� .+�5M      �� -   5        $��0,0,0,4q�5M   2   .��6C   
Steel Blue6O   �� 5N      -   5        $��0,4,0,0q�5N   4   .��6E   Gold6K   5O      5P      ��5Q      �� 5R       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 0,1&�67   ��5T      �  � Color$ 	AliceBlue��6'    � Offset$ 0Q�69   � 5U      $ Orange��6'   $	 0.5Q�66   � 5V      $ 	OrangeRed��6'   $ 1Q�69   5X      5Z      5[      5\      
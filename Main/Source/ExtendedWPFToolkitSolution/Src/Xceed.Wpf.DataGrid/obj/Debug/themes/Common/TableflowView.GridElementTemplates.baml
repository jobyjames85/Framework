   M S B A M L   `   `   `  ����Y  UXceed.Wpf.DataGrid, Version=2.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f47 clr-namespace:Xceed.Wpf.DataGridXceed.Wpf.DataGrid  5      E'clr-namespace:Xceed.Wpf.DataGrid.MarkupXceed.Wpf.DataGrid.Markup  5      M+clr-namespace:Xceed.Wpf.DataGrid.ConvertersXceed.Wpf.DataGrid.Converters  5      C&clr-namespace:Xceed.Wpf.DataGrid.ViewsXceed.Wpf.DataGrid.Views  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source $   tableflowViewRowFocusVisualStyle �� 
TargetType+   %System.Windows.IFrameworkInputElement �� 	Resources6   0Xceed.Wpf.DataGrid.Converters.ThicknessConverter  Key �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels �� RelativeSource	 �� AncestorType
 �� Path  thicknessConverter �� 	Converter �� ConverterParameter  inverseThicknessConverter   InverseValue ( $tableflowViewDataGridControlTemplate �� 
TargetType(   "Xceed.Wpf.DataGrid.DataGridControl ��Name4   .Xceed.Wpf.DataGrid.Views.TableViewScrollViewer  Name   ShowRowSelectorPane   RowSelectorPaneWidth5   /Xceed.Wpf.DataGrid.Views.TableflowViewItemsHost �Name ��Name   ConnectionState �� Triggers �� Value �� Binding �� 
TargetName $  tableflowViewRowSelectorTemplate$   Xceed.Wpf.DataGrid.RowSelector �� Padding n�Name  invisibleThumbStyle  tableflowViewRowTemplate   Xceed.Wpf.DataGrid.Row � 	Resources:   4Xceed.Wpf.DataGrid.Converters.TypeToBooleanConverter � ColumnDefinitions ��Name(   "Xceed.Wpf.DataGrid.Views.TableView   CanScrollHorizontally<	   6Xceed.Wpf.DataGrid.HierarchicalGroupLevelIndicatorPane0
   *Xceed.Wpf.DataGrid.GroupLevelIndicatorPane  
 Name! ��Name ! detailsExpanderButtonTemplate)   #Xceed.Wpf.DataGrid.DataGridCommands"   ToggleDetailExpansion# � OverridesDefaultStyle-   'Xceed.Wpf.DataGrid.Views.FixedCellPanel$  Name%   ColumnStretchMinWidth&   ColumnStretchMode'   FixedCellCount( �� Mode)   FixedColumnDropMarkPen* ^� 
Conditions+ �� Binding, �� Value 	 typeToBooleanConverter    Xceed.Wpf.DataGrid.DataRow )
 %tableflowViewColumnManagerRowTemplate)   #Xceed.Wpf.DataGrid.ColumnManagerRow- {�Name  tableflowViewCellTemplate   Xceed.Wpf.DataGrid.Cell-   'Xceed.Wpf.DataGrid.CellContentPresenter.  Name/ ]� 
Conditions0 �� Property * &tableflowViewColumnManagerCellTemplate*   $Xceed.Wpf.DataGrid.ColumnManagerCell1 d�Name2 J� Opacity3 ��Name4 �� Orientation5 P� 
SourceName6 P� Property7 P� Value ' #tableflowViewGroupByControlTemplate'   !Xceed.Wpf.DataGrid.GroupByControl8   NoGroupContent $  tableflowViewGroupByItemTemplate$   Xceed.Wpf.DataGrid.GroupByItem8   2Xceed.Wpf.DataGrid.Converters.IntAdditionConverter ) %groupHeaderControlGroupLevelConverter + 'tableflowViewGroupHeaderControlTemplate+   %Xceed.Wpf.DataGrid.GroupHeaderControl5   /Xceed.Wpf.DataGrid.Views.PassiveLayoutDecorator9   Axis: 
  Indented; 
  
GroupLevel< � FocusVisualStyle= J� InputBindings>   ToggleGroupExpansion? �� Command
@ �� KeyA   ExpandGroupB   CollapseGroupC d� MouseAction % !groupExpanderToggleButtonTemplateD d� 	IsChecked , (tableflowViewGroupLevelIndicatorTemplate,   &Xceed.Wpf.DataGrid.GroupLevelIndicator ( $tableflowViewDetailIndicatorTemplate(   "Xceed.Wpf.DataGrid.DetailIndicator 0 ,tableflowViewGroupLevelIndicatorPaneTemplate'   !Xceed.Wpf.DataGrid.Views.ViewBase < 8tableflowViewHierarchicalGroupLevelIndicatorPaneTemplate  dataGridContextTemplateE �� DataType(   "Xceed.Wpf.DataGrid.DataGridContextF �� ItemsSource7   1Xceed.Wpf.DataGrid.HierarchicalGroupByControlNodeG  NameH   TitleI �� Triggers  detailConfigurationTemplate,  &Xceed.Wpf.DataGrid.DetailConfiguration=   7Xceed.Wpf.DataGrid.Converters.TypeToVisibilityConverter  notDetailConfigConverterJ   
VisibilityK   SetVisibilityWhenTrue   booleanToVisibilityConverter / +hierarchicalGroupByControlTreeViewItemStyleL � RowDefinitions 9 5tableflowViewCommonHierarchicalGroupByControlTemplate3   -Xceed.Wpf.DataGrid.HierarchicalGroupByControlM R�NameN Q� 
IsExpandedO   NoGroupContent J FtableflowViewCommonHierarchicalGroupByControlOldGroupByControlTemplate P   AllowGroupingModification Q   AllowGroupingModificationR   	AllowSortS   	AllowSortT   ConnectionLinePenU   ConnectionLinePen 7 3tableflowViewHierarchicalGroupByControlNodeTemplateV ��Name 0 ,tableflowViewHierarchicalGroupByItemTemplate0   *Xceed.Wpf.DataGrid.HierarchicalGroupByItem " tableflowViewScrollTipTemplate"    Xceed.Wpf.DataGrid.ScrollTip�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      *local clr-namespace:Xceed.Wpf.DataGrid  5      2markup'clr-namespace:Xceed.Wpf.DataGrid.Markup  5      4conv+clr-namespace:Xceed.Wpf.DataGrid.Converters  5      0views&clr-namespace:Xceed.Wpf.DataGrid.Views  5        5      �� 5      $ Common.Resources.xaml?�6   %?o  &	        7  &	 M    &	 k    &	 �    7  &	 @    7  7 	 7 	 &	
 �    7  &	 $"    7  7  &	 �.    7  7  7  7  &	 N?    &	 �@    &	 �D    &	 E    7  7  &	 �I    &	 �I    &	 dJ    7  7  7  7  &	 P    &	 �P    &	 �R    &	 >S    &	 sS    &	 �S    7  7  &	 W    7  7  7  7  7  7  7  &	 h_    7  7  7  &	 Me    &	 'f    &	 6m    �� 5      "   5       5      ��  5      thicknessConverter 6#   5    	   .�5"      ��  � �� 5#      �� 5$      .R�5%      �� ���	#FF000000$��1��5&      $	 1 2R�5'       . ��5(      ��  �� "	 ��$
 HorizontalOffset�8   $
 Left��5)      5*      5,   	   5-        5/       . 50      �� 55      "  56      .R�57      � .+�58      �� #��z��6   #��z��59      #��z��5:      ._�5=      �� $# PART_DragDropAdornerDecorator��6   .u�5@        $ PART_ScrollViewer��6-   #��z��5C   -    5A   -   ��  �� *Self+$A
 ;(local:DataGridControl.DataGridContext).ShowRowSelectorPane� 5B   -   ��  �� *Self+$B
 <(local:DataGridControl.DataGridContext).RowSelectorPaneWidth�.��5E        5G      5H      5I      � 5J      $ connectionStateGrid��6   $��Right=�5K      $��Bottom=�5L      $��	0,0,25,25q�5M      $��30��5N      $��30��5O      .+�5P      �� $, &connectionStateLoadingContentPresenter��6   #��z 5R      $y�	Collapsed=�5S      ��5Q      ��  �� *Self+$I
 C(local:DataGridControl.DataGridContext).ConnectionStateLoadingGlyph�5S      �� 5T      $/ )connectionStateCommittingContentPresenter��6   #��z 5V      $y�	Collapsed=�5W      ��5U      ��  �� *Self+$L
 F(local:DataGridControl.DataGridContext).ConnectionStateCommittingGlyph�5W      �� 5X      $* $connectionStateErrorContentPresenter��6   #��z 5Z      $y�	Collapsed=�5[      ��5Y      ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).ConnectionStateErrorGlyph�5[      5\      5]   	    5^      �� 5_      $ False��5`       5_      ��  �� *Self+$K
 E(local:DataGridControl.DataGridContext).IsConnectionStateGlyphEnabled�.a�5a      �� $ connectionStateGrid��6    � y�$ 	Collapsed=�5c      5d      �� 5e      $ Loading��5f       5e      ��  �� *Self+$M
 G(local:DataGridControl.DataGridContext).DataGridControl.ConnectionState�.a�5g      �� $, &connectionStateLoadingContentPresenter��6    � y�$ Visible=�5i      �� 5j      $* $connectionStateErrorContentPresenter��6    � y�$ 	Collapsed=�5l      �� 5m      $/ )connectionStateCommittingContentPresenter��6    � y�$ 	Collapsed=�5o      5p      �� 5q      $ 
Committing��5r       5q      ��  �� *Self+$M
 G(local:DataGridControl.DataGridContext).DataGridControl.ConnectionState�.a�5s      �� $, &connectionStateLoadingContentPresenter��6    � y�$ 	Collapsed=�5u      �� 5v      $* $connectionStateErrorContentPresenter��6    � y�$ 	Collapsed=�5x      �� 5y      $/ )connectionStateCommittingContentPresenter��6    � y�$ Visible=�5{      5|      �� 5}      $ Error��5~       5}      ��  �� *Self+$M
 G(local:DataGridControl.DataGridContext).DataGridControl.ConnectionState�.a�5      �� $, &connectionStateLoadingContentPresenter��6    � y�$ 	Collapsed=�5�      �� 5�      $* $connectionStateErrorContentPresenter��6    � y�$ Visible=�5�      �� 5�      $/ )connectionStateCommittingContentPresenter��6    � y�$ 	Collapsed=�5�      5�      5�      �� 5�      "  5�      .R�5�      � .+�5�      �� #��z��6   #��z��5�      #��z��5�      # z��5�      ._�5�      �� $ contentPresenter��6   #��z��5�      #��z��5�      #��z��5�      #��z��5�      #��z��5�      5�      n� 5�      $ PART_RowResizerThumb��6   8��  $��Bottom=�5�      5�   	   5�      �� 5�      "  5�       5�      ��  5�      typeToBooleanConverter 6'   5�   	   .R�5�      � $ rootGrid��6    5�      �� 5�      $
��Auto �6   �� 5�      $
��Auto �6   �� 5�      $
��Auto �6   �� 5�      $��* �6   .+�5�      �� $ 
rootBorder��6   $��2��5�      $��2��5�       .  #��z��5�      #��z��5�      #��z��5�      # z��5�      	  5�      $��0��65    .  5�   5   
  5�      $  groupLevelIndicatorPane��6)    .  $��1��5�   )   �� 5�      $! detailsToggle��6   8��  $	��Top=�5�      $��2��5�      $��2,4,2,0q�5�      #��Z" 5�      # . |�.  $y�	Collapsed=�5�       .  5�      �� 5�      $�� ��6   $y�Hidden=�5�      $��3��5�      #��z��5�        5�      $$ PART_CellsHost��6    $��3��5�       #��z��5�       % 5�       ��  �� *Self+$C
 =(local:DataGridControl.DataGridContext).ColumnStretchMinWidth�& 5�       ��  �� *Self+$?
 9(local:DataGridControl.DataGridContext).ColumnStretchMode�' 5�       ��  �� *Self+$>
 8(local:DataGridControl.DataGridContext).FixedColumnCount�$( TwoWay=�) 5�       ��  �� *Self+$D
 >(local:DataGridControl.DataGridContext).FixedColumnDropMarkPen�5�       5�   	    5�      ^� 5     * 5     �� 5     + 6   ��  �� *Self+$
 
IsSelected�, True5     �� 5     + 6   ��  �� *Self+$S
 M(local:DataGridControl.DataGridContext).DataGridControl.IsKeyboardFocusWithin�, True5     .0�5     �� $ 
rootBorder��6    5     ��  �� *TemplatedParent+$
 SelectionBackground� � ���� 5     $ rootGrid��6    5     ��  �� *TemplatedParent+$
 SelectionForeground� � ��5     ^� 5     * 5     �� 5     + 6   ��  �� *Self+$
 
IsSelected�, True5     �� 5     + 6   ��  �� *Self+$S
 M(local:DataGridControl.DataGridContext).DataGridControl.IsKeyboardFocusWithin�	, False5     �� 5!     + 6   ��  �� *Self+$K
 E(local:DataGridControl.DataGridContext).DataGridControl.HideSelection�	, False5"     .0�5&     �� $ 
rootBorder��6    5(     ��  �� *TemplatedParent+$!
 InactiveSelectionBackground� � ���� 5*     $ rootGrid��6    5,     ��  �� *TemplatedParent+$!
 InactiveSelectionForeground� � ��5.     ^� 51     * 52     �� 53     + 6   ��  �� *Self+$8
 2(local:DataGridControl.DataGridContext).HasDetails�, True54     �� 55     + 6   ��  �� *Self+$?
 9(local:DataGridControl.DataGridContext).AllowDetailToggle�, True56     �� 57     + 58     ��  �� *Self+$
 .�$( OneWay=�8  "  , True57     58     .0�5;     �� $ detailsToggle��6    � y�$ Visible=�5=     5?     ^� 5A     * 5B     �� 5C     + 6   ��  �� *Self+$8
 2(local:DataGridControl.DataGridContext).HasDetails�, True5D     �� 5E     + 6   ��  �� *Self+$?
 9(local:DataGridControl.DataGridContext).AllowDetailToggle�, True5F     �� 5G     + 5H     ��  �� *Self+$
 .�$( OneWay=�8  "  	, False5G     5H     .0�5K     �� $ detailsToggle��6    � y�$ Hidden=�5M     5O     5R     �� 5W     "  5X      5]     ��  5^     thicknessConverter  . 5_  #   5`  	   .R�5c     � $ rootGrid��6    5d     �� 5f     $
��Auto �6   �� 5h     $
��Auto �6   �� 5i     $
��Auto �6   �� 5l     $��* �6   .+�5r     �� $ 
rootBorder��6   $��1��5s     $��3��5t      .  #��z��5v     #��z��5w     #��z��5x     # z��5y     	  5}      .  $��0��5~  5   #��z��5  5   
  5�     $  groupLevelIndicatorPane��6)    .  $��1��5�  )   #��z��5�  )   �� 5�     $! detailsToggle��6   8��  $	��Top=�5�     $��2��5�     $��2,4,2,0q�5�     #��Z" 5�     # . |�.  $y�	Collapsed=�5�      .  5�     {� 5�     $- indentationDecorator��6   $��3��5�     ._�5�       $$ PART_CellsHost��6#   #��z��5�  #   % 5�  #   ��  �� *Self+$C
 =(local:DataGridControl.DataGridContext).ColumnStretchMinWidth�& 5�  #   ��  �� *Self+$?
 9(local:DataGridControl.DataGridContext).ColumnStretchMode�' 5�  #   ��  �� *Self+$>
 8(local:DataGridControl.DataGridContext).FixedColumnCount�$( TwoWay=�) 5�  #   ��  �� *Self+$D
 >(local:DataGridControl.DataGridContext).FixedColumnDropMarkPen�5�  #   5�     5�  	    5�     ^� 5�     * 5�     �� 5�     + 6   ��  �� *Self+$8
 2(local:DataGridControl.DataGridContext).HasDetails�, True5�     �� 5�     + 6   ��  �� *Self+$?
 9(local:DataGridControl.DataGridContext).AllowDetailToggle�, True5�     .0�5�     �� $ detailsToggle��6    � y�$ Hidden=�5�     5�     5�     �� 5�     "  5�     .R�5�     � .+�5�     �� $ gridLinesBorder��6   �� 5�     $ 
rootBorder��6   #��z��5�     #��z��5�     #��z��5�     # z��5�     ._�5�       $. PART_CellContentPresenter��6)   #��z��5�  )   #��z��5�  )   5�     5�  	    5�     ]� 5�     / 5�     �� 5�     0 �@ 	IsCurrent, . 5�     �� 5�     0 �@ HasValidationError, .  5�     ./�5�     �� $ 
rootBorder��6    5�     ��  �� *TemplatedParent+$
 CurrentBackground� � ���� 5�     $ 
rootBorder��6    5�     ��  �� *TemplatedParent+$
 CurrentForeground� � ��5�     ]� 5�     / 5�     �� 5�     0 �@ 	IsCurrent, . 5�     �� 5�     0 �@ HasValidationError, . 5�     �� 5�     , 5�     Z� 0 �@ CellErrorStyle./�5�     �� $ 
rootBorder��6    5      ��  �� *TemplatedParent+$
 CurrentBackground� � ���� 5     $ 
rootBorder��6    5     ��  �� *TemplatedParent+$
 CurrentForeground� � ��5     ^� 5	     * 5
     �� 5     + 6   ��  �� *Self+$
 
IsSelected�, True5     �� 5     + 6   ��  �� *Self+$k
 e(local:DataGridControl.DataGridContext).(local:DataGridContext.DataGridControl).IsKeyboardFocusWithin�, True5     .0�5     �� $ 
rootBorder��6    5     ��  �� *TemplatedParent+$
 SelectionBackground� � ���� 5     $ 
rootBorder��6    5     ��  �� *TemplatedParent+$
 SelectionForeground� � ��5     ^� 5      * 5!     �� 5#     + 6   ��  �� *Self+$
 
IsSelected�, True5$     �� 5&     + 6   ��  �� *Self+$k
 e(local:DataGridControl.DataGridContext).(local:DataGridContext.DataGridControl).IsKeyboardFocusWithin�	, False5'     �� 5)     + 6   ��  �� *Self+$c
 ](local:DataGridControl.DataGridContext).(local:DataGridContext.DataGridControl).HideSelection�	, False5*     .0�5.     �� $ 
rootBorder��6    50     ��  �� *TemplatedParent+$!
 InactiveSelectionBackground� � ���� 52     $ 
rootBorder��6    54     ��  �� *TemplatedParent+$!
 InactiveSelectionForeground� � ��56     �� 5>     $ False��5?      5>     ��  �� *Self+$
 ParentColumn.Visible�.a�5@     ��  � y�$ 	Collapsed=�5A     5B     ^� 5D     * 5E     �� 5F     + 6   ��  �� *Self+$F
 @(local:DataGridControl.DataGridContext).AreColumnsBeingReordered�, True5G     .0�5J     �� $ gridLinesBorder��6    5L     ��  �� *Self+$C
 =(local:DataGridControl.DataGridContext).VerticalGridLineBrush� � ���� 5N     $ gridLinesBorder��6    5P     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8   $
 Left�� � ���� 5R     $ gridLinesBorder��6    5T     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $
 Left�� � ��5V     5Z     �� 5_     "  5`     .R�5e     � .+�5g     �� $ gridLinesBorder��6   �� 5i     #��z��6   #��z��5j     ._�5m     � .+�5o     �� #��� ��6   $
��Left=�5p     $��Stretch=�5q     $��1��5r     $��0,2,0,2q�5s     �� 5u     #��� ��6   $��Right=�5v     $��Stretch=�5w     $��1��5x     $��0,2,0,2q�5y     ]� 5{     .+�5|     �� $! thumbToggleBackgroundBorder��6   $��Right=�5}     ._�5     � .+�5�     �� $ toggleDelimeterBorder��6!   #��� ��5�  !   $��1,0,0,0q�5�  !   $��0,4,0,4q�5�  !   
������ $y�	Collapsed=�5�  !   ._�5�     �� $ toggleDelimeterBorder2��6$   #��� ��5�  $   $��1,0,0,0q�5�  $   $��0,0,0,0q�5�  $   
������ $y�	Collapsed=�5�  $   5�     5�     d� 5�     $1 toggleButton��6'   |�.  $��Stretch=�5�  '   $y�	Collapsed=�5�  '   $��2,0,0,0q�5�  '   $	2 0.5Q�5�  '   5�     5�     �� 5�     #��z��6   ._�5�     � .+�5�     �� # z��6!   ._�5�     �� $3 contentPanel��6(   $4 
Horizontal=�5�  (   .+�5�        #��z��6;   #��z��5�  ;   �� 5�      $ sortGlyphPresenter��61   ��5�  1   Z� ��5�  1   Z� 5�     5�     5�     5�     5�     n� 5�     $! PART_ColumnResizerThumbLeft��6   8��  $��6��5�     $
��Left=�5�     n� 5�     $ PART_ColumnResizerThumb��6   8�� $��6��5�     $��Right=�5�     5�     5�     5�  	    5�     P� 5�     $5 toggleButton��6   6 �@J�IsMouseOver7 . . �5�     �� $ toggleButton��6    �@J�Opacity$ 1Q�5�     5�     P� 5�     6 �@ 	IsPressed7 . . �5�     �� $ contentPanel��6    � ��$ 	1,1,-1,-1q�5�     5�     �� 5�     $ 	Ascending��5�      5�     ��  �� *Self+$ 
 ParentColumn.SortDirection�.a�5�     �� $ sortGlyphPresenter��6    5�     ��  �� *Self+$@
 :(local:DataGridControl.DataGridContext).AscendingSortGlyph� � ���� 5�     $ sortGlyphPresenter��6    � ��$ 6,0,0,0q�5�     5�     �� 5�     $ 
Descending��5�      5�     ��  �� *Self+$ 
 ParentColumn.SortDirection�.a�5�     �� $ sortGlyphPresenter��6    5�     ��  �� *Self+$A
 ;(local:DataGridControl.DataGridContext).DescendingSortGlyph� � ���� 5�     $ sortGlyphPresenter��6    � ��$ 6,0,0,0q�5�     5�     ^� 5      * 5     �� 5     + 6   ��  �� *Self+$ 
 ParentColumn.HasFixedWidth�, True5     �� 5     + 6   ��  �� *Self+$L
 F(local:DataGridControl.DataGridContext).RemoveColumnStretchingOnResize�	, False5     .0�5     �� $ PART_ColumnResizerThumb��6    � {� .  5     5     ^� 5     * 5     �� 5     + 6   ��  �� *Self+$6
 0ParentColumn.PreviousVisibleColumn.HasFixedWidth�, True5     �� 5     + 6   ��  �� *Self+$L
 F(local:DataGridControl.DataGridContext).RemoveColumnStretchingOnResize�	, False5     .0�5     �� $! PART_ColumnResizerThumbLeft��6    � {� .  5     5     �� 5      $ False��5!      5      ��  �� *Self+$!
 ParentRow.AllowColumnResize�.a�5"     �� $ PART_ColumnResizerThumb��6    � {� .  5$     �� 5%     $! PART_ColumnResizerThumbLeft��6    � {� .  5'     5(     �� 5*     $ False��5+      5*     ��  �� *Self+$
 ParentColumn.Visible�.a�5,     ��  � y�$ 	Collapsed=�5-     5.     ^� 51     * 52     �� 53     + 6   ��  �� *Self+$F
 @(local:DataGridControl.DataGridContext).AreColumnsBeingReordered�, True54     .0�57     �� $ gridLinesBorder��6    59     ��  �� *Self+$C
 =(local:DataGridControl.DataGridContext).VerticalGridLineBrush� � ���� 5;     $ gridLinesBorder��6    5=     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $
 Left�� � ���� 5?     $ gridLinesBorder��6    5A     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $
 Left�� � ��5C     5F     �� 5K     "  5L     .R�5N     �� #��z��6   #��z��5O     #��z��5P     # z��5Q     ._�5U     � .+�5[     �� $ noGroupContentPresenter��6   #��z8 5\     $��Center=�5]     $y�	Collapsed=�5^     �� 5d     5f     5g  	    5i     P� 5l     6 �@��HasItems7 .  . �5o     �� $ noGroupContentPresenter��6    � y�$ Visible=�5q     5r     5v     �� 5{     "  5|     .R�5~     �� #��z��6   #��z��5     #��z��5�     # z��5�     ._�5�     �� $4 
Horizontal=�6   .+�5�     �� #��z��6   #��z��5�     #��z��5�     #��z��5�     #��z��5�     �� 5�     $ sortGlyphPresenter��6   ��5�     Z� ��5�     Z� 5�     5�  	    5�     �� 5�     $ 	Ascending��5�      5�     ��  �� *Self+$
 SortDirection�.a�5�     �� $ sortGlyphPresenter��6    5�     ��  �� *Self+$@
 :(local:DataGridControl.DataGridContext).AscendingSortGlyph� � ���� 5�     $ sortGlyphPresenter��6    � ��$ 6,0,0,0q�5�     5�     �� 5�     $ 
Descending��5�      5�     ��  �� *Self+$
 SortDirection�.a�5�     �� $ sortGlyphPresenter��6    5�     ��  �� *Self+$A
 ;(local:DataGridControl.DataGridContext).DescendingSortGlyph� � ���� 5�     $ sortGlyphPresenter��6    � ��$ 6,0,0,0q�5�     5�     5�       5�     6   �� 5�     "  5�     .R�5�       $9 
Horizontal=�6%   ._�5�     ]� .+�5�     	  $
��Left=�68   
  5�     $
��Left=�6,   : .  ; 5�  ,   ��  �� *TemplatedParent+$0
 *(local:GroupLevelIndicatorPane.GroupLevel)�8   $ -1���� 5�     $ 
mainBorder��6   #��z��5�     #��z��5�     #��z��5�     # z��5�     |�. #< z< 5�     = 5�     �� 5�     #? Z> 6   $@ Space��5�     �� 5�     #? ZA 6   $@ Right��5�     �� 5�     #? ZA 6   $	@ Add��5�     �� 5�     #? ZB 6   $
@ Left��5�     �� 5�     #? ZB 6   $@ Subtract��5�     d� 5�     #? Z> 6!   $C LeftDoubleClicke�5�  !   ._�5�     �� $4 
Horizontal=�6   .+�5�     d� 8�� # . #��z��5�  !   |�.  D 5�  !   ��  �� *TemplatedParent+$
 Group.IsExpanded��� 5�     $��3,0,0,0q�6%   #��z��5�  %   #��z��5�  %   #��z��5�  %   #��z��5�  %   5�     5�     5�     5   	    5     P� 5     6 �@ NavigationBehavior$
7 None=�5     . �5     �� $ 
mainBorder��6    � |� .  5     5     5     �� 5     "  5     .R�5     �� #��z��6   #��z��5     #��z��5     # z��5     5     �� 5     "  5     .R�5      �� #��z��6   #��z��5!     #��z��5"     # z��5#     5%     �� 5*     " 
 5+     .R�5,     � .+�5.     �� $ horizontalBorder��6   #��z��5/     #��z��50     ��51     ��  �� *Self+$I
 C(local:DataGridControl.DataGridContext).HorizontalGridLineThickness�8   $	 Top���� 53     $ verticalBorder��6   #��z��54     # z��55     ��56     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $
 Left��._�57     �� $"3 PART_GroupLevelIndicatorHost��6   $4 
Horizontal=�58     59     5;  	    5<     ]� 5=     / 5>     �� 5?     0 �@
 IsLeaf, . 5@     �� 5A     0 �@ 
IsLastItem, . 5B     �� 5C     0 �@ HasExpandedDetails, .  5D     ./�5F     �� $ horizontalBorder��6    5H     ��  �� *Self+$I
 C(local:DataGridControl.DataGridContext).HorizontalGridLineThickness�8  $ Top, Bottom�� � ���� 5I     $ verticalBorder��6    5K     ��  �� *Self+$I
 C(local:DataGridControl.DataGridContext).HorizontalGridLineThickness�8  $ Bottom�� � ��5L     ]� 5N     / 5O     �� 5Q     0 �@
 CurrentIndicatorCount$, 0��5R     �� 5T     0 �@
 IsLeaf, .  5U     ./�5Y     �� $ verticalBorder��6    � ��$ 0q�5[     5]     P� 5_     6 �@
 ShowVerticalBorder7 .  . �5a     �� $ verticalBorder��6    � ��$ 0q�5c     5d     5g     �� 5l     " 	 5m     .R�5n     �� #��z��6   #��z��5o     ._�5p     �� $"3 PART_GroupLevelIndicatorHost��6   $4 
Horizontal=�5q     5r  	   5t     �� 5{     "E  5|     F 5}     �� $
 DetailConfigurations�.R�5       $G groupByControlNode��6-   ��5�  -   �� $
 GroupLevelDescriptions�H 5�  -   �� $%
 SourceDetailConfiguration.Title�I 5�     �� 5�      6   �� $
 SourceDetailConfiguration� 5�     Z� .a�5�     �� $ groupByControlNode��6    �@ Title 5�     �� 5�     $%
 DataGridControl.ItemsSourceName�6   5�     5�     5�     �� 5�     "E  5�     F 5�     �� $
 DetailConfigurations�.R�5�       ��6-   �� $
 GroupLevelDescriptions�H 5�  -   �� *Title+5�       5�     $J Visible=�5�  $   K .  5�  $   �� 5�     6"   �� 5�     " Q�5�     .�5�     ��  �@Q�
IsExpanded . 5�     �� 5�      � |� .  5�     �� 5�      � y� 5�     � 5�     .&�5�     �� $
 .�6   8   "  5�     �� 5�     $
 Visible�6   8  5�     5�     5�  	   �� 5�      � �� 5�     �� 5�     " Q�6   .R�5�     �  5�     �� 5�     $��19 �6(   �� 5�     $
��Auto �6(   �� 5�     $��* �6(   L 5�     �� 5�     $
��Auto �6%   �� 5�     .+�5�     �� $��treeViewItemBorder��5�     #��z��5�     # z��5�     #��z��5�     #��z��5�      . $��1��5�     ._�5�     �� $��PART_Header��5�  (   #��z��5�  (   #��z��5�  (   $��Header��5�  (   #��z��5�  (   # z 5�  (   5�     �� 5�     $��	ItemsHost��6#   $��1��5�  #   $��1��5�  #   $��2��5�  #   5�     5�     5�  	   5�     �� 5�     "  5�      5�     ���� 5�     'R�       " R�6   5�  	   .R�5�     � $ rootGrid��6    5�     �� 5�     $
��Auto �6   �� 5�     $
��Auto �6   �� 5�     $��* �6   .+�5�     �� $ 
rootBorder��6   $��1��5�     $��2��5�     #��z��5�     # z��5     ��5�     ��  �� *Self+$E
 ?(local:DataGridControl.DataGridContext).HorizontalGridLineBrush���5      ��  �� *Self+$I
 C(local:DataGridControl.DataGridContext).HorizontalGridLineThickness�8   $	 Top��5     �� 5     $ verticalGridLineBorder��6   $��1��5     $��2��5     ��5     ��  �� *Self+$C
 =(local:DataGridControl.DataGridContext).VerticalGridLineBrush���5     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $ Right��	  5	     $��0��65   
  5     $  groupLevelIndicatorPane��6)   $��1��5  )   �� 5     $��2��6   $4 
Horizontal=�5     .+�5     R� $-M 'PART_HierarchicalGroupByControlTreeView��6   8�� 
������ 
������ |�.  .@�5     Q� 8�� 8�� 8�� N . ��6   ��  �� *Self+$-
 '(local:DataGridControl.DataGridContext)���5     ��  �� *Self+$B
 <(local:DataGridControl.DataGridContext).DetailConfigurations�5     5     �� 5!     $ noGroupContentPresenter��6   #��zO 5"     $��Center=�5#     $y�	Collapsed=�5$     $��5,0,0,0q�5%     5'     5)  	    5*     �� 5,     $
 True��5-      5,     ��  �� *Self+$
 	HasGroups�.a�5/     �� $ noGroupContentPresenter��6    � y�$ Visible=�51     53     �� 55     $ -1��56      55     ��  �� *TemplatedParent+$0
 *(local:GroupLevelIndicatorPane.GroupLevel)�.a�57     �� $ groupLevelIndicatorPane��6    � y�$ 	Collapsed=�59     �� 5:     $ verticalGridLineBorder��6    5<     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $ Right, Left�� � ��5=     5A     �� 5C     "  5D     .R�5G     � $ rootGrid��6    5H     �� 5J     $
��Auto �6   �� 5L     $
��Auto �6   �� 5O     $��* �6   .+�5U     �� $ 
rootBorder��6   $��1��5V     $��2��5W     #��z��5X     # z��5[     ��5Y     ��  �� *Self+$E
 ?(local:DataGridControl.DataGridContext).HorizontalGridLineBrush���5Z     ��  �� *Self+$I
 C(local:DataGridControl.DataGridContext).HorizontalGridLineThickness�8   $	 Top��5[     �� 5]     $ verticalGridLineBorder��6   $��1��5^     $��2��5_     ��5`     ��  �� *Self+$C
 =(local:DataGridControl.DataGridContext).VerticalGridLineBrush���5a     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $ Right��	  5c     $��0��65   
  5g     $  groupLevelIndicatorPane��6)   $��1��5h  )     5j     $��2��6    #��z��5k      #��z��5l      #��z��5m      #Q zP 5n      #S zR 5o      #U zT 5p      #8 zO 5q       . 5r      5t  	    5v     �� 5x     $ -1��5y      5x     ��  �� *TemplatedParent+$0
 *(local:GroupLevelIndicatorPane.GroupLevel)�.a�5z     �� $ groupLevelIndicatorPane��6    � y�$ 	Collapsed=�5|     �� 5}     $ verticalGridLineBorder��6    5     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $ Right, Left�� � ��5�     5�     �� 5�     "  5�     .R�5�     �� $4 
Horizontal=�6   #��z��5�     .+�5�     �� $V titleTextBlock��6   #��zH 5�     $��0,0,10,0q�5�     �� 5�     $��0,0,0,10q�6   5�  	   5�     �� 5�     "  5�     .R�5�     �� $ outerBorder��6   #��� ��5�     #��� ��5�     $��0,0,1,1q�5�     $ 1,1,0,0q�5�     ._�5�     �� $ innerBorder��6   #��� ��5�     $��0,0,1,1q�5�     $��1,1,0,0q�5�     #��z��5�     # z��5�     ._�5�     �� $3 contentPanel��6   $4 
Horizontal=�5�     .+�5�     �� #��z��6"   #��z��5�  "   #��z��5�  "   #��z��5�  "   #��z��5�  "   �� 5�     $ sortGlyphPresenter��6"   $��6,0,0,0q�5�  "   $y�Hidden=�5�  "   ��5�  "   Z� ��5�  "   ��  �� *Self+$@
 :(local:DataGridControl.DataGridContext).AscendingSortGlyph�5�  "   5�     5�     5�  	    5�     P� 5�     6 � ��7 . . �5�     �� $ outerBorder��6   # � ��5�      � ���� 5�     $ outerBorder��6    � ��$ 1q�5�     �� 5�     $ outerBorder��6    �@��Padding$ 0q�5�     �� 5�     $ innerBorder��6    � ��$ 1q�5�     �� 5�     $ innerBorder��6    � ��$ 0q�5�     �� 5�     $ contentPanel��6    � ��$ 	1,1,-1,-1q�5�     5�     �� 5�     $ 	Ascending��5�      5�     ��  �� *Self+$
 SortDirection�.a�5�     �� $ sortGlyphPresenter��6    5�     ��  �� *Self+$@
 :(local:DataGridControl.DataGridContext).AscendingSortGlyph� � ���� 5�     $ sortGlyphPresenter��6    � y�$ Visible=�5�     5�     �� 5�     $ 
Descending��5�      5�     ��  �� *Self+$
 SortDirection�.a�5�     �� $ sortGlyphPresenter��6    5�     ��  �� *Self+$A
 ;(local:DataGridControl.DataGridContext).DescendingSortGlyph� � ���� 5�     $ sortGlyphPresenter��6    � y�$ Visible=�5�     5�     5     �� 5     "   5     .R�5     �� $��Center=�6   $��Right=�5	     #��z��5
     #��z��5     #��z��5     5     5     
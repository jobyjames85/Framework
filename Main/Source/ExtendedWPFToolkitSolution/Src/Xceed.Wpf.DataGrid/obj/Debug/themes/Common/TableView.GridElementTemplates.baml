   M S B A M L   `   `   `  ����Y  UXceed.Wpf.DataGrid, Version=2.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f47 clr-namespace:Xceed.Wpf.DataGridXceed.Wpf.DataGrid  5      E'clr-namespace:Xceed.Wpf.DataGrid.MarkupXceed.Wpf.DataGrid.Markup  5      M+clr-namespace:Xceed.Wpf.DataGrid.ConvertersXceed.Wpf.DataGrid.Converters  5      C&clr-namespace:Xceed.Wpf.DataGrid.ViewsXceed.Wpf.DataGrid.Views  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source    tableViewRowFocusVisualStyle �� 
TargetType+   %System.Windows.IFrameworkInputElement �� 	Resources6   0Xceed.Wpf.DataGrid.Converters.ThicknessConverter  Key �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels �� RelativeSource	 �� AncestorType
 �� Path  thicknessConverter �� 	Converter �� ConverterParameter  inverseThicknessConverter   InverseValue $  tableViewDataGridControlTemplate �� 
TargetType(   "Xceed.Wpf.DataGrid.DataGridControl ��Name4   .Xceed.Wpf.DataGrid.Views.TableViewScrollViewer  Name   ShowRowSelectorPane   RowSelectorPaneWidth1   +Xceed.Wpf.DataGrid.Views.TableViewItemsHost �Name ��Name   ConnectionState �� Triggers �� Value �� Binding �� 
TargetName   tableViewRowSelectorTemplate$   Xceed.Wpf.DataGrid.RowSelector �� Padding n�Name  invisibleThumbStyle  tableViewRowTemplate   Xceed.Wpf.DataGrid.Row � 	Resources:   4Xceed.Wpf.DataGrid.Converters.TypeToBooleanConverter � ColumnDefinitions ��Name(   "Xceed.Wpf.DataGrid.Views.TableView   CanScrollHorizontally<	   6Xceed.Wpf.DataGrid.HierarchicalGroupLevelIndicatorPane0
   *Xceed.Wpf.DataGrid.GroupLevelIndicatorPane  
 Name! ��Name ! detailsExpanderButtonTemplate)   #Xceed.Wpf.DataGrid.DataGridCommands"   ToggleDetailExpansion# � OverridesDefaultStyle-   'Xceed.Wpf.DataGrid.Views.FixedCellPanel$  Name%   ColumnStretchMinWidth&   ColumnStretchMode'   FixedCellCount( �� Mode)   FixedColumnDropMarkPen* ^� 
Conditions+ �� Binding, �� Value 	 typeToBooleanConverter    Xceed.Wpf.DataGrid.DataRow %
 !tableViewColumnManagerRowTemplate)   #Xceed.Wpf.DataGrid.ColumnManagerRow- {�Name  tableViewCellTemplate   Xceed.Wpf.DataGrid.Cell-   'Xceed.Wpf.DataGrid.CellContentPresenter.  Name/ ]� 
Conditions0 �� Property & "tableViewColumnManagerCellTemplate*   $Xceed.Wpf.DataGrid.ColumnManagerCell1 d�Name2 J� Opacity3 ��Name4 �� Orientation5 P� 
SourceName6 P� Property7 P� Value # tableViewGroupByControlTemplate'   !Xceed.Wpf.DataGrid.GroupByControl8   NoGroupContent   tableViewGroupByItemTemplate$   Xceed.Wpf.DataGrid.GroupByItem8   2Xceed.Wpf.DataGrid.Converters.IntAdditionConverter ) %groupHeaderControlGroupLevelConverter ' #tableViewGroupHeaderControlTemplate+   %Xceed.Wpf.DataGrid.GroupHeaderControl5   /Xceed.Wpf.DataGrid.Views.PassiveLayoutDecorator9   Axis: 
  Indented; 
  
GroupLevel< � FocusVisualStyle= J� InputBindings>   ToggleGroupExpansion? �� Command
@ �� KeyA   ExpandGroupB   CollapseGroupC d� MouseAction % !groupExpanderToggleButtonTemplateD d� 	IsChecked ( $tableViewGroupLevelIndicatorTemplate,   &Xceed.Wpf.DataGrid.GroupLevelIndicator $  tableViewDetailIndicatorTemplate(   "Xceed.Wpf.DataGrid.DetailIndicator , (tableViewGroupLevelIndicatorPaneTemplate'   !Xceed.Wpf.DataGrid.Views.ViewBase 8 4tableViewHierarchicalGroupLevelIndicatorPaneTemplate  dataGridContextTemplateE �� DataType(   "Xceed.Wpf.DataGrid.DataGridContextF �� ItemsSource7   1Xceed.Wpf.DataGrid.HierarchicalGroupByControlNodeG  NameH   TitleI �� Triggers  detailConfigurationTemplate,  &Xceed.Wpf.DataGrid.DetailConfiguration=   7Xceed.Wpf.DataGrid.Converters.TypeToVisibilityConverter  notDetailConfigConverterJ   
VisibilityK   SetVisibilityWhenTrue   booleanToVisibilityConverter / +hierarchicalGroupByControlTreeViewItemStyleL � RowDefinitions 5 1tableViewCommonHierarchicalGroupByControlTemplate3   -Xceed.Wpf.DataGrid.HierarchicalGroupByControlM R�NameN Q� 
IsExpandedO   NoGroupContent F BtableViewCommonHierarchicalGroupByControlOldGroupByControlTemplate P   AllowGroupingModification Q   AllowGroupingModificationR   	AllowSortS   	AllowSortT   ConnectionLinePenU   ConnectionLinePen 3 /tableViewHierarchicalGroupByControlNodeTemplateV ��Name , (tableViewHierarchicalGroupByItemTemplate0   *Xceed.Wpf.DataGrid.HierarchicalGroupByItem  tableViewScrollTipTemplate"    Xceed.Wpf.DataGrid.ScrollTip�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      *local clr-namespace:Xceed.Wpf.DataGrid  5      2markup'clr-namespace:Xceed.Wpf.DataGrid.Markup  5      4conv+clr-namespace:Xceed.Wpf.DataGrid.Converters  5      0views&clr-namespace:Xceed.Wpf.DataGrid.Views  5        5      �� 5      $ Common.Resources.xaml?�6   %gi  &	        7  &	 M    &	 k    &	 �    7  &	 @    7  7 	 7 	 &	
 �    7  &	 $"    &	 �+    7  7  &	 �9    &	 +;    &	 0?    &	 C?    7  7  &	 �C    &	 *D    &	 �D    7  7  7  7  &	 FJ    &	 �J    &	 �L    &	 vM    &	 �M    &	 �M    7  7  &	 NQ    7  7  7  7  7  7  7  &	 �Y    7  7  7  &	 �_    &	 _`    &	 ng    �� 5      "   5       5      ��  5      thicknessConverter 6#   5    	   .�5"      ��  � �� 5#      �� 5$      .R�5%      �� ���	#FF000000$��1��5&      $	 1 2R�5'       . ��5(      ��  �� "	 ��$
 HorizontalOffset�8   $
 Left��5)      5*      5,   	   5-        5/       . 50      �� 55      "  56      .R�57      � .+�58      �� #��z��6   #��z��59      #��z��5:      ._�5=      �� $# PART_DragDropAdornerDecorator��6   .u�5@        $ PART_ScrollViewer��6-   #��z��5C   -    5A   -   ��  �� *Self+$A
 ;(local:DataGridControl.DataGridContext).ShowRowSelectorPane� 5B   -   ��  �� *Self+$B
 <(local:DataGridControl.DataGridContext).RowSelectorPaneWidth�.��5E        5F      5G      5H      � 5I      $ connectionStateGrid��6   $��Right=�5J      $��Bottom=�5K      $��	0,0,25,25q�5L      $��30��5M      $��30��5N      .+�5O      �� $, &connectionStateLoadingContentPresenter��6   #��z 5Q      $y�	Collapsed=�5R      ��5P      ��  �� *Self+$I
 C(local:DataGridControl.DataGridContext).ConnectionStateLoadingGlyph�5R      �� 5S      $/ )connectionStateCommittingContentPresenter��6   #��z 5U      $y�	Collapsed=�5V      ��5T      ��  �� *Self+$L
 F(local:DataGridControl.DataGridContext).ConnectionStateCommittingGlyph�5V      �� 5W      $* $connectionStateErrorContentPresenter��6   #��z 5Y      $y�	Collapsed=�5Z      ��5X      ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).ConnectionStateErrorGlyph�5Z      5[      5\   	    5]      �� 5^      $ False��5_       5^      ��  �� *Self+$K
 E(local:DataGridControl.DataGridContext).IsConnectionStateGlyphEnabled�.a�5`      �� $ connectionStateGrid��6    � y�$ 	Collapsed=�5b      5c      �� 5d      $ Loading��5e       5d      ��  �� *Self+$M
 G(local:DataGridControl.DataGridContext).DataGridControl.ConnectionState�.a�5f      �� $, &connectionStateLoadingContentPresenter��6    � y�$ Visible=�5h      �� 5i      $* $connectionStateErrorContentPresenter��6    � y�$ 	Collapsed=�5k      �� 5l      $/ )connectionStateCommittingContentPresenter��6    � y�$ 	Collapsed=�5n      5o      �� 5p      $ 
Committing��5q       5p      ��  �� *Self+$M
 G(local:DataGridControl.DataGridContext).DataGridControl.ConnectionState�.a�5r      �� $, &connectionStateLoadingContentPresenter��6    � y�$ 	Collapsed=�5t      �� 5u      $* $connectionStateErrorContentPresenter��6    � y�$ 	Collapsed=�5w      �� 5x      $/ )connectionStateCommittingContentPresenter��6    � y�$ Visible=�5z      5{      �� 5|      $ Error��5}       5|      ��  �� *Self+$M
 G(local:DataGridControl.DataGridContext).DataGridControl.ConnectionState�.a�5~      �� $, &connectionStateLoadingContentPresenter��6    � y�$ 	Collapsed=�5�      �� 5�      $* $connectionStateErrorContentPresenter��6    � y�$ Visible=�5�      �� 5�      $/ )connectionStateCommittingContentPresenter��6    � y�$ 	Collapsed=�5�      5�      5�      �� 5�      "  5�      .R�5�      � .+�5�      �� #��z��6   #��z��5�      #��z��5�      # z��5�      ._�5�      �� $ contentPresenter��6   #��z��5�      #��z��5�      #��z��5�      #��z��5�      #��z��5�      5�      n� 5�      $ PART_RowResizerThumb��6   8��  $��Bottom=�5�      5�   	   5�      �� 5�      "  5�       5�      ��  5�      typeToBooleanConverter 6'   5�   	   .R�5�      � $ rootGrid��6    5�      �� 5�      $
��Auto �6   �� 5�      $
��Auto �6   �� 5�      $
��Auto �6   �� 5�      $��* �6   .+�5�      �� $ 
rootBorder��6   $��2��5�      $��2��5�       .  #��z��5�      #��z��5�      #��z��5�      # z��5�      	  5�      $��0��65    .  5�   5   
  5�      $  groupLevelIndicatorPane��6)    .  $��1��5�   )   �� 5�      $! detailsToggle��6   8��  $	��Top=�5�      $��2��5�      $��2,4,2,0q�5�      #��Z" 5�      # . |�.  $y�	Collapsed=�5�       .  5�      �� 5�      $�� ��6   $y�Hidden=�5�      $��3��5�      #��z��5�        5�      $$ PART_CellsHost��6    $��3��5�       #��z��5�       % 5�       ��  �� *Self+$C
 =(local:DataGridControl.DataGridContext).ColumnStretchMinWidth�& 5�       ��  �� *Self+$?
 9(local:DataGridControl.DataGridContext).ColumnStretchMode�' 5�       ��  �� *Self+$>
 8(local:DataGridControl.DataGridContext).FixedColumnCount�$( TwoWay=�) 5�       ��  �� *Self+$D
 >(local:DataGridControl.DataGridContext).FixedColumnDropMarkPen�5�       5�   	    5�      ^� 5�      * 5      �� 5     + 6   ��  �� *Self+$
 
IsSelected�, True5     �� 5     + 6   ��  �� *Self+$S
 M(local:DataGridControl.DataGridContext).DataGridControl.IsKeyboardFocusWithin�, True5     .0�5
     �� $ 
rootBorder��6    5     ��  �� *TemplatedParent+$
 SelectionBackground� � ���� 5     $ rootGrid��6    5     ��  �� *TemplatedParent+$
 SelectionForeground� � ��5     ^� 5     * 5     �� 5     + 6   ��  �� *Self+$
 
IsSelected�, True5     �� 5     + 6   ��  �� *Self+$S
 M(local:DataGridControl.DataGridContext).DataGridControl.IsKeyboardFocusWithin�	, False5     �� 5     + 6   ��  �� *Self+$K
 E(local:DataGridControl.DataGridContext).DataGridControl.HideSelection�	, False5      .0�5$     �� $ 
rootBorder��6    5&     ��  �� *TemplatedParent+$!
 InactiveSelectionBackground� � ���� 5(     $ rootGrid��6    5*     ��  �� *TemplatedParent+$!
 InactiveSelectionForeground� � ��5,     ^� 5/     * 50     �� 51     + 6   ��  �� *Self+$8
 2(local:DataGridControl.DataGridContext).HasDetails�, True52     �� 53     + 6   ��  �� *Self+$?
 9(local:DataGridControl.DataGridContext).AllowDetailToggle�, True54     �� 55     + 56     ��  �� *Self+$
 .�$( OneWay=�8  "  , True55     56     .0�59     �� $ detailsToggle��6    � y�$ Visible=�5;     5=     ^� 5?     * 5@     �� 5A     + 6   ��  �� *Self+$8
 2(local:DataGridControl.DataGridContext).HasDetails�, True5B     �� 5C     + 6   ��  �� *Self+$?
 9(local:DataGridControl.DataGridContext).AllowDetailToggle�, True5D     �� 5E     + 5F     ��  �� *Self+$
 .�$( OneWay=�8  "  	, False5E     5F     .0�5I     �� $ detailsToggle��6    � y�$ Hidden=�5K     5M     5P     �� 5U     "  5V      5[     ��  5\     thicknessConverter  . 5]  #   5^  	   .R�5a     � $ rootGrid��6    5b     �� 5d     $
��Auto �6   �� 5f     $
��Auto �6   �� 5g     $
��Auto �6   �� 5j     $��* �6   .+�5p     �� $ 
rootBorder��6   $��1��5q     $��3��5r      .  #��z��5t     #��z��5u     #��z��5v     # z��5w     	  5{      .  $��0��5|  5   #��z��5}  5   
  5~     $  groupLevelIndicatorPane��6)    .  $��1��5�  )   #��z��5�  )   �� 5�     $! detailsToggle��6   8��  $	��Top=�5�     $��2��5�     $��2,4,2,0q�5�     #��Z" 5�     # . |�.  $y�	Collapsed=�5�      .  5�     {� 5�     $- indentationDecorator��6   $��3��5�     ._�5�       $$ PART_CellsHost��6#   #��z��5�  #   % 5�  #   ��  �� *Self+$C
 =(local:DataGridControl.DataGridContext).ColumnStretchMinWidth�& 5�  #   ��  �� *Self+$?
 9(local:DataGridControl.DataGridContext).ColumnStretchMode�' 5�  #   ��  �� *Self+$>
 8(local:DataGridControl.DataGridContext).FixedColumnCount�$( TwoWay=�) 5�  #   ��  �� *Self+$D
 >(local:DataGridControl.DataGridContext).FixedColumnDropMarkPen�5�  #   5�     5�  	    5�     ^� 5�     * 5�     �� 5�     + 6   ��  �� *Self+$8
 2(local:DataGridControl.DataGridContext).HasDetails�, True5�     �� 5�     + 6   ��  �� *Self+$?
 9(local:DataGridControl.DataGridContext).AllowDetailToggle�, True5�     .0�5�     �� $ detailsToggle��6    � y�$ Hidden=�5�     5�     5�     �� 5�     "  5�     .R�5�     �� $ 
rootBorder��6   #��z��5�     #��z��5�     #��z��5�     # z��5�     ._�5�       $. PART_CellContentPresenter��6&   #��z��5�  &   #��z��5�  &   5�  	    5�     ]� 5�     / 5�     �� 5�     0 �@ 	IsCurrent, . 5�     �� 5�     0 �@ HasValidationError, .  5�     ./�5�     �� $ 
rootBorder��6    5�     ��  �� *TemplatedParent+$
 CurrentBackground� � ���� 5�     $ 
rootBorder��6    5�     ��  �� *TemplatedParent+$
 CurrentForeground� � ��5�     ]� 5�     / 5�     �� 5�     0 �@ 	IsCurrent, . 5�     �� 5�     0 �@ HasValidationError, . 5�     �� 5�     , 5�     Z� 0 �@ CellErrorStyle./�5�     �� $ 
rootBorder��6    5�     ��  �� *TemplatedParent+$
 CurrentBackground� � ���� 5�     $ 
rootBorder��6    5�     ��  �� *TemplatedParent+$
 CurrentForeground� � ��5     ^� 5     * 5     �� 5     + 6   ��  �� *Self+$
 
IsSelected�, True5     �� 5
     + 6   ��  �� *Self+$k
 e(local:DataGridControl.DataGridContext).(local:DataGridContext.DataGridControl).IsKeyboardFocusWithin�, True5     .0�5     �� $ 
rootBorder��6    5     ��  �� *TemplatedParent+$
 SelectionBackground� � ���� 5     $ 
rootBorder��6    5     ��  �� *TemplatedParent+$
 SelectionForeground� � ��5     ^� 5     * 5     �� 5     + 6   ��  �� *Self+$
 
IsSelected�, True5     �� 5!     + 6   ��  �� *Self+$k
 e(local:DataGridControl.DataGridContext).(local:DataGridContext.DataGridControl).IsKeyboardFocusWithin�	, False5"     �� 5$     + 6   ��  �� *Self+$c
 ](local:DataGridControl.DataGridContext).(local:DataGridContext.DataGridControl).HideSelection�	, False5%     .0�5)     �� $ 
rootBorder��6    5+     ��  �� *TemplatedParent+$!
 InactiveSelectionBackground� � ���� 5-     $ 
rootBorder��6    5/     ��  �� *TemplatedParent+$!
 InactiveSelectionForeground� � ��51     �� 59     $ False��5:      59     ��  �� *Self+$
 ParentColumn.Visible�.a�5;     ��  � y�$ 	Collapsed=�5<     5=     5A     �� 5F     "  5G     .R�5M     �� #��z��6   #��z��5N     ._�5Q     � .+�5S     �� #��� ��6   $
��Left=�5T     $��Stretch=�5U     $��1��5V     $��0,2,0,2q�5W     �� 5Y     #��� ��6   $��Right=�5Z     $��Stretch=�5[     $��1��5\     $��0,2,0,2q�5]     ]� 5_     .+�5`     �� $! thumbToggleBackgroundBorder��6   $��Right=�5a     ._�5c     � .+�5e     �� $ toggleDelimeterBorder��6   #��� ��5f     $��1,0,0,0q�5g     $��0,4,0,4q�5h     
������ $y�	Collapsed=�5j     ._�5l     �� $ toggleDelimeterBorder2��6!   #��� ��5m  !   $��1,0,0,0q�5n  !   $��0,0,0,0q�5o  !   
������ $y�	Collapsed=�5q  !   5s     5u     d� 5w     $1 toggleButton��6$   |�.  $��Stretch=�5y  $   $y�	Collapsed=�5z  $   $��2,0,0,0q�5{  $   $	2 0.5Q�5|  $   5~     5�     �� 5�     #��z��6   ._�5�     � .+�5�     �� # z��6   ._�5�     �� $3 contentPanel��6%   $4 
Horizontal=�5�  %   .+�5�       #��z��68   #��z��5�  8   �� 5�     $ sortGlyphPresenter��6.   ��5�  .   Z� ��5�  .   Z� 5�     5�     5�     5�     5�     n� 5�     $! PART_ColumnResizerThumbLeft��6   8��  $��6��5�     $
��Left=�5�     n� 5�     $ PART_ColumnResizerThumb��6   8�� $��6��5�     $��Right=�5�     5�     5�  	    5�     P� 5�     $5 toggleButton��6   6 �@J�IsMouseOver7 . . �5�     �� $ toggleButton��6    �@J�Opacity$ 1Q�5�     5�     P� 5�     6 �@ 	IsPressed7 . . �5�     �� $ contentPanel��6    � ��$ 	1,1,-1,-1q�5�     5�     �� 5�     $ 	Ascending��5�      5�     ��  �� *Self+$ 
 ParentColumn.SortDirection�.a�5�     �� $ sortGlyphPresenter��6    5�     ��  �� *Self+$@
 :(local:DataGridControl.DataGridContext).AscendingSortGlyph� � ���� 5�     $ sortGlyphPresenter��6    � ��$ 6,0,0,0q�5�     5�     �� 5�     $ 
Descending��5�      5�     ��  �� *Self+$ 
 ParentColumn.SortDirection�.a�5�     �� $ sortGlyphPresenter��6    5�     ��  �� *Self+$A
 ;(local:DataGridControl.DataGridContext).DescendingSortGlyph� � ���� 5�     $ sortGlyphPresenter��6    � ��$ 6,0,0,0q�5�     5�     ^� 5�     * 5�     �� 5�     + 6   ��  �� *Self+$ 
 ParentColumn.HasFixedWidth�, True5�     �� 5�     + 6   ��  �� *Self+$L
 F(local:DataGridControl.DataGridContext).RemoveColumnStretchingOnResize�	, False5�     .0�5�     �� $ PART_ColumnResizerThumb��6    � {� .  5�     5�     ^� 5�     * 5�     �� 5�     + 6   ��  �� *Self+$6
 0ParentColumn.PreviousVisibleColumn.HasFixedWidth�, True5�     �� 5�     + 6   ��  �� *Self+$L
 F(local:DataGridControl.DataGridContext).RemoveColumnStretchingOnResize�	, False5�     .0�5�     �� $! PART_ColumnResizerThumbLeft��6    � {� .  5     5     �� 5     $ False��5      5     ��  �� *Self+$!
 ParentRow.AllowColumnResize�.a�5     �� $ PART_ColumnResizerThumb��6    � {� .  5     �� 5	     $! PART_ColumnResizerThumbLeft��6    � {� .  5     5     �� 5     $ False��5      5     ��  �� *Self+$
 ParentColumn.Visible�.a�5     ��  � y�$ 	Collapsed=�5     5     5     �� 5     "  5     .R�5     �� #��z��6   #��z��5     #��z��5      # z��5!     ._�5%     � .+�5+     �� $ noGroupContentPresenter��6   #��z8 5,     $��Center=�5-     $y�	Collapsed=�5.     �� 54     56     57  	    59     P� 5<     6 �@��HasItems7 .  . �5?     �� $ noGroupContentPresenter��6    � y�$ Visible=�5A     5B     5F     �� 5K     "  5L     .R�5N     �� #��z��6   #��z��5O     #��z��5P     # z��5Q     ._�5T     �� $4 
Horizontal=�6   .+�5W     �� #��z��6   #��z��5X     #��z��5Y     #��z��5Z     #��z��5[     �� 5`     $ sortGlyphPresenter��6   ��5a     Z� ��5b     Z� 5d     5e  	    5g     �� 5k     $ 	Ascending��5l      5k     ��  �� *Self+$
 SortDirection�.a�5n     �� $ sortGlyphPresenter��6    5p     ��  �� *Self+$@
 :(local:DataGridControl.DataGridContext).AscendingSortGlyph� � ���� 5r     $ sortGlyphPresenter��6    � ��$ 6,0,0,0q�5t     5v     �� 5x     $ 
Descending��5y      5x     ��  �� *Self+$
 SortDirection�.a�5{     �� $ sortGlyphPresenter��6    5}     ��  �� *Self+$A
 ;(local:DataGridControl.DataGridContext).DescendingSortGlyph� � ���� 5     $ sortGlyphPresenter��6    � ��$ 6,0,0,0q�5�     5�     5�       5�     6   �� 5�     "  5�     .R�5�       $9 
Horizontal=�6%   ._�5�     ]� .+�5�     	  $
��Left=�68   
  5�     $
��Left=�6,   : .  ; 5�  ,   ��  �� *TemplatedParent+$0
 *(local:GroupLevelIndicatorPane.GroupLevel)�8   $ -1���� 5�     $ 
mainBorder��6   #��z��5�     #��z��5�     #��z��5�     # z��5�     |�. #< z< 5�     = 5�     �� 5�     #? Z> 6   $@ Space��5�     �� 5�     #? ZA 6   $@ Right��5�     �� 5�     #? ZA 6   $	@ Add��5�     �� 5�     #? ZB 6   $
@ Left��5�     �� 5�     #? ZB 6   $@ Subtract��5�     d� 5�     #? Z> 6!   $C LeftDoubleClicke�5�  !   ._�5�     �� $4 
Horizontal=�6   .+�5�     d� 8�� # . #��z��5�  !   |�.  D 5�  !   ��  �� *TemplatedParent+$
 Group.IsExpanded��� 5�     $��3,0,0,0q�6%   #��z��5�  %   #��z��5�  %   #��z��5�  %   #��z��5�  %   5�     5�     5�     5�  	    5�     P� 5�     6 �@ NavigationBehavior$
7 None=�5�     . �5�     �� $ 
mainBorder��6    � |� .  5�     5�     5�     �� 5�     "  5�     .R�5�     �� #��z��6   #��z��5�     #��z��5�     # z��5�     5�     �� 5�     "  5�     .R�5�     �� #��z��6   #��z��5�     #��z��5�     # z��5�     5�     �� 5�     " 
 5�     .R�5�     � .+�5�     �� $ horizontalBorder��6   #��z��5�     #��z��5      ��5     ��  �� *Self+$I
 C(local:DataGridControl.DataGridContext).HorizontalGridLineThickness�8   $	 Top���� 5     $ verticalBorder��6   #��z��5     # z��5     ��5     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $
 Left��._�5     �� $"3 PART_GroupLevelIndicatorHost��6   $4 
Horizontal=�5     5	     5  	    5     ]� 5     / 5     �� 5     0 �@
 IsLeaf, . 5     �� 5     0 �@ 
IsLastItem, . 5     �� 5     0 �@ HasExpandedDetails, .  5     ./�5     �� $ horizontalBorder��6    5     ��  �� *Self+$I
 C(local:DataGridControl.DataGridContext).HorizontalGridLineThickness�8  $ Top, Bottom�� � ���� 5     $ verticalBorder��6    5     ��  �� *Self+$I
 C(local:DataGridControl.DataGridContext).HorizontalGridLineThickness�8  $ Bottom�� � ��5     ]� 5     / 5     �� 5!     0 �@
 CurrentIndicatorCount$, 0��5"     �� 5$     0 �@
 IsLeaf, .  5%     ./�5)     �� $ verticalBorder��6    � ��$ 0q�5+     5-     P� 5/     6 �@
 ShowVerticalBorder7 .  . �51     �� $ verticalBorder��6    � ��$ 0q�53     54     57     �� 5<     " 	 5=     .R�5>     �� #��z��6   #��z��5?     ._�5@     �� $"3 PART_GroupLevelIndicatorHost��6   $4 
Horizontal=�5A     5B  	   5D     �� 5K     "E  5L     F 5M     �� $
 DetailConfigurations�.R�5O       $G groupByControlNode��6-   ��5P  -   �� $
 GroupLevelDescriptions�H 5Q  -   �� $%
 SourceDetailConfiguration.Title�I 5T     �� 5U      6   �� $
 SourceDetailConfiguration� 5V     Z� .a�5W     �� $ groupByControlNode��6    �@ Title 5Y     �� 5Z     $%
 DataGridControl.ItemsSourceName�6   5\     5]     5`     �� 5c     "E  5d     F 5e     �� $
 DetailConfigurations�.R�5g       ��6-   �� $
 GroupLevelDescriptions�H 5h  -   �� *Title+5i       5k     $J Visible=�5l  $   K .  5m  $   �� 5o     6"   �� 5r     " Q�5s     .�5u     ��  �@Q�
IsExpanded . 5v     �� 5x      � |� .  5y     �� 5{      � y� 5|     � 5}     .&�5~     �� $
 .�6   8   "  5�     �� 5�     $
 Visible�6   8  5�     5�     5�  	   �� 5�      � �� 5�     �� 5�     " Q�6   .R�5�     �  5�     �� 5�     $��19 �6(   �� 5�     $
��Auto �6(   �� 5�     $��* �6(   L 5�     �� 5�     $
��Auto �6%   �� 5�     .+�5�     �� $��treeViewItemBorder��5�     #��z��5�     # z��5�     #��z��5�     #��z��5�      . $��1��5�     ._�5�     �� $��PART_Header��5�  (   #��z��5�  (   #��z��5�  (   $��Header��5�  (   #��z��5�  (   # z 5�  (   5�     �� 5�     $��	ItemsHost��6#   $��1��5�  #   $��1��5�  #   $��2��5�  #   5�     5�     5�  	   5�     �� 5�     "  5�      5�     ���� 5�     'R�       " R�6   5�  	   .R�5�     � $ rootGrid��6    5�     �� 5�     $
��Auto �6   �� 5�     $
��Auto �6   �� 5�     $��* �6   .+�5�     �� $ 
rootBorder��6   $��1��5�     $��2��5�     #��z��5�     # z��5�     ��5�     ��  �� *Self+$E
 ?(local:DataGridControl.DataGridContext).HorizontalGridLineBrush���5�     ��  �� *Self+$I
 C(local:DataGridControl.DataGridContext).HorizontalGridLineThickness�8   $	 Top��5�     �� 5�     $ verticalGridLineBorder��6   $��1��5�     $��2��5�     ��5�     ��  �� *Self+$C
 =(local:DataGridControl.DataGridContext).VerticalGridLineBrush���5�     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $ Right��	  5�     $��0��65   
  5�     $  groupLevelIndicatorPane��6)   $��1��5�  )   �� 5�     $��2��6   $4 
Horizontal=�5�     .+�5�     R� $-M 'PART_HierarchicalGroupByControlTreeView��6   8�� 
������ 
������ |�.  .@�5�     Q� 8�� 8�� 8�� N . ��6   ��  �� *Self+$-
 '(local:DataGridControl.DataGridContext)���5�     ��  �� *Self+$B
 <(local:DataGridControl.DataGridContext).DetailConfigurations�5�     5�     �� 5�     $ noGroupContentPresenter��6   #��zO 5�     $��Center=�5�     $y�	Collapsed=�5�     $��5,0,0,0q�5�     5�     5�  	    5�     �� 5�     $
 True��5�      5�     ��  �� *Self+$
 	HasGroups�.a�5�     �� $ noGroupContentPresenter��6    � y�$ Visible=�5     5     �� 5     $ -1��5      5     ��  �� *TemplatedParent+$0
 *(local:GroupLevelIndicatorPane.GroupLevel)�.a�5     �� $ groupLevelIndicatorPane��6    � y�$ 	Collapsed=�5	     �� 5
     $ verticalGridLineBorder��6    5     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $ Right, Left�� � ��5     5     �� 5     "  5     .R�5     � $ rootGrid��6    5     �� 5     $
��Auto �6   �� 5     $
��Auto �6   �� 5     $��* �6   .+�5%     �� $ 
rootBorder��6   $��1��5&     $��2��5'     #��z��5(     # z��5+     ��5)     ��  �� *Self+$E
 ?(local:DataGridControl.DataGridContext).HorizontalGridLineBrush���5*     ��  �� *Self+$I
 C(local:DataGridControl.DataGridContext).HorizontalGridLineThickness�8   $	 Top��5+     �� 5-     $ verticalGridLineBorder��6   $��1��5.     $��2��5/     ��50     ��  �� *Self+$C
 =(local:DataGridControl.DataGridContext).VerticalGridLineBrush���51     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $ Right��	  53     $��0��65   
  57     $  groupLevelIndicatorPane��6)   $��1��58  )     5:     $��2��6    #��z��5;      #��z��5<      #��z��5=      #Q zP 5>      #S zR 5?      #U zT 5@      #8 zO 5A       . 5B      5D  	    5F     �� 5H     $ -1��5I      5H     ��  �� *TemplatedParent+$0
 *(local:GroupLevelIndicatorPane.GroupLevel)�.a�5J     �� $ groupLevelIndicatorPane��6    � y�$ 	Collapsed=�5L     �� 5M     $ verticalGridLineBorder��6    5O     ��  �� *Self+$G
 A(local:DataGridControl.DataGridContext).VerticalGridLineThickness�8  $ Right, Left�� � ��5P     5T     �� 5Y     "  5Z     .R�5\     �� $4 
Horizontal=�6   #��z��5]     .+�5_     �� $V titleTextBlock��6   #��zH 5`     $��0,0,10,0q�5a     �� 5c     $��0,0,0,10q�6   5d  	   5f     �� 5k     "  5l     .R�5n     �� $ outerBorder��6   #��� ��5o     #��� ��5p     $��0,0,1,1q�5q     $ 1,1,0,0q�5r     ._�5t     �� $ innerBorder��6   #��� ��5u     $��0,0,1,1q�5v     $��1,1,0,0q�5w     #��z��5x     # z��5y     ._�5|     �� $3 contentPanel��6   $4 
Horizontal=�5}     .+�5�     �� #��z��6"   #��z��5�  "   #��z��5�  "   #��z��5�  "   #��z��5�  "   �� 5�     $ sortGlyphPresenter��6"   $��6,0,0,0q�5�  "   $y�Hidden=�5�  "   ��5�  "   Z� ��5�  "   ��  �� *Self+$@
 :(local:DataGridControl.DataGridContext).AscendingSortGlyph�5�  "   5�     5�     5�  	    5�     P� 5�     6 � ��7 . . �5�     �� $ outerBorder��6   # � ��5�      � ���� 5�     $ outerBorder��6    � ��$ 1q�5�     �� 5�     $ outerBorder��6    �@��Padding$ 0q�5�     �� 5�     $ innerBorder��6    � ��$ 1q�5�     �� 5�     $ innerBorder��6    � ��$ 0q�5�     �� 5�     $ contentPanel��6    � ��$ 	1,1,-1,-1q�5�     5�     �� 5�     $ 	Ascending��5�      5�     ��  �� *Self+$
 SortDirection�.a�5�     �� $ sortGlyphPresenter��6    5�     ��  �� *Self+$@
 :(local:DataGridControl.DataGridContext).AscendingSortGlyph� � ���� 5�     $ sortGlyphPresenter��6    � y�$ Visible=�5�     5�     �� 5�     $ 
Descending��5�      5�     ��  �� *Self+$
 SortDirection�.a�5�     �� $ sortGlyphPresenter��6    5�     ��  �� *Self+$A
 ;(local:DataGridControl.DataGridContext).DescendingSortGlyph� � ���� 5�     $ sortGlyphPresenter��6    � y�$ Visible=�5�     5�     5�     �� 5�     "   5�     .R�5�     �� $��Center=�6   $��Right=�5�     #��z��5�     #��z��5�     #��z��5�     5�     5�     
   M S B A M L   `   `   `  ����  AppView    AppView.CategorieEntry   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=2.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5        N� Title$  CategorieEntry��5	      .��5      � .+�5   
   +  %System.Windows.Controls.Ribbon.Ribbon  -   5          Name$ 	RibbonWin��5       �� SelectedIndex$ 0��6%      HelpPaneContent 5      1  +System.Windows.Controls.Ribbon.RibbonButton  5         SmallImageSource$ familylife.png��6      QuickAccessToolBar 5      =  7System.Windows.Controls.Ribbon.RibbonQuickAccessToolBar  5      .@�5        -   5          Name$
 Save��5   #   $ familylife.png��62   6  0System.Windows.Controls.Ribbon.RibbonSplitButton  5      -   5          Name$
 Undo��5   (   5  /System.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$ familylife.png��67   .@�5      8  2System.Windows.Controls.Ribbon.RibbonSplitMenuItem  $��Undo 1��6.     5      $��Undo 2��6.     5      $��Undo 3��6.   5        5      -   5        $
 Redo��5   (   $ familylife.png��66   .@�5        $��Redo 1��6.     5      $��Redo 2��6.   5      5      	   ApplicationMenu	 5!      :  4System.Windows.Controls.Ribbon.RibbonApplicationMenu  5"      
   KeyTip$
 F��6(   .@�5#      >  8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem  $��Options��60   3	  -System.Windows.Controls.Ribbon.RibbonMenuItem 	  ImageSource$ familylife.png��6A     5$      $
��Exit��60   $ familylife.png��6>   5%      .@�5(      .
  (System.Windows.Controls.Ribbon.RibbonTab
  $
��Home��6    
  KeyTip$ H��6&   .@�5*      0  *System.Windows.Controls.Ribbon.RibbonGroup  -   5          Name$ ClipboardGroup��5*      $
��Home��66   .@�5+           LargeImageSource$ familylife.png��6'      Label$ Paste��6I   $
 V��6W   .@�5,      	  $ familylife.png��6)   $��Keep Text Only��6F    	  KeyTip$ T��6^   	  5-      $ familylife.png��6)   $��Paste Special...��6F   $ S��6`   5.        5/      $ familylife.png��6#      Label$	 Cut��6E      KeyTip$ X��6Q     50      $ familylife.png��6#   $
 Copy��6E   $ C��6R     51      $ familylife.png��6#   $ Format Painter��6E   $ FP��6\   52        54      -   5        $ Employee��54      $��Employee And Payroll��60   .@�55        $ familylife.png��6'   $ Employee��6I   $
 V��6Z   .@�56      	  $ familylife.png��6)   $��Keep Text Only��6F   $ T��6^   	  57      $ familylife.png��6)   $��Paste Special...��6F   $ S��6`   58        59      $ familylife.png��6#   $
 Save��6E   $ X��6R     5:      $ familylife.png��6#   $	 Add��6E   $ C��6Q   5;      5<      
  5>      $��Insert��6   $ I��6(   5?      
  5A      $��
PageLayout��6   $ L��6,   5B      5C      %  Xceed.Wpf.Toolkit.BusyIndicator  5D   
   $
��Left=�6   $��
51,115,0,0q�69   $	��Top=�6M   $��88��6e   $	��127��6q   %  Xceed.Wpf.Toolkit.ButtonSpinner  5E   
   $
��Left=�6   $��
34,246,0,0q�68   $	��Top=�6L   $��29��6d   $	��135��6p   "  Xceed.Wpf.Toolkit.ByteUpDown  5F   
   $
��Left=�6   $��107,168,0,0q�65   $	��Top=�6J   $��35��6b   $	��121��6n   5H      5I      
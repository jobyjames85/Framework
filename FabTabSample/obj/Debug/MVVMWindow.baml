   M S B A M L   `   `   `  ����T  PSampleProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=292626629a736ae0-clr-namespace:SampleProjectSampleProject  5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L5clr-namespace:System.Diagnostics;assembly=WindowsBaseSystem.Diagnostics 5   	       SampleProject.MVVMWindow   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      +localclr-namespace:SampleProject    5      Kdiagnostics5clr-namespace:System.Diagnostics;assembly=WindowsBase    5   	   M IFabTab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=292626629a736ae0$tabhttp://fabtab.codeplex.com  5   	     � Title$  MVVM Window��5      $	��600��6   $	��800��6&    � 	Resources 5        FabTab.FabTabItem �� 
TargetType �� Property �� Value �� Path1  +System.Diagnostics.PresentationTraceSources   
TraceLevel �� Orientation �� DataType   SampleProject.ModelObject	 �� EndPoint   mask
 �� 	Transform �� Angle � Offset � Color��%  '        (�� m    5)      *, +)&	  U    �� 5
   
   "  6   .�5      ��  � �� 6'   �� $ 	LabelText�$
 High=��� 5       � �� 5      �� 5      .R�5      �� $ 
Horizontal=�6%   $��0,0,4,0q�6>   .+�5      �� $��CharacterEllipsis=�69   ��6(   �� 69   5      5      5      �� 5       �@ ShowCloseButton 60   �� *
AllowClose+5(      �� 5)   
   "  6   .R�5-      �� $��0,0,0,0q�6   $	��800��6.   $	��600��6=   
������.+�5.      �� ��6   �� $
 Name��� 5/      ��6   �� $ Value��� 50      $��Bogus��6   51      53      �� 55   
   $		 1,0&�6   
 56      �� 57      $ 10Q�6"   .��59      � $ 0Q�6   $ White��6&   � 5:      $	 0.1Q�6   5;      5=      .��5>      ]� .+�5?   
   �� -   5        $��Right=�5?      $��Add Tab��6=     FabTab.FabTabControl  5@   
   -   5          Name$ 
tabControl��5@      %   ShowDefaultTransitionAnimation .  $
��Left=�5A   #      ContentOpacityMask# [  69   ��5@   0   ��  � Triggers 5B      :� 5C       :� RoutedEvent$ Selector.SelectionChanged��6   .[�5D      �� .��5E      ��  g� AutoReverse .  .��5F      "  FabTab.EasingDoubleAnimation   �� TargetProperty$( "ContentOpacityMask.Transform.Angle�68    �� 
TargetName$ 
tabControl��5G   2   	 W� To$	 -90X�5H   6    W� From$ 10X�6?    g� Duration$ 0:0:0.7D�6I      Equation$ BackEaseInOut=�5I   8   5J      5K      5L      5N      5P      5Q      
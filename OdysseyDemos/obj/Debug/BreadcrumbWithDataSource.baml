   M S B A M L   `   `   `  ����	  Demos    Demos.BreadcrumbDS   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      G COdyssey, Version=1.4.22.21520, Culture=neutral, PublicKeyToken=null(odchttp://schemas.odyssey.com/wpf  5      
����İ�  � Title$?  9BeadcrumbBar Demo: Using XmlDataProvider as Root Property��5      $	��300��6G   $	��700��6T    � 	Resources 5         dataProvider � XPath �� DataType �� ItemsSource �� XPath��%�  &	        (�� �    5-   #   *bc+)� 5   
   $ bc��6/   .��5	      ��<bc xmlns="" title="Desktop">
                    <bc title="Computer">
                        <bc title="C:">
                            <bc title="Windows">
                                <bc title="System32" />
                                <bc title="ie7" />
                                <bc title="Microsoft.NET" />
                                <bc title="Fonts" />
                                <bc title="Driver Cache" />
                                <bc title="inf" />
                            </bc>
                            <bc title="Program Files">
                                <bc title="Visual Studio" />
                                <bc title="Office" />
                            </bc>
                            <bc title="Users">
                                <bc title="Administrator" />
                                <bc title="Guest" />
                            </bc>
                        </bc>
                        <bc title="D:" />
                    </bc>
                    <bc title="Network">
                        <bc title="odyssey">
                            <bc title="public" />
                            <bc title="private" />
                        </bc>
                        <bc title="daedalus">
                            <bc title="system" />
                            <bc title="confidential" />
                        </bc>
                    </bc>
                </bc>        5,      �� 5-   
   $ bc��6#    61   �� $ *��.R�5.      �� 
���  ����6   �� $ @title��66   5/      50      .��51      ]� $��5q�6   .+�52   
   $  Odyssey.Controls.BreadcrumbBar  -   5          Name$
 bar2��52      $	��Top=�6*      Root# [  54         TraceBinding 53      �� $ @title��54      � 55   
   6   56      57      
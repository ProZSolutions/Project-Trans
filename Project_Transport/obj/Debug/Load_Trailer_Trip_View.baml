   M S B A M L   `   `   `  ����L  HProject_Transport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Project_TransportProject_Transport  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      g cMicrosoft.ReportViewer.WinForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91tSclr-namespace:Microsoft.Reporting.WinForms;assembly=Microsoft.ReportViewer.WinFormsMicrosoft.Reporting.WinForms 5      .    (Project_Transport.Load_Trailer_Trip_View   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R	 NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml  	   5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006  	   5      @d2http://schemas.microsoft.com/expression/blend/2008  	   5      1localclr-namespace:Project_Transport  	   5      7date&clr-namespace:System;assembly=mscorlib  	   5      brvSclr-namespace:Microsoft.Reporting.WinForms;assembly=Microsoft.ReportViewer.WinForms  	   5      .��5      � $	��550��6   $��	0 100 0 0q�6   ��5   
   �� 5        �� EndPoint$  0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FFE8F1C8��6    � Offset$ 0Q�61   � 5      $ 	#FFD6DCC2��6   $ 1Q�61   5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��450 �6   .+�5   
   	� -   5        $��tripload��5      $��-1100 -60 0 0q�6&   $��25��6=   $	��100��6I   $��	TRIP LOAD��6U   $��0��6i   6�   	� 5   
   -   5        $��
tripunload��5      $��-890 -60 0 0q�6(   $��25��6>   $	��100��6J   $��TRIP UNLOAD��6V   $��0��6l   6�   	� 5   
   -   5        $��	tripclose��5      $��-650 -60 0 0q�6'   $��25��6=   $	��100��6I   $��
TRIP CLOSE��6U   $��0��6j   6�   �� 5   
   -   5        $��	vehicleno��5      $��VEHICLE NUMBER��6!   $��30��6:   $	��120��6F   $��-1100 0 0 0q�6R   $��0��6h   �� 5   
   -   5        $��vhlno��5      $��30��6    $	��120��6,   $��
-850 0 0 0q�68   $��0��6L    �� 
IsEditable . 6k   �� 5   
   -   5        $��tripno��5      $��TRIP NUMBER��6   $��30��64   $	��120��6@   $��  -590 0 0 0q�6L   $��0��6b   �� 5   
   -   5        $��tripnum��5      $��30��6"   $	��170��6.   $�� -360 0 0 0q�6:   $��0��6O    . 6n   �� 5   
   -   5        $��fromdate��5      $
��FROM��6    $��30��6/   $��50��6;   $��
-130 0 0 0q�6F   $��0��6Z   (  "System.Windows.Controls.DatePicker  5    
   -	   5        $��	startdate��5       $��30��6&   $	��100��62   $��40 0 0 0q�6>   $��0��6P    �� Today   DisplayDateEnd# Z 6^   �� 5!   
   -
   5        $��todate��5!      $��TO��6   $��30��6+   $��40��67   $��	180 0 0 0q�6B   $��0��6U     5"   
   -   5        $��enddate��5"      $��30��6$   $	��100��60   $��	320 0 0 0q�6<   $��0��6O   
	 �� Now
   SelectedDate#
 Z	 6\   # Z 6�   �� 5#   
   -   5        $
��show��5#      $
��SHOW��6   $��30��6,   $��60��68   $��	550 0 0 0q�6C   $��0��6V   6c   7  1System.Windows.Forms.Integration.WindowsFormsHost  5$   
   -   5        $
��host��5$      $	��440��6'   $
��1240��64   $y�Hidden=�6A   $��1��6U      Child. 5%      /  )Microsoft.Reporting.WinForms.ReportViewer  -   5        ReportViewer��5%      5&      5'      5(      
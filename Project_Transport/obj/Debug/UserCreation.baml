   M S B A M L   `   `   `  ����g  cMicrosoft.ReportViewer.WinForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91tSclr-namespace:Microsoft.Reporting.WinForms;assembly=Microsoft.ReportViewer.WinFormsMicrosoft.Reporting.WinForms  5      L HProject_Transport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Project_TransportProject_Transport 5      $   Project_Transport.UserCreation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      brvSclr-namespace:Microsoft.Reporting.WinForms;assembly=Microsoft.ReportViewer.WinForms     5      1localclr-namespace:Project_Transport     5      .��5
      � 
�������$	��500��6   $��0,55,0,0q�6+     � ColumnDefinitions  5   
   �� 5      $	��625 �6   �� 5      $	��625 �6   .+�5   
   �� -   5        $��label��5      $��30��6   $	��300��6)   $��Center=�65   $��REGISTRATION FORM��6Y   $��94,-450,0,0q�6u   $��0��6�   $��2��6�   �� 5   
   -   5        $��label1��5      $��30��6   $	��120��6*   $��0��66   $��USERNAME��6F   $��-280,-380,0,0q�6Z   $��2��6q   �� 5   
   -   5        $
��text��5      $��30��6   $	��150��6*   $��100,-380,0,0q�66   $��0��6L    �� 	MaxLength$ 15��6u   .��6�   ��5      �� 5       �� Path$
 Name�6    �� UpdateSourceTrigger$ PropertyChanged=�6&    �� Mode$ TwoWay=�6L    �� ValidatesOnDataErrors .  �� ValidationRules 5      )  #Project_Transport.OnlyCharacterRule  5      64   5      .��5      5      �� 5   
   -   5        $��label2��5      $��30��6   $	��120��6*   $��PASSWORD��66   $��-280,-270,0,0q�6J   G� 5   
   -   5        $��passtext��5      $��30��6&   $	��150��62   $��100,-270,0,0q�6>    G� 	MaxLength$ 12��6T   $��0��6c   6s   �� 5   
   -   5        $��label3��5      $��30��6   $	��130��6*   $��CONFIRM PASSWORD��66   $��-280,-160,0,0q�6Q   G� 5   
   -   5        $��	passtext1��5      $��30��6'   $	��150��63   $��100,-160,0,0q�6?   $��0��6U   6e   �� 5   
   -   5        $��label4��5      $��30��6   $	��130��6*   $��DESIGNATION��66   $��-280,-40,0,0q�6L   �� 5   
   -	   5        $��combo��5      $��30��6    $	��150��6,   $��0��68   $��100,-40,0,0q�6H    �� 
IsEditable . .@�5       �� 	 �� 
IsSelected	 . .��6-   SELECT65   �� 5!      .��6   ADMIN6#   �� 5"      .��6   	MANAGER6%   �� 5#      .��6   USER6!   5$      7  1System.Windows.Forms.Integration.WindowsFormsHost  5%   
   -
   5        $
��host��5%      $	��550��6'   $y�Hidden=�64   
   Child.
 5&      /   )Microsoft.Reporting.WinForms.ReportViewer  -   5        ReportViewer��5&      5'      �� 5(   
   -   5        $��button1��5(      $��35��6!   $	��120��6-   $��SUBMIT��69   $��	80,90,0,0q�6J   6^   d� 5)   
   -   5        $��	togglebtn��5)      $��35��6(   $
��Left=�64   $��480,279,0,0q�6O   $	��Top=�6h   $	��120��6�   {�. $��0��6�   .��6�   UPDATE6�   �� 5*   
   -   5        $��label5��5*      $��30��6   $	��250��6*   $��1��66   $��Center=�6F   $��
0,-450,0,0q�6j   $��LIST OF USERS��6~   $��2��6�   5+      &   System.Windows.Controls.DataGrid  5,   
   -   5        $��datagrid��5,      $	��400��6#   $	��500��60   $��	0,-20,0,0q�6<   
�������$��1��6{   $��2��6�   �� 5-   
   -   5        $��button3��5-      $��REPORT��6!   $��-30,450,0,0q�62   $��35��6G   $	��120��6S   $��1��6`   6p   �� 5.   
   -   5        $��button2��5.      $��35��6!   $	��120��6-   $
��BACK��69   $��242,450,0,0q�6H   $��1��6^   5/      50      51      
   M S B A M L   `   `   `  ����L  HProject_Transport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Project_TransportProject_Transport  5      $    Project_Transport.Load_Payment   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Project_Transport     5      .��5	      � $	��550��6   $��	0 100 0 0q�6   
�������  � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $	��Top=�6   $
��Left=�6(   $��30��6C   $	��120��6O   $��
100 30 0 0q�6[   $��calibri)�6o   $��14(�6�   $��0��6�   .��6�   PENDING PAYMENT6�   �� 5   
   -   5        $��Pending_Amnt��5      $��0��6&   {�.  $��Center=�6A   $	��Top=�6e   $
��Left=�6}   $��30��6�   $	��150��6�   $��
250 30 0 0q�6�   $��calibri)�6�   $��14(�6�   $��0��6�   6�   �� 5   
   $	��Top=�6   $
��Left=�6(   $��30��6C   $	��120��6O   $��
100 90 0 0q�6[   $��calibri)�6o   $��14(�6�   $��0��6�   .��6�   	REMARKS6�   �� 5   
   -   5        $��Remarks��5      $	��Top=�6!   $
��Left=�69   $��30��6T   $	��150��6`   $��
250 90 0 0q�6l   $��calibri)�6�   $��14(�6�   $��0��6�   6�   �� 5   
   $	��Top=�6   $
��Left=�6(   $��30��6C   $	��125��6O   $��100 150 0 0q�6[   $��calibri)�6p   $��14(�6�   $��0��6�   .��6�   REMARKS AMOUNT6�   �� 5   
   -   5        $��Remarks_Amnt��5       �� 	MaxLength$ 5��6&   $��0��64   $��Center=�6=   $	��Top=�6a   $
��Left=�6y   $��30��6�   $	��150��6�   $��250 150 0 0q�6�   $��calibri)�6�   $��14(�6�   $��0��6�   6a  �� 5   
   $	��Top=�6   $
��Left=�6(   $��30��6C   $	��120��6O   $��100 210 0 0q�6[   $��calibri)�6p   $��14(�6�   $��0��6�   .��6�   
TOTAL TRIP6�   �� 5   
   -   5        $��
Total_Trip��5      $��0��6$   $��Center=�6-   {�.  $	��Top=�6c   $
��Left=�6{   $��30��6�   $	��150��6�   $��250 210 0 0q�6�   $��calibri)�6�   $��14(�6�   $��0��6�   6�   �� 5   
   $	��Top=�6   $
��Left=�6(   $��30��6C   $	��120��6O   $��100 270 0 0q�6[   $��calibri)�6p   $��14(�6�   $��0��6�   .��6�   	PAYABLE6�   �� 5   
   -   5        $��Payable��5      $��0��6!   $��Center=�6*   {�.  $	��Top=�6`   $
��Left=�6x   $��30��6�   $	��150��6�   $��250 270 0 0q�6�   $��calibri)�6�   $��14(�6�   $��0��6�   6�   �� 5   
   $	��Top=�6   $
��Left=�6(   $��30��6C   $	��120��6O   $��100 330 0 0q�6[   $��calibri)�6p   $��14(�6�   $��0��6�   .��6�   
PAYMENT ID6�   �� 5   
   -   5        $��
Payment_Id��5      {�.  $	��Top=�67   $
��Left=�6O   $��30��6j   $	��150��6v   $��250 330 0 0q�6�   $��calibri)�6�   $��14(�6�   $��0��6�   6�   �� 5   
   -   5        $	��Top=�5      $
��Left=�6)   $��30��6D   $	��100��6P   $��270 400 0 0q�6\   $��0��6q   ���#175
�������.��6�   ADD6�   �� 5   
   -   5        $	��Top=�5      $
��Left=�6)   $��30��6D   $	��100��6P   $��430 400 0 0q�6\   $��0��6q   ���#125
��� ���.��6�   RESET6�   �� 5   
   $	��Top=�6   $
��Left=�6(   $��30��6C   $	��120��6O   $��
100 30 0 0q�6[   $��calibri)�6o   $��14(�6�   $��1��6�   $��Center=�6�   .��6�   	DRIVER ID6�   �� 5   
   -	   5        $��	Driver_Id��5      $	��Top=�6$   $
��Left=�6<   $��30��6W   $	��190��6c   $��
240 30 0 0q�6o   $��calibri)�6�   $��14(�6�   $��1��6�    �� 
IsEditable . 6�   �� 5   
   -
   5        $	��Top=�5      $��Right=�6)   $��30��6E   $	��100��6Q   $��1��6]   $��	0 30 50 0q�6m   $��calibri)�6�   $��14(�6�   ���#257
��� ���.��6�   SHOW6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��Payment_Grid��5      $	��400��6'   $	��530��64   $��1��6@   
������    AlternatingRowBackground
 �����   AutoGenerateColumns .     Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$          Trip Number��6D      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
tripnumber+6q     5"      $          Payment   (%)��6A   $	 150 6a    6%   �� *	payment+6p     5#      $          Amount��6@   $	 150 6Y    6%   �� *amount+6h   4  .System.Windows.Controls.DataGridTemplateColumn  5$      $      Select��6)   $ 75 6>   	   CellTemplate	 5%      �� 5&      .R�5'      �� 6*   5(      5*      5,      5-      5.      
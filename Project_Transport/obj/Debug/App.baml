   M S B A M L   `   `   `  ����L  HProject_Transport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Project_TransportProject_Transport  5          Project_Transport.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      1localclr-namespace:Project_Transport     5        �� 	Resources  5       �� 
TargetType �� Property �� Value �� ElementName �� Path �� Triggers P� Property P� Value	 �� RelativeSource
 �� 
TargetType �� Triggers �� 
TargetName��%  '��       '�� S    '_� �    �� 5   
   " ��6   .�5	      ��  �@=�ErrorTemplate 5
      �� 5      .R�5      ]� ��. .+�5      �� $	��Top=�6(   
����  �$��5q�5   (   $
��12pt(�5   (   ��5   (   �� $ 	MyAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5      �� 5      
���  ��$��3q�67   ._�5   "   �� $��	MyAdorner��6<   5      5      5      5       5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 5      �� 	 �� *Self+$) #(Validation.Errors)[0].ErrorContent�5    F   5!      5#      �� 5&   
   " ��6   .�5'      ��  �@=�ErrorTemplate 5(      �� 5)      .R�5*      ]� ��. .+�5+      �� $	��Top=�6(   
����  �$��5q�5-   (   $
��12pt(�5.   (   ��5/   (   �� $ 	MyAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�51      �� 52      
���  ��$��3q�67   ._�53   "   �� $��	MyAdorner��6<   54      56      57      59       5:      P� 5;       �@=�HasError . . �5<      ��  �@�ToolTip 5=      �� 	 �� *Self+$) #(Validation.Errors)[0].ErrorContent�5>   F   5?      5A      �� 5B   
   " _�6   .�5C      ��  �@�OverridesDefaultStyle . 6E   �� 5D       �@_�HasDropShadow . 6.   �� 5E       � �� 5F      �� 5G      "
 _�6&   .R�5H      �� $��Border��6!   
�������
����  �$��1q�6V   #��z��6j   #��z��6�   ._�5I      �� $��4q�6/   $
��Left=�6:   $	��Top=�6U   6o   5J       5K      P� 5L       �@_�HasDropShadow . . �5M   "   �� $ Border��6)    �@��CornerRadius$ 4��6U   6a   �� 5N   "   $ Border��6)    �@J�SnapsToDevicePixels . 6\   5O      5Q      5S      5T      5U      5V      
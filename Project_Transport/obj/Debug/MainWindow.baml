   M S B A M L   `   `   `  ����C  ?WpfTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5(clr-namespace:WpfTools;assembly=WpfToolsWpfTools  5   
   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   L HProject_Transport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Project_TransportProject_Transport 5   	   "   Project_Transport.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5   	   R	 NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml  	   5   	   @d2http://schemas.microsoft.com/expression/blend/2008  	   5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006  	   5   	   =WpfTools(clr-namespace:WpfTools;assembly=WpfTools  	   5   
   7date&clr-namespace:System;assembly=mscorlib  	   5   	   J
 FWpfAnimatedGif, Version=1.4.14.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com 
 5   
   +localclr-namespace:Project_Transport 
 5   	   -   5        " 
 WpfAnimatedGif.ImageBehavior    AnimateInDesignMode  .  � Title$ ProZ Solutions��5   	   $	��700��6    $
��1250��6-    � WindowStartupLocation$ Manual=�6:   
 � Top$ 10��6Y    � Left$ 10��6b    � Icon$% Resources/Icon/ProZ_72 x 72.ico��6l   ��5      �� 5   
    �� ImageSource$' !/Resources/Images/background2.jpg��6   6G   .��5      � .+�5   
   �� -   5         ��Name$ 
Title_Name��5      $��50��6$   $	��900��60   $��
0,-620,0,0q�6U   $��CAMBRIA)�6i   $��28(�6~   $��Center=�6�   
�������$��	ExtraBold"�6�   6�   �� 5   
   -   5        $ 	User_Name��5      $��40��6#   $	��160��6/   $��1080,-580,0,0q�6T   $��CAMBRIA)�6k   $��16(�6�   $��Center=�6�   
��� ���$��	ExtraBold"�6�   $	��Top=�6�   6�   +  %System.Windows.Controls.Ribbon.Ribbon  5   
   -   5          Name$ ribbon��5      $��50��6!   $��
0,-500,0,0q�6-   	   IsMinimized	 . ���	#FFF9E9B4
   FocusedBackground
 5      �� 5       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5      �  � Color$ 	#FFFEFBF4��6#    � Offset$ 0Q�65   � 5      $ 	#FFFDE7CE��6#   $
 0.19Q�65   � 5      $ 	#FFFDDEB8��6#   $
 0.39Q�65   � 5      $ 	#FFFFCE6B��6#   $
 0.39Q�65   � 5      $ 	#FFFFDE9A��6#   $
 0.79Q�65   � 5      $ 	#FFECD897��6#   $ 1Q�65   5         ApplicationMenu 5       :  4System.Windows.Controls.Ribbon.RibbonApplicationMenu  5"      $��Right=�6(   $��Expanded&�6�   $	��150��6�   $��30��6�   
����  � J� RenderTransformOrigin$ 
0.38,0.525&�6  $��80(�65  5  /System.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource 6L      WpfTools.ImageFromFont     
FontFamily$9 3/Project_Transport;component/Resources/#FontAwesome)�   Text$	 ��   Brush
 � ���.@�5#      >  8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   5        $��SIGN-OUT��5#   0   $��40��6�   $	��150��6�   
�������$��16(�6  3  -System.Windows.Controls.Ribbon.RibbonMenuItem   ImageSource 6B     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6    5$      -   5        $
��EXIT��5$   0   $��40��6�   $	��150��6�   
�������$��16(�6   6>     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6  5&      .@�5+      .  (System.Windows.Controls.Ribbon.RibbonTab  $��VECHICLE DETAILS��6   $��CAMBRIA)�64   .@�5,      0	  *System.Windows.Controls.Ribbon.RibbonGroup	  $	��170��6   .@�5-      1
  +System.Windows.Controls.Ribbon.RibbonButton
  -   5        $��70��5-   #   $	��140��6/    
  Label$ NEW VEHICLE��6;   $��cambria)�6O   $��18(�6d   $��Center=�6�   $��Center=�6�   $
��Bold"�6G  $��Expanded&�6Y   
  LargeImageSource 6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6r  5.      	  50      $	��170��6   .@�51      
  -   5        $��70��51   #   $	��140��6/   $ UPDATE��6;   $��cambria)�6J   $��18(�6_   $
��Bold"�6m   $��Expanded&�6   $��Center=�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6M  52      	  54      $	��170��6   .@�55      
  -	   5        $��70��55   #   $	��140��6/   $
 VIEW��6;   $��cambria)�6I   $��18(�6^   $
��Bold"�6l   $��Expanded&�6~   $��Center=�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6Q  56      	  57      $	��170��6   .@�58      
  -
   5        $��70��58   #   $	��140��6/   $ REPORT��6;   $��cambria)�6K   $��18(�6`   $
��Bold"�6n   $��Expanded&�6�   $��Center=�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6S  59      5:        5;      $��DIESEL ENTRY��6   $��CALIBRI)�6.   .@�5<      	  $	��170��6   .@�5=      
  -   5        $��70��5=   #   $	��140��6/   $ 
CARD ENTRY��6;   $��cambria)�6O   $��18(�6d   $
��Bold"�6r   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6B  5>      	  5?      $	��170��6   .@�5@      
  -   5        $��70��5@   #   $	��140��6/   $ 	CARD EDIT��6;   $��cambria)�6N   $��18(�6c   $
��Bold"�6q   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6@  5A      	  5B      $	��170��6   .@�5C      
  -   5        $��70��5C   #   $	��140��6/   $ DEPOSIT ENTRY��6;   $��cambria)�6R   $��18(�6g   $
��Bold"�6u   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6A  5D      	  5G      $	��170��6   .@�5H      
  -   5        $��60��5H   #   $	��140��6/   $
 VIEW��6;   $��cambria)�6H   $��18(�6]   $
��Bold"�6k   $��Expanded&�6}    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �65  5I      5J        5K      $��
TRIP ENTRY��6   $��CALIBRI)�6,   .@�5L      	  $	��170��6   .@�5M      
  -   5        $��70��5M   #   $	��140��6/   $ 	LPG ENTRY��6;   $��cambria)�6M   $��18(�6b   $
��Bold"�6p   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �69  5N      	  5O      $	��170��6   .@�5P      
  -   5        $��70��5P   #   $	��140��6/   $ 
LPG UPDATE��6;   $��cambria)�6N   $��18(�6c   $
��Bold"�6q   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6;  5Q      	  5R      $	��170��6   .@�5S      
  -   5        $��70��5S   #   $	��140��6/   $ LPG VIEW��6;   $��cambria)�6L   $��18(�6a   $
��Bold"�6o   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �67  5T      	  5V      $	��170��6   .@�5W      
  -   5        $��70��5W   #   $	��140��6/   $ 
LOAD ENTRY��6;   $��cambria)�6N   $��18(�6c   $
��Bold"�6q   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �69  5X      	  5Y      $	��170��6   .@�5Z      
  -   5        $��70��5Z   #   $	��140��6/   $ LOAD UPDATE��6;   $��cambria)�6O   $��18(�6d   $
��Bold"�6r   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6<  5[      	  5\      $	��170��6   .@�5]      
  -   5        $��70��5]   #   $	��140��6/   $ 	LOAD VIEW��6;   $��cambria)�6M   $��18(�6b   $
��Bold"�6p   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �69  5^      5_        5a      $��DRIVER DETAILS��6   $��CALIBRI)�60   .@�5b      	  $	��170��6   .@�5c      
  -   5        $��70��5c   #   $	��140��6/   $ 
NEW DRIVER��6;   $��cambria)�6N   $��18(�6c   $
��Bold"�6q   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6@  5d      	  5e      $	��170��6   .@�5f      
  -   5        $��60��5f   #   $	��140��6/   $ UPDATE��6;   $��cambria)�6J   $��18(�6_   $
��Bold"�6m   $��Expanded&�6    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �69  5g      	  5h      $	��170��6   .@�5i      
  -   5        $��60��5i   #   $	��140��6/   $ PAYMENT��6;   $��cambria)�6K   $��18(�6`   $
��Bold"�6n   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6;  5j      	  5k      $	��170��6   .@�5l      
  -   5        $��70��5l   #   $	��150��6/   $ LOAD PAY��6;   $��cambria)�6L   $��18(�6a   $
��Bold"�6o   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6:  5m      	  5n      $	��170��6   $��Center=�6*   .@�5o      
  -   5        $��60��5o   #   $	��140��6/   $
 VIEW��6;   $��cambria)�6H   $��18(�6]   $
��Bold"�6k   $��Expanded&�6}    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �65  5p      5q        5r      $��MAINTENANCE��6   $��CALIBRI)�6-   .@�5s      	  $	��170��6   .@�5t      
  -   5        $��70��5t   #   $	��160��6/   $ BODY BUILDER��6;   $��cambria)�6P   $��18(�6e   $
��Bold"�6s   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6C  5u      	  5v      $	��170��6   .@�5w      
  -   5        $��70��5w   #   $	��160��6/   $ 
ELECTRICAL��6;   $��cambria)�6N   $��18(�6c   $
��Bold"�6q   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6?  5x      	  5y      $	��170��6   .@�5z      
  -   5        $��70��5z   #   $	��160��6/   $ TRAILER/TANK��6;   $��cambria)�6P   $��18(�6e   $
��Bold"�6s   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6C  5{      	  5|      $	��170��6   .@�5}      
  -   5        $��70��5}   #   $	��160��6/   $ SHOP PURCHASE��6;   $��cambria)�6Q   $��18(�6f   $
��Bold"�6t   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6<  5~      	  5      $	��170��6   .@�5�      
  -   5        $��70��5�   #   $	��160��6/   $ 
MECHANICAL��6;   $��cambria)�6N   $��18(�6c   $
��Bold"�6q   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6?  5�      	  5�      $	��170��6   .@�5�      
  -   5        $��70��5�   #   $	��160��6/   $ OTHERS��6;   $��cambria)�6J   $��18(�6_   $
��Bold"�6m   $��Expanded&�6    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �67  5�      	  5�      $	��170��6   .@�5�      
  -    5        $��70��5�   #   $	��160��6/   $ 	BILL VIEW��6;   $��cambria)�6M   $��18(�6b   $
��Bold"�6p   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6D  5�      5�        5�      $��TYRE MAINTENANCE��6   $��CALIBRI)�62   .@�5�      	  $	��170��6   .@�5�      
  -!   5        $��70��5�   #   $	��140��6/   $	 LPG��6;   $��cambria)�6G   $��18(�6\   $
��Bold"�6j   $��Expanded&�6|    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �67  5�      	  5�      $	��170��6   .@�5�      
  -"   5        $��70��5�   #   $	��140��6/   $
 LOAD��6;   $��cambria)�6H   $��18(�6]   $
��Bold"�6k   $��Expanded&�6}    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �69  5�      	  5�      $	��170��6   .@�5�      
  -#   5        $��70��5�   #   $	��140��6/   $ TRAILER��6;   $��cambria)�6K   $��18(�6`   $
��Bold"�6n   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6?  5�      	  5�      $	��170��6   .@�5�      
  -$   5        $��70��5�   #   $	��140��6/   $ 
TYRE PRICE��6;   $��cambria)�6N   $��18(�6c   $
��Bold"�6q   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6>  5�      5�        5�      $��SETTINGS��6   $��CALIBRI)�6*   .@�5�      	  $	��170��6   .@�5�      
  -%   5        $��70��5�   #   $	��160��6/   $ TRANSPORT NAME��6;   $��cambria)�6R   $��18(�6g   $
��Bold"�6u   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6B  5�      	  5�      $	��170��6   .@�5�      
  -&   5        $��70��5�   #   $	��160��6/   $ TRANSPORT LIST��6;   $��cambria)�6R   $��18(�6g   $
��Bold"�6u   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6G  5�      	  5�      $	��170��6   .@�5�      
  -'   5        $��70��5�   #   $	��160��6/   $ USER CREATION��6;   $��cambria)�6Q   $��18(�6f   $
��Bold"�6t   $��Expanded&�6�    6�     $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6E  5�      5�      5�      �� 5�   
   -(   5         ��Name$ LOGIN_PANEL��5�   @   $	��670��6   $
��1250��6"   $��0,0,0,0q�6/   .+�5�      �� -)   5        $��30��5�      $	��100��6    $��
-900,0,0,0q�6,   
������ 6�   �� 5�      -*   5        $��login_panel��5�   F   $	��460��6   $
��AUTO��6&   $��0,30,0,0q�64   ���	#FFF7D1F6$y�Visible=�6p   .+�5�      �� -+   5        $��
today_date��5�      $��35��6*   $	��150��66   $��	780,0,0,0q�6B   $��cambria)�6U   $��18(�6j   
����  �6�   �� 5�      -,   5        $��time_now��5�      $��35��6(   $	��150��64   $��1080,-35,0,0q�6@   $��cambria)�6V   $��18(�6k   
����  �6�   �� 5�      $��35��6   $	��295��6$   $��
900,20,0,0q�60   $��MANAGE YOUR VEHICLES��6D   $��
CONSTANTIA)�6c   $��16(�6{   
���� ��
�������$��Center=�6�   $
��Bold"�6�   $��Center=�6�   6  �� 5�      --   5        $��	error_lbl��5�      $��30��6)   $	��200��65   $��1000,15,0,0q�6A   
���  ��$	��Top=�6g   6�   �� 5�      $��35��6   $	��150��6$   $��
650,-5,0,0q�60   $��Right=�6D   $��Center=�6g   $��USER NAME :��6�   $��CALIBRI)�6�   $��20(�6�   
���   �6�   �� 5�      -.   5        $��user_name_txt��5�       �� CharacterCasing$ Upper=�6/   $��35��6G   $	��200��6S   $��1020,-35,0,0q�6_   $��Center=�6u   $��Center=�6�   6�   �� 5�      $��35��6   $	��150��6$   $��
650,10,0,0q�60   $��Right=�6D   $��Center=�6g   $��
PASSWORD :��6�   $��CALIBRI)�6�   $��20(�6�   
���   �6�   G� 5�      -/   5        $��user_password_txt��5�      $��35��67   $	��200��6C   $��1020,-35,0,0q�6O   $��Center=�6e   $��Center=�6�   6�   �� 5�      -0   5        $��sign_in_btn��5�      $��40��6,   $	��180��68   $��1000,20,0,0q�6D   ��5�      �� 5�      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5�      � $ 	#FF1294EE��6+   $ 0.614Q�6=   � 5�      $ White��6+   5�      .��5�      �� $��45��6!   $	��175��6-   .+�5�      �� $��40��6    $��80��6,   $��	-50,0,0,0q�67   $��GET-IN��6J   $��CALIBRI)�6[   $��22(�6p   
�������$��Center=�6�   6�   �� 5�      $��35��6�   $��60��6�   $��100,-35,0,0q�6�   ��6      $9 3/Project_Transport;component/Resources/#FontAwesome)�$	 ��
 �   �6�   5�      5�      �� 5�      -1   5        $��panel0��5�      $	��450��6+   $	��850��68   $��-380,-270,0,0q�6D   .+�5�      �� -2   5        $	��img��5�      $��Resources/Images/lpg.jpg��6'   $
��Fill=�6I   $	��440��6X   6g   5�      �� 5�      -3   5        $��panel1��5�      $	��450��6+   $	��850��68   $��-380,-450,0,0q�6D   .+�5�      �� -4   5        $
��img1��5�      $��Resources/Images/daf.jpg��6(   $
��Fill=�6J   $	��440��6Y   6h   5�      �� 5�      -5   5        $��panel2��5�      $	��450��6+   $	��850��68   $��-380,-450,0,0q�6D   .+�5�      �� -6   5        $
��img2��5�      $ ��Resources/Images/truck.jpg��6(   $
��Fill=�6L   $	��440��6[   6j   5�      �� 5�      -7   5        $��panel3��5�      $	��450��6+   $	��850��68   $��-380,-450,0,0q�6D   .+�5�      �� -8   5        $
��img3��5�      $#��Resources/Images/hd-truck.jpg��6(   $
��Fill=�6O   $	��440��6^   6m   5�      �� 5�      -9   5        $��panel4��5�      $	��450��6+   $	��850��68   $��-380,-450,0,0q�6D   .+�5�      �� $��60��6   $	��200��6(   $��0,0,0,0q�64   6G   5�      �� 5�      -:   5        $��Expiry_Warning��5�      $��30��6.   $	��120��6:   $��750,-30,0,0q�6F   $��EXPIRY WARNING��6[   $��14(�6t   ���	#FF40D8286�   �� 5�      -;   5        $��Driving_Licence_Expiry��5�      $��30��66   $	��130��6B   $��1050,-30,0,0q�6N   $��DRIVING LICENCE��6d   $��14(�6~   ���	#FF49E2316�   5�      �� 56     -<   5        $��title_panel��56     $	��150��6,   $	��400��69   $��
0,-900,0,0q�6E   ���	#FFF9ECEC$y�Hidden=�6p   .+�57     �� $��30��6   $��50��6$   $��-300,30,0,0q�6/   $
��NAME��6D   6U   �� 58     -=   5        $��
title_name��58     $��30��6,   $	��300��68   $��
50,-40,0,0q�6D   $ Upper=�6X    �� 	MaxLength$ 31��6p   .��6�   ��59     �� 5:      �� Path$
 Name�6"    �� UpdateSourceTrigger$ PropertyChanged=�6.    �� ValidatesOnDataErrors .  �� Mode$ TwoWay=�6q     �� ValidationRules  5;     .  (Project_Transport.CharacterWithSpaceRule  5<  "   6A   5>     .��5?  $   5@     �� 5A     $��25��6   $	��300��6$   $��50,0,0,0q�60   $��Allow 30 Characters Only��6B   $��Right=�6e   6�   �� 5B     ->   5        $��30��5B     $	��100��6%   $��
100,10,0,0q�61   $
��SAVE��6E   $��CALIBRI)�6T   $��18(�6i   ���#F988006�   �� 5C     -?   5        $��30��5C     $��70��6%   $��320,-30,0,0q�60   ���	#FF463A55$
��BACK��6\   
�������$��CAMBRIA)�6~   6�   5D     5F     '  !Project_Transport.Vehicle_Details  5G  
   -@   5        !  Name$! vehicle_panel��5G      $y�Hidden=�67   6M   #  Project_Transport.Diesel_Card  5H  
   -A   5        "  Name$" diesel_panel��5H     $y�Hidden=�62   6H   &   Project_Transport.Driver_Details  5I  
   -B   5        #  Name$# driver_panel��5I     $y�Hidden=�65   6K   "  Project_Transport.Trip_Entry  5J  
   -C   5        $  Name$$ trip_entry_panel��5J     $y�Hidden=�65   6K   #  Project_Transport.Trip_Update  5K  
   -D   5        %  Name$% trip_update_panel��5K     $y�Hidden=�67   6M   !  Project_Transport.Trip_View  5L  
   -E   5        &  Name$& trip_view_panel��5L     $y�Hidden=�63   6I   (  "Project_Transport.Body_Maintenance  5M  
   -F   5        '  Name$' body_expense��5M  !   $y�Hidden=�67   6M   /  )Project_Transport.Electrician_Maintenance  5N  
   -G   5        (  Name$( electrician_panel��5N  (   $y�Hidden=�6C   6Y   (  "Project_Transport.Tank_Maintenance  5O  
   -H   5        )  Name$) 
tank_panel��5O  !   $y�Hidden=�65   6K   $  Project_Transport.Shop_Expense  5P  
   -I   5        *  Name$* 
shop_panel��5P     $y�Hidden=�61   6G   *  $Project_Transport.Mechanical_Expense  5Q  
   -J   5        +  Name$+ mechanical_panel��5Q  #   $y�Hidden=�6=   6S   %  Project_Transport.Other_Expense  5R  
   -K   5        ,  Name$, other_panel��5R     $y�Hidden=�63   6I   (  "Project_Transport.Maintenance_view  5S  
   -L   5        -  Name$- maintenance_view_panel��5S  !   $y�Hidden=�6A   6W   (  "Project_Transport.Tyre_Maintenance  5T  
   -M   5        .  Name$. 
tyre_panel��5T  !   $y�Hidden=�65   6K   "  Project_Transport.Baner_name  5U  
   -N   5        /  Name$/ baner��5U     $y�Hidden=�6*   6@   ,  &Project_Transport.transport_list_Panel  5V  
   -O   5        0  Name$0 transport_list��5V  %   $y�Hidden=�6=   6S   $  Project_Transport.Vehicle_View  5W  
   -P   5        1  Name$1 vehicle_view��5W     $y�Hidden=�63   6I   (  "Project_Transport.Diesel_Card_View  5X  
   -Q   5        2  Name$2 diesel_card_view��5X  !   $y�Hidden=�6;   6Q   +  %Project_Transport.Diesel_Card_Deposit  5Y  
   -R   5        3  Name$3 diesel_card_deposit��5Y  $   $y�Hidden=�6A   6W   (  "Project_Transport.Diesel_Card_Edit  5Z  
   -S   5        4  Name$4 diesel_card_edit��5Z  !   $y�Hidden=�6;   6Q   &    Project_Transport.Driver_Payment   5[  
   -T   5        5   Name$5 driver_salary��5[     $y�Hidden=�66   6L   #!  Project_Transport.Driver_View!  5\  
   -U   5        6 ! Name$6 driver_view��5\     $y�Hidden=�61   6G   %"  Project_Transport.Driver_Update"  5]  
   -V   5        7 " Name$7 driver_update��5]     $y�Hidden=�65   6K   &#   Project_Transport.Vehicle_Update#  5^  
   -W   5        8 # Name$8 vehicle_update��5^     $y�Hidden=�67   6M   %$  Project_Transport.Profit_Viewer$  5_  
   -X   5        9 $ Name$9 profit_viewer��5_     $y�Hidden=�65   6K   $%  Project_Transport.UserCreation%  5`  
   -Y   5        : % Name$: user_create��5`     $y�Hidden=�62   6H   &  Project_Transport.tyre&  5a  
   -Z   5        ; & Name$; tyre_report��5a     $y�Hidden=�6*   6@   $'  Project_Transport.Load_Trailer'  5b  
   -[   5        < ' Name$< load_trailer��5b     $y�Hidden=�63   6I   .(  (Project_Transport.Load_Trailer_Trip_View(  5c  
   -\   5        = ( Name$= load_trailer_view��5c  '   $y�Hidden=�6B   6X   $)  Project_Transport.Load_Payment)  5d  
   -]   5        > ) Name$> load_pay��5d     $y�Hidden=�6/   *  Project_Transport.Update*  5e  
   -^   5        ? * Name$? load_update��5e     $y�Hidden=�6,   *+  $Project_Transport.Trailer_Tyre_Entry+  5f  
   -_   5        @ + Name$@ trailer_tyre��5f  #   $y�Hidden=�69   6O   !,  Project_Transport.load_tyre,  5g  
   -`   5        A , Name$A 	load_tyre��5g     $y�Hidden=�6-   6C   5h     5j     
   M S B A M L   `   `   `  ����E  ABookReview, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BookReview
BookReview  5   	       BookReview.LoginWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BookReview     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  LoginWindow��5	   	   $	��450��6   $	��360��6*    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      �� $��1q�6   
���   � �� CornerRadius$ 10��6=   $��2��6O   ��5      �� 5      .��5      �  � Color$ #1287A8��6'    � Offset$	 0.0Q�67   � 5      $ #107896��6'   $ 1Q�67   5      ._�5      �� -   5         ��Name$ ExitBtn��5      $��X��6*   $��326,2,2,416q�66   $��30��6K   $��30��6V   6b   5      �� 5       $��Center=�6   .+�5!      �� $��/Images/Open_book.png��6   $��80��67   �� 5"      $��Book Review��6   $��Light"�5#      $��	helvetica)�5$      $��22(�5%      
�������$��Center=�5'      5(      �� 5)      $��1��6   .+�5*      �� 	 �� Orientation$	 
Horizontal=�6   .+�5+      �� -   5        
 ��Name$
 EmailTB��5+      $��	Helvetica)�6/   $��Light"�5,      $��Email Address��5-      $��20(�5.      $��Center=�5/      
�������
������ $��0q�52      $	��235��53      $
��Left=�54       J� Opacity$	 0.5Q�55      $��25��56      $��55,0,0,0q�57      .  (MahApps.Metro.IconPacks.PackIconMaterial  58         Kind$ Account=�61   $��Center=�59   1   $��Center=�5:   1   
�������5;   1   5<      �� 5=      $	��250��6   $��2��5>      
�������$	 0.5Q�5@      �� 5D      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�5E      G� -   5         G�Name$ 
PasswordTB��5E   "   $��	Helvetica)�66   $��Light"�5F       G� Password$ Password��5G      $��20(�5H      $��Center=�5I      
�������
������ $��0q�5L      $	��235��5M      $
��Left=�5N      $	 0.5Q�5O      $��25��5P      $��55,0,0,0q�5Q        5R      $ FormTextboxPassword=�61   $��Center=�5S   1   $��Center=�5T   1   
�������5U   1   5V      �� 5W      $	��250��6   $��2��5X      
�������$	 0.5Q�5Z      �� 5]      $	 
Horizontal=�6   $��0,50,0,0q�66   .+�5^      �� -   5        $ LoginBtn��5^      $	��100��6/   $��40��6;   $��LOGIN��6G   $��	51,0,60,0q�6W   6j   �� 5_      -   5        $ RegisterBtn��5_      $	��100��62   $��40��6>   $��REGISTER��6J   6]   5`      5b      5c      5d      5e      
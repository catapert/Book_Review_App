   M S B A M L   `   `   `  ����E  ABookReview, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BookReview
BookReview  5   	       BookReview.CommentsWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BookReview     5   	   -   5          � Title$  CommentsWindow��5   	   $	��700��6    $	��530��6-    � AllowsTransparency$
 True��5	   	   
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �� $��1q�6   
���   � �� CornerRadius$ 10��69   $��2��6K   ��5      �� 5      .��5      �  � Color$ #1287A8��6#    � Offset$	 0.0Q�63   � 5      $ #107896��6#   $ 1Q�63   5      ._�5      �� -   5         ��Name$ ExitBtn��5      $��X��6&   $
��Left=�62   $��30��6M   $��	497,3,0,0q�6Y   $	��Top=�6l   $��30��6�   6�   5      �� 5   
   $��4q�6   $	��Top=�6    $
��Left=�68   .+�5      �� $��/Images/Open_book.png��6   $��80��63   �� 5      $��Book Review��6   $��Light"�5      $��	helvetica)�5      $��22(�5      
�������$��Center=�5      5      �� 5    
   -   5         ��Name$ 
CommentsLB��5       $��Center=�6&   $	��260��6C   $��	0,160,0,0q�5!      $	��Top=�6%   $	��522��6=   $��Light"�5#      $��	helvetica)�5$      
�������$��12(�5&      ��5"      Z� 	 � 	Resources	 5'      
 �� 
TargetType �� Property �� Value��%^   '��       �� 5(      "
 ��6   .�5)      ��  �@��CornerRadius$ 5��65   5*      5+      ��5,      �� 5-      "
 ��6    �� 	Resources 5.      ��%^   '��       �� 5/      "
 ��6    .�50      ��  �@��CornerRadius$ 5��6=   51      52      53      55      �� 56   
   -   5        $ 	InsertBtn��56      $��Insert��6$   $
��Left=�65   $��40��6P   $��428,505,0,0q�6\   $	��Top=�6q   $��84��6�   6�   �� 57   
   -   5        $ 	UpdateBtn��57      $��Update��6$   $
��Left=�65   $��40��6P   $��428,550,0,0q�6\   $	��Top=�6q   $��84��6�   6�   �� 58   
   -   5        $ 	DeleteBtn��58      $��Delete��6$   $
��Left=�65   $��40��6P   $��428,595,0,0q�6\   $	��Top=�6q   $��84��6�   6�   �� 59   
   -   5         ��Name$ 	CommentTB��59      $
��Left=�6%   $	��130��6@   $��
25,505,0,0q�5:      $�� ��6!    �� TextWrapping$
 Wrap=�5;      $	��Top=�6!   $	��398��5<      
�������
������ $��	Helvetica)�5?      $��Light"�5@      $��20(�5A      �� 5B   
   $��Comment:��6   $
��Left=�6#   $��35��5C      $��
25,470,0,0q�6   $	��Top=�6-   $��95��5D      
�������
������ $��	Helvetica)�5G      $��Light"�5H      $��20(�5I      5J      5K      
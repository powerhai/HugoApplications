   M S B A M L   `   `   `  ����H  DJinsonShopper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Sagua.Jinson.Shopper.CommonSagua.Jinson.Shopper.Common  5      =    7Sagua.Jinson.Shopper.Modules.Server.ServerWorkSpaceView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <common)clr-namespace:Sagua.Jinson.Shopper.Common     5      X TXceed.Wpf.Toolkit, Version=2.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��40 �6   �� 5      $��5 �6   �� 5      $��40 �6   �� 5      $��5 �6   �� 5      $
��233* �6   .+�5   
   ��    LabelHeaderStyle#��[  6   .��6:   	服务器6?   �� 5   
   
�������$��2��6)    �� CornerRadius$ 5��66    �� Padding$ 10q�6G   ._�5      � $��Center=�6    � ColumnDefinitions 5      �� 5      $��Auto  �6'   �� 5      $��5 �6'   �� 5      $��1* �6'   �� 5      $��5 �6'   �� 5      $��10 �6'   �� 5      $��5 �6'   �� 5      $	��100 �6'   �� 5      $��5 �6'   �� 5      $��70 �6'   .+�5!      �� $��0��6   服务器网址63   �� 5"      $��2��6   ��6+   �� *WorkForm.Url+6K   �� 5$      $��6��6    d� 	IsChecked 6,   �� *WorkForm.IsOpenning+.��6V   对外开放6\   �� 5%      $��8��6   ��6)   ��  �� Path$ AddServerCommand�.��6T   添加6X   5&      5'      �� 5(   
   $��4��6   ��6    �� *	Servers+ �� View 5)      �� 5*      .P�5+      �� $��网址��6%    �� Width$	 400��61    �� DisplayMemberBinding 6=   �� *Url+�� 5,      $��状态��6%   $ 60��61   	 �� CellTemplate	 5-      �� 5.      .R�5/   "   A� 
 A�Name$

 T_ZT��6*   $��20��68   $��20��6D   
��� � �6_    �� Triggers 51   "   �� 52   &    �� Value$ False��6O    �� Binding 62   �� *
IsEnable+.a�53   *   ��  �� 
TargetName$
 T_ZT��61    �� Property � �� �� Value
 �  ��6a   54   '   56      58      �� 59      $��开放��6%   $ 60��61   	 5:      �� 5;      .R�5=   "   A� $

 T_ZT��6*   $��20��68   $��20��6D   
��� � �6_    5>   "   �� 5?   &   $ False��6Q    62   �� *
IsOpenning+.a�5@   *   �� $
 T_ZT��61    � ��
 �  ��6a   5A   '   5C      5E      �� 5F      $
 auto��6%   	 5G      �� 5H      .R�5I   "   �  5J   &   �� 5K   *   $��30 �6;   6H   �� 5L   *   $��5 �6;   6G   �� 5M   *   $��30 �6;   6H   .+�5O   &   �� $��0��60   y�6@   �� *
IsOpenning+ $  Bool2InvertedVisibilityConverter �� 	Converter# [ �� 6�    �� Command 6�   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ UserControlL�$&  DataContext.SetOpenServerCommand� �� CommandParameter 6/  �� *.+.�6O  �� $�开放��6S  6_  6e  6q  �� 5P   &   $��0 ��60   y�6A   �� *
IsOpenning+  Bool2VisibilityConverter# [ �� 6�    6�   ��  �� $ FindAncestor=�$ UserControlL�$' !DataContext.SetCloseServerCommand� 6*  �� *.+.�6J  �� $�关闭��6N  6Z  6`  6l  �� 5Q   &   $��2��60   �� 6A    6K   ��  �� $ FindAncestor=�$ UserControlL�$" DataContext.DelServerCommand� 6�   �� *.+.�6�   �� $�删除��6�   6�   6  6  5R   #   5S      5U      5V      5X      5Y      5Z      
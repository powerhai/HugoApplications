   M S B A M L   `   `   `  ����H  DJinsonShopper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Sagua.Jinson.Global.DomainSagua.Jinson.Global.Domain  5      ?    9Sagua.Jinson.Shopper.Modules.Mission.MissionWorkSpaceView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=2.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f47toolkit)http://schemas.xceed.com/wpf/xaml/toolkit  5      5domain(clr-namespace:Sagua.Jinson.Global.Domain  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��40 �6   �� 5      $��5 �6   �� 5      $��70 �6   �� 5      $��5 �6   �� 5      $
��233* �6   .+�5   
   ��    LabelHeaderStyle#��[  6   .��6:   任务6>   �� 5   
   
�������$��2��6)    �� CornerRadius$ 5��66    �� Padding$ 10q�6G   ._�5      � $��Center =�6     5      �� 5      �� 5      $��10 �6$   �� 5       � ColumnDefinitions 5      �� 5      $��Auto  �6'   �� 5      $��5 �6'   �� 5      $��2* �6'   �� 5      $��10 �6'   �� 5!      $
��Auto �6'   �� 5"      $��5 �6'   �� 5#      $��2* �6'   �� 5$      $��10 �6'   �� 5&      $
��Auto �6'   �� 5'      $��5 �6'   �� 5(      $��1* �6'   �� 5)      $��10 �6'   �� 5+      $
��Auto �6'   �� 5,      $��5 �6'   �� 5-      $��1* �6'   �� 5.      $��10 �6'   �� 50      $��70 �6'   .+�52      �� $��0��6   开始日期63   &   Xceed.Wpf.Toolkit.DateTimeUpDown  53      $��2��6)      Format$ 	ShortDate=�69   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 6L   �� *Form.StartDate+6o   �� 54      $��4��6   初始数量63   %  Xceed.Wpf.Toolkit.IntegerUpDown  55      $��6��6(   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 68   �� *Form.StartCount+6\   �� 57      $��8��6   持续天数63     58      $��10��6)    6:   �� *Form.DayCount+6\   �� 5:      $��12��6   日增长（%）66   %  Xceed.Wpf.Toolkit.DecimalUpDown  5;      $��14��6(   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 69   �� *Form.DayRise+6Z   �� 5=      $��0��6   $��2��6,   店铺6>   �� 5>      $��2��6   $��2��6+   6:   �� 5@      $��4��6   $��2��6,   
宝贝ID6A   �� 5A      $��6��6   $��2��6*   ��67   �� *Form.GoodsId+6W   �� 5C      $��8��6   $��2��6,   任务单价6A     5D      $��10��6)   $��2��6:    6H   �� *
Form.Price+6g   �� 5F      $��16��6   $��3��6*   $��发布任务��6<   ��6K   �� *PublishMissionCommand+6w   5G      5H      �� 5I   
   -   5         ��Name$ 
T_ListView��5I      $��4��6'   ��64   �� *Missions.View+	 �� View	 5J      �� 5K      .P�5L      �� $��日期��6%   
 �� Width$	
 120��61    �� DisplayMemberBinding 6=   �� *Date+ �� StringFormat$ 
yyyy-MM-dd��6}   �� 5M      $��网站��6%   $	
 100��61    6=   �� *
ShopType+  Enum2StringConverter �� 	Converter# [ 6�   �� 5N      $��宝贝ID��6%   $	
 150��63    6?   �� *	GoodsId+6j   �� 5O      $��计划数量��6%   $
 90��63    6>   �� *	PlanCount+6k   �� 5P      $��实际数量��6%   $
 90��63    6>   �� *	RealCount+6k   �� 5Q      $��状态��6%   $	
 150��61    �� CellTemplate 5R      �� 5S      .R�5T   "   ��  ��Name$ T_Status��6,   ��6>   �� *
TaskStatus+# [ 6�    �� Triggers 5U   "   �� 5V   &   .   (Sagua.Jinson.Global.Domain.BuyTaskStatus   Execute �� Value# Z 6R    �� Binding 63   �� *
TaskStatus+.a�5W   *   ��  �� 
TargetName$ T_Status��61    �� Property � �� �� Value
 ����6s   5X   '   �� 5Y   &      Finish# Z 6R    63   �� *
TaskStatus+.a�5Z   *   �� $ T_Status��61    � ��
 �2�2�6r   5[   '   �� 5\   &      Normal# Z 6R    63   �� *
TaskStatus+.a�5]   *   �� $ T_Status��61    � ��
 �   �6n   5^   '   5`      5b      �� 5e      $

 auto��6%    5f      �� 5g      .R�5h   "   �  5i   &   �� 5j   *   $��30 �6;   6H   �� 5k   *   $��5 �6;   6G   �� 5l   *   $��30 �6;   6H   .+�5n   &   �� $ T_Edit��60   $��0��6C   �� 6T    �� Command 6^   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ UserControlL� �� Path$! DataContext.EditTaskCommand� �� CommandParameter 6�   �� *.+.�6�   �� $�编辑��6  6  6  6   �� 5o   &   $ T_Del��60   $��2��6?   �� 6P    6Z   ��  �� $ FindAncestor=�$ UserControlL�$  DataContext.DelTaskCommand� 6�   �� *.+.�6�   �� $�删除��6�   6
  6  6  5q   #    5r   "   �� 5s   &   # Z 6R    63   �� *
TaskStatus+.a�5t   *   �� $ T_Edit��61    � {� .  6l   �� 5u   *   $ T_Del��61    � {� .  6k   5v   '   �� 5w   &   # Z 6R    63   �� *
TaskStatus+.a�5x   *   �� $ T_Edit��61    � {� .  6k   �� 5y   *   $ T_Del��61    � {� .  6k   5z   '   �� 5{   &   # Z 6R    63   �� *
TaskStatus+.a�5|   *   �� $ T_Edit��61    � {� . 6l   �� 5}   *   $ T_Del��61    � {� . 6k   5~   '   5�      5�      5�      5�      5�      5�      
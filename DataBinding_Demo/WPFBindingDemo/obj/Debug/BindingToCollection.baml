   M S B A M L   `   `   `  ����R  NElementToElementbinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFBindingDemoWPFBindingDemo  5   	   (    "WPFBindingDemo.BindingToCollection   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .localclr-namespace:WPFBindingDemo     5   	     � Title$  BindingToCollection��5   	   $	��400��6%   $	��300��62    � 	Resources 5      "   WPFBindingDemo.DateConverter   dtConverter��%   &	          5   
   6   5	      .��5
      �� $��50q�6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5      �� $��学号:��6   �� 5      $	��100��61   ��6   ��  �� Path$ ID�61   5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $��姓名:��6   �� 5      $	��100��6:   ��6   �� $ StudentName�6:   5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $��分数:��6   �� 5      $	��100��64   ��6   �� $ Score�64   5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $��生日:��6   �� 5      $	��150��6a   ��6   �� $ 	BirthDate� �� 	Converter# [  6a   5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� -   5        $��
changeName��5   $   $��改变姓名��6   66   �� 5      -   5        $��changeScore��5   $   $��改变分数��6   $��20,0,0,0q�67   6I   �� 5      -   5        $��
changeDate��5   $   $��改变日期��6   $��20,0,0,0q�66   6H   5       �� 5!   
   ! �� IsDeferredScrollingEnabled . 6   5"      5#      
   M S B A M L   `   `   `  ����  ElementToElementbinding    WPFBindingDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��400��6)   .��5      �� .+�5   
   �� -   5        $��sliderFontSize��5      $��3q�6'    � Minimum$ 1Q�5       � Maximum$ 40Q�6    � Value$ 10Q�6&    �� TickFrequency$ 1Q�61    �� TickPlacement$ TopLeft=�6C   �� 5   
   -   5        $��lbtext��5   4   $��10q�6   $��LearningHard��6    ��5	      ��  �� ElementName$ sliderFontSize�� �� Path$ Value� �� Mode$ TwoWay=�6_   �� 5   
   	 �� Orientation$	 
Horizontal=�6   .+�5   
   �� -   5        $��10q�5      $��5q�6   .��6>   Set to Small6L   �� 5   
   -   5        $��10q�5      $��5q�6   .��6?   Set to Normal6N   �� 5   
   -   5        $��10q�5      $��5q�6   .��6>   Set to Large6L   5      �� 5   
   $	 
Horizontal=�6   $��5q�6.   .+�5      �� $��Center=�6   Set FontSize:6B   �� 5      -   5        $��txtFontSize��5      $	��100��6�   ��6)   �� $ lbtext��$ FontSize�$ TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   5      5      5      
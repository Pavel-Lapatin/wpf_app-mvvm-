   M S B A M L   `   `   `  ����F  BCoursePaper, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null9!clr-namespace:CoursePaper.DialogsCoursePaper.Dialogs  5   	   %    CoursePaper.Dialogs.GroupDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CoursePaper.Dialogs     5   	     � Title$  Группа��5   	   $	��150��6   $	��300��6%   $	��150��61   $	��300��6A   .��5	      �  � RowDefinitions 5
   
   �� 5      $��2* �6   �� 5      $��1* �6   .+�5   
   �� .��5      �  5      �� 5      $��1* �6$   �� 5      $��1* �6$    � ColumnDefinitions 5      �� 5      $	��89* �6'   �� 5      $
��203* �6'   .+�5      �� $��Родитель��6   $
��Left=�6+   $��	10,10,0,0q�6F   $	��Top=�6Y   $��26��6q   $��61��6}   �� 5      $��Название��6   $
��Left=�6+   $��	10,10,0,0q�6F   $	��Top=�6Y   $��26��6q   $��1��6}   $��63��6�    J� RenderTransformOrigin$ 0.016,0.885&�6�   �� 5      $
��Left=�6   $��23��65   $��9,10,0,0q�6A    �� TextWrapping$
 Wrap=�6S   $��TextBox��6g   $	��Top=�6v   $	��183��6�   $��1��6�   �� 5      $
��Left=�6   $��23��65   $��	10,10,0,0q�6A   $
 Wrap=�6T   $��TextBox��6h   $	��Top=�6w   $	��182��6�   $��1��6�   $��1��6�   5      5      �� 5   
   $��Ok��6   $
��Left=�6   $��
124,10,0,0q�69   $��1��6M   $	��Top=�6Z   $��76��6r   $ 0.441,0.475&�6}   �� 5    
   $��Cancel��6    �� IsCancel . $
��Left=�62   $��
208,10,0,0q�6M   $��1��6a   $	��Top=�6n   $��74��6�   5"      5#      
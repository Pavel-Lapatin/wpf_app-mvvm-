   M S B A M L   `   `   `  ����  CoursePaper-    'CoursePaper.Dialogs.EmployeeLoginDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=3.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xced)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   -   5          �Name$  EmployeeLogWindow��5   R    � Title$  Вход в систему��5   	   $	��350��6    $	��400��60   $	��350��6?   $	��400��6L   
�����_� � DataContext 5   	   �� *EmployeeLoginVM+   Locator �� Source# [   � 	Resources 5       ��Name  LoginAnimation �� 
TargetName �� TargetProperty W� From		 W� To
 g� Duration��%�   &	       �� 5	   
   $ CloseAnimation��6-   .��5
      W� -   5        $
 Info��5
      $ Opacity�6;   $ 0X�5      $	 1X�6'   $
 0:0:3D�5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��2* �6   �� 5      $
��0.1* �6   �� 5      $��2* �6   �� 5      $
��0.5* �6   �� 5      $��2* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��1* �6   .+�5    
   �� $��3��6    �� Orientation$ Vertical=�6)   .+�5!      �� $
��Wrap=�6    �� TextAlignment$ Center=�6,   $��	20,0,20,0q�6^   $��16(�6q   
�������$��Center=�6�   $��Center=�6�   ��6C   �� *	Greetings+6�   5"      �� 5#   
   $��Center=�6   
�������$��1��6C   $��1��6P   $ 
Horizontal=�6`   .+�5$      �� $��Center=�6   $��icons\user.ico��6/   $��33��6G   $��34��6T    J� RenderTransformOrigin$ 0.5,1.21&�6_   (  "Xceed.Wpf.Toolkit.WatermarkTextBox  5%         	Watermark$% Имя Пользователя��6$   $��16(�6}   $��Center=�6�   $��0q�6�   $	��195��6�   ��6A   �� *Login+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5'      �� 5(   
   $��Center=�6   
�������$��3��6C   $��1��6P   $ 
Horizontal=�6`   $��Stretch=�6y   .+�5)      �� $��33��6   $��34��6!   $��Center=�6,   $��icons\lock.ico��6G   $ 0.5,1.21&�6_   ,  &Xceed.Wpf.Toolkit.WatermarkPasswordBox  5*      $ Пароль��6(   $��16(�6{   $��Center=�6�   $��0q�6�   $��Right=�6�   $	��193��6�   ��6;   �� *
Password+$ PropertyChanged=�6�   5-      �� 5.   
   -   5        $��	login_btn��5.      
����iA�$��0q�6[   
�������$��5��6�   $��1��6�   $��LOGIN��6�   $��16(�6�   ��69   �� *LoginToAccess+6�   �� 5/   
   -   5        $
��Info��5/      $��3��68   $��6��6L   $��16(�6Y   $��Center=�6g   $��Center=�6�   
���������6   �� *	InfoBox+6�   51      52      
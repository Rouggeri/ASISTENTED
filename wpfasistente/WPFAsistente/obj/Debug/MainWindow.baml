   M S B A M L   `   `   `  ����G  CWPFAsistente, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPFAsistenteWPFAsistente  5   	       WPFAsistente.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPFAsistente     5   	   -   5          �Name$  window��5   	    � Title$ 
MainWindow��5   	   $��207.576��6   $	��500��6-    J� Opacity$	 0.9Q�69    � AllowsTransparency .  � WindowStyle$
 None=�6a    � WindowStartupLocation$ CenterScreen=�6t    � 	Resources 5	         Storyboard1 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value R� KeyTime R� Value��%V  &	        �� 5
   
   .��5      U� $ (UIElement.Opacity)�6,   $ window��6\   .\�5        $	 0��6'   $
 0Q�63     5      $	 0:0:2��6'   $	
 0.9Q�67   5      T� 5      $ (ContentControl.Content)�6,   $ lbl_reconocimiento��6a   ..�5      i� $ 0:0:2��6)   $ 
BIENVENIDO��69   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6   5      ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ White��6   $ 1Q�6)   5      .��5      �  � ColumnDefinitions 5    
   �� 5!      $��0* �6   �� 5"      .+�5$   
   �� $!��17.575,25.705,22.341,25.757q�6   ���	#FFD32222$��2��6L    �� RadiusY$ 9.781��6`    �� RadiusX$ 9.781��6p   �� 5%   
   -   5         ��Name$ label��5%      $��
ASISTENTE ��6   $��53.03��64   $��192.84,40.909,188.295,0q�6C   $	��Top=�6d   $��20(�6|   $��Center=�6�   $
��Bold"�6�   ���	#FF29E829$��2��6�   �� 5&   
   -   5        $ lbl_reconocimiento��5&      $��
Bienvenido��6,   $��82.917,0,188.296,54.545q�6A   $��20(�6b   ���	#FF112ACD$
��Bold"�6�   $��2��6�   $��40.91��6�   $��Bottom=�6�   � 5'   
   -   5         �Name$ bar_voz��5'      $��2��6'   $��40.91��6;   $��82.917,0,188.296,54.545q�6J   $��Bottom=�6k   
���   � � Value$ 30Q�6�   ���	#FF8E0DE8$	 0.4Q�6�   $��RightToLeft=�6�   ��6�   Z� 6�   5)      5*      
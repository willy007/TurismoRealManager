   M S B A M L   `   `   `  ����G  CHotelManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HotelManager.VentanasHotelManager.Ventanas  5      0    *HotelManager.Ventanas.ServicioHotelWindows   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:HotelManager.Ventanas     5        N� Title$  ServicioHotelWindows��5	       � 	Resources 5
         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyleIcon �� 
TargetType �� 
TargetType	 ��Name
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%'  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6(   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5        � ��8  6,   �� 5!       � ��# � ��6+   �� 5"       � ��$ 1q�60   �� 5#       � ��$ Center=�6;   �� 5$       � ��$ Center=�69   �� 5%       � ��$ 1q�6(   �� 5&       � �� 5'      �� 5(      " ��6&   .R�5)      �� $	 border��6!   #��z��61   #��z��6[   #��z��6�   $
 true��6�   ._�5*      �� $
 Icono��6$   $	��100��63   $	��100��6@   $��/Ventanas/hotel.png��6L   5+       5,      P� 5-       �@��IsDefaulted$
 true��6=   . �5.   "   �� $ border��6@   # � ��6T    � ��5/      P� 50       �@J�IsMouseOver$
 true��6=   . �51   "   �� $ border��6?   8   � ��6S   �� 52   "   $ border��6@   8   � ��6T   53      P� 54       � ��$
 true��6;   . �55   "   �� $ border��6?   8   � ��6S   �� 56   "   $ border��6@   8   � ��6T   57      P� 58       � {�$ false��6;   . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   5;      5=      5?      5@      5A      .��5C      � .+�5D   
   �� -   5         ��Name$ 
cboHoteles��5D      $��	0,34,44,0q�6'   $��Right=�6i   $	��120��6�   $��22��6�   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5E   
   -   5          Name$ dgServicios��5E      $��257,86,44,124q�6(      
IsReadOnly$
 True��6?   �� 5F   
   $��Nombre��6   $
��Left=�6!   $��	56,86,0,0q�6<   $	��Top=�6O   �� 5G   
   -   5         ��Name$ txtNombreServicio��5G      $
��Left=�6-   $��
127,90,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $��77��6�   �� 5H   
   $��Precio��6   $
��Left=�6!   $	��Top=�6<   $��
62,121,0,0q�6T   �� 5J   
   -   5        $ 	txtPrecio��5J      $
��Left=�6%   $��127,125,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $��77��6�   �� 5K   
   -   5         ��Name$ 
btnAgregar��5K      $��Agregar��6%   $
��Left=�67   $��
67,306,0,0q�6R   $	��Top=�6f   6~   �� 5L   
   $��Hoteles��6   $��
0,34,194,0q�6"   $��Right=�66   $��50��6R   $��26��6]   $	��Top=�6i   �� 5M   
   $ ��Servicios de Departamentos��6   $
��Left=�65   $��	51,10,0,0q�6P   $	��Top=�6c   $	��225��6{   $
��Bold"�6�   $��16(�6�   �� 5N   
   -   5        $ txtDescripcion��5N      $
��Left=�6*   $��
67,216,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��165��6�   $��74��6�   �� 5O   
   $��Descripcion��6   $
��Left=�6&   $��
71,188,0,0q�6A   $	��Top=�6U   $��72��6m   �� 5P   
   -   5         ��Name$ 	chbPorDia��5P      $��
Es por dia��6&   $
��Left=�6;   $��130,158,0,0q�6V   $	��Top=�6k   5Q      5R      
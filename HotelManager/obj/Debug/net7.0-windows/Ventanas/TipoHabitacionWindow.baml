   M S B A M L   `   `   `  ����G  CHotelManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HotelManager.VentanasHotelManager.Ventanas  5      0    *HotelManager.Ventanas.TipoHabitacionWindow   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:HotelManager.Ventanas     5        N� Title$  TipoHabitacionWindow��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $	��22* �6   .+�5   
   �� -   5         ��Name$ 
cboHoteles��5      $��Right=�6'   $��	0,43,44,0q�6C   $	��Top=�6V   $	��120��6n   $��2��6�   �� 5   
   $��Hotel��6   $��
0,41,181,0q�6    $	��Top=�64   $��Right=�6L   $��0,5,5,5q�6h   $��2��6z   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgTiposHabitacion��5      $��257,32,44,124q�6.      
IsReadOnly$
 True��6E   $��1��6�   �� 5   
   $��Cantidad Persona��6   $
��Left=�6+   $��7,32,0,0q�6F   $	��Top=�6X   $��1��6p   �� 5   
   $��Precio��6   $
��Left=�6!   $��	67,67,0,0q�6<   $	��Top=�6O   $��1��6g   �� 5   
   -   5         ��Name$ txtCantidadPersona��5      $
��Left=�6.   $��
127,36,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $��77��6�   $��1��6�   �� 5   
   -   5        $ 	txtPrecio��5      $
��Left=�6%   $��
127,71,0,0q�6@   $
 Wrap=�6T   $	��Top=�6h   $��77��6�   $��1��6�   �� 5   
   -   5        $ 	txtNombre��5      $
��Left=�6%   $��127,106,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $��77��6�   $��1��6�   �� 5   
   -   5        $ txtDescripcion��5      $
��Left=�6*   $��
22,165,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��182��6�   $��1��6�   $��99��6�   �� 5   
   $��Descripcion��6   $
��Left=�6&   $��
22,134,0,0q�6A   $	��Top=�6U   $��1��6m   �� 5   
   -   5         ��Name$ 
btnAgregar��5      $��Agregar��6%   $
��Left=�67   $��
22,283,0,0q�6R   $	��Top=�6f   $��1��6�   �� 5   
   -   5        $ btnActualizar��5      $��
Actualizar��6(   $
��Left=�6=   $��154,283,0,0q�6X   $	��Top=�6m   $��1��6�   �� 5   
   $��Tipo de Habitacion��6   $
��Left=�6-   $��	51,10,0,0q�6H   $	��Top=�6[   $	��153��6s   $
��Bold"�6   $��16(�6�   �� 5   
   $��Nombre��6   $
��Left=�6!   $��
56,102,0,0q�6<   $	��Top=�6P   $��1��6h   5      5       
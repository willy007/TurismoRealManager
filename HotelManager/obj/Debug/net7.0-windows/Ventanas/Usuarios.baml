   M S B A M L   `   `   `  ����G  CHotelManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HotelManagerHotelManager  5          HotelManager.Usuarios   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:HotelManager     5        N� Title$  Usuarios��5	      .��5      � .+�5   
   �� -   5         ��Name$ 
txtUsuario��5      $
��Left=�6&   $��	88,52,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��120��6�   G� 5   
   -   5         G�Name$ txtPwd��5      $
��Left=�6&   $��	88,92,0,0q�6A   $	��Top=�6T   $	��120��6l   �� 5   
   -   5        $ txtRun��5      $
��Left=�6"   $��
88,129,0,0q�6=   $
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   �� 5   
   -   5        $ 	txtNombre��5      $
��Left=�6%   $��
88,169,0,0q�6@   $
 Wrap=�6T   $	��Top=�6h   $	��120��6�   �� 5   
   -   5        $ txtApellido��5      $
��Left=�6'   $��
88,207,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   �� 5   
   -   5        $ 	txtCorreo��5      $
��Left=�6%   $��
88,247,0,0q�6@   $
 Wrap=�6T   $	��Top=�6h   $	��120��6�   �� 5   
   -   5        $ txtTelefono��5      $
��Left=�6'   $��
88,286,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   �� 5   
   -   5         ��Name$ cboRol��5      $
��Left=�6#   $��
89,324,0,0q�6>   $	��Top=�6R   $	��120��6j   6v   �� 5   
   -	   5        $ cboHotel��5      $
��Left=�6%   $��
89,364,0,0q�6@   $	��Top=�6T   $	��120��6l   �� 5   
   $��Usuario��6   $
��Left=�6"   $��	33,44,0,0q�6=   $	��Top=�6P   �� 5   
   $��Contraseña��6   $
��Left=�6%   $��	13,88,0,0q�6@   $	��Top=�6S   �� 5   
   $	��Run��6   $
��Left=�6   $��
52,121,0,0q�69   $	��Top=�6M   �� 5   
   $��Nombre��6   $
��Left=�6!   $��
29,161,0,0q�6<   $	��Top=�6P   �� 5   
   $��Apellido��6   $
��Left=�6#   $��
29,199,0,0q�6>   $	��Top=�6R   �� 5   
   $��Correo��6   $
��Left=�6!   $��
33,239,0,0q�6<   $	��Top=�6P   �� 5   
   $��Telefono��6   $
��Left=�6#   $��
28,278,0,0q�6>   $	��Top=�6R   �� 5   
   $	��Rol��6   $
��Left=�6   $��
57,320,0,0q�69   $	��Top=�6M   �� 5   
   -
   5         ��Name$ 
btnAgregar��5      $��Agregar��6%   $
��Left=�67   $��
88,402,0,0q�6R   $	��Top=�6f   6~   �� 5   
   -   5        $ btnActualizar��5      $��
Actualizar��6(   $
��Left=�6=   $��152,402,0,0q�6X   $	��Top=�6m   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dgPersona��5      $��239,92,31,0q�6&      
IsReadOnly$
 True��6;   $	��348��6M   $	��Top=�6Z   �� 5    
   -   5        $ cboRolLista��5       $��	0,50,31,0q�6(   $��22��6;   $	��Top=�6G   $��Right=�6_   $	��120��6{   6�   �� 5!   
   $	��Rol��6   $��Right=�6   $��
0,48,161,0q�6:   $	��Top=�6N   �� 5"   
   $��Hotel��6   $
��Left=�6    $��
44,360,0,0q�6;   $	��Top=�6O   5#      5$      
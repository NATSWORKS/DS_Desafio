   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.Window2   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   -   5          �Name$  Edição��5   	    � Title$ Editar��5   	   $	��249��6   $	��435��6%   .��5	      � ���	#FF333333.+�5
   
   �� $��Título:��6   $
��Left=�6"   $��	10,76,0,0q�6=   $	��Top=�6P   
�������6h   �� 5   
   -   5         ��Name$ txtTela��5      $��Editar tarefa��6!   $
��Left=�69   $��	10,10,0,0q�6T   $	��Top=�6g   $��18(�6   $
��Bold"�6�   
�������6�   �� 5   
   $��Descrição:��6   $
��Left=�6%   $��
10,107,0,0q�6@   $	��Top=�6T   
�������6l   �� 5   
   $��Data de conclusão:��6   $
��Left=�6-   $��
10,200,0,0q�6H   $	��Top=�6\   
�������6t   �� 5   
   -   5         ��Name$ tbTitle��5      $
��Left=�6#   $��	58,80,0,0q�6>    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��369��6}   �� 5   
   -   5        $ tbDesc��5      $
��Left=�6"   $��
79,107,0,0q�6=   $
 Wrap=�6Q   $	��Top=�6e   $	��348��6}   $��88��6�   �� 5   
   -   5         ��Name$ 	btnUpdate��5      $��	Atualizar��6$   $
��Left=�68   $��309,204,0,0q�6S   $	��Top=�6h   ���	#FF585858
�������$	��118��6�   �� 5   
   $	��Id:��6   $
��Left=�6   $��	10,49,0,0q�69   $	��Top=�6L   
�������6d   �� 5   
   -   5        $ tbTitle_Copy��5      $
��Left=�6(   $��	38,53,0,0q�6C   $
 Wrap=�6V   $	��Top=�6j   $	��136��6�   ${�False��6�   �� 5   
   $��Staus:��6   $
��Left=�6!   $��
179,49,0,0q�6<   $	��Top=�6P   
������� J� RenderTransformOrigin$ 2.313,0.528&�6{   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��130,202,0,0q�60   $	��Top=�6E   $	��174��6]   �� 5   
   -   5         ��Name$ ddStatus��5      $
��Left=�6%   $��
225,51,0,0q�6@   $	��Top=�6T   $	��202��6l   .@�5      �� $��Pendente��6   �� 5      $��Em Progresso��6   �� 5      $��
Concluída��6   5      �� 5   
   -   5        $ txtError��5      $
��Erro��6"   $
��Left=�61   $��
130,16,0,0q�6L   $	��Top=�6`   $	��295��6x   $��28��6�   
���  ��${�False��6�   5      5      
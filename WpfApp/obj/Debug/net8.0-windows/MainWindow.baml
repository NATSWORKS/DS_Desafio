   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � SizeToContent$ WidthAndHeight=�65    � WindowStartupLocation$ CenterScreen=�6T    � WindowState$ 	Maximized=�6y   .��5	      �  J� OpacityMask
 �   ����	#FF333333.+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dtTarefas��5
      $��10,132,10,10q�6Q   ���	#FF6565656g   �� 5   
   -   5         ��Name$ btnAddTarefa��5      $��Adicionar Tarefa��6'   $
��Left=�6B   $��	10,49,0,0q�6]   $	��Top=�6p   ���	#FF369223
�������$	��100��6�   6�   �� 5   
   -   5         ��Name$ 	txtTitulo��5      $��Tarefas��6#   $
��Left=�65   $��	10,10,0,0q�6P   $	��Top=�6c   $��18(�6{   $
��Bold"�6�   
�������6�   �� 5   
   -   5         ��Name$ tbSearch��5      $
��Left=�6$   $��
10,105,0,0q�6?   	 �� TextWrapping$
	 Wrap=�6S   $	��Top=�6g   $	��390��6   $��22��6�   �� 5   
   -   5        $ 	txtSearch��5      $��Pesquisar por tarefa��6#   $
��Left=�6B   $��	10,74,0,0q�6]   $	��Top=�6p   
�������6�   �� 5   
   -   5        $ 	btnSearch��5      $��	Pesquisar��6$   $
��Left=�68   $��573,105,0,0q�6S   $	��Top=�6h   $��65��6�   ���	#FF585858
�������
���   �$��22��6�   6�   �� 5   
   -   5        
 ��Name$
 ddKind��5      $
��Left=�6#   $��405,105,0,0q�6>   $	��Top=�6S   $	��163��6k   .@�5      �� $��Todas��6   �� 5      $��	Pendentes��6   �� 5      $��Em progresso��6   �� 5      $��
Concluída��6   5      5      5      
   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Clientes - LabDB��5   	   $	��500��6"   $	��850��6/    � WindowStartupLocation$ CenterScreen=�5	   	   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��5q�6O   $
��Left=�6Z   .+�5      �� -   5        $!��Listar Clientes - DATATABLE��5      $��30��5       $��5q�6!   �� 5!      -   5        $"��Listar Clientes - DATAREADER��5!      $��30��5#      $��5q�6!   �� 5$      -   5         ��Name$ 	txtBuscar��5$      $	��200��6)   $��30��65   $��15,5,5,5q�6A   $��Center=�6S   �� 5%      -   5        $��Buscar��5%      $��30��6>   $��80��6J   $��5q�6U   5&      &   System.Windows.Controls.DataGrid  5)   
   -   5          Name$ dgDemo1��5)      $��1��5*      $��2��6    $��5q�5+         AutoGenerateColumns$
 True��6      
IsReadOnly$
 True��5,      	   AlternatingRowBackground
	 �����5-      �� 50   
   $��2��6   $��10��6!     53   
   -   5        $ dgDemo2��53      $��3��54      $��2��6    $��5q�55      $
 True��6   $
 True��56      
	 �����57      58      59      
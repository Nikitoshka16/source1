   M S B A M L   `   `   `  ????B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp4WpfApp4  5   	       WpfApp4.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp4     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  J? RenderTransformOrigin$ 0.289,0.326&?6   .+?5
   
   &   System.Windows.Controls.DataGrid  -   5        $	??mda??5
      $
??Left=?6   $	??226??69      AutoGenerateColumns .  $??	10,10,0,0q?6b   $	??Top=?6u   $	??438??6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6@      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *doljID+6M     5      $
 obiz??6>   $ 3* 6M    6%   ?? *obiz+6M     5      $ zp??6<   $ 3* 6I    6%   ?? *zp+6I     5      $ nali4ie??6=   $ 3* 6O    6%   ?? *nal+6O   5      ?? 5   
   -   5        $	??cbP??5       ?? SelectedValuePath$ doljID??66    ?? DisplayMemberPath$	 nal??6Q   $
??Left=?6i   $??
10,269,0,0q?6?   $	??Top=?6?   $	??120??6?   ??6   ?? 6?   ?? 5   
   -   5        $	??Add??5      $
??Left=?6   $??522,216,0,0q?6:   $	??Top=?6O   $??75??6g   6r   ?? 5   
   -   5        $
??tbID??5      $
??Left=?6   $??23??6:   $??
522,28,0,0q?6F   	 ?? TextWrapping$
	 Wrap=?6Z   $?? ??6n   $	??Top=?6v   $	??120??6?   ?? 5   
   -   5        $??tbObiz??5      $
??Left=?6!   $??23??6<   $??
522,84,0,0q?6H   $
	 Wrap=?6\   $?? ??6p   $	??Top=?6x   $	??120??6?   ?? 5   
   -   5        $
??tbZp??5      $
??Left=?6   $??23??6:   $??522,131,0,0q?6F   $
	 Wrap=?6[   $?? ??6o   $	??Top=?6w   $	??120??6?   ?? 5   
   -   5        $??tbNal??5      $
??Left=?6    $??24??6;   $??522,172,0,0q?6G   $
	 Wrap=?6\   $?? ??6p   $	??Top=?6x   $	??120??6?   5      5      
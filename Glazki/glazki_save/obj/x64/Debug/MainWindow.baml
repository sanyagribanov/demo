   M S B A M L   `   `   `  ????F  Bglazki_save, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:glazki_saveglazki_save  5   	       glazki_save.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:glazki_save     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? Icon$ res/logo.ico??65   .??5	      ? 
??????? ? RowDefinitions 5
   
   ?? 5      $	??150 ?6   ?? 5      $??* ?6   .+?5   
   ?? -   5        $??AppImage??5      $
??Left=?6!   $??80??6<   $??	10,10,0,0q?6H   $	??Top=?6[   $??80??6s   $??res/logo.png??6~   ?? 5   
   $??Right=?6   $	??Top=?62   .+?5      ?? -   5        $ ??Администратор??5      $??0q?6-   $	??120??69   $??30??6E   $??12(?6Q   
???????6r   ?? 5      -   5        $??Пользователь??5      $??0q?6-   $	??120??69   $??30??6E   $??12(?6R   
???????6s   ?? 5      -   5        $??BackBtn??5   t   $$??Работа с данными??6   $	??120??60   $??30??6<   $??0q?6H   $??12(?6S   
???????6?   5      ?? 5   
   $??ГК Благодать??6   $??Center=?6'   $??
215,32,0,0q?6D   $	??Top=?6X   $??Arial)?6p   $??25(?6?   $??Oblique$?6?    J? RenderTransformOrigin$ 0.059,0.151&?6?   $??35??6?   $	??319??6?    ? 5   
   -   5        $??	MainFrame??5      $??1??6     ? NavigationUIVisibility$ Hidden=?6N   ? 5   
   .+?5      &   System.Windows.Controls.DataGrid  $??0,90,0,0q?6   ???#7ee69b6)    ? 5      -   5          ?Name$ Timer??5   ?   $	??200??6   $??80??6    $??	0 110 0 0q?6,   6P   5      5!      5"      
   M S B A M L   `   `   `  ????F  Bglazki_save, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:glazki_save.Pagesglazki_save.Pages  5           glazki_save.Pages.EditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:glazki_save.Pages     5        N? Title$  EditPage??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??29* ?6   ?? 5      $	??71* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??Наименование??6   6*   ?? 5   
   $??Стоимость??6   $??1??6%   64   ?? 5   
   $??Код заказа??6   $??2??6&   65   ?? 5   
    ?? 	MaxLength$	 100??6)   $??1??69   $??0??6I   $??0,0,0,66q?6V   ??6   ?? *title+6V   ?? 5   
   $??1??6)   $	??175??69   $
??Left=?6E   $??
0,112,0,56q?6`   $??2??6t   ??6   ?? *price+6t   ?? 5   
   -   5         ??Name$ ComboProducts??5   <   $??2??6/   $??1??6S    ?? DisplayMemberPath$ agent??6c   $??0,0,0,66q?6}    ?? SelectedItem 6   ?? *ID+6}   ?? 5    
   -   5        $??BtnSave??5       $??Сохранить??6    $??3??64   $??1??6A   $??94,28,53,28q?6Q   6f   5"      5#      
   M S B A M L   `   `   `  ????G  Cturagentstvo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:turagentstvo.pagesturagentstvo.pages  5      !    turagentstvo.pages.AddHotel   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:turagentstvo.pages     5        N? Title$  AddHotel??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??140* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   $
??Left=?6.   $??Center=?6I   .+?5      ?? $!??Название отеля??6   $??20(?6.   $	?? 20q?6<   ?? 5      $ 
Horizontal=?6   $??2??62   .+?5      ?? -   5        $??HotelString??5   ]    ?? 	MaxLength$	 100??65   $	??400??6E   $??30??6Q   ??6   ?? *	HotelName+6]   5      5      ?? 5    
   $ 
Horizontal=?6   $??1??6.   $
??Left=?6;   $??Center=?6V   .+?5!      ?? $??Кол-во звезд??6   $??20(?6,   $	?? 30q?6:   6I   ?? 5"      -   5        $??StarsString??5"   `   $
??Left=?6-   $	??400??6H   $??30??6T   ??6   ?? *Stars+6`   5$      ?? 5&   
   $ 
Horizontal=?6   $??2??6.   $
??Left=?6;   $??Center=?6V   .+?5'      ?? $??Страна??6   $??60 10q?6&   $??20(?65   6E   ?? 5(      -   5        $??ComboProducts??5(   I   $??1??6<    ?? DisplayMemberPath$ CountryName??6^   $??2??6~   $	??400??6?   $??50??6?    ?? SelectedItem 6   ?? *CountryName+6?   5*      ?? 5,   
   $ Vertical=?6   $??Center=?6,   $??Center=?6I   $??3??6d   $??0??6q   .+?5-      ?? -   5        $??BtnSave??5-      $??Сохранить??6$   $	??200??6O   $??50??6[   $??20(?6g   ??5.      ?? 5/       ?? EndPoint$ 0.5,1&?6*    ?? 
StartPoint$ 0.5,0&?6;   .??50      ? 	 ? Color$	 #949407??6'   ? 51      $	 #bdbd19??6'   
 ? Offset$
 0.426Q?67   ? 52      $	 #e6e632??6'   $
 0.852Q?67   53      55      57      59      5:      
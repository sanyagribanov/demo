   M S B A M L   `   `   `  ????G  Cturagentstvo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:turagentstvo.pagesturagentstvo.pages  5      #    turagentstvo.pages.HotelsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:turagentstvo.pages     5      -   5          N? Title$  
HotelsPage??5
      .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??176* ?6   ?? 5      $	??49* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridClients??5         AutoGenerateColumns .     
IsReadOnly .    RowStyle 5      ?? 5       ?? 
TargetType)  #System.Windows.Controls.DataGridRow"  6    ?? Triggers 5      ?? 5       ?? Binding 6&   ?? *Stars+	 ?? Value	 56@   .a?5      ?? 
 ?? Property
 ? ?? ?? Value
 ? ? ?6K   5      ?? 5       6&   ?? *Stars+	 46@   .a?5      ?? 
 ? ??
 ? ???6L   5      ?? 5       6&   ?? *Stars+	 36@   .a?5      ?? 
 ? ??
 ? ???6L   5      ?? 5       6&   ?? *Stars+	 26@   .a?5      ?? 
 ? ??
 ?  ??6I   5       5"         Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ id??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ?? *	HotelID+6Y     5'      $) #Наименование Отеля??6%   $ * 6_    6A   ?? *	HotelName+6k     5(      $ Звезды??6%   $ * 6O    65   ?? *Stars+6[     5)      $ Страна??6%   $ * 6U    65   ?? *CountryName+6a   4  .System.Windows.Controls.DataGridTemplateColumn  5*      $
 auto 6)      CellTemplate 5+      ?? 5,      .R?5-      ?? $??BtnEdit??6=   -   5        $ ??Редактировать??5-   %   ??5.   "   ?? 5/   &    ?? EndPoint$ 0.5,1&?6:    ?? 
StartPoint$ 0.5,0&?6K   .??50   *   ?  ? Color$ #949407??67   ? 51   *   $ #bdbd19??67    ? Offset$ 0.426Q?6G   ? 52   *   $ #e6e632??67   $ 0.852Q?6G   53   '   55      56      58      5:      ?? 5<   
   -   5        $??BtnAdd??5<   ?   $??Добавить??6   $
??Left=?6$   $	??192??6b   $??
40,18,0,37q?6n   $??1??6?   ??5=   
   ?? 5>      $ 0.5,1&?6"   $ 0.5,0&?63   .??5?      ? $ #949407??6#   ? 5@      $ #bdbd19??6#   $ 0.426Q?63   ? 5A      $ #e6e632??6#   $ 0.852Q?63   5B      5D      ?? 5F   
   -   5        $??	BtnDelete??5F   >   $??Удалить??6   $
??Left=?6#   $??587,18,0,37q?6g   $	??193??6|   $??1??6?   ??5G      ?? 5H      $ 0.5,1&?6&   $ 0.5,0&?67   .??5I      ? $ #949407??6#   ? 5J      $ #bdbd19??6#   $ 0.426Q?63   ? 5K      $ #e6e632??6#   $ 0.852Q?63   5L      5N      5P      5Q      
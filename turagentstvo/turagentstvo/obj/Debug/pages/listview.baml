   M S B A M L   `   `   `  ????G  Cturagentstvo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:turagentstvo.pagesturagentstvo.pages  5      !    turagentstvo.pages.listview   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:turagentstvo.pages     5        N? Title$  listview??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6   .+?5   
   ?  ? Orientation$ 
Horizontal=?6   $??Center=?6-   .+?5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? $7??1Введите данные для поиска: ??6   $	??175??6?    ?? TextAlignment$ Right=?6K   ?? 5      -   5        $??
TBoxSearch??5   &   $	??225??6   6_   5      ?? 5      $ 
Horizontal=?6   .+?5      ?? $??Выберите тип:??6   $	??175??61   $ Right=?6=   ?? 5      -   5        $??	ComboType??5   H   $	??225??6<    ?? DisplayMemberPath$ TypeName??6?   ??6   ?? *
TypeName+6?   5      ?? 5      -   5         ??Name$ CheckActual??5      $A??;Показать только актуальные туры??6l   6?   5      ?? 5   
   -   5        $??	ListTours??5      $??1??6$   $??Disabled=?61   $??Center=?6g   ??5      ?? 5      .R?5      ? $ 
Horizontal=?6    $??Center=?69   5      ??5!      ?? 5"      .R?5#      ? $??20q?6   $	??400??6'    5$      ?? 5%      $??70 ?6,   ?? 5&      $	??310 ?6,   ?? 5'      $
??auto ?6,   ?? 5(      $
??auto ?6,   .+?5*      ?? $	??300??6    $	??300??6,   $??1??69   $??UniformToFill=?6F   $??Center=?6^   $??5q?6{   ??5+      ?? 5,   "    ?? Path$ 	ImageTour?6*    ?? TargetNullValue 5-   &   ??5.   *   EAC:\WORKSPACE\demo\turagentstvo\turagentstvo\resursi\zaglushka.jpg??6y   50   #   52      ?? 53      $??Center=?6>   $ Center=?6Y   $	??390??6p   $
??Wrap=?6|   $??Center=?6?   $	??5 5q?6?   $??26(?6?   $??0??6?   ??6$   ?? *
TourName+6?   ?? 54      $??Center=?6X   $??5 5 5 15q?6u   $??26(?6?   $??2??6?   $
??Bold"?6?   ??6$   ?? *Cost+	 ?? StringFormat$	 {0:N2} Рублей??6?   ?? 55      $??Right=?6h   $??14(?6?   $??3??6?   ??6$   ?? *TicketsCount+$*	 $Билетов осталось: {0}??6?   ?? 56      $
??Left=?6<   $??14(?6W   $??3??6e   ??6$   ?? *Actual+6e   57      58      5:      5;      5<      
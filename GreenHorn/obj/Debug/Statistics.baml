   M S B A M L   `   `   `  ????U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	   D @GreenHorn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GreenHorn	GreenHorn 5   	      GreenHorn.Statistics   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   )localclr-namespace:GreenHorn     5   	     ? 
ResizeMode$  NoResize=?5	   	    ? WindowStartupLocation$ CenterScreen=?5
   	    ? Title$ 
Statistics??5   	   $	??450??6   $	??900??6)   .??5      ? .+?5   
      LiveCharts.Wpf.PieChart  -   5        &    LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Bottom=?5         	Hoverable .    InnerRadius$ 20Q?6?   $??33,50,264,33q?6?      Series 6/   ?? *SeriesCollection+   ChartLegend 5      "   LiveCharts.Wpf.DefaultLegend  5         
BulletSize$ 15Q?6$   $??8(?64   6M   	   DataTooltip	 5      #   LiveCharts.Wpf.DefaultTooltip  5      
   
BulletSize$
 20Q?6%   $??8(?65   6N   5      ?? 5   
   -   5         ??Name$ Btn_Candidates??5      $??
Candidates??6)   $
??Left=?6>   $??
742,94,0,0q?6Y   $	??Top=?6m   $	??125??6?   $??40??6?   ?? 5   
   -   5         ??Name$ 	Cbx_Month??5      $
??Left=?6&   $??668,100,0,0q?6A   $	??Top=?6V   $??48??6n   $??34??6z   .@?5      ??  ?? 
IsSelected . $??1??6-   ?? 5      $??2??6   ?? 5      $??3??6   ?? 5      $??4??6   ?? 5      $??5??6   ?? 5      $??6??6   ?? 5      $??7??6   ?? 5      $??8??6   ?? 5       $??9??6   ?? 5!      $??10??6   ?? 5"      $??11??6   ?? 5#      $??12??6   5$      ?? 5%   
   -   5        $??	Lbl_Title??5%      $?? ??6!   $
??Left=?6,   $??218,0,0,374q?6G   $??Bottom=?6\   $??40??6w   $	??291??6?   
????p??$??24(?6?   ?? 5&   
   $??Month??6   $
??Left=?6    $??592,103,0,0q?6;   $	??Top=?6P   $??37??6h   $??64??6t   
????p??6   ?? 5'   
   -   5        $ Btn_Positions??5'      $??	Positions??6(   $
??Left=?6<   $??742,159,0,0q?6W   $	??Top=?6l   $	??125??6?   $??40??6?   5(      5)      
   M S B A M L   `   `   `  ????D  @GreenHorn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GreenHorn	GreenHorn  5   	   #    GreenHorn.Add_Industry_Dialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:GreenHorn     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
   -   5           MaterialDesignBody#???   5
      $??Regular"?5      $??13(?5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=?5         TextRenderingMode$
 Auto=?5        MaterialDesignPaper#???  5        MaterialDesignFont#???  5       ? 
ResizeMode$ NoResize=?5   	    ? Title$ Add_Industry_Dialog??5   	   $	??350??6%   $	??500??62   .??5      ? .+?5   
   ?? -   5         ??Name$ TxtBlck_New_Industry??5      $??Add New Industry??62    ?? TextAlignment$ Center=?6J   $
??Wrap=?6a   $??24(?6u   $??0,20,0,0q?6?   $
??Bold"?6?   6?   ?? 5   
   -   5        $ TxtBlck_ind??5      $??Center=?6)   $??0,58,0,0q?6F   $
??Wrap=?6X   $4??.Adding a new Industry will add it to our list.??6l   $	??Top=?6?   $ Center=?6?   ?? 5   
   $??Industry Name:??6   $
??Left=?6)   $??
260,92,0,0q?6D   $	??Top=?6X   ?? 5   
   -   5         ??Name$ Txtbx_Industy_Name??5      $
??Left=?6.   $??
354,92,0,0q?6I    ?? TextWrapping$
 Wrap=?6]   $?? ??6q   $	??Top=?6y   $	??112??6?   ???	#FFFFF6EC6?   ?? 5   
   -   5         ??Name$ Btn_AddIndustry??5      $??Add Industry??6*   $
??Left=?6A   $??305,135,0,0q?6\   $	??Top=?6q   ???	#FF673AB7???	#FF673AB76?   ?? 5   
   -   5        $ Btn_UpdateIndustry??5      $??Update??6-   $
??Left=?6>   $??305,201,0,0q?6Y   $	??Top=?6n   $	??112??6?   ?? 5   
   -   5        $ Btn_DeleteIndustry??5      $??Delete??6-   $
??Left=?6>   $??305,268,0,0q?6Y   $	??Top=?6n   $	??112??6?   ?? 5   
   -   5        	 ??Name$	 Lv_Industry??5      $??10,77,245,10q?6(   $??10,10,10,10q?6>   
 ?? SelectionMode$
 Single=?6?    ?? View 5      ?? 5      .P?5       ?? $??ID??6%    ?? Width$ 80??61    ?? DisplayMemberBinding 6<   ?? *
industryId+?? 5!      $
??Name??6%   $	 150??63    6?   ?? *name+5"      5$      5&      5'      
   M S B A M L   `   `   `  ????N  JDZ0601AndreyMatveew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DZ0601AndreyMatveewDZ0601AndreyMatveew  5   	   $    DZ0601AndreyMatveew.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:DZ0601AndreyMatveew     5   	     ? Title$  
MainWindow??5   	   $??510.535??6   $??408.373??6-   .??5	      ? .+?5
   
   ?? -   5         ??Name$ comboBox??5
      $
??Left=?5      $??	26,80,0,0q?5      $	??Top=?5      $	??350??5      $??44??6   ??5      ??  ?? Path$ Departments? ?? UpdateSourceTrigger$ PropertyChanged=???5      ?? 5      .R?5      $? .+?5      ?? ??6$   ?? $ DepartmentName?5      5      5      ?? 5   
   -   5         ??Name$ label??5      $-??'Выберите департамент??6   $
??Left=?6>   $??	72,41,0,0q?6Y   $	??Top=?6l   $	??258??6?   $??22(?6?   ?? 5   
   -   5        $ 
label_Copy??5      $)??#Список сотрудников??6$   $
??Left=?6A   $??
72,153,0,0q?6\   $	??Top=?6p   $	??258??6?   $??22(?6?   ?? 5   
   -   5         ??Name$ listView??5      $
??Left=?6%   $	??126??6@   $??
26,197,0,0q?6M   $	??Top=?6a   $	??350??6y   ??5      ?? $ 	Employees?$ PropertyChanged=? ?? View 5      ?? 5      -   5        separationGridView??.P?5       ?? -   5        
nameColumn??$??Имя??5    9    ?? Width$ 90??5!   %    ?? DisplayMemberBinding 5"   %   ?? *Name+?? 5$      -   5        surnameColumn??$??Фамилия??5$   <   $ 80??6M    5%   %   ?? *	Surname+?? 5'      -   5        departmentColumn??$??Департамент??5'   ?   $	 175??6T    5(   %   ?? *
Department+5*      5,      ?? 5-   
   -	   5        	 ??Name$	 button??5-      $=??7Редактирование 
    сотрудника??6!   $
??Left=?6S   $??
26,328,0,0q?6n   $	??Top=?6?   $	??105??6?   $??38??6?   6?   ?? 5.   
   -
   5        $	 button_Copy??5.      $>??8Редактирование 
  департамента??6&   $
??Left=?6S   $??
26,401,0,0q?6n   $	??Top=?6?   $	??105??6?   $??38??6?   6?   ?? 5/   
   -   5        $	 button_Copy1??5/      $,??&Добавить 
сотрудника??6'   $
??Left=?6J   $??271,328,0,0q?6e   $	??Top=?6z   $	??105??6?   $??38??6?   6?   ?? 50   
   -   5        $	 button_Copy2??50      $.??(Добавить 
департамент??6'   $
??Left=?6K   $??271,401,0,0q?6f   $	??Top=?6{   $	??105??6?   $??38??6?   6?   52      53      
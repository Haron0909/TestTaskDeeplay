   M S B A M L   `   `   `  ����M  ITestTaskDeeplayWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TestTaskDeeplayWpfTestTaskDeeplayWpf  5   	   #    TestTaskDeeplayWpf.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:TestTaskDeeplayWpf     5   	     � Title$  
MainWindow��5   	   $	��469��6   $	��800��6)   .��5	      � $��0,0,0,4q�6   .+�5
   
   �� -   5        $'��!Удалить работника��5
      $
��Left=�6-   $��556,225,0,0q�6H   $	��Top=�6]   $	��208��6u   $	��244��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	StaffGrid��5      $��	0,0,0,225q�6&      AutoGenerateColumns$ False��69      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6=      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *FIO+6J     5      $ Дата рождения��6E   $	 110 6\    6%   �� *DateOfBirth+6\     5      $ Пол��6@   $ 70 6M    6%   �� *Gender+6M     5      $ Должность��6>   $ 80 6Q    6%   �� *Post+6Q     5      $/ )Уникальная информация��6D   $	 150 6c    6%   �� *
UniqueInfo+6c   5      �� 5   
   -   5        $)��#Добавить работника��5      $
��Left=�6.   $��181,225,0,0q�6I   $	��Top=�6^   $	��195��6v   $	��208��6�   �� 5   
   -   5        $%��Обновить таблицу��5      $
��Left=�6,   $��	0,225,0,0q�6G   $	��Top=�6Z   $	��208��6�   $	��176��6�   �� 5   
   -   5        $��Повысить��5      $
��Left=�6$   $��381,225,0,0q�6?   $	��Top=�6T   $	��170��6l   $	��208��6�   5      5      
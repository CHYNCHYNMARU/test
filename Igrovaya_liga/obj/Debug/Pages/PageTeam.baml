   M S B A M L   `   `   `  ����H  DIgrovaya_liga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Igrovaya_liga.PagesIgrovaya_liga.Pages  5      "    Igrovaya_liga.Pages.PageTeam   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Igrovaya_liga.Pages     5        N� Title$  PageTeam��5	      .��5      � 
������� � ColumnDefinitions 5      �� 5   
   $
��177* �6   �� 5   
   $
��121* �6   .+�5      �� -   5         ��Name$ teamList��5      $��0��6!    �� View 5   
   �� 5      .P�5      �� $��Название��6!    �� DisplayMemberBinding 63   �� *
TeamName+�� 5      $��Капитан��6!    62   ��  �� Path$ Player.Surname��� 5       �� CellTemplate 5      �� 5      .R�5   "   ��  ��Name$ StructureBtn��6:   -   5         � ToolTip$ Состав��5   )   $��25��6Q   $��25��6]   $��Segoe MDL2 Assets)�6h   $��16(�6�   ���	#FF625A97���	#FF625A97
�������.��6�   5   #   5      5      5      5!      � 5#      $��1��6   .+�5$   
   �� $��0 0 0 0q�6   .+�5%      �� -   5        $ 
Назад��5%      $��0 5 15 0q�6)   $��45��6;   $��45��6G   $��Segoe MDL2 Assets)�6R   $��16(�6q   ���	#FF625A97���	#FF625A97
�������$��Right=�6�   .��6�   5'      �� 5(      $��Название��6   $��Center=�6,   $��Segoe UI Light)�6I   $
��Bold"�6e   $��16(�6w   �� 5)      -   5        	 ��Name$	 teamnamebox��5)      $��35��6/   $	��250��6;   $��Segoe UI Light)�6G   $��18(�6c   $��0 0 0 5q�6q   �� 5*      $��Капитан��6   $��Center=�6+   $��Segoe UI Light)�6H   $
��Bold"�6d   $��16(�6v   �� 5+      -   5        
 ��Name$
 
CapitanBox��5+      $��35��6/   $	��250��6;   $��Segoe UI Light)�6G   $��18(�6c   $��0 0 0 5q�6q   �� 5.       �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5/      �� -   5        $ AddBtn��5/      $ Добавить��6)   $��0 0 15 0q�6<   $��45��6N   $��45��6Z   $��Segoe UI Light)�6e   $��16(�6�   ���	#FF625A97���	#FF625A97
�������.��6�   +51      �� 52      -   5        $ EditBtn��52      $ Изменить��6*   $��0 0 15 0q�6=   $��45��6O   $��45��6[   $��Segoe MDL2 Assets)�6f   $��16(�6�   ���	#FF625A97���	#FF625A97
�������.��6�   54      �� 55      -   5        $ Удалить��55      $��0 0 0 0q�6+   $��45��6<   $��45��6H   $��Segoe MDL2 Assets)�6S   $��16(�6r   ���	#FF625A97���	#FF625A97
�������.��6�   57      58      59      5:      5;      5<      
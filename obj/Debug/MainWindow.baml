   M S B A M L   `   `   `  ����J  FPhotoMemoryGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PhotoMemoryGamePhotoMemoryGame  5   	        PhotoMemoryGame.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PhotoMemoryGame     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��0,0,10,0q�6   
������� � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ 	UsersList��5      $��0��6%   $	��200��65   $��10,17,500,106q�6A   $��2��6X   6l   �� 5   
   -   5         ��Name$ image��5      $��1��6   $	��300��6/   $	��300��6<   $��116,12,116,122q�6H   �� 5   
   -   5         ��Name$ NrlINII��5      $
��Left=�6#   $��23��6>   $��190,356,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $��56��6�   $��1��6�   �� 5   
   $��Linii:��6   $
��Left=�6!   $��152,355,0,0q�6<   $	��Top=�6Q   $��1��6i   �� 5   
   $��Coloane:��6   $
��Left=�6#   $��132,384,0,0q�6>   $	��Top=�6S   $��1��6k   $��23��6{   $��59��6�   �� 5   
   -   5        $ 	NrColoane��5      $
��Left=�6%   $��23��6@   $��190,384,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $��56��6�   $��1��6�   �� 5   
   -   5        $��1��5      $��New Game��6!   $
��Left=�64   $��310,379,0,0q�6O   $	��Top=�6d   $��84��6|   $��28��6�   6�   �� 5   
   -   5         ��Name$ AddUser��5      $��Add User��6"   $
��Left=�65   $��
50,374,0,0q�6P   $	��Top=�6d   $��84��6|   $��28��6�   6�   �� 5   
   -   5        $��
DeleteUser��5      $��2��6&   $
��Left=�6:   $��162,374,0,0q�6U   $	��Top=�6j   $��28��6�   $��88��6�   6�   5      5      
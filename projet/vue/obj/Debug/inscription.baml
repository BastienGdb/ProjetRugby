   M S B A M L   `   `   `  ����A  =projet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:vuevue  5   	       vue.Inscription   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:vue     5   	     � Title$  
Rugbyscope��5   
   $	��550��6   $	��925��6*   ��5	      
� 5
   
   .��5      �  � Color$ 	#FF2B0A29��6    � Offset$ 1Q�6-   � 5      $ 	#FF2DC2E4��6   5      .��5      ]� .+�5   
   � $	��Top=�6   $
��Auto��6$   $	��100��61    � ColumnDefinitions 5      �� 5      $
��0.2* �6#   �� 5      �� 5      $
��0.2* �6#   .+�5      �� -   5         ��Name$ 	textBlock��5   )   $��1��6   $
��Wrap=�6<   $��Center=�6P   $��60(�6k   $��Center=�6y   ���	#FFA02E91$��
Rugbyscope��6�   $
��Auto��6�   $
��Auto��6�   �� 5      -   5        $��0��5      $��Accueil��6&   $��Center=�68   $��Center=�6V   $��75��6q   ���	#FF2DADCE���	#FF6E1C76$��1q�6�    J� OpacityMask �	#FF644343$
��Auto��6�   5      � 5   
   -   5        $��mGridCentre��5      .+�5      �� $	��Top=�6   $	��100q�61   $
��Auto��6>   .+�5      � $��Center=�6   .+�5      �� -   5        $ 
textBlock1��5       $��Login :��64   $��24��6C   $��58��6O   �� 5      -   5         ��Name$ login��5      $	��120��6.   $��20��6:   5       � 5!      $��Center=�6   .+�5"      �� -   5        $ textBlock1_Copy��5"       $	��104��69   $��Mot de passe :��6E   G� 5#      -   5         G�Name$ password��5#   "   $	��120��65   $��20��6A   5$      � 5%      $��Center=�6   .+�5&      �� -   5        $ textBlock1_Copy1��5&       $��24��6:   $	��104��6F   $��Confirmation :��6R   G� 5'      -	   5        $ 	password2��5'   "   $	��120��66   $��20��6B   5(      � 5)      $��Center=�6   .+�5*      �� -
   5        $ textBlock1_Copy2��5*       $��Sexe :��6:   $��24��6H   $��58��6T   �� 5+      -   5        $	��sex��5+      $	��100��6*   $��22��66   .@�5,      �� $��Homme��6$   �� 5-      $��Femme��6$   5/      50      � 51      $��Center=�6   .+�52      �� -   5        $ textBlock1_Copy3��52       $��Equipe favorite :��6:   $��25��6S   $	��104��6_   �� 53      -   5         ��Name$ comboboxequipe��53      $	��100��67   $��22��6C    
  equipe#��[  54   D   ��6   �� *AllEquipeROC+56      57      � 58      $��Center=�6   .+�59      �� -   5        $ textBlock1_Copy4��59       $!��Equipe nationale favorite :��6:   $��25��6]   $	��151��6i   �� 5:      -   5        $ comboboxequipenat��5:      $	��120��6;   $��22��6G   #��[  5;   D   ��6   �� *EquipeNatROC+5=      5>      5?      �� 5@      -   5        	 ��Name$	 button��5@      $��Valider��6%   $��85��67   $��25��6B   $��Bottom=�6i   5A      5B      5C      
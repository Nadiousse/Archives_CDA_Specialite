   M S B A M L   `   `   `  ����Q  Mtp_combat_data_binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:tp_combat_data_bindingtp_combat_data_binding  5   	   '    !tp_combat_data_binding.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:tp_combat_data_binding     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5   
   �� -   5         ��Name$ ImagePlayerTwo��5      $��430,77,23,0q�6(   $��/warrior_thomas.png��6=   $
��Fill=�6Z    K� ZIndex$ 1��6i   �� 5   
   -   5        $ ImagePlayerOne��5      $��0,120,411,0q�6(   $��/warrior_pl.png��6=   $
��Fill=�6V   $ 1��6e    J� RenderTransformOrigin$ 0.5,0.5&�6v   z�5      V� 5      .~�5      ��  �� ScaleX$ -1Q�6%   �� 5      �� 5      T� 5      5      5      �� 5   
   -   5        $ 
Background��5      $��/background.jpg��6$   $
��Fill=�6=   �� 5   
   -   5         ��Name$ PlayerOneFixedText��5      $
��Left=�60   $��	42,38,0,0q�6K   $
��Wrap=�6^   $	��Top=�6r   $��43��6�   $��68��6�   $��18(�6�   $ 1��6�   �� 6�    � Language$ fr-fr�6�   $�Name :��6�   �� 6�   �� 6�   $ fr-fr�6�   $
�HP :��6  6  �� 5   
   -   5         ��Name$ PlayerOneInfo��5      $
��Left=�6+   $��81��6F   $��	26,19,0,0q�6R   $	��Top=�6e   $	��298��6}   ���	#FFBEAF84���	#FF6F5D336�   �� 5   
   -   5        $ PlayerTwoInfo��5      $
��Left=�6+   $��81��6F   $��
454,19,0,0q�6R   $	��Top=�6f   $	��298��6~   ���	#FFBEAF84���	#FF6F5D336�   �� 5   
   -   5        $ PlayerTwoFixedText��5      $
��Left=�60   $��
475,38,0,0q�6K   $
��Wrap=�6_   $	��Top=�6s   $��43��6�   $��68��6�   $��18(�6�   $ 1��6�   �� 6�   $ fr-fr�6�   $�Name :��6�   �� 6�   �� 6�   $ fr-fr�6�   $
�HP :��6  6  �� 5   
   -   5        $ PlayerOneText��5      $
��Left=�6+   $��
101,38,0,0q�6F   $
��Wrap=�6Z   $	��Top=�6n   $��24��6�   $	��209��6�   $��18(�6�   $ 1��6�    �� TextAlignment$ Right=�6�   $�� ��6�   �� 5   
   -	   5        $ PlayerTwoText��5      $
��Left=�6+   $��
533,38,0,0q�6F   $
��Wrap=�6Z   $	��Top=�6n   $��24��6�   $	��209��6�   $��18(�6�   $ 1��6�   $ Right=�6�   $�� ��6�   �� 5   
   -
   5        $ PlayerOneBindText��5      $
��Left=�6/   $��
101,62,0,0q�6J   $
��Wrap=�6^   $	��Top=�6r   $��24��6�   $	��209��6�   $��18(�6�   $ 1��6�   $ Right=�6�   ��6�   �� *pierreLouis.HP+�� 5   
   -   5        $ PlayerTwoBindText��5      $
��Left=�6/   $��
533,66,0,0q�6J   $
��Wrap=�6^   $	��Top=�6r   $��24��6�   $	��209��6�   $��18(�6�   $ 1��6�   $ Right=�6�   ��6�   �� *	thomas.HP+�� 5   
   -   5        $ TextFixedRound��5      $
��Left=�6,   $��308,105,0,0q�6G   $
��Wrap=�6\   $	��Top=�6p   $��36(�6�   $��Arial Black)�6�   ���	#FFBEAF84�� 6�   $�Round��6�   �� 6�   $ fr-fr�6�   $� ��6�   6�   �� 5    
   -   5        $ TextFixedRoundNumber��5       $
��Left=�62   $��443,105,0,0q�6M   $
��Wrap=�6b   $	��Top=�6v   $��36(�6�   $��Arial Black)�6�   ���	#FFBEAF84$��29��6�   ��6�   �� *BattleRound+�� 6�   $ fr-fr�6�   6  �� 5!   
   -   5        $��
Next Round��5!      $
��Left=�6&   $��349,151,0,0q�6A   $	��Top=�6V   $��34��6n   $��81��6z   ���	#FFBEAF84$��Italic$�6�   ��5"      �� 5#      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5$      �  � Color$ 	#FF88713B��6#    � Offset$ 1Q�65   � 5%      $ 	#FFBEAF84��6#   $ 0Q�65   5&      5(      5*      5+      
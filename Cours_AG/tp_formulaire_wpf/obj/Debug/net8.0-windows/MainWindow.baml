   M S B A M L   `   `   `  ����L  Htp_formulaire_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:tp_formulaire_wpftp_formulaire_wpf  5   	   "    tp_formulaire_wpf.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:tp_formulaire_wpf     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $
��Left=�6   $��	17,14,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   �� 6o    � Language$ fr-fr�6s   $�
First Name��6�   6�   �� 5   
   -   5         ��Name$ 	firstName��5      $
��Left=�6%   $��	17,35,0,0q�6@    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��120��6   �� 5   
   $
��Left=�6   $��	17,64,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   �� 6o   $ fr-fr�6s   $�Last ��6�   �� 6�   $
�Name��6�   6�   �� 5   
   -   5        $ lastName��5      $
��Left=�6$   $��	17,85,0,0q�6?   $
 Wrap=�6R   $	��Top=�6f   $	��120��6~   �� 5   
   $
��Left=�6   $��
17,123,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $ fr-fr�6t   $�Subscrition to mediapart��6�   6�   	� 5   
   -   5         	�Name$ radioOneMonth��5      $��1 Month��6-    	� 	GroupName$ SubscriptionTime��6?   $
��Left=�6\   $��
17,144,0,0q�6w   $	��Top=�6�    d� 	IsChecked$
 TrueY�6�   	� 5   
   -   5        $ radioSixMonth��5      $��6 Months��6-   $ SubscriptionTime��6@   $
��Left=�6]   $��
17,163,0,0q�6x   $	��Top=�6�   6�   	� 5   
   -   5        $ radioOneYear��5      $��1 Year��6,   $ SubscriptionTime��6=   $
��Left=�6Z   $��
17,182,0,0q�6u   $	��Top=�6�   6�   �� 5   
   $
��Left=�6   $��
17,212,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $�Subscrition to ��6t   �� 6�   $ fr-fr�6�   $�the newsletter��6�   6�   �� 5   
   -   5         ��Name$ buttonSubscription��5      $��Subscription��6-   $
��Left=�6D   $��
43,264,0,0q�6_   $	��Top=�6s   6�   �� 5   
   -   5         ��Name$ textblockDatabase��5      $
��Left=�6/   $	��348��6J   $��	413,0,0,0q�6W   $
��Wrap=�6j   $	��Top=�6~   $	��258��6�   	 J� RenderTransformOrigin$	 0.523,0.516&�6�   �� 5   
   -   5        $ buttonShowDatabase��5      $��Show DataBase��6-   $
��Left=�6E   $��500,358,0,0q�6`   $	��Top=�6u   6�   �� 5   
   $
��Left=�6   $	��348��6/   $��	400,0,0,0q�6<   
���   �$	��Top=�6^   $	��286��6v   �� 5   
   -	   5        
 ��Name$
 newsletterCheckBox��5      $	��Yes��6/   $
��Left=�6=   $��
17,233,0,0q�6X   $	��Top=�6l   $
 TrueY�6�   �� 5   
   $
��Left=�6   $	��172��6+   $��
211,17,0,0q�68   $	��Top=�6L   $	��181��6d   $��/linux-tux-seeklogo.png��6p   5      5      
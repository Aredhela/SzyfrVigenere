   M S B A M L   `   `   `  ����  	Szyfrator    Szyfrator.FromScreen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Szyfrowanie z klawiatury��5   	   $	��300��6*   $	��525��67   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF0046FF��6    � Offset$ 0Q�6-   � 5      $ White��6   $ 1Q�6)   5	      .��5      � .+�5   
   �� -   5         ��Name$ TextBox_decrypted_Screen��5      $
��Left=�64   $��50��6O   $��	10,77,0,0q�6[    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��497��6�    J� RenderTransformOrigin$ 0.489,2.667&�6�    �� CharacterCasing$ Lower=�6�   	 �� AcceptsReturn	 . 
 �� 
AcceptsTab
 . 6�   �� 5   
   -   5        $ TextBox_encrypted_Screen��5      $
��Left=�64   $��50��6O   $��
10,180,0,0q�6[   $
 Wrap=�6o   $	��Top=�6�   $	��497��6�   $ 0.489,2.667&�6�   $ Lower=�6�   	 . 
 . 6�   �� 5   
   -   5         ��Name$ Button_encrypt_Screen��5      $��	Zaszyfruj��60   $
��Left=�6D   $	��Top=�6_   $	��145��6w   $��
195,12,0,0q�6�   $��38��6�   �� 5   
   -   5         ��Name$ Label_correct_Screen��5      $��Poprawny tekst��6/   $
��Left=�6H   $	��Top=�6c   $ 1.789,2.385&�6{   $��	10,46,0,0q�6�   $	��150��6�   �� 5   
   -   5        $ Label_encrypted_Screen��5      $��Zaszyfrowany tekst��60   $
��Left=�6M   $��
10,149,0,0q�6h   $	��Top=�6|   $	��150��6�   �� 5   
   -   5        $ Button_BackToMain_Screen��5      $��Menu główne��63   $
��Left=�6I   $	��Top=�6d   $	��120��6|   $��387,239,0,0q�6�   6�   �� 5   
   -   5        $��button1��5   `   $��	Odszyfruj��6   $��38��6%   $
��Left=�61   $��
346,12,0,0q�6L   $	��Top=�6o   $	��145��6�   6�   �� 5   
   -   5        $ TextBox_Password��5      $��23��6,   $
��Left=�68   $��	12,27,0,0q�6S   $	��Top=�6f   $	��177��6~   6�   �� 5   
   -	   5        $��
textBlock1��5   N   $��23��6   $
��Left=�6    $��	12,12,0,0q�6;   $��Klucz :��6`   $	��Top=�6o   5      5      
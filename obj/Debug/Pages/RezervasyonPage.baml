   M S B A M L   `   `   `  ����F  BHaliSahaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HaliSahaWPF.PagesHaliSahaWPF.Pages  5      '    !HaliSahaWPF.Pages.RezervasyonPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HaliSahaWPF.Pages     5        N� Title$  RezervasyonPage��5	      .��5      � -   5        .+�5   
   �� -   5         ��Name$ btn_rez��5      $��
Rezerve Et��6"   $
��Left=�67   $��360,182,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5   
   -   5         ��Name$ 
tb_rez_not��5      $
��Left=�6&   $��23��6A   $��337,142,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $��Rezervasyon Notu��6v   $	��Top=�6�   $	��120��6�   �� 5   
   $��REZERVASYON YÖNETİMİ��6   $��Center=�6/   $
��Left=�6S   $��	10,10,0,0q�6n   $	��Top=�6�   $	��772��6�   $��20(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $	��tb1��5      $��0��6      AutoGenerateColumns .  $��Right=�6J   $��
0,269,18,0q�6f   $	��Top=�6z   $	��171��6�   $	��760��6�   $��5��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Rez ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *RezID+  5      $ 	Saha Adı��6%   $ * 67    6A   �� *
SahaAdı+  5      $ Saha Fiyati��6%   $ * 6:    6D   �� *
SahaFiyati+  5      $ Saha Kapasitesi��6%   $ * 6>    6H   �� *SahaKapasitesi+  5      $ Rezervasyon Notu��6%   $ * 6?    6I   �� *	RezNotu+  5      $ Rezervasyon Zamanı��6%   $ * 6A    6K   �� *	RezNotu+5      �� 5   
   -   5        $ btn_rez_iptal��5      $��Rezervasyonu İptal Et��6(   $
��Left=�6H   $��600,127,0,0q�6c   $	��Top=�6x   $	��135��6�   6�   �� 5   
   -   5        	 ��Name$	 cmbx_rez��5   _   
 �� SelectedValuePath$
 RezID��6+    �� DisplayMemberPath$ RezID��6E   $
��Left=�6q   $��
607,83,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6   �� 6�   �� 5   
   -   5        $	 cmbx_sahalar��5      $
��Left=�6)   $��
337,69,0,0q�6D   $	��Top=�6X   $	��120��6p   6�   �� 5   
   -   5        $ tb_saha_fiyati��5   $    �� 
IsReadOnly . $
��Left=�6<   $��23��6W   $��337,106,0,0q�6c   $
 Wrap=�6x   $��Fiyat Çıktısı��6�   $	��Top=�6�   $	��120��6�   5      5      
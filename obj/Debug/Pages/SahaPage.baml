   M S B A M L   `   `   `  ����F  BHaliSahaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HaliSahaWPF.PagesHaliSahaWPF.Pages  5           HaliSahaWPF.Pages.SahaPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HaliSahaWPF.Pages     5        N� Title$  SahaPage��5	      .��5      � -   5         � RowDefinitions 5   
   �� 5      $
��350* �6   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $	��11* �6   �� 5      $	��89* �6   .+�5   
   �� -   5         ��Name$ btn_add_saha��5      $
��Ekle��6(   $
��Left=�67   $��360,234,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5   
   -   5         ��Name$ txt_sahaName��5      $
��Left=�6)   $��23��6D   $��
337,85,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ txt_sahaPrice��5      $
��Left=�6)   $��23��6D   $��337,139,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ txt_sahaLimit��5      $
��Left=�6*   $��23��6E   $��337,194,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   $��SAHA YÖNETİMİ��6   $��Center=�6(   $
��Left=�6L   $��	10,10,0,0q�6g   $	��Top=�6z   $	��772��6�   $��20(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $	��tb1��5      $��0��6      AutoGenerateColumns .  $��Right=�6J   $��
0,269,18,0q�6f   $	��Top=�6z   $	��171��6�   $	��760��6�   $��5��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Saha Adı��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6A   �� *
SahaAdı+  5      $ Saha Fiyati��6%   $ * 6:   	 6D   �� *
SahaFiyati+  5      $ Saha Kapasitesi��6%   $ * 6>   	 6H   �� *SahaKapasitesi+  5      $ Saha Aktif Mi ?��6%   $ * 6>   	 6H   �� *
isActive+5      �� 5    
   -   5        $ btn_saha_sil��5       $	��Sil��6'   $
��Left=�65   $��107,152,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5!   
   -   5        $ btn_saha_pasif��5!      $��Aktif - Pasif��6)   $
��Left=�6A   $��107,125,0,0q�6\   $	��Top=�6q   $��75��6�   6�   �� 5"   
   -	   5        
 ��Name$
 cmbox_saha_data��5"   d    �� SelectedValuePath$ SahaAdı��6,    �� DisplayMemberPath$ SahaAdı��6H   $
��Left=�6}   $��	85,83,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6   �� 6�   �� 5#   
   $��	Saha Adı��6   $
��Left=�6#   $��
337,59,0,0q�6>   $	��Top=�6R   �� 5$   
   $��Saha Fiyatı��6   $
��Left=�6&   $��337,113,0,0q�6A   $	��Top=�6V   �� 5%   
   $��Saha Kapasitesi��6   $
��Left=�6*   $��337,167,0,0q�6E   $	��Top=�6Z   5'      5(      
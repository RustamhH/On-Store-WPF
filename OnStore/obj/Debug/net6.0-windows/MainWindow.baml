   M S B A M L   `   `   `  ����B  >OnStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnStoreOnStore  5   	       OnStore.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:OnStore     5   	     � Title$  OnStore��5   	   $	��450��6   $	��800��6&   .��5	      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      $
��0.8* �6   6.   .+�5   
   �� 
�������$��1q�6$   ._�5      � $��0��6    � RowDefinitions 5      �� 5      $
��0.2* �6$   64   �� 5      6&   .+�5      �� -   5        $��ShoppingBag��5      $��0��6,   $��10 0 0 4q�69   $��25��6K   $��25��6V   $
��Left=�6b   
������ 
������  � ToolTip 5      �� 5      .+�5      �� $
��Bold"�6(   $��My Products��6;   6P   �� 5      $��See products you buyed��6(   6H   5       � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5       " ��6    .�5!      ��  �@��CornerRadius$ 25��6=   5"      5#      .��5$      �� $��icons/shopping bag.png��6   $��30��6<   6I   5%      �� 5'      -   5        $��SearchTextBox��5'   0   ���#2B5E3D$��0��6E   $	��300��6R   $��40��6^   $��
 Search...��6j   $��Center=�6|   $��17(�6�   
�������6�   �� 5*      -   5         ��Name$ 	AddButton��5*      $��0��6,   $��30��69   $��30��6D   $��	370 0 0 0q�6P   
������ 
������  5+      �� 5,      .+�5-      �� $
��Bold"�6(   $��Add Product��6;   6P   �� 5.      $��Add new products��6(   6B   5/       51      ��%_   '��       �� 52      " ��6    .�53      ��  �@��CornerRadius$ 25��6=   54      55      .��56      �� $��icons/add product.png��6   $��30��6;   6H   57      �� 5<      -   5        $��listBox��5<   T   $��Disabled=�6   $��1��6�   ��6c   �� *
Products+��5=      �� 5>      .R�5?   "   � 	 � Orientation$	 
Horizontal=�6,   5@      ��5B      �� 5C      .R�5D      �� $��0 0 30 0q�6)   .+�5E   "   �� 
 ��Name$
 ProductImage��6(   $��50��6Z   $��50��6e   ��6>   �� *
ImageUrl+6e   �� 5F   "    ��Name$ ProductName��6,   $��10,0,0,0q�6W   $��Center=�6i   $
��Bold"�6�   ��6A   �� *Name+6�   �� 5G   "   $ ProductContent��6,   $��10,0,0,0q�6]   $��Center=�6o   $��Italic$�6�   ��6D   �� *	Content+6�   � 5H   "   .+�5I   &   �� $ ProductPrice��60   $��10,0,0,0q�6]   $��Center=�6o   ��6F   �� *Price+6o   �� 5J   &   $��$��60   $��Center=�69   5K   #   �� 5L   "   $ 
BuyProduct��6)   -   5        
������ $��20��5L   V   $��20��6a   
������ .��5M   &   �� $��icons/buy product.png��6,   6M   5N   #   5O      5P      5R      5T      5U      �� 5Y   
   -   5        $��
Stackpanel��5Y   %   $��1��6   $y�Hidden=�67   .+�5Z      �� $	��100��6@   $	��100��6L   ��6   �� *SelectedProduct.ImageUrl+6[   �� 5[      -   5        $��NameTextBox��5[      ${�False��6)   $��50��6a   ��6;   �� *SelectedProduct.Name+6o   �� 5\      -   5        $��ContentTextBox��5\      ${�False��6,   $��50��6g   ��6>   �� *SelectedProduct.Content+6u   �� 5]      -	   5        $��ImageTextBox��5]      ${�False��6*   $��50��6h   ��6<   �� *SelectedProduct.ImageUrl+6v   �� 5^      -
   5        $��PriceTextBox��5^      ${�False��6*   $��50��6e   ��6<   �� *SelectedProduct.Price+6s   �� 5_      -   5        $��
EditButtom��5_      $��30��6'   $��Edit Product��63   6e   5`      5l      5m      
   M S B A M L   `   `   `  ����K  GSkirmish_Builder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Skirmish_BuilderSkirmish_Builder  5      #    Skirmish_Builder.WarbandParts   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Skirmish_Builder     5      .��5	      �   � 	Resources  5
   
    �� 
TargetType   YellowButtonTemplate ��Name �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value��%�  &	        �� 5      " ��6   .R�5      �� $ MyYellowBorder��5   $   #��z��5      #��z��5   $   $��0q�5   $   ���	#FFEEC300._�5      �� $��Center=�6'   $��Center=�6B   5       5      P� 5       � �� . . �5      �� $ MyYellowBorder��6!    � �� �	#FFD19A036S   5      P� 5       � �� .  . �5      �� $ MyYellowBorder��6!    � �� �	#FFEEC3006S   5      5      5      	 � ColumnDefinitions	 5   
   �� 5      $
��Auto �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5       $��30 �6   �� 5!      $��30 �6   �� 5"      $��30 �6   .+�5$   
   �� -   5        
 ��Name$
 NameTextBlock��5$       �� Padding$ 7q�6+   ��67   �� �� 5%   
   -   5        $
 MultiplierTextBlock��5%      $ 7q�61   $	��x 1��6=   $��1��6H   $
��Left=�6X   �� 5&   
   -   5        $
 CostTextBlock��5&      $ 7q�6+   $��Cost: ��67   $��2��6E   $��Right=�6U   �� 5'   
   -   5         ��Name$ minusButton��5'      $��3��6&   $��20��66   $��20��6B   $��Center=�6M   #��[  6�   .��6�   -6�   �� 5(   
   -   5        $ 
plusButton��5(      $��4��6%   $��20��65   $��20��6A   $��Center=�6L   $��Center=�6i   #��[  6�   .��6�   +6�   �� 5)   
   -   5        $ deleteButton��5)      $��5��6'   $��20��67   $��20��6C   $��Center=�6N   $��Center=�6k   #��[  6�   .��6�   x6�   5*      5+      
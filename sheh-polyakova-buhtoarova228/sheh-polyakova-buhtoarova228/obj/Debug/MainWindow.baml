   M S B A M L   `   `   `  ����W  Ssheh-polyakova-buhtoarova228, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:sheh_polyakova_buhtoarova228sheh_polyakova_buhtoarova228  5   	   -    'sheh_polyakova_buhtoarova228.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:sheh_polyakova_buhtoarova228     5   	     � Title$  File Sharing App��5   	   $	��350��6"   $	��525��6/    � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � �� �#FF007A6+   �� 5       � ��
 �����6+   �� 5       � ��$ 10q�6(   �� 5       � ��$ 5q�6'   5      5      .��5      � .+�5   
   �� -   5        $��Select File��5      $
��Left=�6@   $��	10,10,0,0q�6[   $	��Top=�6n   �� 5   
   -   5         ��Name$ FilePathTextBox��5       �� 
IsReadOnly . $
��Left=�6=   $��23��6X   $��	90,15,0,0q�6d    �� TextWrapping$
 Wrap=�6w   $��Selected File Path��6�   $	��Top=�6�   $	��360��6�   �� 5   
   -   5        $��	Send File��5      $
��Left=�6<   $��	10,50,0,0q�6W   $	��Top=�6j   �� 5   
   -   5        $��Receive File��5      $
��Left=�6B   $��
100,50,0,0q�6]   $	��Top=�6q   �� 5   
   -   5         ��Name$ FileTransferHistory��5      $
��Left=�6/   $	��200��6J   $��
10,100,0,0q�6W   $	��Top=�6k   $	��480��6�   � 5   
   -   5        	 �Name$	 FileTransferProgressBar��5      $
��Left=�67   $��20��6R   $��
10,270,0,0q�6^   $	��Top=�6r   $	��480��6�   
 � Minimum$
 0Q�6�    � Maximum$	 100Q�6�   5      5      
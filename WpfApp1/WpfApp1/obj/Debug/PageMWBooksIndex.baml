   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.PageMWBooksIndex   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5      -   5          N� Title$  PageMWBooksIndex��5	       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $��15 �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $��15 �6    � RowDefinitions 5   
   �� 5      $��0 �6   �� 5      $��40 �6   �� 5      $	��50* �6   �� 5      $��20 �6   �� 5      $	��50* �6   �� 5      $��15 �6   .+�5   
   �� -   5        $��SortBookTableLname��5      $��1��5      $��1��6   $��Right=�5      $	��5,0q�5       $��24��5!      $	��100��6   $��Sort by last name��5"      {�.  5%      �� 5'   
   -   5        $��SortBookTableTitle��5'      $��2��5(      $��1��6   $
��Left=�5)      $	��5,0q�5*      $��24��5+      $��80��6   $��Sort by title��5,      {�.  5/      &   System.Windows.Controls.DataGrid  51   
   -   5        $��
BooksTable��51      $��1��53      $��2��6   $��2��54      {�.     
IsReadOnly . ��52      �� 58        5:   
   -   5        $��CopiesTable��5:      $��1��5<      $��4��6   $��2��5=      {�.   . ��5;      �� 5@      5B      5C      
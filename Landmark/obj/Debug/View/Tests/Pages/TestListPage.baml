   M S B A M L   `   `   `  ����C  ?Landmark, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Landmark.View.Tests.PagesLandmark.View.Tests.Pages  5      ,    &Landmark.View.Tests.Pages.TestListPage   5      Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Landmark.View.Tests.Pages     5        N� 
FontFamily$  Times New Roman)�5	       N� Title$ Список тестов��5       � DataContext 5      ��    	VmLocator �� Source# [   �� Path$ testListPageViewModel�.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   A�  A� Columns$ 3��6   $��10,10,35,10q�5      .+�5      �� $��Название��6   $��Center=�5      $��18(�5      �� 5      $+��%Количество вопросов��6   $��Center=�5      $��18(�5      �� 5      $��Действия��6   $��Center=�5      $��18(�5      5      �� 5!   
   $��1��6   .��5"      �� $��Stretch=�5$      $��7q�5%      ��5"      �� *Tests+ �� SelectedItem 5&      �� *SelectedTest+��5(      �� 5)      .R�5*      A� $ 3��6&   .+�5+      �� $��Center=�5,   $   $��18(�5-   $   ��5+   (   �� *Name+5-   $   �� 5.      $��Center=�5/   $   $��18(�50   $   ��5.   (   �� *QuestionCount+50   $   � 51      $��Center=�6#    � ColumnDefinitions 52   "   �� 53   &   $
��auto �67   �� 54   &   $
��auto �67   �� 55   &   $
��auto �67   .+�58   "   �� $	��▷��6)   $��18(�59   )   $��0��5:   )   $��5q�5;   )   $	��5,0q�5<   )   ��5=   )   �� 	 �� RelativeSource	 �� 
 �� AncestorType$

 PageL�$! DataContext.OpenTestCommand���5>   )   �� *Id+�� 5@   "   $
��🖉��6)   $��18(�5A   !   $��1��5B   !   $��5q�5C   !   $	��3,0q�5D   !   ��5E   !   �� 	 �� $

 PageL�$! DataContext.EditTestCommand���5F   !   �� *Id+�� 5H   "   $
��🗑��6)   $��18(�5I   )   $��2��5J   )   $��5q�5K   )   ��5L   )   �� 	 �� $

 PageL�$# DataContext.DeleteTestCommand���5M   )   �� *Id+5N      5O      5Q      5S      5T      5V      5W      
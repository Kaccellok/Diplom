   M S B A M L   `   `   `  ����C  ?Landmark, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Landmark.View.Tests.PagesLandmark.View.Tests.Pages  5      .    (Landmark.View.Tests.Pages.CreateTestPage   5      Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Landmark.View.Tests.Pages     5        N� 
FontFamily$  Times New Roman)�5	       N� Title$! Создание теста��5       � DataContext 5      ��    	VmLocator �� Source# [   �� Path$ createTestPageViewModel�.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� 
���   �$��1q�5       �� CornerRadius$ 5��5      $��200,20,200,20q�5       �� Padding$ 5q�5      ._�5      �� $��0��5      
������ ��5      �� *	Test.Name+5      5      �� 5   
   $��1��6   .��5      �� ��6   �� *Test.Questions+��5       �� 5!      .R�5"      �� 
���   �$��1q�5#      $ 5��5$      $��200,5,185,5q�5%      $ 10q�5&      ._�5'      �� .+�5(   "   �� $��2q�5)   %    �� TextWrapping$
 Wrap=�5*   %   	 �� TextAlignment$
	 Left=�5+   %   ��5(   *   �� *Name+5+   %   �� 5,   "   ��6/   �� *	Answers+��5-   &   �� 5.   *   .R�5/   .   �� 
 �� Orientation$
 
Horizontal=�69   .+�50   2   	� $��2q�53   :   $��0��54   :    d� 	IsChecked 51   :   �� *IsTrue+ 	� 	GroupName 52   :   ��  �� RelativeSource ��  �� AncestorType$ BorderL�$ DataContext.Id�54   :   �� 55   2   $
	 Left=�56   :   $
 Wrap=�57   :   $	��100��58   :   ��55   :   �� *Name+58   :   �� 59   2   $
��🗑��69   $��1��5:   5   $��2q�5;   5   ��5<   5   ��  �� $
 PageL�$% DataContext.DeleteAnswerCommand���5=   5   �� *Id+5>   /   5?   +   5A   #   �� 5C   "   $	��➕��6)   $
��Left=�5D   )   $	��5,3q�5E   )   ��5F   )   ��  �� $
 PageL�$" DataContext.AddAnswerCommand���5G   )   �� *Id+�� 5I   "   $!��Удалить вопрос��6)   $��5q�5L   %   ��5J   %   ��  �� $
 PageL�$' !DataContext.DeleteQuestionCommand���5K   %   �� *Id+5L   %   5M      5O      5P      5R      5T      A� 5V   
    A� Columns$ 4��6   $��2��5W      .+�5X      �� $#��Добавить вопрос��6   $��5q�5Y      $
��20,5q�5Z      ��5[      �� *AddQuestionCommand+�� 5\      $��Сохранить��6   $��5q�5]      $
��20,5q�5^      ��5_      �� *SaveTestCommand+�� 5`      $$��Сохранить в Файл��6   $��5q�5a      $
��20,5q�5b      ��5c      �� *SaveTestToFileCommand+�� 5d      $��Удалить��6   $��5q�5e      $
��20,5q�5f      ��5g      �� *DeleteTestCommand+5h      5i      5j      
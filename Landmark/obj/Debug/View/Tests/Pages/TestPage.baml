   M S B A M L   `   `   `  ����C  ?Landmark, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Landmark.View.Tests.PagesLandmark.View.Tests.Pages  5      (    "Landmark.View.Tests.Pages.TestPage   5      Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Landmark.View.Tests.Pages     5        N� FontSize$  18(�5	       N� 
FontFamily$ Times New Roman)�5
       N� Title$ Тест��5       � DataContext 5      ��    	VmLocator �� Source# [   �� Path$ testPageViewModel� � 	Resources 5         BooleanToVisibilityConverter��%   &	       �� 5   
   6'   5      .��5      �� .��5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $��* �6    �� 5      $
��auto �6    .+�5      �� 
���   �$��1q�5       �� CornerRadius$ 5��5      $��150,20q�5       	 �� Padding$	 5q�5!      $��1��5"      ._�5$      �� 
������ ��6   �� *QuestionNumber+
 �� StringFormat$
  Вопрос {0}��5%      5'      �� 5)      $��2��5*      $��1q�5+      $ 5��5,      $��150,20,135,20q�5-      $	 5q�5.      ��5)      �� *BorderColor+._�50      �� .+�51      �� $
��Wrap=�52   %    �� Padding$ 2q�53   %    �� TextAlignment$
 Left=�54   %   ��51       �� *CurrentQuestion.Name+54   %   �� 55      ��6#   �� *CurrentQuestion.Answers+��56      �� 57      .R�58   "   �  � Orientation$ 
Horizontal=�6,   .+�59   &   	� $��2q�5;   )    	� 	GroupName 5:   )   ��  �� RelativeSource ��  �� AncestorType$ BorderL�$$ DataContext.CurrentQuestion.Id� d� 	IsChecked 5<   )   �� *IsTrue+{�5=   )   ��  �� $ BorderL�$ DataContext.IsEnabled�.��5>   *   �� $
��Wrap=�5@   -   $
 Left=�5A   -   ��5?   -   �� *Name+5B   +   5C   '   5E   #   5F      5H      5K      5M      �� 5P      
���   �$��1q�5Q      $ 5��5R      $��150,20,150,20q�5S      $	 5q�5T      $��3��5U      y�5V      �� *CanCheckAnswer+ �� 	Converter# [ ._�5X      �� .+�5Y      �� $
��Wrap=�5Z       $ 2q�5[       $
 Left=�5\       ��5Y       �� *CorrectAnswer.Name+$
 Ответ: {0}��5\       5]      5_      �� 5a      $��Проверить��6   $��4��5b      $��300,5q�5c      $��5q�5d      ��5e      �� *CheckAnswerCommand+y�5f      �� *CanCheckAnswer+# [ �� 5h      $%��Следующий вопрос��6   $��5��5i      $��300,5q�5j      $��5q�5k      ��5l      �� *NextQuestionCommand+�� 5n      $'��!Предыдущий вопрос��6   $��6��5o      $��300,5q�5p      $��5q�5q      ��5r      �� *PreviousQuestionCommand+y�5s      �� *ShowPreviousButton+# [ 5t      A� 5v       A� Columns$ 2��6   $��8��5w      $
��50,5q�5x      .+�5y      �� $��Результаты��6   $��70,10q�5z      $��5q�5{      $��16(�5|      ��5}      �� *ShowResultsCommand+�� 5~      $��Покинуть тест��6   $��70,10q�5      $��5q�5�      $��16(�5�      ��5�      �� *LeaveTestCommand+5�      5�      5�      5�      
   M S B A M L   `   `   `  ����C  ?Landmark, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Landmark.ViewLandmark.View  5   	   $    Landmark.View.TestDialogWindow   5   	   Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Landmark.View     5   	   $��16(�5   	   $��Times New Roman)�5   	     � Title$#  Настройки теста��5   	    � SizeToContent$ WidthAndHeight=�6!    � WindowStartupLocation$ CenterScreen=�6@    � DataContext 5	   	   ��    	VmLocator �� Source# [   �� Path$ testDialogWindowViewModel�.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��5q�5      .+�5      �� $#��Всего вопросов: ��6    �� Padding$
 10,5q�5      �� 5      $
 10,5q�5      ��5      �� *MaxQuestionNum+5      5      �� 5   
   $ 
Horizontal=�6   $��5q�5      $��1��5      .+�5      �� $+��%Промежуток вопросов��6   $
 10,5q�5       $��5q�5!      �� 5#      $��70��5$      	 �� TextAlignment$	 Center=�5%      $��5q�5&      $��5q�5'      ��5#      �� $ StartIntervalNum�5'      �� 5)      $	��min��6   $
��10,5q�5*      $��5q�5+      ��5,      �� *SetMinCommand+�� 5.      $��70��5/      $	 Center=�50      $��5q�51      $��5q�52      ��5.      �� $ EndIntervalNum�52      �� 54      $	��max��6   $
��10,5q�55      $��5q�56      ��57      �� *SetMaxIntervalCommand+58      �� 5:   
   $ 
Horizontal=�6   $��5q�5;      $��2��5<      .+�5=      �� $9��3Количество вопросов в тесте��6   $
 10,5q�5>      $��5q�5?      �� 5A      $��70��5B      $	 Center=�5C      $��5q�5D      $��5q�5E      ��5A      �� $ QuestionNum�5E      �� 5G      $	��max��6   $
��10,5q�5H      $��5q�5I      ��5J      �� *SetMaxCommand+5K      �� 5M   
   $��3��6   $��10q�5N      .+�5O      �� $)��#Перемешать вопросы��6   $��5q�5P      
 d� 	IsChecked
 5Q      �� *MixQuestions+�� 5R      $'��!Перемешать ответы��6   $��5q�5S      
 5T      �� *
MixAnswers+�� 5U      $@��:Проверять ответы во время теста��6   $��5q�5V      
 5W      �� *CanCheckAnswers+5X      A� 5Z   
    A� Columns$ 2��6   $��4��5[      $��7q�5\      .+�5]      �� $��Продолжить��6   $��5q�5^      $��15, 0q�5_       �� 	IsDefault . ��5`      �� *ContinueCommand+��5a      ��  �� RelativeSource ��  �� AncestorType$ WindowL�5b      �� 5d      $��Отменить��6   $��5q�5e      $��15, 0q�5f       �� IsCancel . 5g      5h      5i      5j      
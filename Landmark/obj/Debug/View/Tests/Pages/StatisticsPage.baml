   M S B A M L   `   `   `  ����C  ?Landmark, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Landmark.View.Tests.PagesLandmark.View.Tests.Pages  5      .    (Landmark.View.Tests.Pages.StatisticsPage   5      Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Landmark.View.Tests.Pages     5        N� FontSize$  18(�5	       N� 
FontFamily$ Times New Roman)�5
       N� Title$E ?Окно статистики пройденного теста��5       � DataContext 5      ��    	VmLocator �� Source# [   �� Path$ statisticsPageViewModel�.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��Результаты��6    �� TextAlignment$ Center=�5       �� Padding$ 7q�5      $
��Bold"�5      $��20(�5      �� 5   
   $A��;Правильные/Неправильные ответы:��6   $��1��5      $ Center=�5      $ 7q�5       � 5"   
   -   5        $��pbStatus��5+      $��2��5"      	 � Minimum$	 0Q�5#      
 � Maximum$	
 100Q�5$      $��25��5&      $��10q�5'      $��200,5q�5(      
���  ��$
��Bold"�5*       � Value 5%      �� *Result+5+      �� 5-   
   $��Center=�5.      $��Center=�5/      $��2��50      ��5-      ��  �� ElementName$ pbStatus��$ Value� �� StringFormat$ {0:0}%��50      �� 52   
   $��3��6   .��53      �� ��6   �� *	Questions+��54      �� 55      .R�56      �� 
���   �$��1q�57       �� CornerRadius$ 5��58      $��200,5,185,5q�59       �� Padding$ 10q�5:      ._�5;      �� .+�5<   "   �� $
��Wrap=�5=   %   $ 2q�5>   %   $
 Left=�5?   %   ��5<   ,   �� *Name+5?   %   �� 5@   "   ��6/   �� *	Answers+��5A   &   �� 5B   *   .R�5C   .   �  � Orientation$ 
Horizontal=�68   .+�5D   2   	� {�.  $��2q�5G   :   $��0��5H   :    d� 	IsChecked 5E   :   �� *IsTrue+.��5I   6   �� $
��Wrap=�5K   9   $
 Left=�5L   9   ��5J   9   �� *Name+5M   7   5N   3   5O   /   5P   +   5R   #   5S      5T      5U      5W      5Y      A� 5[   
    A� Columns$ 3��6   $��4��5\      .+�5]      �� $'��!Правильные ответы��6   $��5q�5^      $
��10,5q�5_      ��5`      �� *ShowRightQuestions+�� 5a      $+��%Неправильные ответы��6   $��5q�5b      $
��10,5q�5c      ��5d      �� *ShowWrongQuestions+�� 5e      $ ��В главное меню��6   $��5q�5f      $
��10,5q�5g      ��5h      �� *ToStartPage+5i      5j      5k      
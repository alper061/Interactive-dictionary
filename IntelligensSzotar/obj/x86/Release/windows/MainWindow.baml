   M S B A M L   `   `   `  ����   Interaktív szótár"    IntelligensSzotar.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -      
main_title  � Title#  �   $	��420��$	��420��$	��600��$	��600�� � Icon$ /img/dictionary.png��.��]� ��. .+��� $	��Top=�.+�o� -   $
��menu��$��27��.@�m� $��	_Szótár��.@�m� -   $��Új téma felvétele�� m� Icon �� $��25��$��/img/addtopic.png��m� -   $��Szavak felvétele�� �� $��25��$��/img/addword.png��m� $��_Beállítások��.@�m� $��_Megjelenítés nyelve��.@�m� -   $��menu_lang_hungarian��$��Magyar�� �� $��/img/flags/hung_flag.png��m� -   $��menu_lang_english��$��Angol�� �� $��/img/flags/uk_flag.png��m� $��_Információ��c� -   $��toolbar��$��32��.@��� -   $��btn_newTopic�� � ToolTip$ Új téma felvétele��.���� $��/img/addtopic.png���� -	   $��btn_addWords��$. (Szavak felvétele egy megadott témában��.���� $��/img/addword.png���� .��Szó keresése:�� -
   $��textb_findWord��$	��150�����	#FFB9B9F8�� -   $��loadingwords��$��Center=�$��Center=� �� CornerRadius$ 15�����	#FF02A702$��	0,20, 0,0q�$y�	Collapsed=�._��� $��	12,7,12,8q�.+��� $��Center=�
�������$
��Bold"�.��Szavak betöltése...� -   $��progbar_loadingwords��$	��250��$��25���� -   $��border_found��$ 15�����	#FFA0F5A0._�&   System.Windows.Controls.DataGrid  -   $��dgrid_found��$y�	Collapsed=�$��10,10,10,10q�"   VerticalScrollBarVisibility$ Visible=�$	��230���� 
�������.@��� 
�������$��Felvett témák��${ uA betöltött témákat és a hozzájuk tartozó adatokat jeleníti meg, az adatbázisban tárolt statikus formában.��.���� -   $��border_stat��$ 15�����	#FFF3FFFF$��0,5,0,5q�$y�Visible=�._�  -   $��
dgrid_stat�����	#FFF3FFFF   
IsReadOnly . $��10,10,10,10q�   AutoGenerateColumns .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Téma címe��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *
TopicTitle+  $	 Első nyelv��
 �� *StaticLanguage1+  $	 Második nyelv��
 �� *StaticLanguage2+  $	 Nyelv 1 szavak száma��
 �� *StaticLang1Count+  $	 Nyelv 2 szavak száma��
 �� *StaticLang2Count+�� $��Felvett szavak��.��]� ��. .+�c� $��30��$	��Top=�.@��� $��Válassz témát:���� -   $��combo_topicsOfWords���� -   $��border_words��$ 15�����	#FFF3FFFF$��0,5,0,5q�$y�Visible=�._��  � ColumnDefinitions �� $��* ��� $��* � � RowDefinitions �� $��30 ��� $��* �.+��� -   $��label_firstLang��$��Első nyelv szavai:��$��Center=�$��10,0,0,0q��� -   $��label_secondLang��$��Második nyelv szavai:��$��1��$��Center=�$��10,0,0,0q�  -   $��dgrid_words1��$��0��$��1�����	#FFF3FFFF . $��
10,0,10,10q� .     $
	 Szó��
 �� *
WordName+  $	 Nyelv��
 �� *
Language+  $	 Jelentések��
 �� *MeaningManifest+  -   $��dgrid_words2��$��1��$��1�����	#FFF3FFFF . $��
10,0,10,10q� .     $
	 Szó��
 �� *
WordName+  $	 Nyelv��
 �� *
Language+  $	 Jelentések��
 �� *MeaningManifest+�� $��Szavak kikérdezése��
�������.��]� -   $��dock_questions�����	#FFF3FFFF$y�Visible=�.+��� ���	#FF9CEF9C$ 5��._�9� -   $��
exp_topics�� 9� ExpandDirection$
 Left=�$��Témák��.��]� ��. .+��� $��Bottom=�.+��� -   $��btn_switchChosenLang��$��6,6,6,6q�$��23��$
��Auto��.��Nyelvek felcserélése�� -   $��list_topics��$
��Auto�� �� SelectionMode$ Multiple=�$��Stretch=�� $	��Top=�$y�Visible=� �� $��* � �� $��40 ��� $��* ��� $��35 �.+��� $��0��$��0�� �� Orientation$ 
Horizontal=�.+��� -   $��	btn_start��$	��100��$��25��$��	10,0,10,0q�.��Start�� -   $��btn_prevQuestion��$��3,3,3,3q�$ Előző kérdés��{�.  .���� $��/img/arrowprev.png���� $��25��.��Kiválasztott szavak:�� -   $��label_wordIndex��$��34��$��16(�$��0,0,-5,0q�
����  �$��	ExtraBold"�.��0�� $��34��$��16(�.��/�� -   $��label_wordCount��$��34��$��16(�$��-5,0,5,0q�.��0�� -   $��btn_nextQuestion��{�.  $��3,3,3,3q�$ Következő kérdés��.���� $��/img/arrownext.png��� $��0��$��1�� �� $��* ��� $��* � �� $��65 ��� $��70 ��� $��40 ��� $��40 �.+��� 
�������$ 20��$��	20,5,20,5q�$��45��._��� -    $��label_nextWord��$��Center=�$��Center=�$��17(�$��Heavy"��� $��/img/arrow.png��$��1��$��0,3,0,3q��� -!   $��textb_answer��$��2��
����ح�$��	20,5,20,0q� �� TextAlignment$
 Left=�$��17(�$��Center=��� $��3��$��	20,0,20,5q�$ 
Horizontal=�.+��� -"   $��
btn_speech��$��/img/micro_off.png��$��30��$
��Left=�$ Beszédfelismerés���� -#   $��stack_speech��$ 
Horizontal=�$y�	Collapsed=�.+��� -$   $��combo_speech��$��25��$��70��$��	10,0,10,0q�$1 +Válasszon nyelvet a beszédfelismeréshez!��� -%   $��progbar_audio��$��25��$	��100��$� �Ha nem észlel változást a hangszintben, ide kattintva állíthat be másik alapértelmezett hangfelvételi eszközt. Beállítás után kapcsolja ki és be a beszédfelismerést!���� -&   $��	btn_check��{�.  $��1��$	��100��$��30��$7 1Beírt szó helyességének ellenőrzése [Enter]��.��Szó ellenőrzése�� -'   $��label_rightAnswer��$��1��$��1��$��Bottom=�$��Center=�$y�Hidden=�.��A helyes válasz:�� -(   $��textb_rightAnswer��$��2��$��1�����	#FF7DF843$��	20,5,20,0q�$
 Left=�$��17(� �� 
IsReadOnly . $��Center=�$y�	Collapsed=��� -)   $��label_goood��$��2��$��1��$��Center=�$��Center=�$��18(�$y�Hidden=�.��Helyes válasz!�� $
��Left=�$��0��$��2��$ 
Horizontal=�.+��� -*   $��btn_statistics��$��80��$��25��$��	10,0,10,0q�{�.  .��Eredmények�� $��25��$��10,0,0,0q�.��Jó válaszok:�� -+   $��label_goodAnsw��$��0,0,10,0q�$��18(�$��Center=����	#FF21AA21$��	ExtraBold"�.��0�� $��25��.��Rossz válaszok:�� -,   $��label_wrongAnsw��$��0,0,10,0q�$��Center=�$��18(�
���  ��$��	ExtraBold"�.��0�� $��25��.��Nem válaszolt:�� --   $��label_noAnsw��$��0,0,20,0q�$��Center=�$��18(�
����  �$��	ExtraBold"�.��0
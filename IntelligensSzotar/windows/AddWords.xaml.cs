using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IntelligensSzotar
{
    /// <summary>
    /// Interaction logic for AddWords.xaml
    /// </summary>
    public partial class AddWords : Window
    {
        public AddWords()
        {
            InitializeComponent();
            LoadTopics();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AddWord();
            }
        }

        private void AddWord()
        {
            int idx = combo_topics.SelectedIndex;
            string words1 = textb_lang1words.Text;
            string words2 = textb_lang2words.Text;

            StringBuilder stb = new StringBuilder();
            for (int i = 0; i < words1.Length; i++)
            {
                if (i == 0 || !(words1[i - 1] == ',' && words1[i] == ' '))
                    stb.Append(words1[i]);
            }
            words1 = stb.ToString(); 
            stb.Clear();

            for (int i = 0; i < words2.Length; i++)
            {
                if (i == 0 || !(words2[i - 1] == ',' && words2[i] == ' '))
                    stb.Append(words2[i]);
            }
            words2 = stb.ToString();

            if (idx == -1 || words1 == String.Empty || words2 == String.Empty) return;
            string[] ws1 = words1.Split(',');
            string[] ws2 = words2.Split(',');
            MainWindow.Dictionary.Topics[idx].AddNewWord(new List<string>(ws1), new List<string>(ws2), true);
            textb_lang1words.Text = String.Empty;
            textb_lang2words.Text = String.Empty;
            RefreshComboBox();
            textb_lang1words.Focus();
        }

        private void RefreshComboBox()
        {
            int i = combo_topics.SelectedIndex;
            combo_topics.SelectedIndex = -1;
            combo_topics.Items.Refresh();
            combo_topics.SelectedIndex = i;
        }

        private void btn_addWord_Click(object sender, RoutedEventArgs e)
        {
            AddWord();
        }

        private void btn_ready_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadTopics()
        {
            combo_topics.ItemsSource = MainWindow.Dictionary.Topics;
        }

        private void combo_topics_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combo_topics.SelectedIndex == -1) return;
            Topic t = (combo_topics.SelectedItem as Topic);
            label_lang1.Content = t.StaticLanguage1;
            label_lang2.Content = t.StaticLanguage2;
        }
    }
}

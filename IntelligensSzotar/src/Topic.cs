using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IntelligensSzotar
{
    public class Topic
    {
        public Topic(string TopicName, string Language1, string Language2, bool Create)
        {
            L1Words = new List<Word>();
            L2Words = new List<Word>();
            lang1 = Language1;
            lang2 = Language2;
            langSwitcher = true;
            topicName = TopicName;
            tPath = @"topics\" + topicName + '-' + lang1 + '-' + lang2;
            if (Create) SetTopicsDatabase();
            else ReadDatabase();
        }

        private string lang1, lang2;
        private List<Word> L1Words;
        private List<Word> L2Words;
        private string topicName;
        private string tPath;
        private StreamReader str;
        private StreamWriter stw;
        private bool langSwitcher;

        public string TopicTitle
        {
            get { return topicName; }
        }

        public List<Word> StaticLang1Words { get { return L1Words; } }
        public List<Word> StaticLang2Words { get { return L2Words; } }
        public string StaticLanguage1 { get { return lang1; } }
        public string StaticLanguage2 { get { return lang2; } }
        public int StaticLang1Count { get { return L1Words.Count; } }
        public int StaticLang2Count { get { return L2Words.Count; } }

        public List<Word> DynamicLang1Words
        {
            get
            {
                if (langSwitcher) return L1Words;
                else return L2Words;
            }
        }

        public List<Word> DynamicLang2Words
        {
            get
            {
                if (langSwitcher) return L2Words;
                else return L1Words;
            }
        }

        public string DynamicLanguage1
        {
            get
            {
                if (langSwitcher) return lang1;
                else return lang2;
            }
        }

        public string DynamicLanguage2
        {
            get
            {
                if (langSwitcher) return lang2;
                else return lang1;
            }
        }

        public int DynamicLang1Count
        {
            get
            {
                if (langSwitcher) return L1Words.Count;
                else return L2Words.Count;
            }
        }

        public int DynamicLang2Count
        {
            get
            {
                if (langSwitcher) return L2Words.Count;
                else return L1Words.Count;
            }
        }

        public void AddNewWord(List<string> L1NewWords, List<string> L2NewWords, bool Save2Database)
        {
            StringBuilder stb = new StringBuilder();
            for (int i = 0; i < L1NewWords.Count; i++)
            {
                Word existing = StaticLang1Words.Find(word => word.WordName == L1NewWords[i]);
                if (existing != null) existing.AddNewMeanings(L2NewWords);
                else
                {
                    Word w = new Word(L1NewWords[i], DynamicLanguage1, L2NewWords);
                    StaticLang1Words.Add(w);
                }
                stb.Append(L1NewWords[i]);
                if (i < L1NewWords.Count - 1) stb.Append(',');
            }
            stb.Append('|');
            for (int i = 0; i < L2NewWords.Count; i++)
            {                
                Word existing = StaticLang2Words.Find(word => word.WordName == L2NewWords[i]);
                if (existing != null) existing.AddNewMeanings(L1NewWords);
                else
                {
                    Word w = new Word(L2NewWords[i], DynamicLanguage2, L1NewWords);
                    StaticLang2Words.Add(w);
                }
                stb.Append(L2NewWords[i]);
                if (i < L2NewWords.Count - 1) stb.Append(',');
            }
            if (Save2Database) Save(stb.ToString());
            stb.Clear();
        }

        private void SetTopicsDatabase()
        {
            try { if (!File.Exists(tPath)) File.Create(tPath); }
            catch { }
        }

        private void Save(string Text)
        {
            try
            {
                using (stw = new StreamWriter(tPath, true, Encoding.Default))
                {
                    stw.WriteLine(Text);
                    stw.Close();
                }
            }
            catch { }
        }

        private void ReadDatabase()
        {
            try
            {
                using (str = new StreamReader(tPath, Encoding.Default))
                {
                    string[] tags;
                    while (!str.EndOfStream)
                    {
                        tags = str.ReadLine().Split('|');
                        List<string> l1Words = new List<string>(tags[0].Split(','));
                        List<string> l2Words = new List<string>(tags[1].Split(','));
                        AddNewWord(l1Words, l2Words, false);
                    }
                }
            }
            catch { }
        }

        public override string ToString()
        {
            return topicName + ": " + DynamicLanguage1 + " (" + DynamicLang1Count + ") >> " + DynamicLanguage2 + " (" + DynamicLang2Count + ')';
        }

        public override bool Equals(object obj)
        {
            Topic t = obj as Topic;
            if (t == null) return false;
            return (this.topicName.ToLower() == t.topicName.ToLower() &&
                this.DynamicLanguage1.ToLower() == t.DynamicLanguage1.ToLower() &&
                this.DynamicLanguage2.ToLower() == t.DynamicLanguage2.ToLower());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void SwitchLanguage()
        {
            langSwitcher = !langSwitcher;
        }
    }
}

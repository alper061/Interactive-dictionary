using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelligensSzotar
{
    public class Word
    {
        public Word(string Word, string Language, List<string> Meanings)
        {
            word = Word;
            language = Language;
            meanings = Meanings;
        }

        private string word;
        private string language;
        private List<string> meanings;

        public string WordName
        {
            get { return word; }
        }

        public string Language
        {
            get { return language; }
        }

        public List<string> Meanings
        {
            get { return meanings; }
        }

        public string MeaningManifest
        {
            get
            {
                StringBuilder stb = new StringBuilder();
                int count = meanings.Count;
                for (int i = 0; i < count; i++)
                {
                    stb.Append(meanings[i]);
                    if (i < count - 1) stb.Append(", ");
                }
                return stb.ToString();
            }
        }

        public void AddNewMeaning(string Meaning)
        {
            if (!meanings.Contains(Meaning))
                meanings.Add(Meaning);
        }

        public void AddNewMeanings(List<string> Meaning)
        {
            foreach (string  meaning in Meaning)
            {
                AddNewMeaning(meaning);
            }
        }

        public override string ToString()
        {
            return word;
        }
    }
}

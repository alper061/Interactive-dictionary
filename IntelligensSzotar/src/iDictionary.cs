using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace IntelligensSzotar
{
    public delegate void ProgressFunction();

    public class iDictionary
    {
        public iDictionary(string DataBasePath, ProgressFunction ProgressFnc)
        {
            topics = new List<Topic>();
            path = DataBasePath;
            progFnc = ProgressFnc;
            LoadTopics();
        }

        private List<Topic> topics;
        private string path;
        private ProgressFunction progFnc;

        public List<Topic> Topics
        {
            get { return topics; }
        }

        public int TopicCount
        {
            get { return topics.Count; }
        }

        public bool AddNewTopic(String Name, string Language1, string Language2)
        {
            Topic t = new Topic(Name, Language1, Language2, true);
            if (!topics.Contains(t))
            {
                topics.Add(t);
                return true;
            }
            return false;
        }

        public void LoadTopics()
        {
            try
            {
                string[] files = Directory.GetFiles(path);

                string[] topic;
                foreach (string file in files)
                {
                    try
                    {
                        topic = file.Split('\\')[1].Split('-');
                        Topic t = new Topic(topic[0], topic[1], topic[2], false);
                        topics.Add(t);
                    }
                    catch { }
                    progFnc();
                }
            }
            catch { }
        }

        public List<WordMeta> Search(string keyword)
        {
            List<WordMeta> foundWords = new List<WordMeta>();

            for (int i = 0; i < topics.Count; i++)
            {
                foreach (Word w in topics[i].DynamicLang1Words)
                {
                    if (Regex.IsMatch(w.WordName, '^' + keyword))
                    {
                        WordMeta wm = new WordMeta(w.WordName, w.Language, w.Meanings);
                        foundWords.Add(wm);
                    }
                }
                foreach (Word w in topics[i].DynamicLang2Words)
                {
                    if (Regex.IsMatch(w.WordName, '^' + keyword))
                        if (Regex.IsMatch(w.WordName, keyword))
                        {
                            WordMeta wm = new WordMeta(w.WordName, w.Language, w.Meanings);
                            foundWords.Add(wm);
                        }
                }
            }
            return foundWords;
        }

    }
}

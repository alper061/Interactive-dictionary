using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelligensSzotar
{
    /// <summary>
    /// ERRE MÁR NEM LESZ SZÜKSÉG!!!!
    /// </summary>

    public class AnswerMeta
    {
        public AnswerMeta(Result Result, string Question, string Answer, string RightAnswer)
        {
            switch (Result)
            {
                case Result.Helyes: Eredmény = "Helyes"; break;
                case Result.Hibás: Eredmény = "HIBÁS"; break;
                case Result.NincsVálasz: Eredmény = "Nincs válasz"; break;
            }
            result = Result;
            Kérdés = Question;
            Válasz = Answer;
            HelyesVálasz = RightAnswer;
        }

        public Result result;
        public string Eredmény { get; set; }
        public string Kérdés { get; set; }
        public string Válasz { get; set; }
        public string HelyesVálasz { get; set; }
    }
}

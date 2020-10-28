using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glossaries.WinForm
{
    public class PracticeResults
    {
        public string Word { get; set; }
        public string TranslationFrom { get; set; }
        public string TranslationTo { get; set; }
        public string ExpectedAnswer { get; set; }
        public string Answer { get; set; }
        public bool IsCorrect
        {
            get
            {
                return ExpectedAnswer.ToLower() == Answer.ToLower();
            }
        }
    }
}

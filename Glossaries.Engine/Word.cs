using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glossaries
{
    public class Word
    {
        public Word(params string[] translations)
        {
            this.Translations = translations;
        }

        public Word(int fromLanguage, int toLanguage, params string[] translations)
        {
            this.FromLanguage = fromLanguage;
            this.ToLanguage = toLanguage;
            this.Translations = translations;
        }

        public string[] Translations { get; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }
    }
}

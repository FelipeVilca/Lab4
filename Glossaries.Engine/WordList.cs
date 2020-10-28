using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glossaries
{
    public class WordList
    {
        /// <summary>
        /// 
        /// </summary>
        //private static WordList Instance { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public List<Word> WordsList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; } //The name of the list.
        
        /// <summary>
        /// 
        /// </summary>
        public string[] Languages { get; set; } //The names of the languages

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="languages"></param>
        public WordList(string name, params string[] languages)
        {
            this.Name = name;
            this.Languages = languages;
            WordsList = new List<Word>();
        }

        /// <summary>
        /// Returns array with names of all lists that are stored (without the file extension)
        /// </summary>
        /// <returns></returns>
        public static string[] GetLists()
        {
            var applicationDataPath = GetApplicationDataPath();

            var files = new List<string>();

            DirectoryInfo directoryInfo = new DirectoryInfo(applicationDataPath);
            FileInfo[] allFiles = directoryInfo.GetFiles("*.dat"); //Getting Text files
            foreach (FileInfo fileInfo in allFiles)
            {
                files.Add(Path.GetFileNameWithoutExtension(fileInfo.Name));
            }

            return files.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static string GetApplicationDataPath()
        {
            var applicationName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            var basePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var applicationDataPath = Path.Combine(basePath, applicationName);

            if (!Directory.Exists(applicationDataPath))
            {
                Directory.CreateDirectory(applicationDataPath);
            }

            return applicationDataPath;
        }

        /// <summary>
        /// Loads the dictionary(name entered without file extension) and returns as WordList.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static WordList LoadList(string name)
        {
            WordList instance = null;
            var applicationDataPath = GetApplicationDataPath();
            var dictionaryPath = Path.Combine(applicationDataPath, name + ".dat");
            if (File.Exists(dictionaryPath))
            {
                var fileData = File.ReadAllLines(dictionaryPath);
                var lines = new List<string>(fileData);
                if (lines != null && lines.Count > 0)
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        if (i == 0)
                        {
                            var languages = lines[i].Split(';');
                            if (languages != null && languages.Count() > 0)
                            {
                                instance = new WordList(name, languages);
                            }
                        }
                        else
                        {
                            var translations = lines[i].Split(';');
                            instance.Add(translations);
                        }
                    }
                }

            }

            return instance;
        }

        /// <summary>
        /// Saves the list to a file with the same name as the list and file extension.dat
        /// </summary>
        public void Save()
        {
            var data = new List<string>();
            data.Add(string.Join(";", Languages));

            if (WordsList != null && WordsList.Count > 0)
            {
                foreach (var word in WordsList)
                {
                    data.Add(string.Join(";", word.Translations));
                }
            }

            var applicationDataPath = GetApplicationDataPath();
            var dictionaryPath = Path.Combine(applicationDataPath, Name + ".dat");

            using (TextWriter tw = new StreamWriter(dictionaryPath))
            {
                foreach (String s in data)
                    tw.WriteLine(s);
            }
        }

        public void Add(params string[] translations)
        {
            if (WordsList != null)
            {
                var word = new Word(translations);
                WordsList.Add(word);
            }
        }

        /// <summary>
        /// //translation corresponds to the index in Languages.
        /// Search the language and delete the word.
        /// /// </summary>
        /// <param name="translation"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool Remove(int translation, string word)
        {
            bool isRemoved = false;

            if (WordsList != null && WordsList.Count > 0)
            {
                foreach (var item in WordsList)
                {
                    if (item.Translations != null && item.Translations.Count() > translation)
                    {
                        if (item.Translations[translation] == word)
                        {
                            item.Translations[translation] = "";
                            isRemoved = true;
                            break;
                        }
                    }
                }
            }

            return isRemoved;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            if (WordsList != null)
            {
                return WordsList.Count;
            }

            return 0;
        }

        /// <summary>
        /// sortByTranslation = The language in which the list is to be sorted.
        /// showTranslations = Callback that is called for each word in the list.
        /// </summary>
        /// <param name="sortByTranslation"></param>
        /// <param name="showTranslations"></param>
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            if (WordsList != null && WordsList.Count > 0)
            {
                var dictionary = new Dictionary<string, string[]>();
                foreach (var word in WordsList)
                {
                    if (word.Translations != null && word.Translations.Count() >= sortByTranslation)
                    {
                        if (!dictionary.ContainsKey(word.Translations[sortByTranslation]))
                        {
                            dictionary.Add(word.Translations[sortByTranslation], word.Translations);
                        }
                    }
                }

                var lst = dictionary.Keys.ToList();
                lst.Sort();
                showTranslations(lst.ToArray());
            }
        }

        /// <summary>
        /// Randomly returns Word from the list, with randomly selected
        /// FromLanguage and ToLanguage(though not the same).
        /// </summary>
        /// <returns></returns>
        public Word GetWordToPractice()
        {
            if (WordsList != null && WordsList.Count > 0)
            {
                var random = new Random();
                var number = random.Next(0, WordsList.Count);
                return WordsList[number];
            }

            return null;
        }

    }
}

using Glossaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glossaries.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args != null && args.Count() > 0)
                {
                    var value = args[0];
                    if (!string.IsNullOrEmpty(value))
                    {
                        if (value.ToLower().Equals("-lists"))
                        {
                            var list = WordList.GetLists();
                            if (list != null && list.Count() > 0)
                            {
                                Console.WriteLine("Following lists found.");
                                foreach (var item in list)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                        }
                        else if (value.ToLower().Equals("-new"))
                        {
                            if (args.Count() > 2)
                            {
                                var wordList = new WordList(args[1], args.Skip(2).ToArray());
                                wordList.Save();
                                Console.WriteLine("New list created with name " + args[1]);
                                WordInput(args[1]);
                            }
                            else
                            {
                                Console.WriteLine("Not valid arguments.");
                                PrintError();
                            }
                        }
                        else if (value.ToLower().Equals("-add"))
                        {
                            if (args.Length >= 2)
                            {
                                WordInput(args[1]);
                            }
                            else
                            {
                                PrintError();
                            }
                        }
                        else if (value.ToLower().Equals("-remove"))
                        {
                            if (args.Length >= 3)
                            {
                                var wordList = WordList.LoadList(args[1]);
                                if (wordList == null)
                                {
                                    throw new Exception("Can not find this list with name " + args[1]);
                                }

                                var indexOfLanguage = wordList.Languages.ToList().IndexOf(args[2]);
                                if (indexOfLanguage >= 0)
                                {
                                    var words = args.Skip(3);
                                    foreach (var word in words)
                                    {
                                        wordList.Remove(indexOfLanguage, word);
                                        Console.WriteLine("Word " + word + " removed from " + args[2]);
                                    }
                                }

                                wordList.Save();
                            }
                            else
                            {
                                PrintError();
                            }
                        }
                        else if (value.ToLower().Equals("-words"))
                        {
                            var wordList = WordList.LoadList(args[1]);
                            if (wordList == null)
                            {
                                throw new Exception("Can not find this list with name " + args[1]);
                            }

                            var indexOfLanguage = 0;
                            if (args.Length > 2)
                            {
                                indexOfLanguage = wordList.Languages.ToList().IndexOf(args[2]);
                            }

                            wordList.List(indexOfLanguage, (translations) =>
                            {
                                foreach (var translation in translations)
                                {
                                    Console.WriteLine(translation);
                                }
                            });
                        }
                        else if (value.ToLower().Equals("-count"))
                        {
                            var wordList = WordList.LoadList(args[1]);
                            if (wordList == null)
                            {
                                throw new Exception("Can not find this list with name " + args[1]);
                            }

                            Console.WriteLine("There are " + wordList.Count() + " words in " + wordList.Name);
                        }
                        else if (value.ToLower().Equals("-practice"))
                        {
                            var wordList = WordList.LoadList(args[1]);
                            if (wordList == null)
                            {
                                throw new Exception("Can not find this list with name " + args[1]);
                            }

                            List<PracticeResults> results = new List<PracticeResults>();
                            Random random = new Random();
                            while (true)
                            {
                                var word = wordList.GetWordToPractice();

                                if (word == null)
                                {
                                    Console.WriteLine("List is empty, no word found.");
                                    break;
                                }

                                var indexFrom = random.Next(0, word.Translations.Count() - 1);
                                var indexTo = random.Next(0, word.Translations.Count() - 1);
                                while (indexTo == indexFrom)
                                {
                                    indexTo = random.Next(0, word.Translations.Count() - 1);
                                }

                                //Check if word is removed
                                if (string.IsNullOrWhiteSpace(word.Translations[indexFrom]) || string.IsNullOrWhiteSpace(word.Translations[indexTo]))
                                {
                                    continue;
                                }

                                Console.WriteLine("Please translate " + word.Translations[indexFrom] + " from " + wordList.Languages[indexFrom] + " to " + wordList.Languages[indexTo]);

                                var input = Console.ReadLine();

                                if (string.IsNullOrWhiteSpace(input))
                                {
                                    break;
                                }

                                if (input.ToLower() == word.Translations[indexTo].ToLower())
                                {
                                    Console.WriteLine("Correct. Lets do next!");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry! Correct translation is " + word.Translations[indexTo]);
                                }

                                results.Add(new PracticeResults()
                                { 
                                    Answer = input,
                                    ExpectedAnswer = word.Translations[indexTo],
                                    TranslationFrom = wordList.Languages[indexFrom],
                                    TranslationTo = wordList.Languages[indexTo],
                                    Word = word.Translations[indexFrom],
                                });
                            }

                            Console.WriteLine("Practice Summary");
                            Console.WriteLine("Practice Words: " + results.Count);
                            Console.WriteLine("Correct: " + results.Count(a => a.IsCorrect));
                            Console.WriteLine("Wrong: " + results.Count(a => !a.IsCorrect));
                            Console.WriteLine("Details");
                            Console.WriteLine("====================================");
                            foreach (var item in results)
                            {
                                Console.WriteLine("Word: " + item.Word);
                                Console.WriteLine("Translation From: " + item.TranslationFrom);
                                Console.WriteLine("Translation To: " + item.TranslationTo);
                                Console.WriteLine("Answer: " + item.Answer);
                                Console.WriteLine("Expected Answer: " + item.ExpectedAnswer);
                                Console.WriteLine("Is Correct: " + (item.IsCorrect ? "Yes" : "No"));
                                Console.WriteLine("====================================");
                            }
                        }
                        else
                        {
                            PrintError();
                        }
                    }
                }
                else
                {
                    PrintError();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                PrintError();
            }


            Console.WriteLine("");
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();

            //WordList instance = WordList.LoadList(list[0]);

            //instance.Remove(1, "blomma");

            //instance.Save();

            //var word = instance.GetWordToPractice();
        }

        private static void WordInput(string listName)
        {
            Console.WriteLine("We are writing words in list " + listName);
            var wordList = WordList.LoadList(listName);
            while (true)
            {
                List<string> translations = new List<string>();
                foreach (var language in wordList.Languages)
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Please write word for language: " + language);
                    var word = "";
                    while (string.IsNullOrEmpty(word))
                    {
                        word = Console.ReadLine();
                    }

                    translations.Add(word);
                }

                wordList.Add(translations.ToArray());

                Console.WriteLine("Do you want to enter more words? Press Y to continue. Enter to exit.");
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.Y)
                {
                    continue;
                }
                else
                {
                    wordList.Save();
                    break;
                }
            }
        }

        static void PrintError()
        {
            Console.WriteLine("Use any of the following parameters:");
            Console.WriteLine("-lists");
            Console.WriteLine("-new <list name> <language 1> <language 2> .. <langauge n>");
            Console.WriteLine("-add <list name>");
            Console.WriteLine("-remove <list name> <language> <word 1> <word 2> .. <word n>");
            Console.WriteLine("-words <listname> <sortByLanguage>");
            Console.WriteLine("-count <listname>");
            Console.WriteLine("-practice <listname>");
            Console.ReadLine();
        }
    }

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

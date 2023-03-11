using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _NET_End_Translator
{
    class Program
    {
        [Serializable]
        public class Translator
        {
            public string Eng_Word { set; get; }
            public string Russ_Word { set; get; }

            public Translator() { }
            public Translator(string EW, string RW)
            {
                Eng_Word = EW;
                Russ_Word = RW;
            }
           
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Dictionary<string, Translator> tranlator = new Dictionary<string, Translator>();
            Dictionary<string, Translator> tranlator2 = new Dictionary<string, Translator>();

            /* FileStream fileStream = new FileStream("TranslatorEng.xml", FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Translator>));// создание обьекта
            xmlSerializer.Serialize(fileStream, tranlator);

            FileStream file = new FileStream("TranslatorRuss.xml", FileMode.Create);
            XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(List<Translator>));
            xmlSerializer1.Serialize(file, translator2);*/

            Console.WriteLine("Выберите тип словоря: 1) Англо-русский 2)Русско-английский");
            int E= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите на какой язык хотите перевести --> 1)Английски 2)Русский");
            int A1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите cлово которое хотите перевести");
            string word = Console.ReadLine();
           
            tranlator.Add("Car", new Translator { Eng_Word = "Car", Russ_Word = "Машина" });
            tranlator.Add("Apple", new Translator { Eng_Word = "Apple", Russ_Word = "Яблоко" });
            tranlator.Add("Apple",new Translator { Eng_Word = "Apple", Russ_Word = "Дом" });
            tranlator.Add("Cat", new Translator { Eng_Word = "Cat", Russ_Word = "Кошка" });

            tranlator2.Add("Машина",new Translator { Eng_Word = "Машина", Russ_Word = "Car" });
            tranlator2.Add("Яблоко",new Translator { Eng_Word = "Яблоко", Russ_Word = "Apple" });
            tranlator2.Add("Дом",new Translator { Eng_Word = "Дом", Russ_Word = "House" });
            tranlator2.Add("Кошка",new Translator { Eng_Word = "Кошка", Russ_Word = "Cat" });
           
            if (A1==1)
            {
                if (tranlator.ContainsKey(word))
                {
                    Console.WriteLine(word + "-->" + tranlator[word]);
                }
                else
                {
                    Console.WriteLine("Такой страны нет!!");
                }
            }
            if (A1==2)
            {
                if (tranlator2.ContainsKey(word))
                {
                    Console.WriteLine(word+"-->"+tranlator2[word]);
                }
                else
                {
                    Console.WriteLine("Такой страны нет!!");
                }
            }

            Console.WriteLine("Введите на какой язык хотите перевести слово и добавить в словарь --> 1)Английски 2)Русский");
            int v = Convert.ToInt32(Console.ReadLine());
            if (v==2)
            {
                Console.WriteLine("Введите английское слово");
                string w = Console.ReadLine();
                Console.WriteLine("Введите русское слово");
                string word1 = Console.ReadLine();
                Translator translator2 = new Translator(w,word1);//записываю мои новые слова
                tranlator.Add(w, translator2);
            }
            if (v==1)
            {
                Console.WriteLine("Введите русское слово");
                string word1 = Console.ReadLine();
                Console.WriteLine("Введите английское слово");
                string w = Console.ReadLine();
                Translator translator1 = new Translator(word1, w);//записываю мои новые слова
                tranlator.Add(word1, translator1);
            }

        }

         
    }
}


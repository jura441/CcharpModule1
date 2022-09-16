// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region task1
// Рандомные числа
//using AIGuess;

//int userNumber;
//Random r = new Random();
//RandomNumberAndHisBool rnahb = new RandomNumberAndHisBool();

//do
//{
//    do { Console.WriteLine("Введите число в диапазоне от 0 до 100"); userNumber = Int32.Parse(Console.ReadLine()); }
//    while (userNumber < 0 || userNumber > 100);
//    rnahb = Guess.SimpleGuess(0, 100, r, userNumber, rnahb);
//    Console.WriteLine("Числа совпали с числом {0}? {1}", rnahb.RandomNumber, rnahb.HisBool.ToString());
//    Console.WriteLine("Хотя с {0} попытки комп справился!", Guess.EndlessnessGuess(0, 100, r, userNumber));
//    if (rnahb.HisBool) break;
//    Console.WriteLine("Нажмите Y для новой попыткию. Любую клавишу для отмены.");      
//}
//while (Console.ReadLine() == ConsoleKey.Y.ToString());
//namespace AIGuess
//{
//    internal class Guess
//    {
//        public static RandomNumberAndHisBool SimpleGuess(int min, int max, Random r, int userNumber, RandomNumberAndHisBool rnahb)
//        {
//            rnahb.RandomNumber = r.Next(min, max);
//            rnahb.HisBool = (bool) (rnahb.RandomNumber == userNumber);
//            return rnahb;
//        }
//        public static int EndlessnessGuess(int min, int max, Random r, int userNumber)
//        {
//            int buf = -1;
//            int count = 0;
//            while (buf != userNumber)
//            {
//                buf = r.Next(min, max);
//                count++;
//            }
//            return count;
//        }
//    }
//    internal class RandomNumberAndHisBool
//    {
//        public int RandomNumber { get; set; } = 0;
//        public bool HisBool { get; set; } = false;
//    }
//}
#endregion task1
using System.Text;
using Morse;
string startText;
Console.WriteLine("Введите текст для перевода в азбуку Морзе");
startText = Console.ReadLine();
startText = ConvertToMorse.TextToMorse(startText);

Console.WriteLine("Ваш текст в виде азбуки Морзе" + startText);

namespace Morse
{
    class ConvertToMorse
    {
        public static string TextToMorse(string alphaText)
        {
            char[] chars = alphaText.ToLower().ToCharArray();
            string[] massiveMorse = new string[] { "*-", "-***", "*--", "--*", "-**" };
            string[] massiveAlphabet = new string[] { "а", "б", "в", "г", "д" };
            string betaText;
            StringBuilder sb = new StringBuilder();
            int count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                foreach (string str in massiveAlphabet)
                {
                    if (chars[i] == str[0])
                    {
                        sb.Append(massiveMorse[count]);
                    }
                    count++;
                }
                count = 0;
            }
            return betaText = sb.ToString();
        }

        static string MorseToText()
        {
            return "";
        }
    }
}
    




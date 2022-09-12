// See https://aka.ms/new-console-template for more information


#region TASKONE
//Random random = new Random();
//int[] massive = new int[100];
//int[] uniq = new int[21];
//int countOne = 0, countTwo = 0;
//int countUniq = 0;
//for (int i = 0; i < 100; i++)
//{
//    massive[i] = random.Next(20);

//}
//for (int i = 0; i < massive.Length; i++)
//{
//    if (massive[i] % 2 == 0 || massive[i] == 0) { countOne++; }
//    else { countTwo++; }
//    Console.WriteLine(massive[i]);

//}
//for (int i = 0; i <= 20; i++)
//{
//    foreach (int j in massive)
//    {
//        if (i == j)
//        {
//            countUniq++;
//            if (countUniq > 1)
//            {
//                countUniq = 0;
//                uniq[i] = 0;
//                break;
//            }
//            else
//            {
//                uniq[i] = 1;
//            }
//        }
//    }
//}

//Console.WriteLine("Количство четных элементов: {0}", countOne);
//Console.WriteLine("Количство нечетных элементов: {0}", countTwo);
//Console.WriteLine("Уникальные числа в массиве:");
//for (int i = 0; i <= 20; i++) { if (uniq[i] == 1) { Console.WriteLine(i.ToString()); } }
#endregion TASKONE

#region TASKTWO
//Random random = new Random();
//int[] massive = new int[100];
//int counter=0;
//for (int i = 0; i < massive.Length; i++)
//{
//    massive[i] = random.Next(1000); 
//}
//Console.WriteLine("Введите число от 0 до 1000. Будут показаны все элементы меньше вашего числа:");
//try
//{
//    string number = Console.ReadLine();
//    int z = Int32.Parse(number);

//    for (int i = 0; i < massive.Length; i++)
//    {
//        if (massive[i] < z || massive[i] == 0)
//        {
//            counter++;
//            Console.WriteLine(massive[i]);
//        }
//    }
//    Console.WriteLine("Числа меньше {0} найдено {1} штук", z, counter);
//        }
//catch (Exception)
//{
//    Console.WriteLine("Только числа!");
//}
#endregion TASKTWO

#region TASKTHREE

using System.Text;
int[] massive = new int[12] {7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
int counter = 0;
string searchText;
string numberText = "";
StringBuilder sb = new StringBuilder();

for (int i = 0; i < massive.Length; i++)
{ 
sb.Append(massive[i]);    
}

numberText = sb.ToString();

Console.WriteLine("Массив для поиска числового вхождения: \n" + numberText);
searchText = Console.ReadLine();

for (int i = 0; i < numberText.Length; i++)
{
    if (numberText.Contains(searchText))
{
    int indexContains = numberText.IndexOf(searchText);
    counter++;
    numberText = numberText.Remove(0, indexContains + 1);

}
else
{
    Console.WriteLine("Искомой подстроки не обнаружено");
        break;
}
   }
Console.WriteLine("Искомая подстройка найдена {0} раз(а)", counter);


#endregion TASKTHREE

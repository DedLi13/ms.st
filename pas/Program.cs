// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаем двумерный массив символов
//         char[,] charArray = {
//             {'H', 'e', 'l', 'l', 'o'},
//             {'W', 'o', 'r', 'l', 'd'}
//         };

//         // Создаем строку из символов массива
//         string resultString = ConvertCharArrayToString(charArray);

//         // Выводим результат
//         Console.WriteLine("Исходный двумерный массив символов:");
//         PrintCharArray(charArray);

//         Console.WriteLine("\nРезультирующая строка:");
//         Console.WriteLine(resultString);
//     }

//     static string ConvertCharArrayToString(char[,] charArray)
//     {
//         int rows = charArray.GetLength(0);
//         int cols = charArray.GetLength(1);

//         char[] resultArray = new char[rows * cols];
//         int index = 0;

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 resultArray[index++] = charArray[i, j];
//             }
//         }

//         return new string(resultArray);
//     }

//     static void PrintCharArray(char[,] charArray)
//     {
//         int rows = charArray.GetLength(0);
//         int cols = charArray.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(charArray[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }



// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаем строку с латинскими буквами в обоих регистрах
//         string originalString = "HeLLo WoRLd";

//         // Формируем новую строку, в которой все заглавные буквы заменены на строчные
//         string resultString = ConvertToUpperToLower(originalString);

//         // Выводим результат
//         Console.WriteLine("Исходная строка: " + originalString);
//         Console.WriteLine("Результирующая строка: " + resultString);
//     }

//     static string ConvertToUpperToLower(string input)
//     {
//         char[] resultArray = new char[input.Length];

//         for (int i = 0; i < input.Length; i++)
//         {
//             char currentChar = input[i];

//             // Проверяем, является ли символ заглавной латинской буквой
//             if (Char.IsUpper(currentChar))
//             {
//                 // Заменяем на соответствующую строчную букву
//                 resultArray[i] = Char.ToLower(currentChar);
//             }
//             else
//             {
//                 // Оставляем символ без изменений, если это не заглавная буква
//                 resultArray[i] = currentChar;
//             }
//         }

//         return new string(resultArray);
//     }
// }


// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаем произвольную строку
//         string inputString = "level";

//         // Проверяем, является ли строка палиндромом
//         bool isPalindrome = IsPalindrome(inputString);

//         // Выводим результат
//         Console.WriteLine(isPalindrome ? "Да" : "Нет");
//     }

//     static bool IsPalindrome(string input)
//     {
//         // Преобразуем строку в массив символов
//         char[] charArray = input.ToCharArray();

//         // Создаем новый массив с обратным порядком символов
//         Array.Reverse(charArray);

//         // Преобразуем массив обратно в строку
//         string reversedString = new string(charArray);

//         // Сравниваем исходную строку с обратной
//         return input.Equals(reversedString, StringComparison.OrdinalIgnoreCase);
//     }
// }


// Задача 4*(не обязательная): Задайте строку, состоящую из слов, 
// разделенных пробелами. Сформировать строку, в которой слова 
// расположены в обратном порядке. В полученной строке слова должны 
// быть также разделены пробелами.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаем строку из слов, разделенных пробелами
//         string originalString = "This is a sample string";

//         // Формируем новую строку с обратным порядком слов
//         string reversedString = ReverseWords(originalString);

//         // Выводим результат
//         Console.WriteLine("Исходная строка: " + originalString);
//         Console.WriteLine("Строка с обратным порядком слов: " + reversedString);
//     }

//     static string ReverseWords(string input)
//     {
//         // Разбиваем строку на массив слов
//         string[] words = input.Split(' ');

//         // Изменяем порядок слов
//         Array.Reverse(words);

//         // Объединяем слова обратно в строку
//         string reversedString = string.Join(" ", words);

//         return reversedString;
//     }
// }


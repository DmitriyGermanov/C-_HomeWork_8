/*1. Напишите консольную утилиту для копирования файлов
Пример запуска: utility.exe file1.txt file2.txt*/

/*2.Напишите утилиту рекурсивного поиска файлов в заданном каталоге и подкаталогах*/

/*3.Напишите утилиту читающую тестовый файл и выводящую на экран строки содержащие искомое слово.*/

/*HomeWork: Объедините две предыдущих работы(практические работы 2 и 3): поиск файла и поиск текста в файле написав утилиту которая ищет файлы определенного расширения с указанным текстом. Рекурсивно. Пример вызова утилиты: utility.exe txt текст.*/

using Seminar_8;

internal class Program
{
    private static void Main(string[] args)
    {
        var search = new FindFileWithText();
        var result = new Dictionary<String, List<String>>();
        try
        {
            result = search.Search(args);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        if (result.Any())
        {
            foreach (var item in result)
            {
                Console.WriteLine($"Для файла {item.Key} найдены следующие строки:");
                Console.WriteLine(String.Join("\n", item.Value));
            }
        }
        else
        {
            Console.WriteLine("По Вашему запросу файлы не найдены!");
        }




        //Ниже код работы на семинаре

        /*    //CopyToFile.CopyTo(args);
            FindFile find = new();
            var result = new List<string>();
            try
            {
                result = find.Search(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (result.Any())
            {
                result.ForEach(x => Console.WriteLine(x + "\n"));
            }
            else
            {
                Console.WriteLine("Файлы не найдены");
            }*/
        /*       var findWord = new FindWordsInFile();
               try
               {
                   var result = findWord.FindWords(args);
                   if(!result.Any())
                       Console.WriteLine("Слово в данном файле не найдено");
                   else
                      {
                       Console.WriteLine("Слово найдено в следующих строках:");
                       Console.WriteLine(String.Join("\n", result));

                   } 
               }
               catch (Exception ex)
               {
                   Console.WriteLine(ex.Message);
               }*/

    }


}
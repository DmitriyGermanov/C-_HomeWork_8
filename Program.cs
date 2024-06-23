/*1. Напишите консольную утилиту для копирования файлов
Пример запуска: utility.exe file1.txt file2.txt*/
/*2.Напишите утилиту рекурсивного поиска файлов в заданном каталоге и подкаталогах*/
/*Напишите утилиту читающую тестовый файл и выводящую на экран строки содержащие искомое слово.*/

using Seminar_8;

internal class Program
{
    private static void Main(string[] args)
    {
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
        var findWord = new FindWordsInFile();
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
        }
        
    }


}
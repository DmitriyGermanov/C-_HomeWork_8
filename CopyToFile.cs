namespace Seminar_8
{
    public class CopyToFile
    {
        public static void CopyTo(string[] args)
        {
            string currentDir = Directory.GetCurrentDirectory();
            List<string> paths = new();
            if (args.Length < 2)
            {
                Console.WriteLine("Для корректной работы введите 2 аргумента, пример: utility.exe file1.txt file2.txt");
                return;
            }
            foreach (var arg in args)
            {
                paths?.Add(Path.Combine(new string[] { currentDir, arg }));
            }
            try
            {
                File.Copy(paths[0], paths[1], true);
                Console.WriteLine("Копирование файлов было завершено успешно!");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Исходный файл {args[0]} не был найден и программа завершилась с ошибкой {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Программа завершилась с ошибкой " + e.Message);
            }
        }
    }
}

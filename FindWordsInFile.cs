namespace Seminar_8
{
    internal class FindWordsInFile
    {
        public List<String> FindWords(string[] args)
        {
            if (args.Length < 2 || args.Length > 2)
            {
                throw new ArgumentException("Метод FindWords класса FindWordsInFile принимает 2 аргумента: путь к файлу, слово для поиска");
            }
 
            return FindWordsPrivate(args[0], args[1]);
        }


        private List<String> FindWordsPrivate (string path, string word)
        {

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не существует!");
            }
            string[] file = File.ReadAllLines(path);
            return file.Where(line => line.ToLower().Contains(word, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}

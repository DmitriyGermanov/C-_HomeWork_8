namespace Seminar_8
{
    internal class FindFileWithText
    {
        public Dictionary<String, List<String>> Search(string[] args)
        {
            if (args.Length < 3 || args.Length > 3)
                throw new ArgumentException("Метод Dictionary класса FindFileWithText принимает 3 аргумента: путь, расширение файла, текст для поиска");
            var findWords = new FindWordsInFile();
            var findFilesPath = new FindFile();
            var fileList = findFilesPath.Search(new string[] { args[0], args[1] });
            Dictionary<String, List<String>> result = new();

            foreach (var item in fileList)
            {
                List<String> str = findWords.FindWords(new string[] { item, args[2] });
                if (str.Any())
                    result.Add(Path.GetFileName(item), str);
            }
            return result;

        }

    }
}

namespace Seminar_8
{
    internal class FindFileWithText
    {
        public Dictionary<String, List<String>> Search(string[] args)
        {
            if (args.Length < 3 || args.Length > 3)
                throw new Exception("Программа принимает 3 аргумента: путь, расширение файла, искомый текст");
            var findWords = new FindWordsInFile();
            var fileList = SearchForFilesPaths(args[0], args[1]);
            Dictionary<String, List<String>> result = new();

            foreach (var item in fileList)
            {
                List<String> str = findWords.FindWords(new string[] { item, args[2] });
                if (str.Any())
                    result.Add(Path.GetFileName(item), str);
            }
            return result;

        }
        private List<string> SearchForFilesPaths(string path, string extension)
        {

            var list = new List<string>();
            if (!Directory.Exists(path))
                throw new Exception("Директории не существует");
            DirectoryInfo root = new DirectoryInfo(path);
            var files = root.GetFiles();
            var directories = root.GetDirectories();

            foreach (var item in files)
            {
                if (item.Name.Contains(extension))
                {
                    list.Add(Path.Combine(item.Directory.FullName, item.Name));
                }
            }


            foreach (var item in directories)
            {
                list.AddRange(SearchForFilesPaths(item.FullName, extension));
            }
            return list;

        }
    }
}

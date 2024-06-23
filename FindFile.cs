namespace Seminar_8
{
    public class FindFile
    {
        public List<String> Search(string[] args)
        {
            if (args.Length < 2 || args.Length > 2)
                throw new ArgumentException("Метод Search класса FindFile принимает 2 аргумента: путь, имя файла");
            return SearchIn(args[0], args[1]);
        }
        private List<string> SearchIn(string path, string name)
        {

            var list = new List<string>();
            if (!Directory.Exists(path))
                throw new Exception("Директории не существует");
            DirectoryInfo root = new DirectoryInfo(path);
            var files = root.GetFiles();
            var directories = root.GetDirectories();

            foreach (var item in files)
            {
                if (item.Name.Contains(name))
                {
                    list.Add(item.FullName);
                }
            }


            foreach (var item in directories)
            {
                list.AddRange(SearchIn(item.FullName, name));
            }
            return list;

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

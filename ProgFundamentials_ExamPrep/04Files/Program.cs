using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _04Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int filesNum = int.Parse(Console.ReadLine());
            Dictionary<string, List<Directory>> fileDir = new Dictionary<string, List<Directory>>();
            for (int i = 0; i < filesNum; i++)
            {
                string file = Console.ReadLine();
                string root = GetFileRoot(file);
                long fileSize = long.Parse(file.Split(';').Skip(1).First().Trim());
                string fileNamePlusExtention = getFileName(file.Split(';').First().Trim());
                if (root != null)
                {
                    if (fileDir.Any(a => a.Key == root))
                    {
                        if(fileDir[root].Any(a=>a.FilePlusExtention== fileNamePlusExtention))
                        {
                            fileDir[root].First(a => a.FilePlusExtention == fileNamePlusExtention).FileSize = fileSize;
                        }
                        else
                        {
                            fileDir[root].Add(new Directory
                            {
                                FileSize = fileSize,
                                FilePlusExtention = fileNamePlusExtention
                            });
                        }
                    }
                    else
                    {
                        fileDir[root] = new List<Directory>();
                        fileDir[root].Add(new Directory
                        {
                            FileSize = fileSize,
                            FilePlusExtention = fileNamePlusExtention
                        });
                    }
                }
            }
            string fileExtentionAndRoot = Console.ReadLine();
            GetOutput(fileExtentionAndRoot, fileDir);
        }

        private static void GetOutput(string fileExtentionAndRoot, Dictionary<string, List<Directory>> fileDir)
        {
            string [] searchFileInfoArray = fileExtentionAndRoot.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string file = "."+searchFileInfoArray[0];
            string root = searchFileInfoArray[searchFileInfoArray.Length - 1];
            bool fileMatch = false;
            if (fileDir.ContainsKey(root))
            {
                foreach (var files in fileDir[root].OrderByDescending(x=>x.FileSize).ThenBy(x=>x.FilePlusExtention))
                {
                        if (files.FilePlusExtention.EndsWith(file))
                        {
                            Console.WriteLine($"{files.FilePlusExtention} - {files.FileSize} KB");
                            fileMatch = true;
                        }
                }
            }
            if (fileMatch == false)
            {
                Console.WriteLine("No");
            }
        }

        private static string getFileName(string v)
        {
            string[] fileArr = v.Split('\\');
            return fileArr[fileArr.Length - 1];
        }

        private static string GetFileRoot(string file)
        {
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i] == '\\')
                {
                    return file.Substring(0, i);
                }
            }
            return null;
        }

        class Directory
        {
            public string FilePlusExtention { get; set; }
            public long FileSize { get; set; }
        }
    }
}

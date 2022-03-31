using System;
using System.IO;

namespace GetFilesName
{
    class GetFilesName
    {
        static void Main(string[] args)
        {
            if (args.Length == 1 && args[0] == "-fullpath") // Syntax : GetFileName.exe -fullpath
            {
                DirNotSpecified(1);     
            }

            else if (args.Length == 0) //  Syntax : GetFileName.exe

            {
                DirNotSpecified(0); 
            }

            else if (args.Length == 1) //  Syntax : GetFileName.exe <dir>

            {
                DirSpecified(args, 0); 
            }

            else if (args.Length == 2 && args[0] == "-fullpath")  //  Syntax : GetFileName.exe -fullpath 

            {
                DirSpecified(args, 1); 
            } 

        }
        public static void DirNotSpecified(int i)

        {
            var getfiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.*", SearchOption.AllDirectories);
            using (StreamWriter filelist = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "filelist.list")))

                if (i == 0)
                {
                    foreach (string file in getfiles)

                    {
                        filelist.WriteLine(Path.GetFileName(file));
                        Console.WriteLine(file);
                    }
                }

                else if (i == 1)

                {
                    foreach (string file in getfiles)

                    {
                        filelist.WriteLine(Path.GetFullPath(file));
                        Console.WriteLine(file);
                    }

                }

            Space();
            Console.WriteLine("Number of files found: " + getfiles.Length);
        }

        public static void DirSpecified(string[] args, int i)

        {
            var getfiles = Directory.GetFiles(args[i], "*.*", SearchOption.AllDirectories);
            using (StreamWriter filelist = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "filelist.list")))
   
                if (i == 0)
                {
                    foreach (string file in getfiles)

                    {
                        filelist.WriteLine(Path.GetFileName(file));
                        Console.WriteLine(file);
                    }
                }

                else if (i == 1)

                {
                    foreach (string file in getfiles)

                    {
                        filelist.WriteLine(Path.GetFullPath(file));
                        Console.WriteLine(file);
                    }

                }
           
            Space();
            Console.WriteLine("Number of files found: " + getfiles.Length);
        }

        public static void Space()
        {
            Console.WriteLine();
            Console.WriteLine("__________________________________________");
            Console.WriteLine();
        }
    }

 }

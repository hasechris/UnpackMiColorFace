using System;
using System.IO;
using UnpackMiColorFace.Helpers;

namespace UnpackMiColorFace
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MainBody(args);
        }

        static void MainBody(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("usage: UnpackMiColorFace example.bin");
                return;
            }

            string filename = args[0];

            if (!File.Exists(filename))
            {
                Console.WriteLine($"File {filename} is not found.");
                return;
            }

            try
            {
                Unpacker.Exec(filename);
            }
            catch (MissingFieldException)
            {
                Console.WriteLine("Seems wrong file passed,\r\nPlease check a source file is correct Watchface");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Got unexcepted error,\r\nPlease check a source file is correct Watchface");
            }
        }
    }
}

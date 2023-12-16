using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class CreateDeleteDirectory
    {
        static void Main(string[] args)
        {
            ////create New Directory
            //string path = @"C:\Users\Yadynesh.mendhi\OneDrive - Systems Plus Pvt. Ltd\Documents";
            //DirectoryInfo directoryInfo = new DirectoryInfo(path);
            //try
            //{
            //    directoryInfo.CreateSubdirectory("SubDirectory");
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Delete Directory
            //string path2 = @"C:\Users\Yadynesh.mendhi\OneDrive - Systems Plus Pvt. Ltd\Documents\SubDirectory";
            //Directory.Delete(path2);

            ////Create a file.txt

            //string file = @"C:\Users\Yadynesh.mendhi\OneDrive - Systems Plus Pvt. Ltd\Documents\SubDirectory\file2.txt";
            //FileStream filestream = File.Create(file);

            //Write text to the file
            //string path = @"C:\Users\Yadynesh.mendhi\OneDrive - Systems Plus Pvt. Ltd\Documents\SubDirectory\file3.txt";

            ////file does'nt already exist
            //if (!File.Exists(path))
            //{
            //    using (StreamWriter streamWriter = File.CreateText(path))
            //    {
            //        streamWriter.WriteLine("Hello I am Yadynesh");
            //    }
            //}

            ////append text to the file
            //File.AppendAllText(@"C:\Users\Yadynesh.mendhi\OneDrive - Systems Plus Pvt. Ltd\Documents\SubDirectory\file3.txt", "Mendhi");
            Console.ReadLine();

            //Move the file source to destination
            File.Move(@"C:\Users\Yadynesh.mendhi\OneDrive - Systems Plus Pvt. Ltd\Documents\SubDirectory\file2.txt", @"C:\Users\Yadynesh.mendhi\OneDrive - Systems Plus Pvt. Ltd\Documents\Subdirectory2\bdjbdwcb");


            //delete file 

        }
    }
}

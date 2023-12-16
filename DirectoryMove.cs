using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class DirectoryMove
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\Yadynesh.mendhi\OneDrive - Systems Plus Pvt. Ltd\Documents\SubDirectory";
            string destination = @"C:\Users\Yadynesh.mendhi\OneDrive - Systems Plus Pvt. Ltd\Pictures";


            try
            {
                //directory exist or not
                if (Directory.Exists(source))
                {
                    //directory does't already exist
                    if (!Directory.Exists(destination))
                    {
                        Directory.Move(source, destination);
                    }
                    else
                    {
                        Console.WriteLine("Already existed");
                    }
                }
                else
                {
                    Console.WriteLine("source directory" + "Does'nt exist");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

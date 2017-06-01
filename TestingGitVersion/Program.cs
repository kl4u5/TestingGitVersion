using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGitVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Here ar some danish characters: æøå HEJ");

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
          
            string version = fvi.FileVersion;

            Console.WriteLine("FileVersion: " + version);

            Console.Write("Press any key to exit:");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace MoveFileWithNativeProgressBar
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                return 1;
            }

            try
            {
                FileSystem.MoveFile(
                                args[0],
                                args[1],
                                UIOption.AllDialogs,
                                UICancelOption.DoNothing
                            );
            } catch (System.IO.FileNotFoundException fileNotFoundException)
            {
                Console.WriteLine("ERROR: \"" + args[0] + "\" file NOT FOUND.");
                return 1;
            }
            Console.WriteLine("\"" + args[1] + "\" successfully transfered.");
            return 0;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.FileIO;
using System.IO;


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

			if (hasIllegalCharacters(args[1])){
					Console.WriteLine("ERROR: \"" + args[1] + "\" contains illegal characters.");
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
            } catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("ERROR: \"" + args[0] + "\" file NOT FOUND.");
                return 1;
            }
            Console.WriteLine("\"" + args[1] + "\" successfully transfered.");
            return 0;
        }

		static bool hasIllegalCharacters(string name){
			var illegalCharactersInName = new List<String>() { "<",">","\"","/","|","?","*"}; //List of illegal characters in Windows file path
			// Illegal characters "\" and ":" have been removed, because they are part of the path name

			return illegalCharactersInName.Any(name.Contains) || Path.GetFileNameWithoutExtension(name).Contains(":");
		}
    }
}


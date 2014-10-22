﻿/*************************************************************************
 * Project: CookML
 * Copyright: Joe Collins (c) 2003
 * Purpose: 
 * $Author: cookml $
 * $Date: 2011-07-20 13:01:57 +0100 (Wed, 20 Jul 2011) $
 * $Workfile: $
 * $Revision: 12 $
 ************************************************************************/
using System;
using System.IO;

namespace CookML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Update the schema so it includes all the ingredient types
            CookMLConsole.Schema schema = new CookMLConsole.Schema();
            schema.UpdateSchema();
            // Transform the CookML 
            CookMLConsole.Transformer transformer = new CookMLConsole.Transformer();
            string lastFile = transformer.CreateBook(@"../../Input/FoodFile.xml");
            // Rename last file to LaTeX
            File.Copy(lastFile, @"../../Output/FoodFile.tex", true);

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}

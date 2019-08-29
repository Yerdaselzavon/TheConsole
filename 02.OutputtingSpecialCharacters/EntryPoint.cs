class EntryPoint
{
    static void Main()
    {
        string exeFile = "word.exe\"";
        string pathToExe = "\"C:\\Program Files\\Microsoft Word\\";
        //Have to put a slash to escape special characters, as most special characters are reserved for certain utilities
        System.Console.WriteLine(pathToExe + exeFile);
        string exeFile2 = @"word.exe""";
        string pathToExe2 = @"""C:\Program Files\Microsoft Word\";
        System.Console.WriteLine(pathToExe2 + exeFile2);
        // @ allows you to escape symbols without backslashes but quotation marks require an additional quotation mark to escape
        // Escape takes away the functionality of \, \n would no longer work and just be outputed as string
        //below is string output challenge
        System.Console.WriteLine("C:\\Program Files\\\"Microsoft Programs\"\\'VisualStudio'");
        //using \ escaping
        System.Console.WriteLine(@"C:\Program Files\""Microsoft Programs""\'VisualStudio'");
        // using @
        System.Console.WriteLine($"{{{pathToExe}{exeFile}}}");
        //for string interpolation, same as other special characters, you have to double up curly bois
    }
}
using System.IO;

    string fileName = "NewFile.txt";

    Console.WriteLine(File.Exists(fileName));

    File.WriteAllText(fileName, "Something");

    Console.WriteLine(File.Exists(fileName));
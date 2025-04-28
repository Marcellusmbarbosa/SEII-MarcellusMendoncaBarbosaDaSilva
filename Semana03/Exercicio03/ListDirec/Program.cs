using System.IO;

string path = "//home/marco/Downloads/";

string[] files = Directory.GetFiles(path);
foreach (string file in files)
    Console.WriteLine(file);


using System.IO;

string directoryName = "New_Folder";

Directory.CreateDirectory(directoryName);

Console.WriteLine("Succes to create the directory: " + directoryName);
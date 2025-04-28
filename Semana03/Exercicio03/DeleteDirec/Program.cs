using System.IO;

string directoryName = "New_Folder";

Directory.Delete(directoryName);

Console.WriteLine("Succes do delete the directory: " + directoryName);
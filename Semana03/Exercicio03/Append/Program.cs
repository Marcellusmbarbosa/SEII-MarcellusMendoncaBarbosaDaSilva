using System.IO;

string fileName = "Documents.txt";

string contents = File.ReadAllText(fileName);

Console.WriteLine("File contents \n" + contents + "\n");

File.AppendAllText(fileName, "Documento 3.");

contents = File.ReadAllText(fileName);
Console.WriteLine("File contents \n" + contents + "\n");

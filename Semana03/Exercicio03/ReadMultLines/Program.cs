using System.IO;

string fileName = "Documents.txt";

string[] documentos = File.ReadAllLines(fileName);

foreach(string documentositem in documentos)
    Console.WriteLine(documentositem);


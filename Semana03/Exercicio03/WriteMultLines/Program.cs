using System.IO;

string fileName = "Documents.txt";

string[] documents = {"Documento 1,", "Documento 2."};

File.WriteAllLines(fileName, documents);

Console.WriteLine("Success do write the file " + fileName);
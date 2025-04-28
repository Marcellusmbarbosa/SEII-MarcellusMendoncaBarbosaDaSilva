using System.IO;

string fileName = "Hello_World.txt";

string text = File.ReadAllText(fileName);

Console.WriteLine("Contetudo do arquivo " + fileName + ": " + text);

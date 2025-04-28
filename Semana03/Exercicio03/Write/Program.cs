using System.IO;

string fileName = "Hello_World.txt";

string text = "Hello World!";

File.WriteAllText(fileName, text);

Console.WriteLine("Success to create a file " + fileName);



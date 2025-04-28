using System.IO;

string directory = "Folder";

if(Directory.Exists(directory)){
    Console.WriteLine("Finded directory!");
}
else
{
    Console.WriteLine("Directory could not finded!");
}

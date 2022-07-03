
// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

/*
try
{
    // Open the text file using a stream reader.
    using (var sr = new StreamReader("deneme.txt"))
    {
        // Read the stream as a string, and write the string to the console.
        Console.WriteLine(sr.ReadToEnd());
    }
}
catch (IOException e)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}
*/


StreamReader sr = new StreamReader("deneme.txt");
string satir = ""; int counter = 0;
while (true)
{

    satir = sr.ReadLine();
    string[] bakalim = satir.Split(' ');
    string[] calisanDizisi = new string[int.Parse(bakalim[0])];
    string[] projeDizisi = new string[int.Parse(bakalim[0])];

    counter++;
    if (counter == 1)
    {
        break;
    }
    Console.WriteLine(satir);
}

counter = 0;
string satirr = "";
ArrayList DinamikDizi = new ArrayList();
while (true)
{

    satir = sr.ReadLine();


    /*if (counter == 0)
    {
        continue;
    }*/

    string[] parca = satir.Split(' ');
    int countYetenek = int.Parse(parca[1]);
    for(int i = 0; i < countYetenek; i++)
    {
        satirr = sr.ReadLine();
        DinamikDizi.Add(satirr);
    }

    Console.WriteLine(satir);
    counter++;

}

Console.ReadKey();
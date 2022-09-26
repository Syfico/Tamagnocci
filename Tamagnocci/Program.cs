using System;

Console.WriteLine("Hallåå däär, hjärtligt välkommen till Tamagnocci!");

Tamagnocci minTama = new Tamagnocci();

Console.WriteLine("Välj ett vackert namn till din tamagnocci!");
minTama.namn = Console.ReadLine();

Console.WriteLine($"Nämen se där! {minTama.namn} är ett otroligt passande namn för den här lilla filuren!");

while (minTama.BliTillLiv() == true)
{
    Console.Clear();
    minTama.PrintStats();
    Console.WriteLine("Vaad ska du hitta på nuurå?");
    Console.WriteLine($"1. Lär ut {minTama.namn} ett nytt ord");
    Console.WriteLine($"2. Praata med {minTama.namn}");
    Console.WriteLine($"3. Maata {minTama.namn}");
    Console.WriteLine($"4. Rulla tummaarna");

    string görVad = Console.ReadLine();
    if (görVad == "1")
    {
        Console.WriteLine("Vadåå för ord?");
        string word = Console.ReadLine();
        minTama.Teach(word);
    }
    if (görVad == "2")
    {
        minTama.HallååDäär();
    }
    if (görVad == "3")
    {
        minTama.Mata();
    }
    else
    {
        Console.WriteLine("Rullar tummarna...");
    }
    minTama.Nedräkning();

}

Console.WriteLine($"Jag har närt en kommunist vid min barm! {minTama.namn} blev socialist!");
Console.WriteLine("Tryck ENTER för att ge upp hoppet");
Console.ReadLine();


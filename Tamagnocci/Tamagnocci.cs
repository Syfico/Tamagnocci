using System.Net;
using System;
using System.Collections.Generic;

public class Tamagnocci
{
    private int hunger;
    private int tråkometern;
    private List<string> ordlista = new List<string>() { "Ärru goo ellerr" };
    private bool ärVidLiv;
    private Random generator;
    public string namn;

    public Tamagnocci()
    {
        generator = new Random();
        ärVidLiv = true;
    }

    public void Mata()
    {
        Console.WriteLine($" [{namn}] käkar å hungern försvinner");
        hunger -= 2;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void HallååDäär()
    {
        int wordNum = generator.Next(ordlista.Count);
        Console.WriteLine($" [{namn}] says: {ordlista[wordNum]}");
        MinskaTråkometern();
    }

    public void LärUt(string ord)
    {
        Console.WriteLine($" [{namn}] lär sig: {ord}");
        ordlista.Add(ord);
        MinskaTråkometern();
    }

    public void Nedräkning()
    {
        hunger++;
        tråkometern++;
        if (hunger > 10 || tråkometern > 10)
        {
            ärVidLiv = false;
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"namn: {namn} || Hunger: {hunger} || Tråkometern: {tråkometern} || Ordförråd: {ordlista.Count} ord");
    }

    public bool BliTillLiv()
    {
        return ärVidLiv;
    }

    public void MinskaTråkometern()
    {
        Console.WriteLine($" [{namn}] is now less bored!");

        tråkometern -= 2;
        if (tråkometern < 0)
        {
            tråkometern = 0;
        }
    }
}



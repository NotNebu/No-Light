using No_Light_RPG;
using System;
using System.Threading;

public class Game
{
    public void Start()
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("     WELCOME TO THE ADVENTURE      ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();
        Console.WriteLine();

        Player player = new Player(playerName);
        Thread.Sleep(5000);
        player.ChooseClass();
    }
}


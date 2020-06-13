using System;

public class Player
{
    string name;
    Boolean sex;

    int hp;
    int attack;
    int defend;

    public static uint CountOfPlayer;
    public Player(string n)
    {
        name = n;
        CountOfPlayer++;
    }

    public void GetInfomation()
    {
        Console.WriteLine(name); 
    }
}

public class test
{
    static void Main()
    {
        Player p1 = new Player("LingQi");
        p1.GetInfomation();
        Player p2 = new Player("WangZhi");  //comment
        //comment
        Console.WriteLine(Player.CountOfPlayer);
    }
}
using System;
using RPGOO.src.Entities;

namespace RPGOO
{
    class Program
    {
        static void Main(string[]args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");


            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
        }


    }
}
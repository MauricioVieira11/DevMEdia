using DevMEdia.Entities;
using System;
using System.Globalization;


namespace DevMEdia
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = ("Mauricio Luis Pantoja Vieira");
            p.Bracos = 2;
            p.Pernas = 2;
            p.Olhos = 2;
            p.CorCabelos = "Preto";
            Console.WriteLine(p.Nome+" POssui "+
                p.Bracos+" braços "+p.Pernas+" Pernas "+
                p.Olhos+" olhos e cabelo "+p.CorCabelos+"\n");

            Pessoa p1 = new Pessoa("Loiro");
            p1.Nome = "Neymar Jr.";
            Console.WriteLine(p1.Nome + ": POssui " +
                p1.Bracos + " braços " + p1.Pernas + " Pernas " +
                p1.Olhos + " olhos e cabelo " + p1.CorCabelos + "\n");


            //  Console.WriteLine("Hello World!");
        }
    }
}

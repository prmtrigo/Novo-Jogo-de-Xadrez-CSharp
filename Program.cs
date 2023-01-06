// See https://aka.ms/new-console-template for more information
using System;
using tabuleiro;

namespace xadrez_console{
    static void Main(string[] args){

        Posicao P;

        P = new Posicao(3,4);

        Console.WriteLine("Posição: "+ P);

        Console.ReadLine();
    }
}

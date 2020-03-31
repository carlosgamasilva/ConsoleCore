using System;
using GameTOP.lib;

namespace gameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogo = new JogoCrente(new Jogador2(), new Jogador3());
           jogo.IniciarJogo();
        }
    }

}

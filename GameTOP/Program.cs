using System;
using GameTOP.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando jogador 2 e 3 com parametro usando interface
           var jogo = new JogoCrente(new Jogador2(), new Jogador3());
           jogo.IniciarJogo();
        }
    }

}

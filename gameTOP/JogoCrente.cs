﻿using GameTOP.Interface;

namespace gameTOP
{
    class JogoCrente
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public JogoCrente(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }

        public void IniciarJogo()
        {
            System.Console.Write("\nJogador 1 \n");

            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Passe());

            System.Console.Write("\nJogador 2 \n");

            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passe());
            System.Console.Write(_jogadorB.Corre());
        }

    }
}
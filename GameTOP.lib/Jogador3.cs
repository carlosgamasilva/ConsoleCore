using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "teste esta chutando \n";
        }

        public string Corre()
        {
            return "teste esta correndo \n";
        }

        public string Passe()
        {
            return "teste esta passando \n";
        }
    }
}
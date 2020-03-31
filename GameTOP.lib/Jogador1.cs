using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador1 : iJogador
    {
        public string _Nome { get; set; }

        public Jogador1(string nome="Ronaldo")
        {
            _Nome = nome;
        }

        //chuta
        public string Chuta()
        {
            return $"{_Nome} esta chutando \n";
        }

        //corre
        public string Corre()
        {
            return $"{_Nome} esta Correndo \n";
            
        }

        //passe        
        public string Passe()
        {
            return $"{_Nome} esta passando \n";
            
        }
        
    }
}
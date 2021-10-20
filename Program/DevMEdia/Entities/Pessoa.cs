
namespace DevMEdia.Entities
{
    public class Pessoa
    {
        public Pessoa(string cabelo)
        {
            Olhos = 2;
            Bracos = 2;
            Pernas = 2;
            CorCabelos = cabelo;
        }
        public string Nome { get; set; }
        public int Olhos { get; set; }
        public string CorCabelos { get; set; }
        public int Bracos { get; set; }
        public int Pernas { get; set; }


        public Pessoa()// construtor padrão. cria o objeto na memória
        {

        }




        
    }
}

namespace MiniProjeto_PesquisaComLINQ.Models

{
    public class Imovel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Cidade Cidade { get; set; }
        public double Valor { get; set; }

        public Imovel() { }
        public Imovel(Imovel imovel) { }
    }
}

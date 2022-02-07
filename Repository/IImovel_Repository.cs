using MiniProjeto_PesquisaComLINQ.Models;

namespace MiniProjeto_PesquisaComLINQ.Repository
{
    public interface IImovel_Repository
    {
        //CRUD
        public void Add_Imovel(Imovel imovel);
        public void Update_Imovel(Imovel imovel);
        public List<Imovel> Get_Imovel();
        public void Delete_Imovel(Imovel imovel);

        //Search Metods
        public List<Imovel> Get_Imovel_By_Name(string name);
        public List<Imovel> Get_Imovel_by_Cidade(string cidade);
        public List<Imovel> Get_Imovel_by_Value(double valor, bool maior_ou_menor);              
        
    }
}

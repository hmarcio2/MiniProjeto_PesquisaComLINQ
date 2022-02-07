using MiniProjeto_PesquisaComLINQ.Models;

namespace MiniProjeto_PesquisaComLINQ.Repository

{
    public class Imovel_Repository : IImovel_Repository
    {
        List<Imovel> Imoveis = new()
        {
            new Imovel() { Id = 1, Cidade = Cidade.santacatarina, Titulo="Apartamento Beira-mar", Valor = 280000},
            new Imovel() { Id = 2, Cidade = Cidade.natal , Titulo = "Casa com 3 quartos com vaga garagem", Valor = 320000 },
            new Imovel() { Id = 3, Cidade = Cidade.florianopolis, Titulo = "Apartamento 2 quartos", Valor = 210000 },
            new Imovel() { Id = 4, Cidade = Cidade.joaopessoa, Titulo = "Apartamento Terreo", Valor = 120000 },
            new Imovel() { Id = 5, Cidade = Cidade.saopaulo, Titulo = "Casa 2 andares 4 quartos 2 suítes", Valor = 580000 },
            new Imovel() { Id = 6, Cidade = Cidade.recife, Titulo = "Casa 1 quarto", Valor = 90000 },
            new Imovel() { Id = 7, Cidade = Cidade.riodejaneiro, Titulo = "Apartamento 1 quarto", Valor = 80000 },
            new Imovel() { Id = 8, Cidade = Cidade.santacatarina, Titulo = "Casa 2 quartos com vaga na garagem", Valor = 180000 },
            new Imovel() { Id = 9, Cidade = Cidade.joaopessoa, Titulo = "Casa Beira-mar", Valor = 600000 },
            new Imovel() { Id = 10, Cidade = Cidade.florianopolis, Titulo = "Apartamento cobertura", Valor = 1280000 }
        };

        public void Add_Imovel(Imovel imovel)
        {
            Imoveis.Add(imovel);
        }

        public void Delete_Imovel(Imovel imovel)
        {
            Imoveis.Remove(imovel);
        }

        public List<Imovel> Get_Imovel()
        {
            return Imoveis;
        }

        public List<Imovel> Get_Imovel_by_Cidade(string cidade)
        {
            return Imoveis.Where(x => x.Cidade
                                       .GetEnumDescription()
                                       .ToLower()
                                       .Contains(cidade.ToLower()))
                                       .ToList();
        }

        public List<Imovel> Get_Imovel_By_Name(string titulo)
        {
            return Imoveis.Where(x => x.Titulo
                                       .ToLower()
                                       .Contains(titulo.ToLower()))
                                       .ToList();
        }

        public List<Imovel> Get_Imovel_by_Value(double valor, bool maior_ou_menor)
        {
            if (maior_ou_menor)
            {
                return Imoveis.Where(x => x.Valor <= valor)
                                           .ToList();
            }
            else
            {
                return Imoveis.Where(x => x.Valor >= valor)
                                           .ToList();
            }
        }

        public void Update_Imovel(Imovel imovel)
        {
            Imoveis[Imoveis.FindIndex(x=> x.Id.Equals(imovel.Id))] = imovel;
        }        
    }
}

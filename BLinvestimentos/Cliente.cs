using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLinvestimentos
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Capital { get; set; }


        public static double mediaidade(List<Cliente> clientes)
        {
            double soma = 0;

            foreach (var item in clientes)
            {
                soma = soma + item.Idade;
            }
            double media = soma / clientes.Count();
            return Math.Round( media, 2);
        }




    }
}

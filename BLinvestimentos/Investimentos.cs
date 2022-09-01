using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLinvestimentos
{
    public class Investimentos
    {
        public double Valorinvestido { get; set; }
        public int meses { get; set; }
        public List<Cliente> Clientes { get; set; }

        public double retornaJurosAcumulado(List<Cliente> clientes, int meses)
        {

            double jurosAcumulado = 0;
            foreach (var item in clientes)
            {
                jurosAcumulado = jurosAcumulado + retornaJurosCliente(item, 24);
            }
            return jurosAcumulado;

        }

        public double retornaJurosCliente(Cliente cliente, int meses)
        {
            double montante = cliente.Capital * (Math.Pow((1 + 0.07), meses / 12));
            return montante - cliente.Capital;
           
            montante = cliente.Capital * (Math.Pow((1 + 0.07), meses / 12));
            double juros = montante - cliente.Capital;
            return Math.Round(juros, 2);
        }

      
    }
}

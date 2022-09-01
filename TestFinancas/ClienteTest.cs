using BLinvestimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinancas
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void mediaDeIdade()
        {
            double esperado = 31.67;
            double resultado = 0;
            Cliente cli01 = new Cliente();
            cli01.Idade = 33;
            Cliente cli02 = new Cliente();
            cli02.Idade = 25;
            Cliente cli03 = new Cliente();
            cli03.Idade = 37;
            List<Cliente> lista = new List<Cliente>();

            lista.Add(cli01);
            lista.Add(cli02);
            lista.Add(cli03);

            resultado = Cliente.mediaidade(lista);
            Assert.AreEqual(esperado, resultado);

        }
    }
}

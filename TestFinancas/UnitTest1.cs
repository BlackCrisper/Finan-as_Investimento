using BLinvestimentos;

namespace TestFinancas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void jurosDeUmClienteCorreto()
        {
            double esperado = 202.86;
            double resultado = 0;

            Cliente cliente = new Cliente();
            cliente.Capital = 1400;

            Investimentos invest = new Investimentos();

            resultado = invest.retornaJurosCliente(cliente, 24);

            Assert.AreEqual(esperado, resultado);


        }

        [TestMethod]
        public void jurosDe3Clientes()
        {
            double esperado = 608.58;
            double resultado = 0;

            Cliente cliente1 = new Cliente();
            cliente1.Capital = 1400;
            Cliente cliente2 = new Cliente();
            cliente2.Capital = 1400;
            Cliente cliente3 = new Cliente();
            cliente3.Capital = 1400;

            List<Cliente> lista = new List<Cliente>();
            lista.Add(cliente1);
            lista.Add(cliente2);
            lista.Add(cliente3);

            Investimentos invest = new Investimentos();
            resultado = invest.retornaJurosAcumulado(lista, 24);

            Assert.AreEqual(esperado, resultado);

        }
    }
}
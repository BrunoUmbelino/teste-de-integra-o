using Xunit;

namespace Livraria.Testes
{
    public class DeveLogarUsuario
    {
        [Fact]
        public void DeveRetornarDadosDoUsuarioCasoEstejaLogado()
        {
            var altentica��o = new Altentica��o("maria@email.com", "123456");
            var contaUsuario = new ContaUsuario();

            if (altentica��o.Logado)
            {
                var DadosDoUsuario = contaUsuario.buscarDadosDoUsuario();
            }

            Assert.True(altentica��o.Logado);
        }
    }
}
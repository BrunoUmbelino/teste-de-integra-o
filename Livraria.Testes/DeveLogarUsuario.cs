using Xunit;

namespace Livraria.Testes
{
    public class DeveLogarUsuario
    {
        [Fact]
        public void DeveRetornarDadosDoUsuarioCasoEstejaLogado()
        {
            var altenticação = new Altenticação("maria@email.com", "123456");
            var contaUsuario = new ContaUsuario();

            if (altenticação.Logado)
            {
                var DadosDoUsuario = contaUsuario.buscarDadosDoUsuario();
            }

            Assert.True(altenticação.Logado);
        }
    }
}
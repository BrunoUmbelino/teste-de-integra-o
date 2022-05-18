using Xunit;

namespace Livraria.Testes
{
    public class QuandoUsuarioLogado
    {
        [Fact]
        public void DeveBuscarDadosDoUsuario()
        {
            var dadosDoUsuario = new ContaUsuario();
            
            var usuarioTeste = new ContaUsuario();
            usuarioTeste.Id = "302e9542-ff3f-4d0a-a34a-e001739eefd9";
            usuarioTeste.Nome = "Maria";
            usuarioTeste.Sobrenome = "Dipirona";
            usuarioTeste.Email = "maria@email.com";
            usuarioTeste.CPF = "320.839.390-34";

            var altentica��o = new Altentica��o("maria@email.com", "123456");
            
            var usuarioLogado = altentica��o.Logar();
            
            if (usuarioLogado)
            {
                dadosDoUsuario = dadosDoUsuario.buscarDadosDoUsuario(altentica��o.Email);
            }

            Assert.True(usuarioLogado);
            Assert.Equal(usuarioTeste, dadosDoUsuario);
        }
    }
}
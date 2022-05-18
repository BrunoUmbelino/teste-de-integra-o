// See https://aka.ms/new-console-template for more information

using Livraria;


var altenticação = new Altenticação("maria@email.com", "123");
var dadosDoUsuario = new ContaUsuario();

var usuarioLogado = altenticação.Logar();

if (usuarioLogado)
    dadosDoUsuario = dadosDoUsuario.buscarDadosDoUsuario(altenticação.Email);
else
    Console.WriteLine("Email ou Senha inválidos.");

Console.WriteLine
    ($" {dadosDoUsuario.Id} \n " +
    $"{dadosDoUsuario.Nome} \n " +
    $"{dadosDoUsuario.Sobrenome} \n " +
    $"{dadosDoUsuario.Email} \n " +
    $"{dadosDoUsuario.CPF}");


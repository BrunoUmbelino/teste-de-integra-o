using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    public class ContaUsuario
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }

        public ContaUsuario buscarDadosDoUsuario(string email)
        {
            if (email == "maria@email.com")
            {
                this.Id = "302e9542-ff3f-4d0a-a34a-e001739eefd9";
                this.Nome = "Maria";
                this.Sobrenome = "Dipirona";
                this.Email = "maria@email.com";
                this.CPF = "320.839.390-34";
                return this;
            }
            else
            {
                return this;
            }
        }
    }
}

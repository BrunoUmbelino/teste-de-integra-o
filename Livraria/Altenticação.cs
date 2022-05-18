using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    public class Altenticação
    {
        public string Email { get; private set; }
        private string Senha { get; set; }

        public Altenticação(string email, string Senha)
        {
            this.Email = email;
            this.Senha = Senha;
        }

        public bool Logar()
        {
            //Consultando no banco de dados
            if (Email == "maria@email.com" && Senha == "123456")
                return true;
            else
                return false;
        }
    }
}

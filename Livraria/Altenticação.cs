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

        public bool Logado { get; set; }    

        public Altenticação(string email, string Senha)
        {
            if (email == "maria@email.com" && Senha == "123456")
            {
                this.Email = email;
                this.Logado = true;
            }
            else
            {
                this.Email = "";
                this.Logado = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauUniBanco
{
      public class SistemasInterno
    {
        public bool Logar(IAutenticavel funcionarios, string senha)s
        {
            bool usuarioAutenticado = funcionarios.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao Sistema");
                return true;
            }
            else
            {
                Console.WriteLine("senha incorreta");
                return false;
            }
        }
    }
}

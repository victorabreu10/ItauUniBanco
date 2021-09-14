using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauUniBanco
{
     public class Diretores : FuncionarioAutenticavel
    {
        public Diretores(string cpf) : base(5000,cpf)
        {
            Console.WriteLine("Criando Diretores:");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}

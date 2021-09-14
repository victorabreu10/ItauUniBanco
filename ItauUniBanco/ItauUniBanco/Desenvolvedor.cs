using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauUniBanco
{
    public class Desenvolvedor : Funcionarios
    {
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {
        }
        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }
        public override double GetBonificacao()
        {
            return 0.1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauUniBanco
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionarios Funcionarios)
        {
            _totalBonificacao += Funcionarios.GetBonificacao();
        }
      
        public double GetTotalDeBonificacao()
        {
            return _totalBonificacao;
        }
    }

}





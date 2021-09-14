using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ItauUniBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();
            UsarSustema();
            Console.ReadLine();
        }

        public static void UsarSustema()
        {
            SistemasInterno sistemasInterno = new SistemasInterno();
            Diretores roberta = new Diretores("556777877");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta isabel = new GerenteDeConta("34455556");
            isabel.Nome = "Isabel";
            isabel.Senha = "abc";
            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "futebol";

            sistemasInterno.Logar(roberta, "123");
            sistemasInterno.Logar(isabel, "abc");
            sistemasInterno.Logar(parceiro, "futebol");

        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("12343222");

            Diretores maria = new Diretores("123212343");

            Auxiliar igor = new Auxiliar("8786678");

            GerenteDeConta isabel  = new GerenteDeConta("34455556");

            Desenvolvedor victor = new Desenvolvedor("23232334343");

            gerenciadorBonificacao.Registrar(victor);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(maria);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(isabel);

            Console.WriteLine("Total de Bonificações do Mês"
                + gerenciadorBonificacao.GetTotalDeBonificacao());



        }
    }

}
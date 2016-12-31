using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesleySafadao
{
    /// <summary>
    /// Resolução de problema algortimo do wesley safadão
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método que recolhe as informções do usuario e chama o método para o calculo do nivel de safadeza
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data de seu nascimento: dia, mes e ano em cada linha ");
            int dia = Convert.ToInt32(Console.ReadLine());
            int mes = Convert.ToInt32(Console.ReadLine());
            int ano = Convert.ToInt32(Console.ReadLine());
            ContaSafadeza CS = new ContaSafadeza();
            CS.wesley_safadao(dia, mes, ano);
            Console.ReadKey();
        }
    }
}

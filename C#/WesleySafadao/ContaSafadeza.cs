using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesleySafadao
{ 
    class ContaSafadeza
    {
        /// <summary>
        /// Método para calcular o nivel de safadeza de uma pessoa
        /// </summary>
        /// <param name="dia">Recebe o dia do nascimento</param>
        /// <param name="mes">Recebe o mes do nascimento</param>
        /// <param name="ano">Recebe o ano do nascimento</param>
         public void wesley_safadao(int dia, int mes, int ano)
        {
            double safadeza = somatorio(mes) + (ano/100) * (50-dia);
            double anjo = 100 - safadeza;
            Console.WriteLine(String.Format("Você é: {0}% safado, e {1}% vagabundo", safadeza, anjo));
        }

        /// <summary>
        /// Método SOMATORIO, utilizado no método wesley_safadao
        /// Faz a soma de todos os numeros anteriores do numero recebido por parametro
        /// </summary>
        /// <param name="mes">Recebe o mes para que se possa fazer a soma com os numeros anteriores</param>
        /// <returns></returns>
        private int somatorio(int mes)
        {
            int resultado = 0;
            for (int i = 1; i <= mes; i++)
            {
                resultado += i;
            }
            return resultado;  
        }
    }
}

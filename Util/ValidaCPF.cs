using System;

namespace Util
{
    public class ValidaCPF
    {
        /// <summary>
        /// Método que pede o CPF para o usuário e envia para o método CalculaCpf
        /// </summary>
        /// <returns>Se o CPF for válido, retorna uma mensagem, senão continua pedindo um CPF para o usuário</returns>
        public string validaCPF ()
        {
            string msg = "";
            string cpf = "";
            do
            {
                Console.Write("Informe um CPF válido: ");
                cpf = Console.ReadLine();
                
            } while (calculaCpf(cpf) == false);

            msg = "CPF Válido";
            return msg;
        }

        /// <summary>
        /// Método que faz o calculo do CPF informado
        /// </summary>
        /// <param name="cpfEntrada">recebe o CPF como String</param>
        /// <returns>Retorna TRUE para CPF válido e FALSE para CPF inválido</returns>
        private bool calculaCpf(string cpfEntrada)
        {
            bool retorno = true;
            string cpfCalculado = cpfEntrada.Substring(0, 9);
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < cpfCalculado.Length; i++)
            {
                soma += (int.Parse(cpfCalculado.Substring(i, 1)) * multiplicador1[i]);
            }
            if (soma % 11 < 2)
            {
                cpfCalculado += 0;
            }
            else
            {
                cpfCalculado += (11 - (soma % 11));
            }

            soma = 0;
            for (int i = 0; i < cpfCalculado.Length; i++)
            {
                soma += (int.Parse(cpfCalculado.Substring(i, 1)) * multiplicador2[i]);
            }

            if (soma % 11 < 2)
            {
                cpfCalculado += 0;
            }
            else
            {
                cpfCalculado += (11 - (soma % 11));
            }
            if (cpfCalculado != cpfEntrada)
            {
                retorno = false;
                return retorno;
            }
            return retorno;
        }
    }
}
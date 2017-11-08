using System;

namespace Util
{
    public class ValidaCNPJ
    {
        /// <summary>
        /// Método que pede o CNPJ para o usuário e envia para o método CalculaCNPJ
        /// </summary>
        /// <returns>Se o CNPJ for válido, retorna uma mensagem, senão continua pedindo um CNPJ para o usuário</returns>
        public string validaCNPJ ()
        {
            string msg = "";
            string cnpj = "";
            do
            {
                Console.Write("Informe um CNPJ válido: ");
                cnpj = Console.ReadLine();
                
            } while (CalculaCNPJ(cnpj) == false);

            msg = "CNPJ Válido";
            return msg;
        }

        /// <summary>
        /// Método que faz o calculo do CNPJ informado
        /// </summary>
        /// <param name="cnpjusuario">recebe o CNPJ como String</param>
        /// <returns>Retorna TRUE para CNPJ válido e FALSE para CNPJ inválido</returns>
        private bool CalculaCNPJ(string cnpjusuario)
        {
           int[] v1 = {5,4,3,2,9,8,7,6,5,4,3,2};
           int[] v2 = {6,5,4,3,2,9,8,7,6,5,4,3,2};
          
           bool retorno = true;

           string cnpjcalculo = "";
           int resultado = 0;
           int resto = 0;

           cnpjcalculo = cnpjusuario.Substring(0,12);

           for(int i = 0; i < cnpjcalculo.Length;i++){
               resultado+=int.Parse(cnpjcalculo[i].ToString())*v1[i];
           }
           resto = resultado % 11;

           if(resto<2){
           cnpjcalculo+="0";
           }
           else{
           cnpjcalculo+=(11-resto).ToString();
           }

           resultado = 0;

           for(int i = 0; i < cnpjcalculo.Length;i++){
               resultado+=int.Parse(cnpjcalculo[i].ToString())*v2[i];
           }
           resto = resultado % 11;

           if(resto<2){
           cnpjcalculo+="0";
           }
           else{
           cnpjcalculo+=(11-resto).ToString();
           }
          
           if(cnpjcalculo!=cnpjusuario){
               retorno = false;
           }
           return retorno;
        }
    }
}
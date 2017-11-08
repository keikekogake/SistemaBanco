namespace Dados
{
    public class ContaPF : Conta
    {
        public Pessoa Pessoa { get; set; }

        /// <summary>
        /// Efetua saque na conta do cliente PF
        /// </summary>
        /// <param name="Valor">Parametro do tipo Double com o valor do saque</param>
        /// <returns>Retorna o saldo após o saque</returns>
        public override double Sacar(double Valor)
        {
            base.Sacar(Valor + 0.10);
            return this.Saldo;
        }

        /// <summary>
        /// Efetua deposito na conta do cliente PF
        /// </summary>
        /// <param name="Valor">Parametro do tipo Double com o valor do depósito</param>
        /// <returns>Retorna o saldo após o depósito</returns>
        public override double Depositar(double Valor)
        {
            base.Depositar(Valor + 0.10);
            return this.Saldo;
        }
    }
}
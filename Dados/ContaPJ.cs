namespace Dados
{
    public class ContaPJ : Conta
    {
        public Empresa Empresa { get; set; }

        /// <summary>
        /// Efetua saque na conta do cliente PJ
        /// </summary>
        /// <param name="Valor">Parametro do tipo Double com o valor do saque</param>
        /// <returns>Retorna o saldo após o saque</returns>
        public override double Sacar(double Valor)
        {
            base.Sacar(Valor + 0.50);
            return this.Saldo;
        }

        /// <summary>
        /// Efetua depósito na conta do cliente PJ
        /// </summary>
        /// <param name="Valor">Parametro do tipo Double com o valor do depósito</param>
        /// <returns>Retorna o saldo após o depósito</returns>
        public override double Depositar(double Valor)
        {
            base.Depositar(Valor + 0.05);
            return this.Saldo;
        }

        public void CadastrarConta(Empresa empresa, ContaPJ conta)
        {
        }
    }
}
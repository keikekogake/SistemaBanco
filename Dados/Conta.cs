namespace Dados
{
    public class Conta
    {
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public double Saldo { get; protected set; }

        /// <summary>
        /// Método utilizado para realizar saques na conta do cliente
        /// </summary>
        /// <param name="Valor">Parametro deve ser pasasdo como DOUBLE</param>
        /// <returns>Retorna o valor disponível na conta após o saque</returns>
        public virtual double Sacar(double Valor)
        {
            this.Saldo -= Valor;
            return this.Saldo;
        }

        /// <summary>
        /// Método utilizado para realizar depósitos na conta do cliente
        /// </summary>
        /// <param name="Valor">Parametro deve ser passado como DOUBLE</param>
        /// <returns>Retorna o valor disponível na conta após o deposito</returns>
        public virtual double Depositar(double Valor)
        {
            this.Saldo += Valor;
            return this.Saldo;
        }
    }
}
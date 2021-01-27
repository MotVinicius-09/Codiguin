using System.Globalization;
namespace FirstProgram
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }
        
        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }
        public ContaBancaria(int numeroConta, string nomeTitular, double depInicial) : this(numeroConta, nomeTitular)
        {
            Deposito(depInicial);
        }
       
        public void Deposito (double deposito)
        {
            Saldo += deposito;
        }

        public void Saque (double saque)
        {
            Saldo -= saque + 5.0;
        }
        
        
        public override string ToString()
        {
            return "Conta: " + NumeroConta
                + ", Titular: " + NomeTitular
                + ", Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
using System;
using System.Globalization;
namespace CadastroDeFuncionario
{
    class Aumento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Aumento(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void AumentoSalario(double porcent)
        {
            Salario += (porcent * Salario) / 100;
        }

        public override string ToString()
        {
            return Id + ", "
                + Nome + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }           
    }
}

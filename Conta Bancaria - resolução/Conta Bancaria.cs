using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria___resolução
{
    internal class Conta_Bancaria
    {
        // Definição de propriedades

        public int NumeroConta { get; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        // Construtores

        public Conta_Bancaria(int numero, string titular) // Este construtor permite instanciar contas bancarias apenas com o numero de conta e o seu titular
        {
            NumeroConta = numero;
            NomeTitular = titular;
        }

        public Conta_Bancaria(int numero, string titular, double saldo): this (numero, titular)  //Este construtor permite instanciar uma conta a partir do seu numero de conta, titular e também o seu saldo inicial
        {
            Saldo = saldo;
        }

        // Secção de Métodos

        public void Deposito (double quantia) // Este é o método que permite depositar dinheiro na conta
        {
            Saldo += quantia;
        }

        public void Levantamento (double quantia) // Este é o método que permite fazer o levantamento de dinheiro
        { 
            Saldo -= quantia + 5.00; 
        }

        public override string ToString()
        {
            return "Conta Bancária número "
                + NumeroConta
                + ", Titular da conta: "
                + NomeTitular
                + ", Saldo: "
                + Saldo.ToString("F2")
                + " euros.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria___resolução
{
    i

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

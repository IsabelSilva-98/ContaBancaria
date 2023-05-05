namespace Conta_Bancaria___resolução
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta_Bancaria cb; 
            
            Console.WriteLine("Insira com o núnmero de conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Deseja fazer um depósito inicial? s/n");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.WriteLine("Insira o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                cb = new Conta_Bancaria(numero, titular, depositoInicial);
            }
            else
            {
                cb = new Conta_Bancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(cb);

            Console.WriteLine();
            Console.WriteLine("Valor a depositar: ");
            double quantia = double.Parse(Console.ReadLine());
            cb.Deposito(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(cb);

            Console.WriteLine();
            Console.WriteLine("Valor a levantar: ");
            quantia = double.Parse(Console.ReadLine());
            cb.Levantamento(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(cb);

            cb.NomeTitular = "Maria ";
            Console.WriteLine(cb);
        }     

    }
}
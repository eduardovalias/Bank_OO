using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Client eduardo = new Client();
            Client thulio = new Client();

            eduardo.titular = "Eduardo";
            eduardo.agencia = 1234;
            eduardo.conta = 890;
            eduardo.saldo = 333.33;

            thulio.titular = "Thulio";
            thulio.agencia = 1234;
            thulio.conta = 900;
            thulio.saldo = 3333333.33;

            Console.WriteLine("O titular da conta é: " + eduardo.titular);
            Console.WriteLine("O titular da conta é: " + thulio.titular);
        }
    }
}

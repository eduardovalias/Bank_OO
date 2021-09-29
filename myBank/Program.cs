using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcEduardo = new Funcionario("Eduardo Valias", "123.456.345-80", "Caixa", 3333);
            Funcionario funcFabiano = new Funcionario("Fabiano", "345.234.567-20", "Caixa", 33333);
            Funcionario funcThulio = new Funcionario("Thulio", "345.345.345-10", "Caixa", 33333333);


            ContaCorrente contaDoChopin = new ContaCorrente("Chopin", 1234, 789, 1810, funcEduardo);
            ContaCorrente contaDoLiszt = new ContaCorrente("Liszt", 1234, 790, 1811, funcThulio);
            ContaCorrente contaDoBach = new ContaCorrente("Bach", 1234, 791, 1685, funcFabiano);

            Console.WriteLine("O total de contas criadas é de: " + ContaCorrente.TotalDeContasCriadas + " conta(s).");

            Console.WriteLine("Saldo inicial: Chopin R$" + contaDoChopin.Saldo + "; conta vendida pelo vendedor: " + funcEduardo.Nome + ", que recebeu uma comissão de: R$" + funcEduardo.Comissao);
            Console.WriteLine("Saldo inicial: Liszt R$" + contaDoLiszt.Saldo + "; conta vendida pelo vendedor: " + funcThulio.Nome + ", que recebeu uma comissão de: R$" + funcThulio.Comissao);
            Console.WriteLine("Saldo inicial: Bach R$" + contaDoBach.Saldo + "; conta vendida pelo vendedor: " + funcFabiano.Nome + ", que recebeu uma comissão de: R$" + funcFabiano.Comissao);

            contaDoChopin.Sacar(30);
            contaDoLiszt.Depositar(20);
            contaDoBach.Transferir(100, contaDoChopin);

            Console.WriteLine("Saldo após saque: Chopin R$" + contaDoChopin.Saldo);
            Console.WriteLine("Saldo após depósito: Liszt R$" + contaDoLiszt.Saldo);
            Console.WriteLine("Saldo após transferência: Bach R$" + contaDoBach.Saldo + "; Saldo após transferência: Chopin R$" + contaDoChopin.Saldo);
        }
    }
}
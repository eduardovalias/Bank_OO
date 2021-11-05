using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteLiszt = new Gerente()
            {
                Nome = "Franz Liszt",
                CPF = "654.566.357-15",
                Salario = 33000,
                NumeroDeAgencias = 3,
            };

            Vendedor vendedorChopin = new Vendedor()
            {
                Nome = "Frederic Chopin",
                CPF = "387.562.396-45",
                Salario = 15000,
                NumeroClientesAtendidos = 5,
            };

            Vendedor vendedorBach = new Vendedor()
            {
                Nome = "Johann Sebastian Bach",
                CPF = "394.856.234-87",
                Salario = 15000,
                NumeroClientesAtendidos = 3,
            };

            Vendedor vendedorPaganini = new Vendedor()
            {
                Nome = "Niccolò Paganini",
                CPF = "349.857.986-34",
                Salario = 15000,
                NumeroClientesAtendidos = 4,
            };

            vendedorBach.Bonificacao = vendedorBach.Salario;
            vendedorChopin.Bonificacao = vendedorChopin.Salario;
            vendedorPaganini.Bonificacao = vendedorPaganini.Salario;
            gerenteLiszt.Bonificacao = gerenteLiszt.Salario;

            ContaCorrente contaDoEdu = new ContaCorrente("Eduardo Pereira Valias", 3333, 33, vendedorBach);
            contaDoEdu.Conta = 333;
            ContaCorrente contaDoSus = new ContaCorrente("Sushi", 2424, 4848, vendedorPaganini);
            contaDoSus.Conta = 123;
            ContaCorrente contaDoMartins = new ContaCorrente("Martins", 3332, 333, vendedorChopin);
            contaDoMartins.Conta = 332;

            Console.WriteLine("\nBonificação Chopin: " + vendedorChopin.Bonificacao +
            "\nBonificação Paganini: " + vendedorPaganini.Bonificacao + 
            "\nBonificação Bach: " + vendedorBach.Bonificacao +
            "\nBonificação Liszt: " + gerenteLiszt.Bonificacao +
            "\nRemuneração total Chopin: " + vendedorChopin.RemuneracaoTotal(vendedorChopin.Salario, vendedorChopin.Bonificacao) +
            "\nRemuneração total Bach: " + vendedorBach.RemuneracaoTotal(vendedorBach.Salario, vendedorBach.Bonificacao) + 
            "\nRemuneração total Paganini: " + vendedorPaganini.RemuneracaoTotal(vendedorPaganini.Salario, vendedorPaganini.Bonificacao) +
            "\nRemuneração total Liszt: " + gerenteLiszt.RemuneracaoTotal(gerenteLiszt.Salario, gerenteLiszt.Bonificacao) +
            "\nDias de férias Chopin: " + vendedorChopin.CalcularFerias() +
            "\nDias de férias Bach: " + vendedorBach.CalcularFerias() +
            "\nDias de férias Paganini: " + vendedorPaganini.CalcularFerias() +
            "\nDias de férias Liszt: " + gerenteLiszt.CalcularFerias());

            Console.WriteLine("\nConta 1: " + contaDoEdu.Titular +
            "\nConta 2: " + contaDoMartins.Titular + 
            "\nConta 3: " + contaDoSus.Titular);

            Console.WriteLine("\nO número de contas criadas é: " + ContaCorrente.TotaldeContasCriadas);

            Console.WriteLine("\nLink do repo: https://github.com/eduardovalias/Bank_OO.git");
        }
    }
}
using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Client eduardo = new Client("Eduardo", 1234, 890, 333.33);
            Client thulio = new Client("Thulio", 1234, 900, 3333333.33);
            Client cana = new Client("Cana", 1234, 999, 3333333333333333333.33);

            Console.WriteLine("O titular da conta é: " + eduardo.titular);
            Console.WriteLine("O titular da conta é: " + thulio.titular);
            Console.WriteLine("O titular da conte é: " + cana.titular);
        }
    }
}

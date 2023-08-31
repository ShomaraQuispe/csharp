
using Exercicio1.Model;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente01 = new("Shomara", "123456", "456789", "shomara@shomara.com", 159753);
            cliente01.Visualizar();


            Cliente cliente02 = new("Evander", "158456", "365248", "evander@evander.com", 987563);
            cliente02.Visualizar();

        }
    }
}
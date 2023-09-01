
using Exercicio1.Model;

namespace Exercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente01 = new("Shomara", "123456", "456789", "shomara@shomara.com", 159753);
            cliente01.Visualizar();

            Cliente cliente02 = new("Evander", "158456", "365248", "evander@evander.com", 987563);
            cliente02.Visualizar();

            PessoaJuridica cliente03 = new("Andrea", "123456", "11995159585", "andrea@andrea.com",15987, "015898522");
            cliente03.Visualizar();

            PessoaJuridica cliente04 = new("Junior", "35789", "11995159898", "junior@junior.com",15987, "987856321");
            cliente03.Visualizar();

            PessoaFisica cliente05 = new("Jennifer", "01124030", "11960598523", "jennifer@gmail.com", 123478, "4299888756");
            cliente05.Visualizar();

            PessoaFisica cliente06 = new("Helen", "01128020", "11960158563", "helen@gmail.com", 928765, "21985698563");
            cliente05.Visualizar();
        }
    }
}
using System;
using System.Threading.Tasks;
using TestEcheancier.Models;

namespace TestEcheancier
{
    public class App
    {

        public void Run(Arguments arguments)
        {
            Console.WriteLine($"On doit avoir {arguments.NBEcheance} echeance(s)");
for (int i = 1; i <= arguments.NBEcheance; i++)
{
    var previous = arguments.DateDebut.AddMonths((i - 1) * arguments.Periodicite);
    var res = (i == arguments.NBEcheance && arguments.DateFin != null) ? arguments.DateFin.Value : arguments.DateDebut.AddMonths(i * arguments.Periodicite).AddDays(-1);
    Console.Write($"du {previous.ToShortDateString()} au {res.ToShortDateString()} pour un montant {Math.Round(arguments.MontantAnnuel / arguments.NBEcheance,2)} euros \n");
}
		}
    }
}

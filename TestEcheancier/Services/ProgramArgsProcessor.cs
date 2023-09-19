
using System;
using TestEcheancier.Models;

namespace TestEcheancier.Services
{
	public interface IProgramArgsProcessor
	{
		Arguments Process(string[] args);
	}
	public class ProgramArgsProcessor : IProgramArgsProcessor
	{
		/*
		 public decimal MontantAnnuel { get; set; }

		public int Periodicite { get; set; }

		public int NBEcheance { get; set; }

		public DateTime? DateFin { get; set; }
		 */
		private const string ARG_DATE_DEBUT = "-d";
		private const string ARG_DATE_FIN = "-f";
		private const string ARG_PERIODICITE = "-p";
		private const string ARG_NB_ECHEANCE = "-n";
		private const string ARG_MONTANT = "-m";

		public ProgramArgsProcessor()
		{
		}

		public Arguments Process(string[] args)
		{
			Arguments arguments = new Arguments();
			try
			{
				foreach (string arg in args)
				{
					string[] parametres = arg.Split('=');
					if (parametres.Length != 2)
						throw new Exception($"Le parametre {arg} est incorrect");
					switch (parametres[0])
					{
						case ARG_DATE_DEBUT: arguments.DateDebut = DateTime.Parse(parametres[1]); break;
						case ARG_DATE_FIN: arguments.DateFin = DateTime.Parse(parametres[1]); break;
						case ARG_PERIODICITE: arguments.Periodicite = Convert.ToInt32(parametres[1]); break;
						case ARG_NB_ECHEANCE: arguments.NBEcheance = Convert.ToInt32(parametres[1]); break;
						case ARG_MONTANT: arguments.MontantAnnuel = Convert.ToDecimal(parametres[1]); break;

					}
				}
			}
			catch(Exception e)
			{Console.WriteLine("L'ordre des paramètres est libre.");
				Console.WriteLine(e.Message);
				return arguments;
			}
			return arguments;
		}
	}
}

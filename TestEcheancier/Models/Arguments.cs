

using System;

namespace TestEcheancier.Models
{
	public class Arguments
	{
		public DateTime DateDebut { get; set; }
		public decimal MontantAnnuel { get; set; }

		/// <summary>
		/// Périodicité en mois
		/// </summary>
		public int Periodicite { get; set; }

		public int NBEcheance { get; set; }

		public DateTime? DateFin { get; set; }
	}
}

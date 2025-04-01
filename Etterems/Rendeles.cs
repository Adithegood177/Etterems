using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterems
{
	internal class Rendeles
	{
		public string VendegNev { get; set; }
		public List<MenuElem> RendeltEtelek { get; set; }

		public Rendeles(string vendegNev)
		{
			VendegNev = vendegNev;
			RendeltEtelek = new List<MenuElem>();
		}

		public void Hozzaad(MenuElem elem)
		{
			RendeltEtelek.Add(elem);
		}

		public decimal Vegosszeg()
		{
			return RendeltEtelek.Sum(etel => etel.Ar);
		}

		public override string ToString()
		{
			return $"{VendegNev}: {string.Join(", ", RendeltEtelek.Select(etel =>etel.Nev))} - Összesen: {Vegosszeg()} Ft";
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterems
{
	internal class Vendeg
	{
		public string Nev { get; set; }
		public List<MenuElem> Rendelesek { get; private set; }

		public Vendeg(string nev)
		{
			Nev = nev;
			Rendelesek = new List<MenuElem>();
		}

		public void Rendel(MenuElem elem)
		{
			Rendelesek.Add(elem);
		}

		public decimal Fizet()
		{
			decimal vegosszeg = Rendelesek.Sum(e => e.Ar);
			Rendelesek.Clear();
            Console.WriteLine("Sikeres fizetés!");
            return vegosszeg;
		}
	}
}


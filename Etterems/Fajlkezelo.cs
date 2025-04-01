using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterems
{
	
	internal class FajlKezelo
	{
		private static string menuFajl = "menuk.txt";

		public static void MenuMentese(List<MenuElem> elemsz)
		{
			using (StreamWriter sw = new StreamWriter(menuFajl))
			{
				foreach (var elem in elemsz)
				{
					sw.WriteLine($"{elem.Nev};{elem.Ar};{elem.Kategoria}");
				}
			}
			Console.WriteLine("Könyvek elmentve!");
		}

		public static List<MenuElem> MenuBetoltese()
		{
			List<MenuElem> konyvek = new List<MenuElem>();
			if (File.Exists(menuFajl)) return konyvek;

			foreach (var sor in File.ReadLines(menuFajl))
			{
				var adatok = sor.Split(';');
				var elem = new MenuElem(adatok[0], int.Parse(adatok[1]), adatok[2]);
				konyvek.Add(elem);
			}

			Console.WriteLine("Könyvek betöltve!");
			return konyvek;
		}
		public void RendelesMentese(List<Rendeles> elemsz) {
			using (StreamWriter sw = new StreamWriter(menuFajl))
			{
				foreach (var elem in elemsz)
				{
					sw.WriteLine($"{elem.VendegNev};{elem.RendeltEtelek}");
				}
			}
			Console.WriteLine("Könyvek elmentve!");

		}
	}
}


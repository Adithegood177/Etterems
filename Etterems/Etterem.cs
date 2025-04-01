using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterems
{
    internal class Etterem
    {
        public List<MenuElem> Menu { get;  set; }
        public List<Rendeles> Rendelesek { get; private set; }

        public Etterem()
        {
            Menu = new List<MenuElem>();
            Rendelesek = new List<Rendeles>();
        }

        public void HozzaadMenuElem(MenuElem elem)
        {
            Menu.Add(elem);
        }

        public void ListazMenu()
		{
			foreach (var elem in Menu)
			{
				Console.WriteLine(elem);
			}
		}   
        public void Ujrendeles(Vendeg vendeg)
        {
            Rendeles ujRendeles = new Rendeles(vendeg.Nev);
            Rendelesek.Add(ujRendeles);
        }
    }
}


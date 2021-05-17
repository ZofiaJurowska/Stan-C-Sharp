using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Chmura: KroplaStan
    {
        public Chmura(KroplaWody app) : base(app)
        {
        }
        public override void Info()
        {
            Console.WriteLine("Kropla wody jest w chmurze");
        }
        public override void ZmianaStanu()
        {
            lista.Add("Jest teraz w chmurze");
            Random rnd = new Random();
            int a = rnd.Next(3);
            switch (a)
            {
                case 0:
                    poczatek.ZmienStan(new Roślina(poczatek));
                    break;
                case 1:
                    poczatek.ZmienStan(new Studnia(poczatek));
                    break;
                case 2:
                    poczatek.ZmienStan(new Rzeka(poczatek));
                    break;
                default:
                    lista.Add("Przebieg skończony");
                    break;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Rzeka: KroplaStan
    {
        public Rzeka(KroplaWody app) : base(app)
        {

        }
        public override void Info()
        {
            Console.WriteLine("Kropla wody jest w rzece");
        }
        public override void ZmianaStanu() 
        {
            lista.Add("Jest teraz w rzece");
            Random rnd = new Random();
            int a = rnd.Next(3);
            switch (a)
            {
                case 0:
                    poczatek.ZmienStan(new Chmura(poczatek));
                    break;
                case 1:
                    poczatek.ZmienStan(new Ocean(poczatek));
                    break;
                case 2:
                    poczatek.ZmienStan(new Zwierze(poczatek));
                    break;
                default:
                    break;
            }
        
        }
    }
}

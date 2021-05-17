using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Zwierze : KroplaStan
    {
        public Zwierze(KroplaWody app) : base(app)
        {

        }
        public override void Info()
        {
            Console.WriteLine("Kropla wody jest w zwierzęciu");
        }
        public override void ZmianaStanu() 
        {
            lista.Add("Jest teraz w zwierzęciu");
            Random rnd = new Random();
            int a = rnd.Next(2);
            switch (a)
            {
                case 0:
                    poczatek.ZmienStan(new Chmura(poczatek));
                    break;
                case 1:
                    poczatek.ZmienStan(new Rzeka(poczatek));
                    break;
                default:
                    break;
            }
        }

    }
}

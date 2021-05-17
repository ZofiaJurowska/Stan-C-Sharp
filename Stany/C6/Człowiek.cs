using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Człowiek : KroplaStan
    {
        public Człowiek(KroplaWody app) : base(app)
        {

        }
        public override void Info()
        {
            Console.WriteLine("Kropla wody jest w człowieku");
        }
        public override void ZmianaStanu() 
        {
            lista.Add("Jest teraz w człowieku");
            Random rnd = new Random();
            int a = rnd.Next(2);
            switch (a)
            {
                case 0:
                    poczatek.ZmienStan(new Oczyszczalnia(poczatek));
                    break;
                case 1:
                    poczatek.ZmienStan(new Chmura(poczatek));
                    break;
                default:
                    break;
            }

        }
    }
}

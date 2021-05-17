using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Oczyszczalnia : KroplaStan
    {
        public Oczyszczalnia(KroplaWody app) : base(app)
        {

        }
        public override void Info()
        {
            Console.WriteLine("Kropla wody jest w oczyszczalni");
        }
        public override void ZmianaStanu() 
        {
            lista.Add("Jest teraz w oczyszczalni");
            poczatek.ZmienStan(new Rzeka(poczatek));
        }
    }
}

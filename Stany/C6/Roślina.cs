using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Roślina: KroplaStan
    {
        public Roślina(KroplaWody app): base(app)
        {
            
        }
        public override void Info()
        {
            Console.WriteLine("Kropla wody jest w roślince");
        }
        public override void ZmianaStanu() 
        {
            lista.Add("Jest teraz w roślinie");
            poczatek.ZmienStan(new Chmura(poczatek));
        }
    }
}

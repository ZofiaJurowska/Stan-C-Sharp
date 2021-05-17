using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Studnia: KroplaStan
    {
        public Studnia(KroplaWody app) : base(app)
        {

        }
        public override void Info()
        {
            Console.WriteLine("Kropla wody jest w studni");
        }
        public override void ZmianaStanu() 
        {
            lista.Add("Jest teraz w studni");
            poczatek.ZmienStan(new Człowiek(poczatek));
            lista.Add("Jest teraz w studni");
        }
    }
}

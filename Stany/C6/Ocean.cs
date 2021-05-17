using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Ocean: KroplaStan
    {
        public Ocean(KroplaWody app) : base(app)
        {

        }
        public override void Info()
        {
            Console.WriteLine("Kropla wody jest w oceanie");
        }
        public override void ZmianaStanu()
        {
            lista.Add("Jest teraz w oceanie");
            poczatek.ZmienStan(new Chmura(poczatek));

        }
    }
}

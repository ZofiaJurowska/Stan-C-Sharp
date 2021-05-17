using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class MenuState : KroplaStan
    {
        public MenuState(KroplaWody app): base(app)
        {

        }
        public override void Info()
        {
            
        }
        public override void ZmianaStanu()
        {
            poczatek.ZmienStan(new Roślina(poczatek));
        }
    }
}

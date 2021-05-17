using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    abstract class KroplaStan
    {
        // kazdy stan musi wiedziec kto go uzywa, na wypadek gdyby potrzebowal wywolac metode ChangeState 
        protected KroplaWody poczatek;
        protected List<string> lista = new List<string>();


        // dlatego bedziemy podawali obiekt typu GameApp w konstruktorze
        public KroplaStan(KroplaWody app)
        {
            poczatek = app;
        }

        // ponizej znajduja sie metody ktore kazdy stan bedzie musial zaimplementowac na inny sposob
        public abstract void Info();
        public abstract void ZmianaStanu();
        
    }
}

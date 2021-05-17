using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class KroplaWody
    {
        // tutaj przechowujemy obecny stan naszej aplikacji
        private KroplaStan aktualnyStan;
        // konstruktor
        public KroplaWody()
        {
            // zaczynamy od menu, jako argument konstruktora podajemy ten sam obiekt klasy GameApp w ktorym obecnie jestesmy (slowo kluczowe this)
            aktualnyStan = new MenuState(this);
        }

        // metoda pozwalajaca zmieniac stan na inny
        public void ZmienStan(KroplaStan nowyStan)
        {
            aktualnyStan = nowyStan;
        }

        // ponizej znajduja sie metody dla uzytkownika
        public void Info()
        {
            aktualnyStan.Info();
        }       

        public void NastepnyStan()
        {
            aktualnyStan.ZmianaStanu();
        }
    }
}

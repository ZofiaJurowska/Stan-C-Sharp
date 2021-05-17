using System;

namespace C6
{
    class Program
    {
        static void Main(string[] args)
        {
            KroplaWody kroplaWody = new KroplaWody();
            kroplaWody.ZmienStan(new Chmura(kroplaWody));
            kroplaWody.NastepnyStan();
            for (int i = 0; i< 10; i++)
            {
                kroplaWody.NastepnyStan();
                kroplaWody.Info();
            }      

        }
    }
}

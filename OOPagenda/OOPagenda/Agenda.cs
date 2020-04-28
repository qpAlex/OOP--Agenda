using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPagenda
{
    class Agenda
    {
        public List<Activitate> activitati = new List<Activitate>();
        public Persoana owner;
        public string InfoAgenda()
        {
            return $"Aceasta este agenda lui {owner}.";
        }

    }
}

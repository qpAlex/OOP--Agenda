using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPagenda
{
    class Activitate
    {
        //public List<Persoana> persoanaParticipa;
        string nume;
        string descriere;
        DateTime dataInceput;
        DateTime dataSfarsit;
        public string Info_Activitate()
        {
            return $"{nume}-{descriere}.Inceput:{dataInceput.ToString()}. Sfarsit:{dataSfarsit.ToString()}.";
        }
    }
}

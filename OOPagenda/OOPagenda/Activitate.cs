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
        public  string nume;
        public string descriere;
        public DateTime dataInceput;
        public DateTime dataSfarsit;
        public List<Persoana> Participanti;
        public string Info_Activitate()
        {
            return $"{nume}-{descriere}.Inceput:{dataInceput.ToString()}. Sfarsit:{dataSfarsit.ToString()}.";
        }
    }
}

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
            return $"Index:{Liste.Activitati.IndexOf(this)}  Activitate:{nume}, {descriere} ce începe la: {dataInceput.ToString()} si se termină la: {dataSfarsit.ToString()}.";
        }
    }
}

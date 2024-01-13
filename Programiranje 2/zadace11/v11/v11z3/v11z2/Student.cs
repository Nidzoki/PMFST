using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v11z2
{
    public class Student
    {
        public string ime, prezime;
        public int godina;

        public string Ime { 
            get { return ime; }
            set { ime = value; } 
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public int Godina
        {
            get { return godina; }
            set { godina = value; }
        }

        public Student(string name, string surname, int year)
        {
            ime = name;
            prezime = surname;
            godina = year;
        }

        public bool Punoljetan()
        {
            return DateTime.Now.Year - godina > 17 ? true : false;
        }

        public int Dob()
        {
            return DateTime.Now.Year - godina;
        }

    }
}

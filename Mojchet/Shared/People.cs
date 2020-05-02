using System;
using System.Collections.Generic;
using System.Text;

namespace Mojchet.Shared
{
    public class People
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Pasword { get; set; }
        public string Name { get; set; }

        public People() { }
        public People(string usrn,string psw, string nme )
        {
            Username = usrn;
            Pasword = psw;
            Name = nme;
        }
        public People(string usrn, string psw)
        {
            Username = usrn;
            Pasword = psw;
        }
        public override string ToString()
        {
            return $"{Name}";
        }

    }
}

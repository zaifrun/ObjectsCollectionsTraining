using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCardCollection
{
   
    public class Person
    {
        public Person(CprNr cpr, String navn, String adresse)
        {
            Cpr = cpr;
            Navn = navn;
            Adresse = adresse;
        }

        public CprNr Cpr { get; set; }
        public String Navn { get; set; }
        public string Adresse { get; set; }

        public override string ToString()
        {
            return $"{Navn} bor {Adresse} med cpr: {Cpr}";
        }
    }
}

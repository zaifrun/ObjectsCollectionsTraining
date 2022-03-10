using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCardCollection
{
   
    public class CprNr
    {

        //glem om denne kode - den er nødvendig for at få Equals til
        //at virke
        public override int GetHashCode()
        {
              return 0;
        }


        //Denne linje kode sammenligner to objekter af typen CPR
        //se kommentarer i Program.cs for hvorfor dette er med
        public override bool Equals(object cpr)
        {
            if (cpr is CprNr)
            {
                //så vi ved at vi har et CPR objekt, så
                //kan vi bruge BirthDate og SequenceNumber
                CprNr other = cpr as CprNr;
                return (BirthDate == other.BirthDate &&
                      SequenceNumber == other.SequenceNumber);
            }
            else return false;
        }

        public CprNr(String bDate, String sNumber)
        {
            BirthDate = bDate;
            SequenceNumber = sNumber;
        }
        public string BirthDate { get; set; }
        public string SequenceNumber { get; set; }

        public override string ToString()
        {
            return $"{BirthDate}{SequenceNumber}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCardCollection
{



    

    class Program
    {

        static int fakultet(int n)
        {
            if (n == 0)
                return 1;
            else
            {
                int resultatet = 1;
                for (int i = 1; i <= n; i++)
                {
                    resultatet = resultatet * i;
                }
                return resultatet;
            }
        }

        static int fakultet2(int n)
        {
            if (n == 0)
                return 1;
            else
            {
                int resultatet = 1;
                int i = n;
                while (i>=2)
                { 
                    resultatet = resultatet * i;
                    i--;
                }
                return resultatet;
            }
        }

        static int fakultet3(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * fakultet3(n - 1);
        }

        static void Main()
        {

            Console.WriteLine("fak(0): " + fakultet(0));
            Console.WriteLine("fak(1): " + fakultet(1));
            Console.WriteLine("fak(5): " + fakultet(5));
            Console.WriteLine("fak2(0): " + fakultet2(0));
            Console.WriteLine("fak2(1): " + fakultet2(1));
            Console.WriteLine("fak2(5): " + fakultet2(5));
            Console.WriteLine("fak3(0): " + fakultet3(0));
            Console.WriteLine("fak3(1): " + fakultet3(1));
            Console.WriteLine("fak3(5): " + fakultet3(5));



            var personCollection = new GenericCollection<CprNr, Person>();

            var morten = new Person(new CprNr("211271", "7777"), "Morten", "Brabrand");
            var karina = new Person(new CprNr("141174", "8888"), "Karina", "Aarhus");

            personCollection.AddElement(karina.Cpr, karina);
            personCollection.AddElement(morten.Cpr, morten);

            Console.WriteLine("Person(211271,7777)="+personCollection.GetElement(morten.Cpr));
            //Console.WriteLine("Person(211271,7777)="+personCollection.GetElement(new CprNr("211271", "7777")));
            //læg mærke til den udkommenterede linjen ovenover - her tester vi om et nyt objekt
            //findes i vores collection - godt nok med det samme cpr nr, men det er 
            //et NYT objekt, så det findes som udgangspunkt IKKE i vores collection.
            //HVIS man gerne vil have ovenstående udkommenterede kode til at virke, 
            //så skal vi fortælle C# hvordan den HELT PRÆCIST skal sammenligne 2 cpr
            //numre for at se om de er ens - se koden for Equals i CprNr klassen.

            Console.WriteLine("Size= "+ personCollection.Size());

            MyList<String> list = new MyList<string>();

            list.AddElement("martin");
            list.AddElement("Jens");
            list.AddElement("Benny");
            Console.WriteLine("index 0 : "+list.GetElement(0));
            Console.WriteLine("index 1 : "+list.GetElement(1));
            Console.WriteLine("index 2 : "+list.GetElement(2));
            try
            {
                //her burde vi få en fejl, så lad os tjekke det
                Console.WriteLine("index 3 : " + list.GetElement(3));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Fejl i index");
            }


            Console.ReadLine();
        }


        
    }
}

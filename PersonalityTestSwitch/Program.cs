using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema lemmikvärvi;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {userColor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine().ToLower();

            //Punane, Sinine, Roheline. Ehk User võib sisestada need ükskõik miskujul, suurtähtedega, ning programm 
            //kuvab need väikeste tähtedega, kasutades .tolower()

            switch(userColor) //lüliti, ehk me lülitame võimaluste/valikute vahel
            {
                case "punane": // sisuliselt sama, mis if(userColor == "punane")
                    Console.WriteLine("Oled romantiline.");
                    break; //break sunnib koodi tööd peatama ja peab kohe minema järgmisele reale, ehk väljuma siis alast
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber.");
                    break;
                default: //default peab olema igas switchis, pmst nagu if'is on 'else' viimases read
                    Console.WriteLine("Oled " + userColor + " ükssarvik.");
                    break;
            }

            Console.WriteLine("Kena päeva!");




        }
    }
}

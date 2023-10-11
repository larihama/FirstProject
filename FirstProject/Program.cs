namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä 1: Tulosta "Hello World!"
            Console.WriteLine("Hello World!");

            //Tehtävä 2: Kysy käyttäjältä nimi
            Console.WriteLine("Syötä etunimesi:");
            var name = Console.ReadLine();

            //Tehtävä 3: Poista nimestä turhat välilyönnit
            name = name.Replace(" ", "");

            //Tehtävä 4: Muuta nimen ensimmäinen kirjain isoksi ja muut pieniksi käyttämällä CapitalizeFirstLetter funktiota
            name = name.First().ToString().ToUpper() + name.Substring(1).ToLower();

            //ulosta "Terve, <name>!"
            Console.WriteLine($"Terve {name}!");

            //Tehtävä 5: Kysy käyttäjältä sukunimi omaan muuttujaan ja tulosta "Terve, <firstName> <lastName>!"
            Console.WriteLine("Syötä sukunimesi:");
            var lastName = Console.ReadLine();
            lastName = lastName.Replace(" ", "");
            lastName = lastName.First().ToString().ToUpper() + lastName.Substring(1).ToLower();
            Console.WriteLine("Terve " + name + " " + lastName + "!");

            //Tulosta käyttäjän nimi kolmella eri tavalla, käyttäen eri string tekniikoita
            //Katso esimerkkiä SecondProject\Program.cs
            Console.WriteLine(string.Format("Nimesi on {0} {1}", name, lastName));
            Console.WriteLine($"Eikö nimesi ole {name} {lastName}?");

            //Tehtävä 6: Kommentoi koodi selventämään, että mitä se tekee

        }

        private static string CapitalizeFirstLetter(string? inputString)
        {
            /*inputString.First().ToString().ToUpper(): Ottaa ensimmäisen merkin inputString-merkkijonosta, 
             * muuttaa sen takaisin merkkijonoksi char tyyppisestä muuttujasta ja muuttaa sen isoksi kirjaimeksi (eli alkukirjaimeksi).

             inputString.Substring(1).ToLower(): Ottaa inputString-merkkijonon loput merkit ensimmäisen merkin jälkeen ja muuttaa ne pieniksi kirjaimiksi.
             Lopuksi yllä mainitut kaksi osaa yhdistetään yhteen merkkijonoon käyttäen + -operaattoria.
             Koodin tulos on, että inputString-merkkijonon ensimmäinen kirjain muutetaan isoksi kirjaimeksi ja kaikki muut merkit pieniksi kirjaimiksi. 
             Esimerkiksi jos inputString oli alun perin "hELLo", sen arvo koodin suorittamisen jälkeen on "Hello".*/

            inputString = inputString.First().ToString().ToUpper() + inputString.Substring(1).ToLower();
            return inputString;
        }


    }
}
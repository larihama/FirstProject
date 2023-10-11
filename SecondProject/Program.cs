namespace SecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moro moro, lasketaan kahdella luvulla toimituksia");
            Console.WriteLine("Syötä x");

            var x = Console.ReadLine();

            Console.WriteLine("Syötä y");

            var y = Console.ReadLine();

            //Tehtävä 7: Kysy käyttäjältä laskuoperaatio +,-, * tai / ja tulosta laskun tulos

            Console.WriteLine("Syötä laskuoperaatio +, -, * tai /:");

            var operaatio = Console.ReadLine();

            int result = 0;

            if (operaatio == "+")
            {
                result = int.Parse(x) + int.Parse(y);
            }
            else if (operaatio == "-")
            {
                result = int.Parse(x) - int.Parse(y);
            }
            else if (operaatio == "*")
            {
                result = int.Parse(x) * int.Parse(y);
            }
            else if (operaatio == "/")
            {
                result = int.Parse(x) / int.Parse(y);
            }

            Console.WriteLine($"Tulos on {result} hYVÄÄÄ");
            Console.WriteLine("Mees ny töihi siitä");

            //parses string to int and adds them together
            //var result = int.Parse(x) + int.Parse(y);


            // Console.WriteLine("Combine result + is " + result);
            // Console.WriteLine(string.Format("String format result is {0}", result));
            // Console.WriteLine($"Interpolation result $ is {result}");


            // Console.WriteLine("Combine example: Result " + x + " +  " + y + " = " + result);
            // Console.WriteLine(string.Format("string.Format example: Result {0} + {1} = {2}", x, y, result));
            // Console.WriteLine($"Interpolation example: Result {x} + {y} = {result}");
        }
    }
}
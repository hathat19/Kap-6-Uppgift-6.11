using System;
using System.Collections.Generic;
namespace Uppgift6_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            //-------------------------------------------

            RitaKvadrat(3, 'B',2);

        }

        static void RitaKvadrat(int sideLength, char sign, int space = 0)
        {
            //längden
            for (int i = 0; i < sideLength; i++)
            {
                //Bredden
                for (int j = 0; j < sideLength; j++) 
                {
                    Console.Write(sign);

                    //space eller inte?
                    if (j != sideLength - 1)
                    {
                        for (int k = 0; k < space; k++)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                if (i != sideLength - 1)
                {
                    for (int k = 0; k < space; k++)
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
/*Skapa ett program med en metod som heter RitaKvadrat som ritar ut en kvadrat av
valfri storlek bestående av ett valfritt tecken. Den som anropar metoden ska kunna
ange hur stort mellanrummet ska vara mellan tecknen som skrivs ut, detta ska
påverka mellanrummet både i x- och y-led. Om mellanrumsstorleken inte anges vid
anropet av metoden så ska den vara 0.
Om metoden anropas med RitaKvadrat(4, &#39;A&#39;) så ska följande kvadrat ritas ut:
AAAA
AAAA
AAAA
AAAA
Om metoden anropas med RitaKvadrat(3, &#39;B&#39;, 2) så ska följande kvadrat ritas ut:
B B B
B B B
B B B*/
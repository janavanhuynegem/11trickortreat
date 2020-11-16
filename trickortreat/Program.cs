//ANALYSE:
/*VRAAG SNOEP OF UW LEVEN
 * BEREKEN ANTWOORD TRICK
 * BEREKEN ANTWOORD TREAT
 * TOON REACTIE OP TRICK
 * TOON REACTIE OP TREAT
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trickortreat
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            string reactie, antwoord;

            //INPUT
            //VRAAG TRICK OR TREAT
            Console.Write("trick or treat? ");
            antwoord = Console.ReadLine().ToLower();

            //PROCESSING
            //BEREKEN ANTWOORD TRICK
            if (antwoord == "trick")
            {
                reactie = "BOOOO!!";
            }
            //BEREKEN ANTWOORD TREAT
            else
            {
                reactie = " Snoepjesssss!!!!";
            }
            //OUTPUT
            //TOON REACTIE OP TRICK
            Console.WriteLine(reactie);
            //TOON REACTIE OP TREAT
            Console.WriteLine(reactie);

            //WACHTEN....
            Console.WriteLine();
            Console.Write("druk op enter om af te sluiten");
            Console.WriteLine();

        }
    }
}

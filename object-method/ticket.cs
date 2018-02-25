using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskticket
{
    class Ticket
    {
        //muuttujat
        public double Age;
        public double Mtk;
        public double Varusmies;
        public double Opiskelija;
        public double Price;

        //konstruktori
        public Ticket(double age, double mtk, double varusmies, double opiskelija, double price)
        {
            Age = age;
            Mtk = mtk;
            Varusmies = varusmies;
            Opiskelija = opiskelija;
            Price = price;
        }

        public Ticket()
        {
            Age = 0;
            Mtk = 0;
            Varusmies = 0;
            Opiskelija = 0;
            Price = 16;
        }

        //metodit
        public void customerquestions()
        {
            Console.WriteLine("Sinun on ensin vastattava muutamaan kysymykseen,\nennen kun me myymme sinulle lippuja. \n");

            Console.Write("Minkä ikäinen sinä olet?: ");
            string userInputAge = Console.ReadLine();
            Age = double.Parse(userInputAge);

            Console.Write("Oletko Mtk:n jäsen? Jos olet paina 1, jos et paina 2: ");
            string userInputMtk = Console.ReadLine();
            Mtk = double.Parse(userInputMtk);

            Console.Write("Oletko varusmies? Jos olet paina 1, jos et paina 2: ");
            string userInputVarusmies = Console.ReadLine();
            Varusmies = double.Parse(userInputVarusmies);

            Console.Write("Oletko kenties opiskelija? Jos olet paina 1, jos et paina 2: ");
            string userInputOpiskelija = Console.ReadLine();
            Opiskelija = double.Parse(userInputOpiskelija);
        }

        public void ThePrice(Ticket ticket)
        {
            

            if (Age < 7)
            {
                Console.WriteLine($" Alle seitsemän vuotiaat pääsevät ilmaiseksi. Onneksi olkoon!  {Price * 0} euroa\n");
            }
            else if (Mtk == 1 && Opiskelija == 1)
            {
                Console.WriteLine($"Nuoriso puoleen hintaan! Lippusi hinta on {Price * 0.4} euroa\n");
            }
            else if (Age > 64)
            {
                Console.WriteLine($"Saat eläkeläis alennuksesi. Lipun hinta on {Price * 0.5} euroa\n");
            }
            else if (Age < 15)
            {
                Console.WriteLine($"Nuoriso  puoleen hintaan. Lipun hinta {Price * 0.5}euroa \n");
            }
            else if (Varusmies == 1)
                Console.WriteLine($"Olet varusmies, Lippusi hinta on {Price * 0.5} euroa\n");

            else if (Opiskelija == 1)
            {

                Console.WriteLine($"Opiskelija lippu maksaa {Price * 0.55} euroa\n");
            }
            else if (Mtk == 1)
            {

                Console.WriteLine($"Mtk:n jäsen. Lipusta 15 % pois. Maksat vain {Price * 0.85} euroa\n");
            }
            
            else
            {

                Console.WriteLine($"Lipun hinta on { Price } euroa.\n");
            
            }
                   
                    
                
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigthClub.Models
{

    public class Character
    {

        public string Name { get; set; }
        public string Figther { get; set; }
        public string Branch { get; set; }
        public int Damage { get; set; }
        public string Branch2 { get; set; }
        public int Damage2 { get; set; }
        public void Attack()
        {
            /*
             Figther ==> Turabi için +5 ,Yuri boyka için +10,Jet Li
            Jackie Chan için +15 dmg fazlası var.

            Gun -> 65
            Sword -> 25 - 45
            Nunchucks -> 26 - 55
             */

            Random r = new Random();

            Damage = 0;
            Damage2 = 0;

            if (Figther == "Turabi")
                Damage = Damage + 5;
            if (Figther == "Yuri boyka")
            {
                Damage = Damage + 10;
            }
            else
            {
                Damage = Damage + 15;

            }
            /*burada vereceğimiz hasar kodları aşağıdadır 
              */

            switch (Branch)
            {
                case "Gun":
                    Damage = Damage + 65;


                    break;

                case "Sword":
                    Damage = Damage + r.Next(25, 46);
                    break;

                case "Nunchucks":
                    Damage = Damage + r.Next(26, 55);
                    break;

                default:
                    break;
            }
            /*burada alacağımız hasar kodları aşağıdadır 
                  */


            switch (Branch)
            {
                case "Gun":
                    Damage2 = Damage2 + 33;


                    break;

                case "Sword":
                    Damage2 = Damage2 + r.Next(1, 32);
                    break;

                case "Nunchucks":
                    Damage2 = Damage2 + r.Next(66, 75);
                    break;

                default:
                    break;
            }


        }
    }
}

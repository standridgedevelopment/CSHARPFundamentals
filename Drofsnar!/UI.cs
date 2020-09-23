using Drofsnar;
using Drofsnar.Points;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drofsnar_
{
    class UI
    {
       
        static void Main(string[] args)
        {
            void SaveBird(string ID)
            { 

            }
            Drofsnar player = new Drofsnar(5000, 3);
            string[] gameInput = System.IO.File.ReadAllText(@"C:\ElevenFiftyProjects\SD 65\CSHARPFundamentals\Drofsnar!\GameInput.txt").Split(',');
            for (int i = 0; i < gameInput.Length; i++)
            {
                Thread.Sleep(100);

                switch (gameInput[i])
                {
                    case "Stopper":
                        player.EatStopper();
                        break;
                    case "BirdHunter":
                        player.EatBirdHunter();
                        break;
                    case "Bird":
                        player.GetPoints(new Bird());
                        break;
                    case "CrestedIbis":
                        player.GetPoints(new CrestedIbis());
                        break;
                    case "GreatKiskudee":
                        player.GetPoints(new GreatKiskudee());
                        break;
                    case "RedCrossbill":
                        player.GetPoints(new RedCrossbill());
                        break;
                    case "Red-neckedPhalarope":
                        player.GetPoints(new RedneckedPhalarope());
                        break;
                    case "EveningGrosbeak":
                        player.GetPoints(new EveningGrosbeak());
                        break;
                    case "GreaterPrairieChicken":
                        player.GetPoints(new GreaterPrairieChicken());
                        break;
                    case "IcelandGull":
                        player.GetPoints(new IcelandGull());
                        break;
                    case "Orange-belliedParrot":
                        player.GetPoints(new OrangebelliedParrot());
                        break;
                }
                if (player.elScore >= 10000) player.ExtraLife();
                if (player.lives == 0) break;
                player.StopperCount -= 1;

            }
            //Console.Clear();
            player.DisplayScore();
            Console.ReadKey();
        }
    }
}

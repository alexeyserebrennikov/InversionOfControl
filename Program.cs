using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero(new PVPArena());
            hero.Arena();
            Console.ReadLine();
            hero.BattleArena = new PVEArena();
            hero.Arena();
            Console.ReadLine();
        }
         
        interface IBattleArena
        {
            void Arena();
        }

        class Hero
        {
            public IBattleArena BattleArena { get; set; }

            public Hero(IBattleArena battleArena)
            {
                this.BattleArena = battleArena;
            }

            public void Arena()
            {
                BattleArena.Arena();
            }
        }

        class PVPArena : IBattleArena
        {
            public void Arena()
            {
                Console.WriteLine("Герой подключается к PVP арене");
            }
        }

        class PVEArena : IBattleArena
        {
            public void Arena()
            {
                Console.WriteLine("Герой подключается к PVE арене");
            }
        }
    }
}

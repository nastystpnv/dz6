using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    public abstract class LocaL_resident
    {
        bool satiety;
        public abstract void eat_garbage();
        public abstract void eat_something();
    }
    public class Homeless : LocaL_resident
    {
        int count_clothes;
        bool drunk;
        bool satiety;
        string name;
        public Homeless( int count_clothes1, bool drunk1, bool satiety1, string name1)
        {
            count_clothes = count_clothes1;
            drunk = drunk1;
            satiety = satiety1;
            name = name1;
        }
        public Homeless() { }
        public override void eat_garbage () {
            if (satiety)
            {
                Console.WriteLine("съел мусор");
            }
            else
                Console.WriteLine("я сыт");
        }
        public override void eat_something()
        {
            if (drunk)
            {
                Console.WriteLine("съел кошку, проблевался");
            }
            else
                Console.WriteLine("съел кошку, вкусно");
        }

    }
    public class Animals : LocaL_resident
    {
        bool satiety;
        bool predator;
        bool isCat;
        bool lichen;
        public Animals(bool satiety1, bool predator1, bool cat_dog1, bool lichen1)
        {
            satiety = satiety1;
            predator = predator1;
            isCat = cat_dog1;
            lichen = lichen1;
        }
        public Animals() { }
        public override void eat_garbage()
        {
            if (!satiety)
            {
                Console.WriteLine("съел мусор");
            }
            else
                Console.WriteLine("я сыт");
        }
        public override void eat_something()
        {
            if (predator)
            {
                Console.WriteLine("съел человека");
            }
            else
                Console.WriteLine("съел мусор");
        }
        public void catordog()
        {
            if (isCat)
            {
                Console.WriteLine("мяу");
            }
            else
                Console.WriteLine("непонятные звуки");

        }
    }
    
    public class Dumper
    {
        bool workind_day;
        bool satiety;
        bool trash;
        string name;
        public Dumper (bool working_day1, bool satiety1, bool trash1, string name1)
        {
            workind_day = working_day1;
            satiety = satiety1;
            trash = trash1;
            name = name1;
        }
        
        public void working()
        {
            if (workind_day)
            {
                Console.WriteLine("еду");
            }
            else
                Console.WriteLine("отвалите");
        }
        public void satietys()
        {
            if (satiety)
            {
                Console.WriteLine("я сыт");
            }
            else
                Console.WriteLine("я не буду есть мусор, поем дома");

        }
        

    }
    public class Junkyard
    {
        int trash;
        string location;
        bool inTown;
        string name;
        public Junkyard (int trash1, string location1, bool inTown1, string name1)
        {
            trash = trash1;
            location = location1;
            inTown = inTown1;
            name = name1;
        }
        public void clearJunkyard()
        {
            trash = 0;
            Console.WriteLine("мусора нет");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Homeless valera = new Homeless(2, true, true, "valera");
            valera.eat_garbage();
            valera.eat_something();
            Animals maxic = new Animals (true, true, false, true);
            maxic.eat_garbage();
            maxic.eat_something();
            maxic.catordog();
            Dumper oleg = new Dumper(false, false, true, "oleg");
            oleg.working();
            oleg.satietys();
            Junkyard heap = new Junkyard (50, "australia", false, "havana_club");
            heap.clearJunkyard();
            Console.ReadKey();

        }

    }
    
}

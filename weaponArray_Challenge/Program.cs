using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weaponArray_Challenge
{


   
    
    internal class Program
    {
        static int[] Ammo = { 50, 50, 50, 50 };
        static int[] Chamber = { 15, 3, 10, 1 };
        static void Main(string[] args)
        {
            Console.WriteLine(Ammo[0]);

            Console.WriteLine(FireWeapon(3));

            if (Chamber[0] == 0)
            {
                Chamber[0] = 15;
                Ammo[0] = -15;
            }
        }

        static int FireWeapon(int Chamber)
        {
            Chamber = Chamber - 1;

            return Chamber;
        }
        
    }
}

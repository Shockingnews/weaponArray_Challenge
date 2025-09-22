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
            test(50);
            Console.WriteLine("Ammo: " + Ammo[0]);
            Console.WriteLine("Clip: " + Chamber[0]);
            Console.WriteLine("bang bang bang");
            
            
            while(Ammo[0] > 0)
            {
                Console.ReadKey();
                Console.WriteLine("bang bang bang");
                Console.WriteLine("Ammo: " + Ammo[0]);
                Console.WriteLine("Clip: " + FireWeapon(3));

                if (Chamber[0] == 0)
                {
                    if (Ammo[0] < Chamber[0])
                    {
                        Chamber[0] += Ammo[0];
                        Ammo[0] = 0;
                        
                    }
                    else
                    {
                        Chamber[0] += 15;
                        Ammo[0] -= 15;
                    }
                        
                }
            }
            
           
        }

        static void test(int Ammoleft)
        {
            int index = Array.IndexOf(Ammo,Ammoleft);
            Chamber[index] = 15;
        }

        static int FireWeapon(int fire)
        {
            Chamber[0] -= fire;
          
            return Chamber[0];
        }
        
    }
}

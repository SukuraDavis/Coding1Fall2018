using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterGun
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            Watergun Player1 = new Watergun();
            Watergun Player2 = new Watergun();
            Console.WriteLine("la");
            float amount = float.Parse(Console.ReadLine());
            float amount1 = float.Parse(Console.ReadLine());


            Player1.Shoot(amount);
            Player2.Shoot(amount1);

            Player1.Refill();
            Player2.Refill();




        }
    }
    class Watergun
    {
        float capacity;
        bool isWet;
        Random rand = new Random();

        public Watergun()
        {
            
        }

        public bool Shoot(float amount)
        {
            if (capacity > 0)
            {
                capacity -= amount;
                float percentChance = (amount * .2f) + .2f;
                if (rand.NextDouble() < percentChance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }
       public void Refill()
        {
            capacity += .25f;
        }
    }
}
    
    


        






    

      
    


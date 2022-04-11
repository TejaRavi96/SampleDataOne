using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataOne
{
    public class FLipCoin
    {
        public void Flip()
        {
            int tailCount = 0, headCount = 0;

            Random random = new Random();

            Console.WriteLine("Enter Number of Times to Flip a Coin");
            int time = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= time; i++)
            {
                double input = random.NextDouble();
                if (input < 0.5)
                    tailCount++;
                else
                    headCount++;
            }
            Console.WriteLine("headcount:{0} tailcount:{1}", headCount, tailCount);
            double tail_Percentage = (tailCount * 100) / time;
            double head_Percentage = (headCount * 100) / time;
            Console.WriteLine("Head Percentage: " + head_Percentage + ", Tail Percentage: " + tail_Percentage + "\n");
        }
    }
}
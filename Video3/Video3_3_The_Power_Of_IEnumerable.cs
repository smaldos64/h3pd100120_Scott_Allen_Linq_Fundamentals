using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Allen_Linq_Fundamentals.Video3
{
    public class Video3_3_The_Power_Of_IEnumerable
    {
        public static void Video3_3_The_Power_Of_IEnumerable_Start()
        {
            Console.WriteLine("");
            Console.WriteLine("Video3_3_The_Power_Of_IEnumerable");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            UsingLinq UsingLinq_Object = new UsingLinq();
            UsingLinq_Object.ShowAuthorsUsingLinq();

            NotUsingLinq NotUsingLinq_Object = new NotUsingLinq();
            NotUsingLinq_Object.ShowAuthorsNotUsingLinq();
        }
    }
}

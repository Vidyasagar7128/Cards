using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{
    class Cards
    {
        List<List<dynamic>> list = new List<List<dynamic>>();
        public void Pass()
        {
            for (int i = 0; i < 4; i++)
            {
                List<dynamic> temp = new List<dynamic>();
                for (int j = 0; j < 9; j++)
                {
                    temp.Add(new Random().Next(1, 14));
                }
                list.Add(temp);
            }
            foreach (var i in list)
            {
                Console.WriteLine("-----------");
                foreach (var j in i)
                {
                    if (j == 11)
                    {
                        Console.WriteLine("value : Jack");
                    }
                    else if (j == 12)
                    {
                        Console.WriteLine("value : Queen");
                    }
                    else if (j == 13)
                    {
                        Console.WriteLine("value : King");
                    }
                    else if (j == 14)
                    {
                        Console.WriteLine("value : Ace");
                    }
                    else
                    {
                        Console.WriteLine($"value : {j}");
                    }
                }
            }
        }
    }
}
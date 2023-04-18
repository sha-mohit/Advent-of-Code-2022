using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvantofCode2022
{
    public class Puzzel_1
    {
        public string FirstSolution(List<string> readings)
        {
            int count = 0;
            int total = 0;
            for (int i = 1; i < readings.Count; i++)
            {
                if (int.Parse(readings[i]) ==0)
                {
                    if(count< total)
                    count = total;

                    total = 0;
                }
                if (!string.IsNullOrEmpty(readings[i]))
                {
                    total = total+ int.Parse(readings[i]);
                }
            }
           return count.ToString();
        }
       
        public string SecondSolution(List<string> readings)
        {
            List<int> totalCount = new List<int>();
            int total = 0;
            for (int i = 1; i < readings.Count; i++)
            {
                if (int.Parse(readings[i]) == 0)
                {
                    totalCount.Add(total);

                    total = 0;
                }
                if (!string.IsNullOrEmpty(readings[i]))
                {
                    total = total + int.Parse(readings[i]);
                }
                totalCount.Sort();
                totalCount.Reverse();
            }
            return (totalCount[0] + totalCount[1] + totalCount[2]).ToString();
        }
    }
}

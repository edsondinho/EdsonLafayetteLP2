using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula__28042015
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            int auxiliar = 0;

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int I = 0; I < n - i - 1; I++)
                {
                    {
                        if (nums[I] > nums [I + 1])
                        {
                            auxiliar = nums[I];
                            nums[I] = nums[I + 1];
                            nums[I + 1] = auxiliar;
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", nums[i]);
            }

        }
    }
}

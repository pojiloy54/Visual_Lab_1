using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            int[] cashbox = new int[n];

            int time = 0;
            do
            {
                int sum = 0;
                for (int i = 0; i < customers.Length; i++) sum += customers[i];
                if (sum == 0) break;
                for (int i = 0; i < n; i++) cashbox[i] = 0;
                for (int i = 0; i < n; i++) if (customers[i] == 0) cashbox[i] = 1;
                for (int i = 0; i < cashbox.Length; i++)
                {
                    if (cashbox[i] == 1)
                    {
                        customers[i] = customers[n];
                        for (int j = n; j < customers.Length - 1; j++)
                        {
                            customers[j] = customers[j + 1];
                        }
                        customers[customers.Length - 1] = 0;
                    }
                    if (customers[i] != 0)
                        customers[i]--;
                }
                time++;
            } while(true);
            return time;
        }
    }
}

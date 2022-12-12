using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05C_11_03
{
    public class Queue
    {
        int[] val;

        public Queue()
        {
            val = new int[0];
        }

        public void Push(int v)
        {
            int[] t = new int[val.Length + 1];
            for (int i = 0; i < val.Length; i++)
            {
                t[i + 1] = val[i];
            }
            t[0] = v;
            val = t;
        }

        public int Pop()
        {
            int toR = val[val.Length - 1];
            int[] t = new int[val.Length - 1];
            for (int i = 0; i < val.Length - 1; i++)
            {
                t[i] = val[i];
            }
            val = t;
            return toR;
        }

        public string View()
        {
            string toR = "";
            for (int i = 0; i < val.Length; i++)
            {
                toR += val[i] + " ";
            }
            return toR;
        }

        public bool IsEmpty()
        {
            return val.Length == 0;
        }
    }
}

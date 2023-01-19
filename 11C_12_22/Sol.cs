using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11C_12_22
{
    public class Sol
    {
        public int[] v;

        public Sol() //initializeaza valorile initiale, solutiile initilae
        {
            v = new int[Engine.n];
            for (int i = 0; i < Engine.n; i++)
                v[i] = Engine.rnd.Next(Engine.min, Engine.max);
        }
        public Sol(Sol toClone)//constructor de copiere
        {
            v = new int[Engine.n];
            for (int i = 0; i < Engine.n; i++)
                this.v[i] = toClone.v[i];
        }

        public float fadec()
        {
            float sumaGLobala = 0;
            for (int i = 0; i < Engine.n; i++)
            {
                float sumaLocala = 0;
                for (int j = 0; j < Engine.n; j++)
                {
                    sumaLocala = Engine.A[i, j] * v[j];
                }
                sumaLocala -= Engine.T[i];
                sumaGLobala += Math.Abs(sumaLocala);
            }
            return sumaGLobala;
        }

        public string View()
        {
            string toR = "";
            for (int i = 0; i < Engine.n; i++)
                toR += v[i] + " ";
            return toR;
        }
    }
}

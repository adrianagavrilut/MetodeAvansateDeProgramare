using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11C_12_22
{
    public class AlgGenetic
    {
        List<Sol> populatie;
        int N = 2000; //dimensiunea populatiei
        int k = 50;
        List<Sol> par;

        public AlgGenetic()
        {
            populatie = new List<Sol>();
            par = new List<Sol>();
        }

        public void InitPop()
        {
            for (int i = 0; i < N; i++)
            {
                populatie.Add(new Sol());
            }
        }

        public void SortPop()
        {
            populatie.Sort(delegate(Sol A, Sol B) { return A.fadec().CompareTo(B.fadec()); });
        }

        public void SelectPop()
        {
            par.Clear();
            for (int i = 0; i < k; i++)
                par[i] = populatie[i];
        }

        public Sol Mutate(Sol A)
        {
            Sol ToR = new Sol(A);
            ToR.v[Engine.rnd.Next(Engine.n)] = Engine.rnd.Next(-100, 100); 
                    return ToR;
        }

        public Sol Cross(Sol A, Sol B)
        {
            Sol ToR = new Sol(A); //si de la o anumita pozitie copiem B peste A
            int t = Engine.rnd.Next(1, Engine.n);
            for (int i = t; i < Engine.n; i++)
                ToR.v[i] = B.v[i];
            return ToR;
        }

        public void UpdatePop()
        {
            int idx1, idx2;
            populatie.Clear();
            for (int i = 0; i < N; i++)
            {
                do
                {
                    idx1 = Engine.rnd.Next(k);
                    idx2 = Engine.rnd.Next(k);
                } while (idx1 == idx2);
                populatie[i] = Mutate(Cross(par[idx1], par[idx2]));
            }
        }

        public string View()
        {
            return populatie[0].View();
        }
    }
}

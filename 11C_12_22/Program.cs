using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11C_12_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine.LoadFromFile(@"../../TextFile1.txt");
            AlgGenetic demo = new AlgGenetic();
            demo.InitPop();
            //alegem timpul de evolutie un milion
            for (int i = 0; i < 1000000; i++)
            {
                demo.SortPop();
                demo.SelectPop();
                demo.UpdatePop();
            }
            demo.SortPop(); //dupa aceasta sortare, prinmul individ e solutia noastra
            demo.View();

            //citire din fisier n, matrice si vector

            /*
            1.matrice A patratica citita din fisier
            A:            
            2 3 -1
            5 1 -1
            1 3 2
            1.1 avem n paramtru global (dimensiunea sistemului)
            2.avem un vector T de dimensiune n cu valori citie din fisier
            T:
            -11, 2, 2
            3.Construim clasa solutie
            -in engine sau statice min = -100, max = 100

            public class sol
            {
                int[] v;
                public sol() //initializeaza valorile initiale, solutiile initilae
                {
                    v = new int[n];
                    for(int i = 0; i<n; i++)
                        v[i] = rnd.Next(min, max);
                }
                public sol( sol toClone)//constructor de copiere
                {
                    v = new int[n];
                    for(int i = 0; i<n; i++)
                        this.v[i] = toClone.v[i];
                }
                public float fadec()
                {  
                    float sumaGLobala = 0;
                    for (int i = 0, i < n; i++)
                    {
                        float sumaLocala = 0;
                        for(int j = 0, j < n; j++)
                        {
                            sumaLocala = A[i,j) * v[j]
                        }
                        sumaLocala -= T[i];
                        sumaGLobala += Math.Abs(sumaLocala);
                    }
                    return sumaGlobala;
                }
                public string view()
                {
                    string toR = "";
                    for(int i = 0; i< v.L; i++)
                        toR += v[i] + " ";
                    return toR;
                }
            }

            public class AG
            {
                List<sol> pop;
                int N = 2000; //dimensiunea populatiei
                int k = 50;
                List<Sol> par;
                public AG()
                {
                    pop = new LIst<sol>();
                    par = new LIst<Sol>();
                }
                void InitPop()
                {
                    for(int i = 0; i<N; i++)
                    {
                        pop.Add(new Sol());
                    }
                }
                void SortPop()
                {
                    pop.Sort({delegate(Sol A, SOl B)} return A.fadec().CompareTo(B.fadec()); });
                }
                void SelectPop()
                {
                    par.Clone(); sau Close sau Clear
                    for(int i = 0; i<k; i++)
                        par[i] = pop[i]
                }
                Sol Mutate(Sol A)
                {
                    Sol ToR = new Sol(A); 
                    Tor.v[rnd.Next(n)//n sau ToR.v.Length] = rnd.Next(-100, 100); 
                    return ToR;
                }
                Sol Cross(Sol A, Sol B)
                {
                    Sol ToR = new Sol(A); //si de la o anumita pozitie copiem B peste A
                    int t = rnd.Next(1, n);
                    for(int i = t; i<n; i++)
                        Tor.v[i] = B.v[i];
                    return ToR;
                }
                void UpdatePop()
                {
                    int idx1, idx2;
                    pop.Clear();
                    for(int i = o; i<N; i++)
                    {
                        do
                        {
                            idx1 = rnd.Next(k);
                            idx2 = rnd.Next(k);
                        }while(idx1==idx2);
                        pop[i] = Mutate(Cross(par[idx1], par[idx2]));
                    }
                }
                string View()
                {
                    return pop[0].View();
                }
            }
            Main/Load
            {
                AG demo = new AG();
                demo.InitPop();
                //alegem timpul de evolutie un milion
                for(int i = 0; i<1000000 milion; i++)
                {
                    demo.SortPop();
                    demo.SelectPop();
                    demo.UpdatePop();
                }
                demo.Sort(); //dupa aceasta sortare, prinmul individ e solutia noastra
                demo.View();
            }
            */
        }
    }
}

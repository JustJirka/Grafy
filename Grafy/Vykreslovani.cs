using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Grafy
{
    class Vykreslovani
    {
        List<int[]> Bod = new List<int[]>();
        List<List<int>> spojeni = new List<List<int>>();
        int velikost = 50;
        int line_thick = 10;
        public Vykreslovani()
        {
        }
        public void AddBod(int x, int y)
        {
            int[] souradnice = new int[2];
            souradnice[0] = x;
            souradnice[1] = y;
            Bod.Add(souradnice);
            List<int> pridej = new List<int>();
            pridej.Add(-1);
            spojeni.Add(pridej);
        }
        public void AddHranu(int bod1,int bod2)
        {
            if(spojeni[bod1][0]==-1) spojeni[bod1][0]=bod2;
            else spojeni[bod1].Add(bod2);
        }
        public void RmBod(int x, int y)
        {
            int pozice = Najdibod(x, y);
            if (pozice != -1)
            {
                Bod[pozice][0] = Bod[pozice][1] = -1;
                List<int> pridej = new List<int>();
                pridej.Add(-1);
                spojeni[pozice]=pridej;
            }
        }
        public int Najdibod(int x, int y)
        {
            for (int i = 0; i < Bod.Count(); i++)
            {
                double vzdalenost = Math.Sqrt(Math.Pow(x - Bod[i][0], 2) + Math.Pow(y - Bod[i][1], 2));
                if (vzdalenost <= velikost / 2) return i;
            }
            return -1;
        }
        public void Vykresli(Graphics g)
        {
            Brush brush_normalni = Brushes.Green;
            Pen pen_normalni = new Pen(Brushes.DeepSkyBlue, line_thick);
            for (int i = 0; i < spojeni.Count(); i++)
            {
                if (spojeni[i][0] != -1)
                {
                    int delka = spojeni[i].Count();
                   for (int j = 0; j < delka; j++)
                    {
                        if (Bod[spojeni[i][j]][0] == -1)
                        {
                            spojeni[i].RemoveAt(j); 
                            delka--;
                        }
                        else g.DrawLine(pen_normalni, Bod[i][0], Bod[i][1], Bod[spojeni[i][j]][0], Bod[spojeni[i][j]][1]);
                    }
                }
            }
            
            for (int i = 0; i < Bod.Count(); i++)
            {
                if(Bod[i][0]!=-1) g.FillEllipse(brush_normalni, Bod[i][0] - (velikost / 2), Bod[i][1] - (velikost / 2), velikost, velikost);
            }
        }
    }
};

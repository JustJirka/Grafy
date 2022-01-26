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
        List<int[]> prosly = new List<int[]>();
        int velikost = 50;
        int line_thick = 10;
        int vizual = 0;
        public Vykreslovani(){}
        public void AddBod(int x, int y)
        {
            int[] souradnice = new int[2];
            souradnice[0] = x;
            souradnice[1] = y;
            Bod.Add(souradnice);
            List<int> pridej = new List<int> { -1 };
            spojeni.Add(pridej);
        }
        public void AddHranu(int bod1, int bod2)
        {
            if (spojeni[bod2][0] == -1) spojeni[bod2][0] = bod1;
            else spojeni[bod2].Add(bod1);
        }
        public void RmBod(int x, int y)
        {
            int pozice = Najdibod(x, y);
            if (pozice != -1)
            {
                Bod.RemoveAt(pozice);
                spojeni.RemoveAt(pozice);
            }
            for (int i = 0; i < spojeni.Count(); i++)
            {
                int delka = spojeni[i].Count();
                for (int j = 0; j < delka; j++)
                {
                    if (spojeni[i][j] == pozice)
                    {
                        if (spojeni[i].Count() > 1) spojeni[i].RemoveAt(j);
                        else spojeni[i][0] = -1;
                        delka--;
                        j--;
                    }
                    else if (spojeni[i][j] > pozice) spojeni[i][j]--;
                }
            }
        }
        public void RmHranu(int x, int y)
        {
            for (int i = 0; i < spojeni.Count(); i++)
            {
                for (int j = 0; j < spojeni[i].Count(); j++)
                {
                    if (spojeni[i][j] != -1)
                    {
                        double vzdalenost = Math.Abs((Bod[spojeni[i][j]][0] - Bod[i][0]) * (Bod[i][1] - y) - (Bod[i][0] - x) * (Bod[spojeni[i][j]][1] - Bod[i][1])) / Math.Sqrt(Math.Pow(Bod[spojeni[i][j]][0] - Bod[i][0], 2) + Math.Pow(Bod[spojeni[i][j]][1] - Bod[i][1], 2));
                        if (vzdalenost < 5)
                        {
                            if (spojeni[i].Count() <= 1) spojeni[i][j] = -1;
                            else spojeni[i].RemoveAt(j);
                        }
                    }
                }
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
        private void Nakreslispoj(int[] kam, int[] odkud, Pen pero, Graphics g)
        {
            int delka_sipky = 20;
            double d = Math.Sqrt(Math.Pow(kam[0] - odkud[0], 2) + Math.Pow(kam[1] - odkud[1], 2));
            int x2 = Convert.ToInt32(kam[0] - (25 * (kam[0] - odkud[0]) / d));
            int y2 = Convert.ToInt32(kam[1] - (25 * (kam[1] - odkud[1]) / d));
            float vx = odkud[0] - x2;
            float vy = odkud[1] - y2;
            float dist = (float)Math.Sqrt(vx * vx + vy * vy);
            vx /= dist;
            vy /= dist;
            float ax = delka_sipky * (vy + vx);
            float ay = delka_sipky * (-vx + vy);
            PointF[] points =
            {
                new PointF(x2 + ax, y2 + ay),
                new PointF(x2, y2),
                new PointF(x2 - ay, y2 + ax)
            };
            g.DrawLines(pero, points);
            g.DrawLine(pero, kam[0], kam[1], odkud[0], odkud[1]);
        }
        public int Vykresli(Graphics g)
        {
            Brush brush_normalni = Brushes.Green;
            Brush brush_text = Brushes.Black;
            Pen pen_normalni = new Pen(Brushes.DeepSkyBlue, line_thick);
            Pen pen_prosly = new Pen(Brushes.Red, line_thick);
            Font Font_label = new Font("Arial", 16);
            StringFormat drawFormat = new StringFormat();
            for (int i = 0; i < spojeni.Count(); i++)
            {
                if (spojeni[i][0] != -1)
                {
                    for (int j = 0; j < spojeni[i].Count(); j++) Nakreslispoj(Bod[i], Bod[spojeni[i][j]], pen_normalni, g);
                }
            }
            for (int i = 0; i < vizual; i++) Nakreslispoj(Bod[prosly[i][1]], Bod[prosly[i][0]], pen_prosly, g);
            for (int i = 0; i < Bod.Count(); i++)
            {
                if (Bod[i][0] != -1)
                {
                    g.FillEllipse(brush_normalni, Bod[i][0] - (velikost / 2), Bod[i][1] - (velikost / 2), velikost, velikost);
                    g.DrawString(i + "", Font_label, brush_text, Bod[i][0] - 10, Bod[i][1] - 10, drawFormat);
                }
            }
            return Bod.Count();
        }
        public List<int[]> Startviz(int start, int end,bool dfs)
        {
            Graf Grafy = new Graf(spojeni.Count());
            for (int i = 0; i < spojeni.Count(); i++)
            {
                for (int j = 0; j < spojeni[i].Count(); j++)
                {
                    if (spojeni[i][j] != -1) Grafy.AddEdge(i, spojeni[i][j]);
                }
            }
            vizual = 0;
            if(dfs)prosly = Grafy.DFS(start, end);
            else prosly = Grafy.BFS(start, end);
            return prosly;
        }
        public bool Vizualiz()
        {
            if (vizual < prosly.Count()) vizual++;
            else 
            {
                prosly = new List<int[]>();
                vizual = -1;
                return true;
            }
            return false;
        }
    }
}
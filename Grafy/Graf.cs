using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Grafy
{
    class Graf
    {
        int[,] body = new int[,] { { 10, 20 }, { 90, 100 }, { 10, 80 }, };
        LinkedList<int>[] linkedListArray;

        public Graf(int v)
        {
            linkedListArray = new LinkedList<int>[v];
        }

        public void AddEdge(int u, int v, bool blnBiDir = true)
        {
            if (linkedListArray[u] == null)
            {
                linkedListArray[u] = new LinkedList<int>();
                linkedListArray[u].AddFirst(v);
            }
            else
            {
                var last = linkedListArray[u].Last;
                linkedListArray[u].AddAfter(last, v);
            }

            if (blnBiDir)
            {
                if (linkedListArray[v] == null)
                {
                    linkedListArray[v] = new LinkedList<int>();
                    linkedListArray[v].AddFirst(u);
                }
                else
                {
                    var last = linkedListArray[v].Last;
                    linkedListArray[v].AddAfter(last, u);
                }
            }
        }

        internal void DFSHelper(int src, bool[] visited)
        {
            visited[src] = true;
            Console.Write(src + "->");
            if (linkedListArray[src] != null)
            {
                foreach (var item in linkedListArray[src])
                {
                    if (!visited[item] == true)
                    {
                        DFSHelper(item, visited);
                    }
                }
            }
        }

        internal void DFS()
        {
            Console.WriteLine("DFS");
            bool[] visited = new bool[linkedListArray.Length + 1];
            DFSHelper(1, visited);

        }
        public void vykresli(Graphics g)
        {
            Brush brush;
            for (int i = 0; i < body.GetLength(0); i++)
            {
                brush = Brushes.Green;
                g.FillEllipse(brush, body[i, 0], body[i, 1], 50, 50);

            }
            //brush = Brushes.Green;
            //g.FillEllipse (brush, X, Y, X+50, Y+50);
        }
    }
}


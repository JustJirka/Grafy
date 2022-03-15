using System;
using System.Collections;
using System.Collections.Generic;

namespace Grafy
{
    class Graf
    {
        LinkedList<int>[] linkedListArray;
        List<int[]> vypis = new List<int[]>();
        bool[] visited;
        Queue Fronta;
        int konec;
        bool najito = false; 
        public Graf(int v)
        {
            linkedListArray = new LinkedList<int>[v];
        }
        public void AddEdge(int u, int v)
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
        }
        internal void DFSHelper(int src)
        {
            visited[src] = true;
            if (src != konec && linkedListArray[src] != null)
            {
                foreach (var item in linkedListArray[src])
                {
                    if (!najito && !visited[item]) vypis.Add(new int[2] { src, item });
                    if (item == konec)
                    {
                        najito = true;
                        vypis.Add(new int[2] { src, item });
                        break;
                    }
                    else if (!visited[item] && !najito) { DFSHelper(item); }
                }
            }
        }
        internal void BFSHelper(int src)
        {
            if (linkedListArray[src] != null/* && !visited[src]*/)
            {
                //visited[src] = true;
                foreach (var item in linkedListArray[src])
                {
                    if (item == konec)
                    {
                        najito = true;
                        vypis.Add(new int[2] { src, item });
                    }
                    else if (!najito && !visited[item])
                    {
                        visited[item] = true;
                        vypis.Add(new int[2] { src, item });
                        Fronta.Enqueue(item);
                    }
                }
            }
        }
        public List<int[]> DFS(int start, int end)
        {
            visited = new bool[linkedListArray.Length + 1];
            konec = end;
            DFSHelper(start);
            return vypis;
        }
        public List<int[]> BFS(int start, int end)
        {
            visited = new bool[linkedListArray.Length + 1];
            Fronta = new Queue();
            konec = end;
            BFSHelper(start);
            while(Fronta.Count>0 && !najito) BFSHelper(Convert.ToInt32(Fronta.Dequeue()));
            return vypis;
        }
    }
}

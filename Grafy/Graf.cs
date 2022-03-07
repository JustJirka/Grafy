using System;
using System.Collections;
using System.Collections.Generic;

namespace Grafy
{
    class Graf
    {
        LinkedList<int>[] linkedListArray;
        List<int[]> vypis = new List<int[]>();
        int konec;
        bool najito = false; 
        public Graf(int v)
        {
            linkedListArray = new LinkedList<int>[v];
        }
        public void AddEdge(int v, int u)
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
        internal void DFSHelper(int src, bool[] visited)
        {
            visited[src] = true;
            if (src != konec && linkedListArray[src] != null)
            {
                foreach (var item in linkedListArray[src])
                {
                    if (!najito)
                    {
                        int[] souradnice = new int[2];
                        souradnice[0] = src;
                        souradnice[1] = item;
                        vypis.Add(souradnice);
                    }
                    if (item == konec)
                    {
                        najito = true;
                        break;
                    }
                    else if (!visited[item]) DFSHelper(item, visited);
                }
            }
        }
        internal void BFSHelper(int src, Queue fronta, bool[] visited)
        {
            visited[src] = true;
            if (src != konec && linkedListArray[src] != null)
            {
                foreach (var item in linkedListArray[src])
                {
                    if (!najito)
                    {
                        int[] souradnice = new int[2];
                        souradnice[0] = src;
                        souradnice[1] = item;
                        vypis.Add(souradnice);
                    }
                    if (item == konec)
                    {
                        najito = true;
                        break;
                    }
                    else if (!visited[item]) fronta.Enqueue(item);
                }
                if (!najito && fronta.Count > 0) BFSHelper(Convert.ToInt32(fronta.Dequeue()), fronta, visited);
            }
        }
        public List<int[]> DFS(int start, int end)
        {
            bool[] visited = new bool[linkedListArray.Length + 1];
            konec = end;
            DFSHelper(start, visited);
            return vypis;
        }
        public List<int[]> BFS(int start, int end)
        {
            bool[] visited = new bool[linkedListArray.Length + 1];
            Queue BFS = new Queue();
            konec = end;
            BFSHelper(start, BFS, visited);
            while(BFS.Count>0 && !najito) BFSHelper(Convert.ToInt32(BFS.Dequeue()), BFS, visited);
            return vypis;
        }
    }
}

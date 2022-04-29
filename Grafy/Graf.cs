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
            if (linkedListArray[src] != null)
            {
                foreach (var item in linkedListArray[src])
                {
                    if (!visited[item])
                    {
                        visited[item] = true;                        
                        vypis.Add(new int[2] { src, item });
                        DFSHelper(item);
                    }
                }
            }
        }
        internal void BFSHelper(int src)
        {
            if (linkedListArray[src] != null)
            {
                foreach (var item in linkedListArray[src])
                {
                    if (!visited[item])
                    {
                        visited[item] = true;
                        vypis.Add(new int[2] { src, item });
                        Fronta.Enqueue(item);
                    }
                }
            }
        }
        public List<int[]> DFS(int start)
        {
            visited = new bool[linkedListArray.Length + 1];
            DFSHelper(start);
            return vypis;
        }
        public List<int[]> BFS(int start)
        {
            visited = new bool[linkedListArray.Length + 1];
            Fronta = new Queue();
            visited[start] = true;
            Fronta.Enqueue(start);
            while (Fronta.Count>0) BFSHelper(Convert.ToInt32(Fronta.Dequeue()));
            return vypis;
        }
    }
}
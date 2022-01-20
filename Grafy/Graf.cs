﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Grafy
{
    class Graf
    {
        LinkedList<int>[] linkedListArray;
        List<int> vypis = new List<int>();
        int konec;
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
                    if (item != konec) break;
                    else if (!visited[item])
                    {
                        vypis.Add(src);
                        vypis.Add(item);
                        DFSHelper(item, visited);
                    }
                }
            }
        }
        public List<int> DFS(int start, int end)
        {
            bool[] visited = new bool[linkedListArray.Length + 1];
            konec = end;
            DFSHelper(start, visited);
            return vypis;

        }
    }
}

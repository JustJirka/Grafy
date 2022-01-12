using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Grafy
{
    // definice hrany - búňka ze které tvořím vektor vektorů
    class Vertex
    {
        //public:
        int V; // vrchol
        int W; // váha
        Vertex(int v) { V = v; W = 1; } // pro neohodnecený graf
        Vertex(int v, int w) { V = v; W = w; } // pro ohodnocený graf
    };
    class Graf
    {
        /*int nekonecno = 2147483647; // max kladný int
        //private:
        int V_count; // počet vrcholů
        //vector<vector<Vertex>> Edge; // vector hran - vektor vektorů
        int[] visited; //vector <int> visited; navštívené vrcholy

        //Public:
        Graf(int V) // konstruktor
        {
            Edge.resize(V); // nastav velikost vektoru vektorů
            visited = new int[V]; // nastavím si visited na počet vrcholů
            V_count = V; // nastavím si počet vrcholů
        }

        void add_edge(int u, int v)
        {
            Edge[u].push_back(Vertex(v)); //přidej hranu
        }

        void add_edge(int u, int v, int w)
        {
            Edge[u].push_back(Vertex(v, w)); //přidej hranu
        }

        void vypis()
        {
            for (int i = 0; i < V_count; i++)
            {
                cout << i;
                for (vector<Vertex> ::iterator it = Edge[i].begin(); it != Edge[i].end(); it++)
                {
                    cout << "->(" << it->V << "|" << it->W << ")";
                }
                cout << endl;
            }

            cout << endl;
        }

        void BFS(int s) // Breadth First Search
        {
            visited.assign(V_count, false); // žádný uzel nebyl navštíven - celý vector vyplníme F
            queue<int> fronta; // fronta
            visited[s] = true;
            cout << s << " "; // první uzel byl navštíven
            fronta.push(s); // vlož uzel do front
            while (!fronta.empty()) // dokud není fronta prázdná
            {
                s = fronta.front();
                fronta.pop(); // vyndej uzel z fronty
                              // pro všechny syny uzlu s zkontroluj, zda byly navštíveny
                for (vector<Vertex> ::iterator it = Edge[s].begin(); it != Edge[s].end(); it++)
                {
                    if (!visited[it->V]) // jestli nebyl navštíven
                    { // dej jej do fronty a označ jej jako navštívený
                        visited[it->V] = true;
                        cout << it->V << " ";
                        fronta.push(it->V);
                    }
                }
            }
        }

        void BFS_with_tree(int s) // Breadth First Search
        {
            visited.assign(V_count, false); // žádný uzel nebyl navštíven - celý vector vyplníme F
            queue<int> fronta; // fronta
            vector<int> strom;
            strom.resize(V_count);
            strom.assign(V_count, -1);
            visited[s] = true;
            cout << s << " "; // první uzel byl navštíven
            fronta.push(s); // vlož uzel do fronty
            while (!fronta.empty()) // dokud není fronta prázdná
            {
                s = fronta.front();
                fronta.pop(); // vyndej uzel z fronty
                              // pro všechny syny uzlu s zkontroluj, zda byly navštíveny
                for (vector<Vertex> ::iterator it = Edge[s].begin(); it != Edge[s].end(); it++)
                {
                    if (!visited[it->V]) // jestli nebyl navštíven
                    { // dej jej do fronty a označ jej jako navštívený
                        visited[it->V] = true;
                        cout << it->V << " ";
                        fronta.push(it->V);
                        strom[it->V] = s;
                    }
                }
            }
            // výpis stromu
            cout << endl << "strom: "; ;
            for (int i = 0; i < V_count; i++) cout << i << "<-" << strom[i] << " ";
        }

        void DFS(int s)
        {
            stack<int> zasobnik;
            visited.assign(V_count, false);
            visited[s] = true; // cout << s << " ";
            zasobnik.push(s);
            while (!zasobnik.empty()) // dokud není zásobník prázdný
            {
                s = zasobnik.top();
                cout << s << " ";
                zasobnik.pop();
                for (vector<Vertex> ::iterator it = Edge[s].begin(); it != Edge[s].end(); it++)
                {
                    if (!visited[it->V])
                    {
                        visited[it->V] = true;
                        zasobnik.push(it->V);
                    }
                }

            }
        }

        void DFS_with_tree(int s) // Depth First Search
        {
            visited.assign(V_count, false); // žádný uzel nebyl navštíven
            stack<int> zasobnik; // zasobnik
            vector<int> strom;
            strom.resize(V_count);
            strom.assign(V_count, -1);
            zasobnik.push(s); // vlož uzel do zasobniku
            while (!zasobnik.empty()) // dokud není zásobník prázdný
            {
                s = zasobnik.top();
                zasobnik.pop(); // vyndej uzel ze zasobniku
                if (visited[s] == false)
                {
                    visited[s] = true;
                    cout << s << " ";
                    for (vector<Vertex> ::iterator it = Edge[s].begin(); it != Edge[s].end(); it++)
                    {
                        zasobnik.push(it->V);
                        if (!visited[it->V]) strom[it->V] = s;
                    }
                }
            }
            // výpis stromu
            cout << endl << "strom: "; ;
            for (int i = 0; i < V_count; i++) cout << i << "<-" << strom[i] << " ";
        }

        void Find(int s, int t) // Hledáme nějakou cestu pomocí Breadth First Search
        {
            visited.assign(V_count, false); // žádný uzel nebyl navštíven
            queue<int> fronta; // fronta
            vector<int> cesta;
            vector<int> vzdalenosti;
            cesta.resize(V_count);
            cesta.assign(V_count, -1);
            vzdalenosti.resize(V_count);
            vzdalenosti.assign(V_count, nekonecno);

            visited[s] = true; // první uzel byl navštíven
            fronta.push(s); // vlož uzel do fronty
            vzdalenosti[s] = 0;
            while (!fronta.empty() && s != t) // dokud není fronta prázdná a nenašel se uzel
            {
                s = fronta.front();
                fronta.pop(); // vyndej uzel z fronty
                              // pro všechny syny uzlu s zkontroluj, zda byly navštíveny
                for (vector<Vertex> ::iterator it = Edge[s].begin(); it != Edge[s].end(); it++)
                {

                    if (!visited[it->V]) // jestli nebyl navštíven
                    { // dej jej do fronty a označ jej jako navštívený
                        visited[it->V] = true;
                        cesta[it->V] = s;
                        vzdalenosti[it->V] = vzdalenosti[s] + it->W;
                        fronta.push(it->V);
                    }
                }
            }
            if (s == t)
            {
                cout << endl << "Delka cesty: " << vzdalenosti[t] << endl;
                cout << "Cesta: " << t << " ";
                while (cesta[t] != -1)
                {
                    cout << cesta[t] << " ";
                    t = cesta[t];
                }
            }
            else cout << endl << "Cesta neexistuje";
        }

        void Find_Best(int s, int t) // Hledáme nejkratší cestu úpravou Breadth First Search
        {
            // visited.assign(V_count, false); // žádný uzel nebyl navštíven
            queue<int> fronta; // fronta
            vector<int> cesta;
            vector<int> vzdalenosti;
            cesta.resize(V_count);
            cesta.assign(V_count, -1);
            vzdalenosti.resize(V_count);
            vzdalenosti.assign(V_count, nekonecno);

            // visited[s] = true; // první uzel byl navštíven
            fronta.push(s); // vlož uzel do fronty
            vzdalenosti[s] = 0;
            while (!fronta.empty()) // dokud není fronta prázdná
            {
                s = fronta.front();
                fronta.pop(); // vyndej uzel z fronty
                              // pro všechny syny uzlu s zkontroluj
                for (vector<Vertex> ::iterator it = Edge[s].begin(); it != Edge[s].end(); it++)
                {
                    if (vzdalenosti[it->V] > vzdalenosti[s] + it->W) // jestli jsem našel kratší
                    {
                        cesta[it->V] = s;
                        vzdalenosti[it->V] = vzdalenosti[s] + it->W;
                        fronta.push(it->V);
                    }
                }
            }
            if (vzdalenosti[t] < nekonecno)
            {
                cout << endl << "Delka nejkratsi cesty: " << vzdalenosti[t] << endl;
                cout << "Nejkratsi cesta: " << t << " ";
                while (cesta[t] != -1)
                {
                    cout << cesta[t] << " ";
                    t = cesta[t];
                }
            }
            else cout << endl << "Nejkratsi cesta neexistuje";
        }

        void Find_Worst(int s, int t) // Hledáme nejdelší cestu úpravou Breadth First Search - Graf nesmí obsahovat cyklus
        {
            visited.assign(V_count, false); // žádný uzel nebyl navštíven
            queue<int> fronta; // fronta
            vector<int> cesta;
            vector<int> vzdalenosti;
            cesta.resize(V_count);
            cesta.assign(V_count, -1);
            vzdalenosti.resize(V_count);
            vzdalenosti.assign(V_count, 0);

            visited[s] = true; // první uzel byl navštíven
            fronta.push(s); // vlož uzel do fronty
            vzdalenosti[s] = 0;
            while (!fronta.empty()) // dokud není fronta prázdná a nenašel se uzel
            {
                s = fronta.front();
                fronta.pop(); // vyndej uzel z fronty
                              // pro všechny syny uzlu s zkontroluj, zda byly navštíveny
                for (vector<Vertex> ::iterator it = Edge[s].begin(); it != Edge[s].end(); it++)
                {
                    if (vzdalenosti[it->V] < vzdalenosti[s] + it->W) // jestli jsem našel delší
                    {
                        cesta[it->V] = s;
                        vzdalenosti[it->V] = vzdalenosti[s] + it->W;
                        fronta.push(it->V);
                    }
                }
            }
            if (vzdalenosti[t] > 0)
            {
                cout << endl << "Delka nejdelsi cesty: " << vzdalenosti[t] << endl;
                cout << "Nejdelsi cesta: " << t << " ";
                while (cesta[t] != -1)
                {
                    cout << cesta[t] << " ";
                    t = cesta[t];
                }
            }
            else cout << endl << "Nejdelsi cesta neexistuje";
        }

        void Dijkstra(int s) // Jako Breadth First Search, ale s hledanim pivota
        {
            vector<int> pivoti(visited); // pivoti
                                         // pivoti.resize(V_count);
            pivoti.assign(V_count, false); // žádný uzel nebyl zatím pivot
                                           // queue<int> fronta; // fronta
            pivoti[s] = true; // první uzel je pivot
            vector<int> vzdalenosti;
            vzdalenosti.resize(V_count);
            vzdalenosti.assign(V_count, nekonecno);
            int pivot = s;
            vzdalenosti[s] = 0;
            cout << endl << "pivot: ";
            while (pivot != -1)
            {
                cout << pivot << " ";
                pivoti[pivot] = true; // už byl pivot
                                      // pro všechny syny pivota zkontroluj, zda neni lepsi cesta (relaxuj hrany)
                for (vector<Vertex> ::iterator it = Edge[pivot].begin(); it != Edge[pivot].end(); it++)
                {
                    if (vzdalenosti[it->V] > it->W + vzdalenosti[pivot]) vzdalenosti[it->V] = it->W + vzdalenosti[pivot];
                }
                // nyní najdi nového pivota (uzel kretý nebyl pivot a je do něj nejkratší cesta
                int min = nekonecno;
                pivot = -1;
                for (int i = 0; i < vzdalenosti.size(); i++)
                {
                    if (vzdalenosti[i] < min && !pivoti[i])
                    {
                        min = vzdalenosti[i];
                        pivot = i;
                    }
                }
            }
            // vypíšeme vzdálenosti
            for (int i = 0; i < vzdalenosti.size(); i++)
            {
                cout << endl << i << ": " << vzdalenosti[i];
            }*/
        }
    }


namespace DynamicProgrammingDemo
{
    internal class Program
    {
        private static int V; // Number of vertices in the graph

        // Function to find the vertex with the minimum distance value, from the set of vertices not yet included in the shortest path tree
        private static int MinDistance(int[] dist, bool[] sptSet)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int v = 0; v < V; v++)
            {
                if (!sptSet[v] && dist[v] < min)
                {
                    min = dist[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        // Function to print the constructed distance array
        private static void PrintSolution(int[] dist)
        {
            Console.WriteLine("Vertex \t Distance from Source");
            for (int i = 0; i < V; i++)
            {
                Console.WriteLine(i + " \t " + dist[i]);
            }
        }

        // Function to implement Dijkstra's algorithm for a given graph
        private static void Dijkstra(int[,] graph, int src)
        {
            int[] dist = new int[V]; // The output array to store the shortest distance from the source to each vertex
            bool[] sptSet = new bool[V]; // sptSet[i] will be true if vertex i is included in the shortest path tree

            // Initialize all distances as infinite and sptSet[] as false
            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            // Distance of source vertex from itself is always 0
            dist[src] = 0;

            // Find shortest path for all vertices
            for (int count = 0; count < V - 1; count++)
            {
                int u = MinDistance(dist, sptSet); // Pick the vertex with the minimum distance value
                sptSet[u] = true;

                // Update dist[] value of the adjacent vertices of the picked vertex
                for (int v = 0; v < V; v++)
                {
                    if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                    }
                }
            }

            // Print the constructed distance array
            PrintSolution(dist);
        }

        public static void Main(string[] args)
        {
            V = 9; // Number of vertices in the graph
            int[,] graph =
            {
                { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
            };

            Dijkstra(graph, 0); // Find the shortest paths from source vertex 0
        }
    }
}
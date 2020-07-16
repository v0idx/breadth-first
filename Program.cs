using System;
using System.Collections;
using System.Collections.Generic;

namespace graphTraversal
{
    class Program
    {
        public static void addElements(int[] elements, ref Queue addQueue)
        {
            foreach (int e in elements)
            {
                addQueue.Enqueue(e);
            }
        }

        public static int breadthSearch(Dictionary<int, int[]> graph, Queue searchQueue)
        {
            int endNode = 3;

            ArrayList checkedNodes = new ArrayList();
            while (searchQueue.Count > 0)
            {
                int node = (int)searchQueue.Dequeue();
                if (!checkedNodes.Contains(node))
                {
                    if (node == endNode)
                    {
                        Console.WriteLine("You have reached the end node!");
                        return node;
                    }
                    else
                    {
                        checkedNodes.Add(node);
                        addElements(graph[node], ref searchQueue);

                    }
                }

            }
            return -1;
        }

        public static void Main(string[] args)
        {

            Dictionary<int, int[]> graph = new Dictionary<int, int[]>();

            Queue searchQueue = new Queue();



            graph.Add(0, new int[] { 1, 2 });
            graph.Add(1, new int[] { 3 });
            graph.Add(2, new int[] { 0 });
            graph.Add(3, new int[] { 2 });

            addElements(graph[0], ref searchQueue);

            Console.WriteLine(breadthSearch(graph, searchQueue));
            Console.ReadKey();

        }
    }
}

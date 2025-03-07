using System;
using System.Collections.Generic;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace GraphPlayground
{
    internal class Program
    {
        public static void DFS2(Node currentNode) //rekurzivně
        {
            currentNode.visited = true;
            foreach (Node neighbor in currentNode.neighbors)
            {
                if (!neighbor.visited) 
                {
                    DFS2(neighbor);
                }
            }
        }
        public static void DFS(Graph graph, Node startNode, Node targetNode = null)
        {
            Node currentNode = null;
            List<Node> stack = new List<Node>(); 
            stack.Add(startNode);

            while (stack.Count > 0)
            {
                currentNode = stack[stack.Count - 1]; 
                stack.RemoveAt(stack.Count - 1); 

                foreach (Node neighbor in currentNode.neighbors)
                {
                    if (!neighbor.visited)
                    {
                        stack.Add(neighbor); 
                        neighbor.visited = true;
                        Console.WriteLine("lol");
                    }
                    else
                    {
                        Console.WriteLine("Neighbor " + neighbor.index + " is already visited");
                    }
                }
            }

            Console.WriteLine("Ended at node " + currentNode.index);
        }

        public static void BFS(Graph graph, Node startNode, Node targetNode = null)
        {
            Node currentNode = null;
            List<Node> queue = new List<Node>();
            queue.Add(startNode);
            while (queue.Count>0)
            {
                currentNode = queue[0];
                queue.RemoveAt(0);
                foreach (Node  neighbors in currentNode.neighbors)
                {
                    if (!neighbors.visited && !queue.Contains(currentNode))
                    {
                        queue.Add(neighbors);
                        neighbors.visited = true;
                        Console.WriteLine("lol");
                    }
                    else 
                    {
                        Console.WriteLine("Neighbor "+neighbors.index+" is already visited");
                    }
                }                
            }
            Console.WriteLine("Ended at node " +currentNode.index);
        }

        static void Main(string[] args)
        {
            //Create and print the graph
            Graph graph = new Graph();
            graph.PrintGraph();
            graph.PrintGraphForVisualization();

            //Call both algorithms with a random starting node
            Random rng = new Random();
            DFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);
            BFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);

            Console.ReadKey();
        }
    }
}

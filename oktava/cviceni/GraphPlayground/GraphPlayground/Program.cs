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
        public static void DFS(Graph graph, Node startNode, Node targetNode = null)
        {
            Node current_node = null;
            Stack<Node> stack = new Stack<Node>();
            stack.Push(startNode);
            Console.WriteLine("Starting node: " + startNode.index);

            while(stack.Count > 0)
            {
                current_node = stack.Pop();
                Console.WriteLine("Current node: " + current_node.index);
                current_node.visited = true;
                foreach(Node neighbor in current_node.neighbors)
                {
                    if(!neighbor.visited && !stack.Contains(neighbor))
                    {
                        Console.WriteLine("Adding neighbor " + neighbor.index + " to stack.");
                        stack.Push(neighbor);
                    }
                    else
                    {
                        Console.WriteLine("Neighbor " + neighbor.index + " is already visited or in stack.");
                    }
                }
            }
            Console.WriteLine("Ended at node: " + current_node.index);
        }

        public static void BFS(Graph graph, Node startNode, Node targetNode = null)
        {
            Node current_node = null;
            List<Node> queue = new List<Node>();
            queue.Add(startNode);
            Console.WriteLine("Starting node: " + startNode.index);

            while(queue.Count > 0)
            {
                current_node = queue[0];
                Console.WriteLine("Current node: " + current_node.index);
                current_node.visited = true;
                queue.RemoveAt(0);
                foreach(Node neighbor in current_node.neighbors)
                {
                    if(!neighbor.visited && !queue.Contains(neighbor))
                    {
                        Console.WriteLine("Adding neighbor " + neighbor.index + " to queue.");
                        queue.Add(neighbor);
                    }
                    else
                    {
                        Console.WriteLine("Neighbor " + neighbor.index + " is already visited or in queue.");
                    }
                    
                }
            }
            Console.WriteLine("Ended at node: " + current_node.index);
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

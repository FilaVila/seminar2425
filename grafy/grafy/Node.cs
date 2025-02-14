using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy
{
    internal class Node
    {
        public int index;
        public List<Node> neighbours;
        public Node(int index)
        {
            this.index = index;
            neighbours = new List<Node>();
        }

        public void AddNeighbours(List<Node> ToAdd) 
        {
            foreach (Node node in ToAdd) 
            {
                if (neighbours.Contains(node))
                {
                    Console.WriteLine("Soused "+ node.index + " is already in the list");
                }
                else
                {
                    neighbours.Add(node);
                }
            }
            //neighbours.AddRange(newnighboursToAdd);
        }
        public void Printneighbours() 
        {
            Console.Write("Node "+index+" has neighbours ");
            foreach (Node node in neighbours) 
            {
                Console.WriteLine(node.index + " ");
            }
        }
        public Node TraverseNode(int indexToTravelrse) 
        {
            foreach(Node node in neighbours) 
            {
                if (node.index == indexToTravelrse)
                {
                    return node;
                }
            }
            Console.WriteLine("sry tento bod s tím nesousedí");
            return this; //vrátí index na kterém zrovna jsme
        }
    }
}

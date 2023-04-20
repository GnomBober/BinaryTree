using System.Xml.Linq;

namespace Tree
{
    class Program
    {
        static private void Main()
        {

        }
        class binaryNode
        {
            class Node
            {
                public Node LeftNode { get; set; }
                public Node RightNode { get; set; }
                public int Data { get; set; }
                public string Straight()
                {
                    string result = "";
                    result+=Data.ToString();
                    if (LeftNode != null) { result += ',' + LeftNode.Straight(); }
                    if (RightNode != null) { result += ',' + RightNode.Straight(); }
                    return result; 
                }

                public string Obratnii()
                {
                    string result = "";              
                    if (LeftNode != null) { result += ',' + LeftNode.Obratnii(); }
                    if (RightNode != null) { result += ',' + RightNode.Obratnii(); } 
                    result += Data.ToString();
                    return result;
                }

                public string Simmetricnii()
                {
                    string result = "";
                    if (LeftNode != null) { result += ',' + LeftNode.Simmetricnii(); }
                    result += Data.ToString();
                    if (RightNode != null) { result += ',' + RightNode.Simmetricnii(); }                   
                    return result;
                }

            }
            class BinaryTree
            {
                public Node Root { get; set; }

                public bool Add(int value)
                {
                    Node before = null, after = this.Root;

                    while (after != null)
                    {
                        before = after;
                        if (value < after.Data)
                            after = after.LeftNode;
                        else if (value > after.Data)
                            after = after.RightNode;
                        else
                        {
                            return false;
                        }
                    }
                    Node newNode = new Node();
                    newNode.Data = value;
                    if (this.Root == null)
                        this.Root = newNode;
                    else
                    {
                        if (value < before.Data)
                            before.LeftNode = newNode;
                        else
                            before.RightNode = newNode;
                    }

                    return true;
                }
                public string Straight()
                {
                   return Root.Straight();
                }
                public string Obratnii()
                {
                    return Root.Obratnii();
                }
                public string Simmetricnii()
                {
                    return Root.Simmetricnii();
                }
            }              
        }
    }
}

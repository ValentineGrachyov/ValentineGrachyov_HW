using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Control_Work.CW2.Trees
{
    public class TreeNode<T> : IComparable<T>, IComparable where T : IComparable, IComparable<T>
    {
        public T Data;
        public TreeNode<T> Left;
        public TreeNode<T> Right;
        public TreeNode<T> Parent;
        public int height;

        public TreeNode(T data)
        {
            Data = data;
        }

        public int CompareTo(object obj)
        {
            if (obj is TreeNode<T> item)
            {
                return Data.CompareTo(item);
            }
            throw new ArgumentException("Не совпадение типов данных");
        }

        public int CompareTo(T data)
        {
            return Data.CompareTo(data);
        }
    }

    public class BinarySearchTree<T> where T : IComparable, IComparable<T>
    {
        private TreeNode<T> Root;
        public List<TreeNode<T>> nodeList;

        public void Add(T data)
        {
            var node = new TreeNode<T>(data);

            if (Root == null)
            {
                node.height = 1;
                Root = node;
                nodeList.Add(Root);
            }
            else
            {
                var runner = Root;
                while (true)
                {
                    if (node.Data.CompareTo(runner.Data) < 0)
                    {
                        if (runner.Left == null)
                        {
                            node.Parent = runner;
                            node.height += node.Parent.height + 1;
                            runner.Left = node;
                            nodeList.Add(node);
                            return;
                        }
                        runner = runner.Left;
                    }
                    else
                    {
                        if (runner.Right == null)
                        {
                            node.Parent = runner;
                            node.height += node.Parent.height + 1;
                            runner.Right = node;
                            nodeList.Add(node);
                            return;
                        }
                        runner = runner.Right;
                    }
                }
            }
        }

        public void NodeHeight(int height)
        {
            foreach (var node in nodeList)
            {
                if (node.height == height)
                {
                    Console.Write(node.Data + " ");
                }
            }
            Console.WriteLine();
        }

        public int NumOfLeaves()
        {
            int count = 0;
            foreach (var node in nodeList)
            {
                if (node.Left == null && node.Right == null)
                {
                    count++;
                }
            }
            return count;
        }

        public void RainbowPrint()
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            var random = new Random();

            if (Root == null)
            {
                return;
            }

            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);
            var lastHeight = 1;
            var currentColor = colors[0];

            while (queue.Count != 0)
            {
                var runner = queue.Peek();
                int currentHeight = runner.height;
                queue.Dequeue();

                if (currentHeight == lastHeight)
                {
                    Console.ForegroundColor = currentColor;
                    Console.WriteLine(runner.Data);
                }
                else
                {
                    lastHeight = currentHeight;
                    currentColor = colors[new Random().Next(1, 15)];
                    Console.ForegroundColor = currentColor;
                    Console.WriteLine(runner.Data); 
                }

                if (runner.Left != null)
                {
                    queue.Enqueue(runner.Left);
                }

                if (runner.Right != null)
                {
                    queue.Enqueue(runner.Right);
                }
            }
        }
    }
}

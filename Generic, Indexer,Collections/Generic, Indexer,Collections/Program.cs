using System;
using System.Collections.Generic;

namespace Generic__Indexer_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Rafet");
            list.Add("Ehmed");
            list.Add("Nurlan");
            list.Add("Kenan");

            list.Remove("Rafet");
            list.RemoveAt(0);
            list.RemoveRange(0, 1);
            Console.WriteLine(list.Count);
            list.ForEach(x => Console.WriteLine(x));
            list.Contains(list[0]);
            int[] arr=new int[] { 1, 2, 3 };
            List<int> list2 = new List<int>(arr);
            list2.Clear();

            HashSet<int> list3 = new HashSet<int>(arr)
            {
                53,53,534,123
            };
            foreach (var item in list3)
            {
                Console.WriteLine(item.GetHashCode());
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Pop();
            stack.Peek();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(4);
            queue.Enqueue(9);
            queue.Dequeue();
            queue.Peek();


            SortedList<int,string> keyValuePairs = new SortedList<int,string>();
            keyValuePairs.Add(1, "bir");
            keyValuePairs.Add(2, "iki");
            keyValuePairs.Add(3, "uc");

            foreach (KeyValuePair<int,string> item in keyValuePairs)
            {
                Console.WriteLine("key:{0} value:{1}",item.Key,item.Value);
            }
            Console.WriteLine("=================");
            Console.WriteLine(keyValuePairs[3]);
            if (keyValuePairs.ContainsKey(2))
            {
                keyValuePairs[2] = "ehmed";
            }
        }
    }
}

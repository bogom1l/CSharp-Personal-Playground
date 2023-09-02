namespace LinearDataStructuresDemo //List, LinkedList, Stack, Queue, 
{
    public class Program
    {
        private static void Main()
        {
            // LinkedListDemo();
            // StackDemo_FindMatchingBraces();
            // LinkedListDemo_Reverse();
            // StackDemo_ReverseString("abc");
            // StackDemo_DeleteMiddleElement();
            QueueDemo_PrintFileDirectories(@"C:\User\Programs\Visual Studio\Projects\LinearStructuresDemo");
        }

        private static void LinkedListDemo()
        {
            LinkedList<string> myLinkedList = new();
            myLinkedList.AddFirst("first");
            myLinkedList.AddLast("last");
            myLinkedList.AddAfter(myLinkedList.First!, "test1");
            myLinkedList.AddBefore(myLinkedList.Last!, "test2");


            foreach (var i in myLinkedList)
            {
                Console.Write(i + " ");
            }
        }

        private static void LinkedListDemo_Reverse()
        {
            MyLinkedList myLinkedList = new();
            myLinkedList.Push(3);
            myLinkedList.Push(66);
            myLinkedList.Push(34);
            myLinkedList.Push(75);
            myLinkedList.Push(1);

            myLinkedList.Print();
        }

        private static void StackDemo_FindMatchingBraces()
        {
            string expression = "1 + (2 - (2+3) * 4 / (3+1)) * 5";
            Stack<int> myStack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];
                if (ch == '(')
                {
                    myStack.Push(i);
                }
                else if (ch == ')')
                {
                    int startIndex = myStack.Pop();
                    int length = i - startIndex + 1;
                    string content = expression.Substring(startIndex, length);
                    Console.WriteLine(content);
                }
            }
        }

        private static void StackDemo_ReverseString(string str)
        {
            Stack<char> myStack = new();

            foreach (var c in str)
            {
                myStack.Push(c);
            }

            // Print
            while (myStack.Count > 0)
            {
                Console.Write(myStack.Pop());
            }
        }

        private static void StackDemo_DeleteMiddleElement() //unsolved (probably should use new temp stack)
        {
            Stack<int> myStack = new();
            myStack.Push(50);
            myStack.Push(40);
            myStack.Push(30);
            myStack.Push(20);
            myStack.Push(10);

            int middleElementIndex = myStack.Count / 2;

            for (int i = 0; i < myStack.Count; i++)
            {
                if (i == middleElementIndex)
                {
                    myStack.Pop();
                    break;
                }
            }

            // Print
            while (myStack.Count > 0)
            {
                Console.Write(myStack.Pop() + " ");
            }
        }

        private static void QueueDemo_PrintFileDirectories(string fileDirectory)
        {
            Queue<char> myQueue = new();

            for (int i = 0; i < fileDirectory.Length; i++)
            {
                char currentCharacter = fileDirectory[i];

                myQueue.Enqueue(currentCharacter);

                if (currentCharacter == '\\' || i == fileDirectory.Length - 1)
                {
                    while (myQueue.Count > 0)
                    {
                        Console.Write(myQueue.Dequeue());
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
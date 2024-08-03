internal class Program
{
    private static void Main(string[] args)
    {
        


        #region ArrayList

        // ArrayList   ==>    Non Generics Collection
        // Array Based : Implemented Based On Array

        // ArrayList  Indexed == Dynamic Size
        // Array      Indexed == Fixed   Size


        //ArrayList list = new ArrayList(new int[] {1,2,3});
        //ArrayList list = new ArrayList(5);
        //   ArrayList list = new ArrayList();

        ////   Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity} ");  // Like Length ==> Count

        //   list.Add( 1 );
        ////   Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity} ");  // Count : 1 , Capacity : 4

        //   list.Add( 2 );
        //   list.Add( 3 );
        //   list.Add( 4 );
        //   list.Add( 5 );
        // //  Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity} ");  // Count : 5 , Capacity : 8

        //   //list[0] = 12;
        //   //list[6] = 18;

        //   //Console.WriteLine(list[6]); // Expection OutofRange

        //   list.Add(7);
        //   list.Add(6);
        //   list.Add(8);
        //   list.Add(9);
        //   Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity} ");  // Count : 9 , Capacity : 16


        //  ArrayList list = new ArrayList();
        //int i =  list.Add(1);
        //    i =  list.Add(2);
        //    i =  list.Add(3);
        //    i =  list.Add(4);

        //  // Console.WriteLine(i);  // 3

        //  list.AddRange(new int[] {1,2,3,4,5});
        //  i = list.BinarySearch(1);

        //  // list.BinarySearch();

        //  // list.Clear();

        //  list.Clone(); //Deep Copy

        //  int[] num = new int[] {1,2,3,5};

        //  // list.CopyTo(num);
        //  // 0 1 2 3 4 5 6 
        //  // list.CopyTo(num,6);

        //  //ArrayList array = list.GetRange(0, 30);

        //  //list.IndexOf(1);
        //  //list.IndexOf(1,2);
        //  //list.IndexOf(1,3,4);

        //  //list.Insert(1,2);
        //  //list.InsertRange(2,new int[] { 10,4,55});

        // // list.TrimToSize();
        //  Console.WriteLine($" Count : {list.Count} , Capacity : {list.Capacity} ");

        //  Console.WriteLine("==========Element===============");
        //  foreach (int item in num)
        //  {
        //      Console.WriteLine(item);
        //  }
        #endregion

        #region  Problem Of ArrayList

        //ArrayList list = new ArrayList();

        //list.Add(1);
        //list.Add(2);
        //list.Add(3);
        //list.Add(4);    
        //list.Add(5);
        //list.Add("koll");

        //int sum = SumArrayList(list);

        //Console.WriteLine(sum);

        // Generics Version Of Array List ==> List

        #endregion

        #region List 

        // List : Generics Collection - Lists
        // Array Based Indexed
        // Dynamic Size

        //   List<int> list = new List<int>(new int[] {1,2,3,});
        //   List<int> list = new List<int>(5);
        //  List<int> list = new List<int>();

        //  Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity} ");

        //list.Add(1);
        //list.Add(2);
        //list.Add(3);

        //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity} "); //Count : 3 , Capacity : 4

        // list.Add("hello"); //  InValid

        //Console.WriteLine("======Elements is List======");
        //foreach (int item in list)
        //{  
        //    Console.WriteLine(item); 
        //}

        //  list.Add(1);
        // list.AddRange(new int[] {1,2,3});
        // list.AsReadOnly();
        //int i = list.EnsureCapacity(20);
        //Console.WriteLine(i); // 20

        #endregion

        #region LinkedList

        // Generics Lists
        // LinkedList  : NodeBased

        //LinkedList<int> LinkedList = new LinkedList<int>();

        //LinkedList.AddLast(1);
        //LinkedList.AddLast(2);
        //LinkedList.AddLast(3);
        //LinkedList.AddLast(4);

        //LinkedList.AddFirst(15);

        //LinkedList.AddBefore(LinkedList.Last, 999);
        ////Console.WriteLine(LinkedList.First.Value);

        //LinkedListNode<int> current = LinkedList.First;

        //// Frist ==> Last

        //// LinkedList.Last.Next // null
        //while (current != LinkedList.Last)
        //{
        //    Console.WriteLine(current.Value);
        //    current = current.Next;
        //}

        #endregion

        #region Stack

        //Stack : Generics _ Non Generics _ List
        //Array Based _ Node Based 

        //Stack<int> stack = new Stack<int>();

        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(3);
        //stack.Push(4);

        //int Pop = stack.Pop();
        //int Top = stack.Peek();

        //Console.WriteLine(Top);//3
        //Console.WriteLine(Pop);//4

        //stack.TryPop(out int Pop);
        //Console.WriteLine(Pop);
        //stack.TryPeek(out int Top);
        //Console.WriteLine(Top);

        #endregion

        #region Queue
        //Queue : Generics _ Non Generic _ List
        //Arry Based 

        //Queue<int> queue = new Queue<int>();

        //queue.Enqueue(1);
        //queue.Enqueue(2);
        //queue.Enqueue(3);
        //queue.Enqueue(4);

        //queue.Dequeue();

        //Console.WriteLine(queue.Peek());

        //queue.TryDequeue(out int frist);
        //Console.WriteLine(frist);
        //queue.TryPeek(out int Peek);
        //Console.WriteLine(Peek); 
        #endregion


    }
}
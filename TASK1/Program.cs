//TASK5

Stack<int> ints=new Stack<int>();
ints.Push(5);
ints.Push(16);
ints.Push(11);
ints.Push(1);
ints.Push(2);
ints.Push(3);
ints.Push(4);
ints.Push(6);

System.Console.WriteLine("Deleted of stack : "+ints.Pop());
System.Console.WriteLine();
foreach (var item in ints)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("Writed on last : "+ints.Peek());
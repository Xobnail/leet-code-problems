namespace LeetCodeProblems.Problems._232._Implement_Queue_using_Stacks;

/// <summary>
/// 232. Implement Queue using Stacks
/// </summary>

internal class MyQueue
{
    private Stack<int> items;
    private Stack<int> buf;

    public MyQueue()
    {
        items = new Stack<int>();
        buf = new Stack<int>();
    }

    public void Push(int x)
    {
        items.Push(x);
    }

    public int Pop()
    {
        Reverse();

        return buf.Pop();
    }

    public int Peek()
    {
        Reverse();

        return buf.Peek();
    }

    public bool Empty()
    {
        return items.Count == 0 && buf.Count == 0;
    }

    public void Reverse()
    {
        if (buf.Count == 0)
        {
            while (items.Count > 0)
            {
                buf.Push(items.Pop());
            }
        }        
    }
}

//internal class MyQueue
//{
//    private Stack<int> items;
//    private Stack<int> buf;

//    public MyQueue()
//    {
//        items = new Stack<int>();
//        buf = new Stack<int>();
//    }

//    public void Push(int x)
//    {
//        while (items.Count > 0)
//        {
//            buf.Push(items.Pop());
//        }

//        items.Push(x);

//        while (buf.Count > 0)
//        {
//            items.Push(buf.Pop());
//        }
//    }

//    public int Pop()
//    {
//        return items.Pop();
//    }

//    public int Peek()
//    {
//        return items.Peek();
//    }

//    public bool Empty()
//    {
//        return items.Count == 0;
//    }
//}

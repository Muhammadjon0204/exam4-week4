using System;

namespace TASK1;

public class Stack<T>
{

public List<T> _list = new List<T>();

public void Push(T item)
    {
        _list.Add(item);
    }
    public T Pop()
    {
        int lastIndex=_list.Count-1;
        _list.RemoveAt(lastIndex);
        return _list[lastIndex];
    }
    public T Peek()
    {
         int lastIndex=_list.Count-1;
  return _list[lastIndex];
      }

}

using System;
using System.Collections.Generic;
using System.Text;

class Stack
{
    private int _position;
    private object[] _data = new object[10];

    public void Push(object obj)
    {
        _data[_position++] = obj;
    }
    public object Pop()
    {
        return _data[--_position];
    }
}

interface IDisplayable
{

}

struct Point : IDisplayable
{
    public int X;
    public int Y;
}

class GenericStack<T>
{
    private T[] _items = new T[100];
    private int _top = 0;

    public void Push(T item)
    {
        _items[_top++] = item;  
    }

    public T Pop()
    {
        return _items[--_top]; 
    }
}

class Points
{
    public int X;
    public int Y;
}
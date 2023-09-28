using System;
using System.Collections;
using System.Collections.Generic;
public class Myarray<t> : IEnumerable<t>
{
    t[] arr;
    int count;
    public Myarray(int size = 3)
    {
        count = 0;
        arr = new t[size];

    }
    public void Add(t item)
    {
        if (count == arr.Length)
            Array.Resize(ref arr, arr.Length * 2);
        arr[count++] = item;
    }

    public IEnumerator<t> GetEnumerator()
    {
        foreach (t item in arr)
        {
            if (item != null)

                yield return item;
        }

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}



using System;
using System.Collections.Generic;

    public static class Arraymethode
    {
    public static t first<t> (this IEnumerable<t> item)
    {
        int i = 0;
        foreach (t T in item)
        {
            if (i == 0)
                return T;
        }
        return default;

    }
    public static t last<t>(this t[] item)
    {
        return item[item.Length - 1];
    }
    public static IEnumerable<t> where<t> (this IEnumerable<t> item, Func<t ,bool> arrfilter)
    {
        foreach(t T in item)
        {
            if(arrfilter(T))
                yield return T;
        }
    } 
    public static IEnumerable<t> taken<t> (this IEnumerable<t> item, int num)
    {
        int cur = 0;
            foreach(t T in item)
        {
            cur++;
            if (cur <= num)
                yield return T;
        }
    }
    public static IEnumerable<outp> SelectMethod<t, outp>(this IEnumerable<t> item,
                Func<t, outp> filter)
    {
        foreach (t T in item)
            yield return filter(T);
    }


}


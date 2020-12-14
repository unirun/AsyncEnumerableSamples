using System;
using System.Collections.Generic;

namespace AsyncEnumerableSamples
{
    public static class Extensions
    {
        public static async IAsyncEnumerable<U> Select<T, U>(this IAsyncEnumerable<T> items, Func<T, U> selector)
        {
            await foreach (var item in items)
                yield return selector(item);
        }

        public static async IAsyncEnumerable<T> Where<T>(this IAsyncEnumerable<T> items, Func<T, bool> predicate)
        {
            await foreach (var item in items)
            {
                if (predicate(item))
                    yield return item;
            }
        }
        // 他、 await foreach を使って実装する
    }
}
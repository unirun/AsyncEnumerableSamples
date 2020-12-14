using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncEnumerableSamples
{
    public class Sample
    {
        public async Task DoAsync()
        {
            await foreach (var item in ReadAllLinesAsync())
                Console.WriteLine(item);
        }

        public async IAsyncEnumerable<string> ReadAllLinesAsync()
        {
            var lines = @"read
all
lines
async";
            var reader = new System.IO.StringReader(lines);
            while (reader.Peek() != -1)
            {
                yield return await reader.ReadLineAsync();
            }
        }
    }
}
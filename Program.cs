using System;
using System.Threading.Tasks;

namespace AsyncEnumerableSamples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await new Sample().DoAsync();
        }
    }
}

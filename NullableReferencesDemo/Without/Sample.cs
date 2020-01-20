using System;

namespace Without
{
    public class Sample
    {
        private string DoSomeWork()
        {
            var something = new Something(7);

            var result = GetAStringFor(something);

            return result.Replace('a', 'e');
        }

        private string GetAStringFor(
            Something something)
        {
            return null;
        }


        private class Something
        {
            public Something(
                int length)
            {
                Length = length;
            }

            public int Length { get; }
        }

        public static void Main()
        {
            var sample = new Sample();
            var result = sample.DoSomeWork();

            Console.WriteLine(result);
        }
    }
}
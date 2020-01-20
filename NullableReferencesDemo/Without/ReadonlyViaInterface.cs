using System;

namespace Without
{
    public class ReadonlyViaInterface
    {
        public interface IReadonly
        {
             Something Value { get; }
        }

        public class Mutable : IReadonly
        {
            public Something Value { get; set; }
        }

        public class Something
        {
        }

        public static void Run()
        {
            var mutable = new Mutable();
            mutable.Value = new Something();

            var readable = (IReadonly) mutable;

            var result = readable.Value;
        }
    }
}
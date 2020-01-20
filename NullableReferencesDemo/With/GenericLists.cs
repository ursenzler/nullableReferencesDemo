using System;
using System.Collections.Generic;

namespace With
{
    // show that it works nicely with generic collections
    public class GenericLists
    {
        public class Worker<T>
            where T : IValueProvider
        {
            public void Work(
                IReadOnlyCollection<T> values)
            {
                foreach (var value in values)
                {
                    var x = value.Value;
                }
            }
        }

        public static void Run()
        {
            var classWorker = new Worker<SomeClass>();
            classWorker.Work(new[] { new SomeClass() /*, null */ });

            var structWorker = new Worker<SomeStruct>();
            structWorker.Work(new[] { new SomeStruct() });
        }

        public interface IValueProvider
        {
            string Value { get; }
        }

        public class SomeClass : IValueProvider
        {
            public string Value { get; } = string.Empty;
        }

        public struct SomeStruct : IValueProvider
        {
            public string Value => string.Empty;
        }
    }
}
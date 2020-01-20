using System;
using System.Collections.Generic;
using System.Linq;

namespace With
{
    // T? zurück geben
    // Option verwenden
    public class ReturnGenerics
    {
        // public class GenericClass<T>
        // {
        //     public Option<T> GetValue()
        //     {
        //         return Option<T>.None;
        //     }
        // }
        //
        // public static void Run()
        // {
        //     var genericInt = new GenericClass<int>();
        //     var intResult = genericInt.GetValue();
        //
        //     var genericObject =  new GenericClass<Something>();
        //     var objectResult = genericObject.GetValue();
        // }
        //
        // public class Something
        // {
        // }
        //
        // public class Option<T>
        // {
        //     public static Option<T> Some(T value)
        //         => new Option<T>(new[] { value });
        //
        //     public static Option<T> None
        //         => new Option<T>(new T[0]);
        //
        //     private readonly IEnumerable<T> values;
        //
        //     private Option(
        //         IEnumerable<T> values)
        //     {
        //         this.values = values;
        //     }
        //
        //     public bool IsSome
        //         => this.values.Any();
        //
        //     public bool IsNone
        //         => !this.values.Any();
        //
        //     private T Value
        //         => !this.IsSome
        //             ? throw new InvalidOperationException("Option does not have a value")
        //             : this.values.Single();
        //
        //     public Option<T2> Map<T2>(Func<T, T2> f)
        //         => this.IsSome
        //             ? Option<T2>.Some(f(this.Value))
        //             : Option<T2>.None;
        //
        //     public bool TryGetValue(out T value)
        //     {
        //         if (this.IsSome)
        //         {
        //             value = this.Value;
        //             return true;
        //         }
        //
        //         value = default!;
        //         return false;
        //     }
        // }
    }
}
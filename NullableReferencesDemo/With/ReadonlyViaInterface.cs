using System;

namespace With
{
    // Something? zurück geben
    // Interface explizit implementieren
    // mutable und readonly model
    public class ReadonlyViaInterface
    {
    //     public interface IReadonly
    //     {
    //          Something Value { get; }
    //     }
    //
    //     public class Mutable : IReadonly
    //     {
    //         public Something? ValueMutable { get; set; }
    //
    //         Something IReadonly.Value => ValueMutable ?? throw new InvalidOperationException("oops");
    //     }
    //
    //     public class Something
    //     {
    //     }
    //
    //     public static void Run()
    //     {
    //         var mutable = new Mutable();
    //         mutable.ValueMutable = new Something();
    //
    //         var readable = (IReadonly) mutable;
    //
    //         var result = readable.Value;
    //     }
    }
}
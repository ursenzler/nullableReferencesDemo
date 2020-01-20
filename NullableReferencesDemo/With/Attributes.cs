using System;

namespace With
{
    public class Attributes
    {
        public (string, string?) Get(
            string a,
            string? b,
            int c,
            int? d)
        {
            return ("blah", null);
        }
    }

    /*

using System;
using System.Runtime.CompilerServices;

namespace With
{
  public class Attributes
  {
    [NullableContext(1)]
    [return: Nullable(new byte[] {0, 1, 2})]
    public ValueTuple<string, string> Get(string a, [Nullable(2)] string b, int c, int? d)
    {
      return new ValueTuple<string, string>("blah", (string) null);
    }
  }
}

     */
}
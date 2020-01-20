namespace Without
{
    public class ReturnGenerics
    {
        public class GenericClass<T>
        {
            public T GetValue()
            {
                return default;
            }
        }

        public static void Run()
        {
            var genericInt = new GenericClass<int>();
            var intResult = genericInt.GetValue();

            var genericObject =  new GenericClass<Something>();
            var objectResult = genericObject.GetValue();
        }

        public class Something
        {
        }
    }
}
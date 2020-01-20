namespace With
{
    // show notnull type constraint
    // show that it is no safe if used from a library without nullable reference types
    public class NotNullTypeConstraint
    {
        public class Worker<T>
            where T : notnull
        {
            public string Work(T value)
            {
                if (value != null) // that can return false if called from a library without checks
                {
                    return value.ToString() ?? string.Empty;
                }

                return string.Empty;
            }
        }

    }
}
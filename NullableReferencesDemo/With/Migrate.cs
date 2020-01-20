namespace With
{
    // bottom-up, otherwise you have to deal with all the nullable types
    // you can use ? to delay big refactorings, but it will get confusing
    // cheat with ! but look for a better design
    // using external libraries without support for NRT is a pain -> wrapper
    // introduce something like Option to simplify handling real nulls (e.g. Map)
    // or just use F# :-)
    public class Migrate
    {
    }
}
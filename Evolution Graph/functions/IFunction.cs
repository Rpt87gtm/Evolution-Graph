namespace Evolution_Graph.functions
{
    internal interface IFunction<T>
    {
        string Name { get; }
        T Evaluate(T value);
    }
}

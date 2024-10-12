namespace Evolution_Graph.functions
{
    internal class Function : IFunction<Double>
    {
        private Func<double, double> _function;
        public string Name { get; }

        public Function(string name, Func<double, double> function)
        {
            Name = name;
            _function = function;
        }

        public double Evaluate(double value)
        {
            return _function(value);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

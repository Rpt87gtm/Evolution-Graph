namespace Evolution_Graph.genetic
{
    internal class GeneticAlgorithm
    {
        public Population Population { get; private set; }

        private int _roundSize;
        private int _splitsCount;
        private Random _random = new Random();
        private Mutation _mutation;
        private double[] _targetValues;
        public GeneticAlgorithm(Population population, int roundSize, int splitsCount, Mutation mutation, double[] targetValues)
        {
            Population = population;
            _roundSize = roundSize;
            _splitsCount = splitsCount;
            _mutation = mutation;
            _targetValues = targetValues;
        }



        public void DoEvolutionStep(int crossoversCount, int maxMutationCount)
        {
            for (int i = 0; i < crossoversCount; i++)
            {
                Population.CrossoverPair(_roundSize, _splitsCount);
            }
            for (int i = 0; i < maxMutationCount; i++)
            {
                if (_mutation.CanMutate(_random)) Population.MutateRandomIndivid(_mutation);
            }

            Population.PopulationDecline();
        }

        public void DoEvolutionUntilTarget(double eps, int crossoversCount, int maxMutationCount, Action callback)
        {
            while (Population.TopFitness() > eps)
            {
                DoEvolutionStep(crossoversCount, maxMutationCount);
                callback.Invoke();
            }
        }

    }
}

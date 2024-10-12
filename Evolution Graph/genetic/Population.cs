namespace Evolution_Graph.genetic
{
    internal class Population
    {
        private List<Individual> _individuals;
        private double[] _targetValues;
        private int _populationSize;
        private bool _isSorted;
        private Random _random = new Random();

        public Population(int populationSize, double minSpread, double maxSpread, double[] targetValues)
        {
            _individuals = new List<Individual>();
            _populationSize = populationSize;

            InitRandomPopulation(populationSize, minSpread, maxSpread);
            _targetValues = targetValues;
            _isSorted = false;
        }

        private void SortPopulation()
        {
            _individuals = _individuals.OrderBy(i => i.Fitness(in _targetValues)).ToList();
            _isSorted = true;
        }

        public double TopFitness()
        {
            if (!_isSorted) SortPopulation();
            return _individuals[0].Fitness(in _targetValues);
        }

        public double[] TopFitnessPoints()
        {
            if (!_isSorted) SortPopulation();
            return _individuals[0].Genotype.Gens;
        }


        private void InitRandomPopulation(int populationSize, double minSpread, double maxSpread)
        {
            for (int i = 0; i < populationSize; i++)
            {
                _individuals.Add(new Individual(new Genotype(100, minSpread, maxSpread)));
            }
            _isSorted = false;
        }
        public void CrossoverPair(int tournamentSize, int splitsCount)
        {
            var parents = SelectParentsForCrossover(tournamentSize);
            var children = parents.Item1.Crossover(parents.Item2, splitsCount);
            _individuals.Add(children.Item1);
            _individuals.Add(children.Item2);
            _isSorted = false;
        }

        public void MutateRandomIndivid(Mutation mutation)
        {
            _individuals.Add(mutation.Mutate(GetRandomIndivid().Genotype, _random));
            _isSorted = false;
        }
        private Individual GetRandomIndivid()
        {
            return _individuals[_random.Next(0, _individuals.Count)];
        }

        private (Individual, Individual) SelectParentsForCrossover(int tournamentSize)
        {
            Individual parent1 = TournamentSelection(tournamentSize);
            Individual parent2 = TournamentSelection(tournamentSize);

            return (parent1, parent2);
        }

        private Individual TournamentSelection(int tournamentSize)
        {
            Individual best = null;
            double minFitness = double.MinValue;

            for (int i = 0; i < tournamentSize; i++)
            {
                Individual candidate = _individuals[_random.Next(_individuals.Count)];
                double candidateFitness = candidate.Fitness(in _targetValues);

                if (candidateFitness > minFitness)
                {
                    best = candidate;
                    minFitness = candidateFitness;
                }
            }
            return best;
        }

        public void PopulationDecline()
        {
            if (!_isSorted) SortPopulation();
            _individuals = _individuals.Take(_populationSize).ToList();
        }
    }
}

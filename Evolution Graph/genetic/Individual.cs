namespace Evolution_Graph.genetic
{
    class Individual
    {
        public Genotype Genotype { get; private set; }
        private double? _fitness;
        public Individual(Genotype genotype)
        {
            Genotype = genotype;
        }

        public double Fitness(in double[] targetValues)
        {
            if (!_fitness.HasValue)
            {
                _fitness = Genotype.EuclideanDistance(targetValues);
            }
            return _fitness.Value;
        }

        public (Individual, Individual) Crossover(Individual other, int splitsCount)
        {

            var childGenotypes = Genotype.Crossover(other.Genotype, splitsCount);
            return (new Individual(childGenotypes.Item1), new Individual(childGenotypes.Item2));
        }
    }

    public struct Genotype
    {
        public double[] Gens;
        private Random _random;
        public Genotype(double[] gens)
        {
            Gens = gens;
            _random = new Random();
        }
        public Genotype(int size, double minSpread, double maxSpread)
        {
            _random = new Random();
            Gens = new double[size];
            InitRandomValues(minSpread, maxSpread);
        }

        private void InitRandomValues(double minSpread, double maxSpread)
        {
            for (int i = 0; i < Gens.Length; i++)
            {
                Gens[i] = minSpread + (maxSpread - minSpread) * _random.NextDouble();
            }
        }

        public (Genotype, Genotype) Crossover(Genotype other, int splitsCount)
        {

            int[] splitsPositions = GenerateUniqueSplits(splitsCount, Gens.Length);


            double[] childGens1 = new double[Gens.Length];
            double[] childGens2 = new double[Gens.Length];

            bool useThisGenotype = _random.Next(0, 2) == 0;

            for (int i = 0; i < childGens1.Length; i++)
            {
                childGens1[i] = (useThisGenotype ? this : other).Gens[i];
                childGens2[i] = (useThisGenotype ? other : this).Gens[i];
                if (Array.IndexOf(splitsPositions, i) != -1)
                {
                    useThisGenotype = !useThisGenotype;
                }
            }

            return (new Genotype(childGens1), new Genotype(childGens2));
        }

        private int[] GenerateUniqueSplits(int splitsCount, int length)
        {
            HashSet<int> splits = new HashSet<int>();
            while (splits.Count < splitsCount)
            {
                splits.Add(_random.Next(0, length));
            }

            return splits.ToArray();
        }
        public double EuclideanDistance(Genotype other)
        {

            double sumOfSquares = 0.0;
            for (int i = 0; i < Gens.Length; i++)
            {
                double difference = Gens[i] - other.Gens[i];
                sumOfSquares += difference * difference;
            }

            return Math.Sqrt(sumOfSquares);
        }
        public double EuclideanDistance(double[] target)
        {
            return EuclideanDistance(new Genotype(target));
        }
        public Genotype Copy()
        {
            double[] copiedGens = new double[Gens.Length];
            Array.Copy(Gens, copiedGens, Gens.Length);
            return new Genotype(copiedGens);
        }
    }
}

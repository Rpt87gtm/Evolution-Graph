namespace Evolution_Graph.genetic
{
    internal class Mutation
    {
        double _minSpread;
        double _maxSpread;
        double _mutationChane;
        public Mutation(double minSpread, double maxSpread, double mutationChane)
        {
            _minSpread = minSpread;
            _maxSpread = maxSpread;
            _mutationChane = mutationChane;
        }

        public Individual Mutate(Genotype genotype, Random random)
        {
            double mutationValue = _minSpread + (_maxSpread - _minSpread) * random.NextDouble();
            Genotype newGenotype = genotype.Copy();
            newGenotype.Gens[random.Next(0, newGenotype.Gens.Length)] += mutationValue;
            return new Individual(newGenotype);
        }

        public bool CanMutate(Random random)
        {
            return (_mutationChane < random.NextDouble());
        }
    }
}

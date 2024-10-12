using Evolution_Graph.functions;
using Evolution_Graph.genetic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Evolution_Graph
{
    public partial class Form1 : Form
    {
        private List<IFunction<double>> _functions = new List<IFunction<double>>();
        private GeneticAlgorithm _algorithm;
        private int _countOfIterations = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitFunctions();
            AddFunctionsInComboBox(comboBox1);
            ChartSettings();

            ResetGraph();
        }

        private void ChartSettings()
        {
            chart1.Series[0].XValueType = ChartValueType.Double;
            chart1.Series[0].YValueType = ChartValueType.Double;

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.0";
            chart1.ChartAreas[0].AxisX.Interval = 1f;

            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
        }

        private void InitAlgorithm()
        {
            Mutation mutation = new Mutation(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox3.Text));
            double[] targetValues = CalculateTargetValues((IFunction<double>)comboBox1.SelectedItem, 100, 0.1);
            Population population = new Population(Convert.ToInt32(numericUpDown1.Value), Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox9.Text), targetValues);
            _algorithm = new GeneticAlgorithm(population, Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox8.Text), mutation, targetValues);
        }
        private double[] CalculateTargetValues(IFunction<double> function, int size, double step)
        {
            double[] targetValues = new double[size];
            for (int i = 0; i < size; i++)
            {
                targetValues[i] = function.Evaluate(0 + i * step);
            }
            return targetValues;
        }

        private void DrawTargetGraph(IFunction<double> function, Chart chart, double startX = 0, double step = 0.1f, int countOfSteps = 20)
        {
            double x = startX;
            for (int i = 0; i < countOfSteps; i++)
            {
                double y = function.Evaluate(x);
                if (!double.IsNaN(y) && !double.IsInfinity(y))
                {
                    chart.Series[0].Points.AddXY(x, y);
                }
                x += step;
            }
        }
        private void DrawPopulatoinGraph(double[] YValues, Chart chart, double startX = 0, double step = 0.1f, int countOfSteps = 20)
        {
            double x = startX;
            for (int i = 0; i < countOfSteps; i++)
            {
                chart.Series[1].Points.AddXY(x, YValues[i]);
                x += step;
            }
        }
        private void ClearTargerGraph(Chart chart)
        {
            chart.Series[0].Points.Clear();
        }
        private void ClearPopulationGraph(Chart chart)
        {
            chart.Series[1].Points.Clear();
        }

        private void InitFunctions()
        {
            _functions.Add(new Function("Y = sin(x)", (value) => Math.Sin(value)));
            _functions.Add(new Function("Y = cos(x)", (value) => Math.Cos(value)));
            _functions.Add(new Function("Y = x^2", (value) => Math.Pow(value, 2)));
            _functions.Add(new Function("Y = ln(x)", (value) => value > 0 ? Math.Log(value) : 0));
            _functions.Add(new Function("Y = 1 + sin(x)", (value) => 1 + Math.Sin(value)));
            _functions.Add(new Function("Y = sqrt(x)", (value) => Math.Sqrt(value)));
            _functions.Add(new Function("Y = sin(2x)", (value) => Math.Sin(2 * value)));
            _functions.Add(new Function("Y = cos(2x)", (value) => Math.Cos(2 * value)));
            _functions.Add(new Function("Y = 1 + sin(2x)", (value) => 1 + Math.Sin(2 * value)));
            _functions.Add(new Function("Y = sqrt(2x)", (value) => Math.Sqrt(2 * value)));
            _functions.Add(new Function("Y = sin(3x)", (value) => Math.Sin(3 * value)));
            _functions.Add(new Function("Y = cos(3x)", (value) => Math.Cos(3 * value)));
            _functions.Add(new Function("Y = 3x^2", (value) => 3 * Math.Pow(value, 2)));
            _functions.Add(new Function("Y = ln(3x)", (value) => value > 0 ? Math.Log(3 * value) : 0));
            _functions.Add(new Function("Y = 1 + sin(3x)", (value) => 1 + Math.Sin(3 * value)));
            _functions.Add(new Function("Y = sqrt(3x)", (value) => Math.Sqrt(3 * value)));
            _functions.Add(new Function("Y = sin(4x)", (value) => Math.Sin(4 * value)));
            _functions.Add(new Function("Y = cos(4x)", (value) => Math.Cos(4 * value)));
            _functions.Add(new Function("Y = 4x^2", (value) => 4 * Math.Pow(value, 2)));
            _functions.Add(new Function("Y = ln(4x)", (value) => value > 0 ? Math.Log(4 * value) : 0));
            _functions.Add(new Function("Y = 1 + sin(4x)", (value) => 1 + Math.Sin(4 * value)));
            _functions.Add(new Function("Y = sqrt(4x)", (value) => Math.Sqrt(4 * value)));

        }
        private void AddFunctionsInComboBox(ComboBox comboBox)
        {
            foreach (Function function in _functions)
            {
                comboBox.Items.Add(function);
            }
            comboBox.SelectedIndex = 0;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTargerGraph(chart1);
            DrawTargetGraph((IFunction<double>)comboBox1.SelectedItem, chart1, 0, 0.1f, 100);
            ResetGraph();
        }

        private void ReDrawPopulation()
        {
            _countOfIterations++;
            label10.Text = "Iterations: " + _countOfIterations.ToString();
            label11.Text = "Best Fitness: " + _algorithm.Population.TopFitness().ToString("0.000");
            ClearPopulationGraph(chart1);
            DrawPopulatoinGraph(_algorithm.Population.TopFitnessPoints(), chart1, 0, 0.1f, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _algorithm.DoEvolutionStep(10, 5);
            ReDrawPopulation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _algorithm.DoEvolutionUntilTarget(Convert.ToDouble(textBox2.Text), 10, 5, ReDrawPopulation);

        }

        private void ResetGraph()
        {
            InitAlgorithm();
            _countOfIterations = 0;
            ReDrawPopulation();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetGraph();
        }
    }
}

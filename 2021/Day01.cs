namespace AdventOfCode.TwentyTwentyOne
{
    internal class Day01
    {
        private readonly string data;
        private readonly string dataPath = @"Inputs\2021\Day01.txt";

        public Day01()
        {
            data = this.LoadData();
        }

        private string LoadData()
        {
            if (File.Exists(dataPath))
            {
                return File.ReadAllText(Path.Combine(dataPath));
            }

            return string.Empty;
        }

        private int PartOne()
        {
            var depths = this.data.Split("\n").Select(int.Parse).ToArray();

            return depths.Skip(1).Select((depth, increment) => depth > depths[increment]).Count(depth => depth);
        }

        private int PartTwo()
        {
            var depths = this.data.Split("\n").Select(int.Parse).ToArray();

            return depths.Skip(3).Select((depth, increment) => depth > depths[increment]).Count(depth => depth);
        }

        internal void Solve()
        {
            Console.WriteLine("*--------------------*");
            Console.WriteLine("| Day 1: Sonar Sweep |");
            Console.WriteLine("*--------------------*\n");

            Console.WriteLine("------ Part One ------");
            Console.WriteLine($"Answer: {this.PartOne()}\n");

            Console.WriteLine("------ Part Two ------");
            Console.WriteLine($"Answer: {this.PartTwo()}");

            Console.Read();
        }
    }
}

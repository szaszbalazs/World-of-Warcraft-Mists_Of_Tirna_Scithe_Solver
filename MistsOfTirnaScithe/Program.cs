using System;

namespace MistsOfTirnaScithe // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Input> list = new List<Input>();

            //circle, shape, Colored
            list.Add(new Input(false,"flower",true));
            list.Add(new Input(false,"flower",false));
            list.Add(new Input(true,"leaf",true));
            list.Add(new Input(true,"flower",false));

            Solver solver = new Solver();

            string megoldas = solver.Solve(list);

            Console.WriteLine(megoldas);
        }
    }
}

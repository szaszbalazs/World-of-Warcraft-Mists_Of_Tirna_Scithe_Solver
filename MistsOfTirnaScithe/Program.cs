using System;
using System.Speech.Recognition;
using System.Speech.Synthesis;


namespace MistsOfTirnaScithe 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            SpeechRecognitionEngine recognize = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            


            List<Input> list = new List<Input>();

            //circle, shape, Colored
            list.Add(new Input(false,"flower",true));
            list.Add(new Input(false,"flower",false));
            list.Add(new Input(true,"leaf",true));
            list.Add(new Input(true,"flower",false));

            Solver solver = new Solver();

            string megoldas = solver.Solve(list);

            Console.WriteLine(megoldas);
            synth.Speak(megoldas);

            //todo: RESET, NEXT, SOLVE
        }
    }
}

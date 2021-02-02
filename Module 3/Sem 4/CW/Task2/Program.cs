using System;

namespace Task2
{
    class PlayIsStartedEventArgs : EventArgs
    {
        public int SoundMaker { get; set; }
    }

    class BandMaster
    {
        public event EventHandler<PlayIsStartedEventArgs> ev;
        static Random rnd = new Random();
        public void StartPlay()
        {
            ev?.Invoke(this, new PlayIsStartedEventArgs() { SoundMaker = rnd.Next(2, 6) });
        }
    }

    public abstract class OrchestraPlayer
    {
        public string Name { get; set; }
        public abstract void PlayIsStartedEventHandler()
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

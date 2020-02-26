using System;
using MediaWorld.Domain.Models;

namespace MediaWorld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayAudio();
        }

        private static void PlayAudio()
        {
            //AudioPlayer ap = new AudioPlayer();
            //Console.WriteLine(ap);
           var ap = AudioPlayer.GetInstance();
           var ap2 = AudioPlayer.Instance;
           Console.WriteLine(ap);
           Console.WriteLine(ap2);
        }
    }
}

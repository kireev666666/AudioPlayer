using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Player
    {
        private const int _maxVolume = 300;
        private bool Locked;
        private bool playing;
        private int volume;
        public bool Playing 
        {
            get
            {
                return playing;
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            private set
            {
                if(value > _maxVolume)
                {
                    volume = _maxVolume;
                }
                else if(value < 0)
                {
                    volume = 0;
                }
                else
                {
                    volume = value;
                }
            }
        }

        public int Step
        {
            get
            {
                return volume;
            }
            private set
            {
                if (value > _maxVolume)
                {
                    volume = _maxVolume;
                }
                else if (value < 0)
                {
                    volume = 0;
                }
                else
                {
                    volume = value;
                }
            }
        }
                        
        public Song[] Songs;

        public void Play()
        {
            for (int i = 0; i < Songs.Length; i++)
            {
                Console.WriteLine(Songs[i].Title + " " + Songs[i].Artist.Name + " " + Songs[i].Duration);
                System.Threading.Thread.Sleep(2000);
            }
        }

        public void VolumeUp()
        {
            Volume += 5;
            Console.WriteLine("Volume is: " + Volume);
            Console.WriteLine("Звук был увеличен");
        }

        public void VolumeDown()
        {
            Volume -= 5;
            Console.WriteLine("Volume is: " + Volume);
            Console.WriteLine("Звук был уменшен");
        }
        public void VolumeChange1()
        {
            int step1 = Convert.ToInt32(Console.ReadLine());
            Step = Volume + step1;
            Console.WriteLine("Volume is: "  + Volume);
            Console.WriteLine("Звук был увеличен");

        }
        public void VolumeChange2()
        {
            int step2 = Convert.ToInt32(Console.ReadLine());
            Step = Volume - step2;
            Console.WriteLine("Volume is: " + Volume);
            Console.WriteLine("Звук был уменшен");
        }

        public void Lock()
        {
            Locked = true;
            Console.WriteLine("Player is " + Locked);
            Console.WriteLine("Плеер заблокирован");
        }
        public void Unlock()
        {
            Locked = false;
            Console.WriteLine("Player is " + Locked);
            Console.WriteLine("Плеер разблокирован");
        }

        public bool Stop()
        {
            if (Locked == false)
            {
                playing = false;
                Console.WriteLine("Player is " + Playing);
                Console.WriteLine("Плеер остановлен");
            }
            else if (Locked == true) Console.WriteLine("Доступ не возможен, плеер заблокирован");


            return Playing;
            
        }
        public bool Start()
        {
            if (Locked == false)
            {
                playing = true;
                Console.WriteLine("Player is " + Playing);
                Console.WriteLine("Плеер играет");
            }


            else if (Locked == true) Console.WriteLine("Доступ не возможен, плеер заблокирован");
            return Playing;
            
        }
        
    }                 
}

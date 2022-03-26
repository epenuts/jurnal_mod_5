using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace modul5_1302204060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo a = new SayaTubeVideo("Tutorial Design By Contract – [RIZKY EVENTA BAHTIAR]");
            a.PrintVideoDetails();
            a.IncreasePlayCount(2);
            a.PrintVideoDetails();

            SayaTubeUser b = new SayaTubeUser("he he he ha!");  
            b.GetTotalVideoplayCount();
            b.PrintAllvideoplayCount();
        }
    }

    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string a)
        {
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int angka)
        {
            playCount = playCount + angka;
        }

        public int GetPlaycount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("title: " + title);
            Console.WriteLine("id: " + id);
            Console.WriteLine("playCount:" + playCount);
        }


    }

    public class SayaTubeUser
    {
        int id;
        List<SayaTubeVideo> uploadedVideo;
        string Username;

        public SayaTubeUser(string profile)
        {
            this.Username = profile;
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            uploadedVideo = new List<SayaTubeVideo>();

        }

        public void GetTotalVideoplayCount()
        {
            int dataplayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideo)
            {
                dataplayCount = dataplayCount + video.GetPlaycount();
            }
        }

        public void addVideo(SayaTubeVideo data)
        {
            uploadedVideo.Add(data);
        }


        public void PrintAllvideoplayCount()
        {

            for (int i = 0; i < uploadedVideo.Count; i++)
            {
                Console.WriteLine("username:" + Username);
                Console.WriteLine("video:" + (i + 1) + ":" + uploadedVideo[i]);
            }

        }

    }
}
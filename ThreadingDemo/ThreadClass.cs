using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingDemo{    public class ThreadClass    {        public void ShowThreads()        {            var countdown = new CountdownEvent(4);            var list = new List<string>();            var twThread = new Thread(() =>            {                list.Add(DoTwitter());                countdown.Signal();            });            var fbThread = new Thread(() =>            {                list.Add(DoFacebook());                countdown.Signal();            });            var ytThread = new Thread(() =>            {                list.Add(DoYoutube());                countdown.Signal();            });            var instThread = new Thread(() =>            {                list.Add(DoInstagram());                countdown.Signal();            });            twThread.Start();            fbThread.Start();            ytThread.Start();            instThread.Start();            countdown.Wait();
            // Is waiting here

            foreach (var item in list)            {                Console.WriteLine(item);            }        }        static string DoTwitter()        {            Thread.Sleep(new Random().Next(2000, 4000));            Console.WriteLine("Twitter completed");            return "Twitter posted...";        }        static string DoFacebook()        {            Thread.Sleep(new Random().Next(2000, 4000));            Console.WriteLine("Fb completed");            return "Facebook posted...";        }        static string DoYoutube()        {            Thread.Sleep(new Random().Next(2000, 4000));            Console.WriteLine("YT completed");            return "Youtube posted...";        }        static string DoInstagram()        {            Thread.Sleep(new Random().Next(2000, 4000));            Console.WriteLine("Insta completed");            return "Insta posted...";        }    }}

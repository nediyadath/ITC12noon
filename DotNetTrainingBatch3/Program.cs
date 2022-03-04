using DotNetTrainingBatch3.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Threading;

namespace DotNetTrainingBatch3
{
    class Program
    {
       public void m1(string n, int x = 100)
        {

        }
       
        static void Main(string[] args)
        {


            var val = new
            {
                Id = 101,
                Name = "Rave"
            };
            Program p = new Program();
            p.m1(n:"",x:200);

            Console.WriteLine(val.Name);

            string path = @"c:\training\temp\test.txt";
            if (!File.Exists(path) && !Directory.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                    sw.WriteLine("Testing an input" + " | " + DateTime.Now);
                }
            }
            else
            {
                File.Delete(path);
                using (StreamWriter sw = File.AppendText(path))
                {
                    Console.WriteLine("Text Again Added" + " | " + DateTime.Now);
                }
            }

            using(StreamReader sr = File.OpenText(path))
            {
                string txt = "";
                while ((txt = sr.ReadLine()) != null)
                {
                    Console.WriteLine(txt);
                }
            }
            IBilling b = new Bill();

            b.M1();
            Console.ReadLine();
        }
    }

    public class Billing
    {
        public void Estimate() { }
        public void Bill() { }
        public void Gift() { }
        public void Anniversary() { }
    }
    //single responsibility
    //open/closed - open for extension but not for modification
    //Liskov Substitution - child class should be able to substitue a base class
    //Interface segregation principle
    //dependency inversion principle


    public interface IBilling
    {
        void M1();
    }
    public class Bill : IBilling
    {
        public Bill()
        {

        }
        public void M1()
        {
            throw new NotImplementedException();
        }
    }
}
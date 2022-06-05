using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Frozen
        {

            //Anna wants new earrings for Christmas

            string character;
            string wish;
            
            public Frozen(string _character, string _wish)
            {
                character = _character;
                wish = _wish;
            }

            
            public string Character
            {
                get { return character; }
            }

            public string Wish
            {
                get { return wish; }
            }

        }
        static void Main(string[] args)
        {
            List<Frozen> myFrozen = new List<Frozen>();
            string[] frozenFromFile = GetDataFromFile();

            foreach (string line in frozenFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Frozen newFrozen = new Frozen(tempArray[0], tempArray[1]);
                myFrozen.Add(newFrozen);
            }

            foreach (Frozen frozenFromList in myFrozen)
            {
                Console.WriteLine($"{frozenFromList.Character} wants {frozenFromList.Wish} for Christmas.");
            }

        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\Samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
                
              
    }
}

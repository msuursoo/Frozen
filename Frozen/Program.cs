using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    { 
        
        class SecretSanta
        {
            string name;
            string gift;
            public SecretSanta(string _name, string _gift)
            {
            name = _name;
            gift = _gift;

            }

            //getters for Gifts

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }


        }
        static void Main(string[] args)
        {
            List<SecretSanta> myGifts = new List<SecretSanta>();
            string[] giftsFromFile = GetDataFromFile();

            foreach (string line in giftsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newGift = new SecretSanta(tempArray[0], tempArray[1]);
                myGifts.Add(newGift);
            }

            foreach (SecretSanta giftsFromList in myGifts)
            {
                Console.WriteLine($"{giftsFromList.Name} wants {giftsFromList.Gift} for Christmas.");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Mart\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
    
}

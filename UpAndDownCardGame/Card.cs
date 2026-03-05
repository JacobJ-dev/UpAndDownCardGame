using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpAndDownCard
{
    public class Card
    {
        public string Suit {  get; }
        public int Value {  get; }
        public string Name { get; }

        public string imgFileName { get; }

        public Card(string suit, string name, int number, string imgFileName)
        {
            Suit = suit;
            Value = number;
            Name = name;
            this.imgFileName = imgFileName;
        }
    }
}

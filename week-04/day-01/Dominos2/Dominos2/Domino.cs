using System;

namespace Domino
{
    public class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo (object obj)
        {
            Domino otherDomino = obj as Domino;
            if (otherDomino != null)
            {
                return this.GetValues()[0].CompareTo(otherDomino.GetValues()[1]);
            }
            else
            {
                throw new ArgumentException("WTF");
            }
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}

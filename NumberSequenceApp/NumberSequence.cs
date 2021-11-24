namespace NumberSequenceApp
{
    public class NumberSequence
    {
        private int lengthArray ;       // n
        private double squareNumber;    // m
        internal int LengthArray
        {
            get
            {
                return lengthArray;
            }
        }
        internal double SquareNumber
        {
            get
            {
                return squareNumber;
            }
        }
        public NumberSequence(int lengthArray, double squareNumber)
        {
            this.lengthArray = lengthArray;
            this.squareNumber = squareNumber;
        }
    }
}

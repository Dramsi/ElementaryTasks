namespace NumberSequenceApp
{
    public class NumberSequence
    {
        private int lengthArray;
        private double squareNumber;
        public int LengthArray
        {
            get
            {
                return lengthArray;
            }
        }
        public double SquareNumber
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

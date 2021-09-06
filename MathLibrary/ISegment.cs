namespace MathLibrary
{
    interface ISegment
    {
        public double GetLength(Segment segment);

        public double GetLength(Vector begin, Vector end);

        public double GetLength();

        public bool Contains(Vector vetor);

        public double GetAreaCircle();
    }
}

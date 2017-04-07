namespace BowlingGameTests
{
    internal class Frame
    {
        public int? Roll1 { get; set; }
        public int Roll2 { get; internal set; }

        public bool isSpare { get; set; }
        public bool IsStrike { get; internal set; }
        public int Score { get; set; }

        
    }
}
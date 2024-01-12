namespace Chess.Forms
{
    public class Position
    {
        private int y;
        private int x;

        public Position(int y, int x)
        {
            this.y = y;
            this.x = x;
        }


        public int X { get => x; set => x = value; }

        public int Y { get => y; set => y = value; }
    }
}
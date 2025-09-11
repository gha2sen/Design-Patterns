namespace Canvas.Originator.CanvasShapes
{
    public class Shape(Guid id,(int, int) position, string color)
    {
        public Guid Id { get; set; } = id;
        public (int X, int Y) Position { get; set; } = position;
        public string Color { get; set; } = color;

        public Shape DeepCopy()
        {
            return new Shape(id,Position,Color);
        }

        public override string ToString()
        {
            return $"A {Color} colored shape with X:{Position.X} and Y:{Position.Y}.";
        }
    }
}

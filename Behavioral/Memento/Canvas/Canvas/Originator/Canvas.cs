namespace Canvas.Originator
{
    public class CanvasSpace
    {
        private Dictionary<Guid,Shape> _shapes = [];

        public CanvasMemento AddShape(Shape shape) 
        { 
            _shapes.Add(shape.Id,shape.DeepCopy()); 

            return Save();
        }

        public CanvasMemento ChangeColor(Guid id, string newColor)
        {
            if(!_shapes.ContainsKey(id)) throw new ArgumentException($"shape with {id} doesnt exist");

            _shapes[id].Color = newColor;

            return Save();
        }

        public CanvasMemento MoveShape(Guid id, int x, int y)
        {
            if (!_shapes.ContainsKey(id)) throw new ArgumentException($"shape with {id} doesnt exist");

            _shapes[id].Position = (_shapes[id].Position.X + x ,_shapes[id].Position.Y + y);

            return Save();
        }

        private CanvasMemento Save()
        {
            return new CanvasMemento(_shapes
                                    .ToDictionary(
                                    kvp => kvp.Key, 
                                    kvp => kvp.Value.DeepCopy()
                                    ));
        }

        public void Restore(CanvasMemento original)
        {
            _shapes = original.Shapes.ToDictionary(
                                    kvp => kvp.Key,
                                    kvp => kvp.Value.DeepCopy()
                                    );
        }

        public string Draw()
        {
            var values = _shapes.Values.ToList();

            return string.Join( ",", values );
        }
    }
}

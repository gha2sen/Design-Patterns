namespace Canvas.Caretaker
{
    public class CanvasHistory
    {
        private readonly Stack<CanvasMemento> _undoStack = new();
        private readonly Stack<CanvasMemento> _redoStack = new();

        public void Save(CanvasMemento memento)
        {
            _undoStack.Push(memento);
            _redoStack.Clear();
        }

        public CanvasMemento Undo()
        {
            if (_undoStack.Count > 0)
            {
                var memento = _undoStack.Pop();
                _redoStack.Push(memento);
                return memento;
            }
            throw new InvalidOperationException("No states to undo.");
        }

        public CanvasMemento Redo()
        {
            if (_redoStack.Count > 0)
            {
                var memento = _redoStack.Pop();
                _undoStack.Push(memento);
                return memento;
            }
            throw new InvalidOperationException("No states to redo.");
        }
    }

}


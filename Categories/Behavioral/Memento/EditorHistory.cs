
    public class EditorHistory
    {
        public readonly Stack<EditorMemento> _history = new();

        public void Push(EditorMemento memento) => _history.Push(memento);

        public EditorMemento? Pop() => _history.Count > 0 ? _history.Pop() : null;
    }
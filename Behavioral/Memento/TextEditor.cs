
    public class TextEditor
    {
        public string Content { get; private set; } = "";

        public void Type(string words)
        {
            Content += words;
        }

        public EditorMemento Save()
        {
            return new EditorMemento(Content);
        }

        public void Restore(EditorMemento editorMemento)
        {
            Content = editorMemento.Content;
        }
    }

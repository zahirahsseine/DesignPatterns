
var editor = new TextEditor();
var history = new EditorHistory();

editor.Type("Hello");
history.Push(editor.Save());

editor.Type(", world!");
history.Push(editor.Save());

editor.Type(" More typing...");
Console.WriteLine(editor.Content);

var m1 = history.Pop();
editor.Restore(m1);
Console.WriteLine(editor.Content);

var m2 = history.Pop();
editor.Restore(m2);
Console.WriteLine(editor.Content);

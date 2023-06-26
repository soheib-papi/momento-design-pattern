namespace momento.momento;

public class History
{
    private Stack<EditorState> _states = new();

    public void Push(EditorState state) => _states.Push(state);

    public EditorState Pop() => _states.Pop();
}

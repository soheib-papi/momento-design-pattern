
namespace momento.momento
{
    public class Editor
    {
        private string? _content;

        public void SetContent(string value) => _content = value;
        public string GetContent => _content ?? "";

        public EditorState CreateState() => new(_content ?? "");
        
        public void RestoreState(EditorState state) => _content = state.GetContent;
    }
}
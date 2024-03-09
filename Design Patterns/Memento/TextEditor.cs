using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Memento
{
    public class TextEditor
    {
        public string Content { get; set; }

        public TextEditor()
        {
            Content = "";
        }

        public TextEditorState Save()
        {
            return new TextEditorState(Content);
        }

        public void Restore(TextEditorState textEditorState)
        {
            Content = textEditorState.Content;
        }

    }
}

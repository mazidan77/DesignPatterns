using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Memento
{
    public class TextEditorState
    {
        public string Content { get; set; }

        public TextEditorState(string Content)
        {
            this.Content = Content;
        }
    }
}

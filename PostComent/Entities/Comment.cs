using System;
using System.Collections.Generic;
using System.Text;

namespace PostComment.Entities
{
    class Comment
    {
        public string text { get; set; }

        public Comment(string text)
        {
            this.text = text; 
        }
        public override string ToString()
        {
            return text;
        }
    }
}

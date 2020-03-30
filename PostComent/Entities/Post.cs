using System;
using System.Collections.Generic;
using System.Text;

namespace PostComment.Entities
{
    class Post
    {
        public DateTime moment { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int likes { get; set; }
        public List<Comment> Comments { get; set; }  = new List<Comment>();

        public Post()
        {
        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            this.moment = moment;
            this.title = title;
            this.content = content;
            this.likes = likes;
        }
      
        public void addComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void removeComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(title);
            sb.Append(likes);
            sb.Append(" Likes - ");
            sb.AppendLine(moment.ToString("dd/MM/yyyy HH:mm:SS"));
            sb.AppendLine(content);
            sb.AppendLine("");
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.text);
            }
            return sb.ToString();     
        }



    }
}

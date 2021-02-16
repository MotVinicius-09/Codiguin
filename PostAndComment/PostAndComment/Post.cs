using System;
using System.Collections.Generic;
using System.Text;

namespace PostAndComment
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Contente { get; set; }
        public int Like { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string contente, int like)
        {
            Moment = moment;
            Title = title;
            Contente = contente;
            Like = like;
        }

        public void AddComment (Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
                
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Like);
            sb.Append(" Likes -");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Contente);
            sb.AppendLine("Comments: ");

            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
    public class Comment
    {
        public string Text { get; set; }

        public Comment(string text)
        {
            Text = text;
        }
    }
}

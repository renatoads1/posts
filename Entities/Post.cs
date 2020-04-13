using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Posts.Entities
{
    class Post
    {
        public DateTime Data { get; set; }
        public string Title { get; set; }
        public string comments { get; set; }
        public int likes { get; set; }
        /*como tem muitos comentarios para cada post
        instanciaremos uma lista de comentarios    */

        public List<Comment> comentarios { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime data, string title, string comments, int likes)
        {
            Data = data;
            Title = title;
            this.comments = comments;
            this.likes = likes;
        }
        public void AddComment(Comment com) {
            comentarios.Add(com);        
        }
        public void RemoveComment(Comment com)
        {
            comentarios.Remove(com);
        }
        public override string ToString()
        {
            //usando o string Builder da clase system.text
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Data.ToString());
            sb.AppendLine(Title);
            foreach (Comment com in comentarios) {
                sb.AppendLine(com.Text);
            }
            return sb.ToString();
        }
    }
}

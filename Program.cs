using System;
using Posts.Entities;


namespace Posts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva o comentario 1");
            Comment c1 = new Comment(Console.ReadLine().ToString());
            Console.WriteLine("escreva o comentario 2");
            Comment c2 = new Comment(Console.ReadLine().ToString());
            Post post1 = new Post(DateTime.Parse("11/06/1982"),"titulo1","comentario1",12);
            post1.AddComment(c1);
            post1.AddComment(c2);

            Console.WriteLine(post1);
        }
    }
}

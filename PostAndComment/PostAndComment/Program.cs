using System;

namespace PostAndComment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime moment1 = DateTime.Parse("06/21/2018 13:03:44");
            string title1 = "Traveling to New Zealand";
            string contente1 = "I'm going to visit this wonderful country!";
            int like1 = int.Parse("12");
            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awesome!");
            Post post1 = new Post(moment1, title1, contente1, like1);
            post1.AddComment(comment1);
            post1.AddComment(comment2);

            DateTime moment2 = DateTime.Parse("07/28/2018 23:14:19");
            string title2 = "Good Night Guys";
            string contente2 = "See you tomorrow";
            int like2 = int.Parse("12");
            Comment comment3 = new Comment("Good night");
            Comment comment4 = new Comment("May the Force be with you");
            Post post2 = new Post(moment2, title2, contente2, like2);
            post2.AddComment(comment3);
            post2.AddComment(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}

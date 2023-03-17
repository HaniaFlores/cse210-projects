using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Program 1: Youtube Videos");
        /* VIDEO 1 */
        /* COMMENTS */
        Comment c1 = new Comment();
        c1._name = "user1";
        c1._text = "Comment1";

        Comment c2 = new Comment();
        c2._name = "user2";
        c2._text = "Comment2";

        Comment c3 = new Comment();
        c3._name = "user3";
        c3._text = "Comment3";

        /* VIDEO INFORMATION */
        Video v1 = new Video();
        v1._title = "Video1";
        v1._author = "Author1";
        v1._length = 90;
        v1._comments.Add(c1);
        v1._comments.Add(c2);
        v1._comments.Add(c3);
        v1.Display();


        /* VIDEO 2 */
        /* COMMENTS */
        Comment c4 = new Comment();
        c4._name = "user4";
        c4._text = "Comment4";

        Comment c5 = new Comment();
        c5._name = "user5";
        c5._text = "Comment5";

        Comment c6 = new Comment();
        c6._name = "user6";
        c6._text = "Comment6";

        /* VIDEO INFORMATION */
        Video v2 = new Video();
        v2._title = "Video2";
        v2._author = "Author2";
        v2._length = 45;
        v2._comments.Add(c4);
        v2._comments.Add(c5);
        v2._comments.Add(c6);
        v2.Display();


        /* VIDEO 3 */
        /* COMMENTS */
        Comment c7 = new Comment();
        c7._name = "user7";
        c7._text = "Comment7";

        Comment c8 = new Comment();
        c8._name = "user8";
        c8._text = "Comment8";

        Comment c9 = new Comment();
        c9._name = "user9";
        c9._text = "Comment9";

        /* VIDEO INFORMATION */
        Video v3 = new Video();
        v3._title = "Video3";
        v3._author = "Author3";
        v3._length = 310;
        v3._comments.Add(c7);
        v3._comments.Add(c8);
        v3._comments.Add(c9);
        v3.Display();
    }
}
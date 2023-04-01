using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Program 1: Youtube Videos\n");
        List<Video> _videos = new List<Video>();

        /* VIDEO 1 */
        /* VIDEO INFORMATION */
        Video v1 = new Video();
        v1._title = "Day in the Life of a Japanese Game Designer";
        v1._author = "Paolo fromTOKYO";
        v1._length = 971;

        /* COMMENTS */
        Comment c1 = new Comment();
        c1._name = "JBG";
        c1._text = "These employees actually have all the tools and support they need to do their job. What a crazy concept!";

        Comment c2 = new Comment();
        c2._name = "Eagle Nebula";
        c2._text = "They should present this kind of content at schools and univs to help students choose their career path of choice, thanks for this Paolo.";

        Comment c3 = new Comment();
        c3._name = "Liquid";
        c3._text = "Not sure if you'll ever see this Paolo, but I definitely would not hate it if these videos were like twice as long. This is such good stuff.";

        /* ADDING TO THE LISTS */
        v1._comments.Add(c1);
        v1._comments.Add(c2);
        v1._comments.Add(c3);
        _videos.Add(v1);

        /* VIDEO 2 */
        /* VIDEO INFORMATION */
        Video v2 = new Video();
        v2._title = "Broken Bread Cutter Restoration";
        v2._author = "Cool Again Restoration";
        v2._length = 1009;

        /* COMMENTS */
        Comment c4 = new Comment();
        c4._name = "Eirir Eve";
        c4._text = "A guillotine bread cutter. That's the most French thing I've ever heard of.";

        Comment c5 = new Comment();
        c5._name = "Scott Tchviski";
        c5._text = "Your range of techniques, attention to detail and artistic flair are immense. Fantastic job and what a beautiful piece.";

        Comment c6 = new Comment();
        c6._name = "Rey C26";
        c6._text = "You're like a scientist/chemist of restoration. You even have that washing machine for metals. I'm subscribing. This is so satisfying.";

        Comment c7 = new Comment();
        c7._name = "Cadavu2";
        c7._text = "This was next level. Makes you realise that for a simple screw or nail, what effort and machinery has to be made. Today we really are disconnected from that world. These sort of videos makes me appreciate the times we live in. We are so effing lucky.";

        /* ADDING TO THE LISTS */
        v2._comments.Add(c4);
        v2._comments.Add(c5);
        v2._comments.Add(c6);
        v2._comments.Add(c7);
        _videos.Add(v2);


        /* VIDEO 3 */
        /* VIDEO INFORMATION */
        Video v3 = new Video();
        v3._title = "I Cleaned The World’s Dirtiest Beach #TeamSeas";
        v3._author = "MrBeast";
        v3._length = 294;

        /* COMMENTS */
        Comment c8 = new Comment();
        c8._name = "bella vinson";
        c8._text = "jimmy you do ALOT  of great work but i love seeing this. thank you for doing this for the community";

        Comment c9 = new Comment();
        c9._name = "Diep Tran";
        c9._text = "really thank you for what you do for this world :3";

        Comment c10 = new Comment();
        c10._name = "I Talk";
        c10._text = "Appreciate using your brand for good. So many people don't understand the power the internet can be for good, and we have to thank you for that.";

        Comment c11 = new Comment();
        c11._name = "Emilyy";
        c11._text = "I honestly don’t know why he doesn’t get more recognition he’s done so many amazing things for people and the planet ❤";

        /* ADDING TO THE LISTS */
        v3._comments.Add(c8);
        v3._comments.Add(c9);
        v3._comments.Add(c10);
        v3._comments.Add(c11);
        _videos.Add(v3);


        /* ITERATING THROUGH THE LIST OF VIDEOS */
        foreach(Video i in _videos)
        {
            i.Display();
        }
    }
}
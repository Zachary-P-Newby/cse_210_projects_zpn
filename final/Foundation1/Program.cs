using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video apology = new Video("I am sorry.", "Spider-Man", 647);
        
        Comment babyPowder = new Comment("Dude", "I heard it was made of real babies tho fr");

        apology.AddComment(babyPowder);

        apology.AddComment(new Comment("Person1", "first"));

        videoList.Add(apology);

        Video crash1Music = new Video("Crash Bandicoot 1 OST", "OSTLibrary", 4144);

        crash1Music.AddComment(new Comment("zpnewby", "This is fire."));
        crash1Music.AddComment(new Comment("F1NN", "I like the hog riding mustic"));
        crash1Music.AddComment(new Comment("N. Cortex", "I commissioned most of this you know, you're welcome."));

        videoList.Add(crash1Music);

        Video sonicTrailer = new Video("Sonic Illusions Announcement Trailer", "Sonic Team", 187);

        videoList.Add(sonicTrailer);

        sonicTrailer.AddComment(new Comment("zpnewby", "YES!"));
        sonicTrailer.AddComment(new Comment("don'tRegisterYourOwnNameCubot", "Is that hypo sonic??/?"));
        sonicTrailer.AddComment(new Comment("carl5692", "ADVENTURE IS BACK?"));
        sonicTrailer.AddComment(new Comment("_lila29", "I need this yesterday."));

        videoList.ForEach(Video =>{
            Console.WriteLine();
            Video.PrintInfo();
            Video.PrintComments();
        });
    }
}
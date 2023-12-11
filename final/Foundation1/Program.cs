using System;

class Program
{

    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        videos.Add(new Video("Title", "Author", 1500, new List<Comment>
        {
            new Comment("Alice123", "This is incredible! I love the attention to detail"),
            new Comment("TechEnthusiast47", "Well done! I never thought about it from this perspective before."),
            new Comment("CreativeMind22", "Great work! The visuals are stunning, and the content is spot-on"),
            new Comment("CuriousExplorer78", "Impressive! Your explanation makes it so much easier to understand")
        }));

        videos.Add(new Video("Bobs Burgers", "John Doe", 10, new List<Comment>
        {
            new Comment("SocialMediaGuru", "Fantastic job! I can't wait to share this with my friends."),
            new Comment("GratefulLearner", "This is exactly what I needed. Thank you for the clear explanation!"),
            new Comment("LaughingReader", "Wow, the humor in your writing made my day. More please!"),
            new Comment("InsightfulMind", "Incredible insights! Your expertise shines through in every paragraph")
        }));

        videos.Add(new Video("Minecraft Lets Play - Episode 321: Lets Build a Factory", "Ethos", 300, new List<Comment>
        {
            new Comment("LostInResearch", "I've been searching for this information everywhere. You're a lifesaver!"),
            new Comment("BookwormExpress", "Your writing style is so engaging. I couldn't stop reading until the end!"),
            new Comment("HonestOpinionsOnly", "I appreciate your honesty and transparency. Refreshing to see in content"),
            new Comment("ForwardThinker99", "Mind-blown! Your innovative approach is truly inspiring.")
        }));

        foreach(var video in videos){
            video.DisplayInfo();
        }



    }

}
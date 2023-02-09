using System.Media;
Console.WriteLine("Hello, welcome to the Music player");
for (var i = 0; i < 20; ++i)
{
    Console.WriteLine("which type of music would you like to listen to?");
    Console.WriteLine("pop, rock, jazz, exit");
    PlayMusic();
}

static void PlayMusic()
{
    SoundPlayer player = new SoundPlayer();
    var read = Console.ReadLine().ToLower();
    var location= System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
    switch (read)
    {
        case "pop":
                Console.WriteLine("OK you'd like to listen to pop, playing pop");
                Console.WriteLine("If you would like to stop playing this song, write stop");
                player.SoundLocation = location.Substring(6) + "/coming_home_30.wav";
                player.Stop();
                player.Play();
            break;
        case "rock":
                Console.WriteLine("OK you'd like to listen to rock, playing rock");
                Console.WriteLine("If you would like to stop playing this song, write stop");
                player.SoundLocation = location.Substring(6) + "/redsky_30.wav";
                player.Stop();
                player.Play();
            break;
        case "jazz":
                Console.WriteLine("OK you'd like to listen to jazz music, playing jazz music");
                Console.WriteLine("If you would like to stop playing this song, write stop");
                player.SoundLocation = location.Substring(6) + "/funky_dan_10.wav";
                player.Stop(); 
                player.Play();        
            break;
        case "stop":
            player.Stop();
            Console.WriteLine("stopped playing current song");
            Console.WriteLine("Type in the genre you would like to play, otherwise type exit to quit the application");
            Console.WriteLine("Pop, Rock, jazz, exit");
            break;
        case "exit":
            Environment.Exit(0);
            break;

    }
}
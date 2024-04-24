namespace Fasada4.classes;

class HomeTheaterFacade
{
    public Projector Projector;
    public SoundSystem SoundSystem;
    public MediaPlayer MediaPlayer;

    public HomeTheaterFacade(MediaPlayer mediaPlayer)
    {
        Projector = new Projector();
        SoundSystem = new SoundSystem();
        MediaPlayer = mediaPlayer;
    }

    public void watchMovie()
    {
        Projector.on();
        SoundSystem.on();
        MediaPlayer.play();
    }

    public void endMovie()
    {
        Projector.off();
        SoundSystem.off();
        MediaPlayer.stop();
    }
}

class Projector
{
    public void on()
    {
        System.Console.WriteLine("Projektor został włączony");
    }
    public void off()
    {
        System.Console.WriteLine("Projektor został wyłączony");
    }
}

class SoundSystem
{
    public void on()
    {
        System.Console.WriteLine("Dźwięk został włączony");
    }
    public void off()
    {
        System.Console.WriteLine("Dźwięk został wyłączony");
    }
}

class MediaPlayer
{
    public void play()
    {
        System.Console.WriteLine("Film został włączony");
    }
    public void stop()
    {
        System.Console.WriteLine("Film został wyłączony");
    }
}

class Client
{

}
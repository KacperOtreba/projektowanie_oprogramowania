using Fasada4.classes;
namespace Fasada4;

class Program
{
    static void Main(string[] args)
    {
        MediaPlayer md = new MediaPlayer();
        HomeTheaterFacade hTF = new HomeTheaterFacade(md);
        hTF.watchMovie();
    }
}

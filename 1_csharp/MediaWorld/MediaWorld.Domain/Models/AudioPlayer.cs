namespace MediaWorld.Domain.Models
{
  // public static class AudioPlayer
  // {
  //   public static void Play()
  //   {
  //     Console.WriteLine("blah");
  //   }
    
  // }
  public class AudioPlayer
  {

    private static AudioPlayer _ap = new AudioPlayer();

    private AudioPlayer(){}

    public static AudioPlayer Instance
    {
      get
      {
        return _ap;
      }
    }
    public static AudioPlayer GetInstance()
    {
      return _ap;
    }


  }
}
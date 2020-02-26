namespace MediaWorld.Domain.Models
{
  public class VideoPlayer{


    private static VideoPlayer _vp = new VideoPlayer();

    public VideoPlayer getInstance()
    {
      return _vp;
    }
    private VideoPlayer(){}
    
  }
}
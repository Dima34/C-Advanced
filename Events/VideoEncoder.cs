using System.ComponentModel;

namespace EncodingSpace
{
    internal class Video
    {
        public string Name { get; set; }
    }

    public delegate void VideoEncodedHandler(object source, VideoEventArgs args);
    
    class VideoEncoder
    {
        // public event VideoEncodedHandler VideoEncodedEvent;
        // public event Action<object, VideoEventArgs> VideoEncodedEvent;
        public event EventHandler<VideoEventArgs> VideoEncodedEvent; 

        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding {video.Name}...");
            Thread.Sleep(3000);
        
            OnVideoEncoded(video.Name);
        }

        protected virtual void OnVideoEncoded(string videoName)
        {
            if (VideoEncodedEvent != null)
            {
                VideoEventArgs videoEventArgs = new VideoEventArgs() {Name = videoName};
                VideoEncodedEvent(this, videoEventArgs);
            }
        } 
    }

    public class VideoEventArgs : EventArgs
    {
        public string Name { get; set; }
    }
}


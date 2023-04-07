using EncodingSpace;

VideoEncoder ve = new VideoEncoder();
ve.VideoEncodedEvent += OnVideoEncoded;
ve.Encode(new Video(){Name = "video1"});

void OnVideoEncoded(object source, VideoEventArgs videoEventArgs)
{
    Console.WriteLine($"{videoEventArgs.Name} encoded!");
}

Console.ReadLine();

using EncodingSpace;

VideoEncoder ve = new VideoEncoder();
ve.VideoEncodedEvent += OnVideoEncoded;
ve.Encode(new Video(){Name = "video1"});

VideoEncoder ve1 = new VideoEncoder();
ve1.VideoEncodedEvent += OnVideoEncoded;
ve1.Encode(new Video(){Name = "video2"});

void OnVideoEncoded(object source, VideoEventArgs videoEventArgs)
{
    Console.WriteLine($"{videoEventArgs.Name} encoded!");
}

Console.ReadLine();

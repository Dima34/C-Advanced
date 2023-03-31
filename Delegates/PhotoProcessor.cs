class PhotoProcessor
{
    public void Process(string path, Action<Photo> photoFilterHandler)
    {
        Photo photo = Photo.Load(path);
        photoFilterHandler(photo);
        photo.Save();
    }
}
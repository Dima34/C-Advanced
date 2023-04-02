using Delegates;

Photo dogPhoto = new Photo();
PhotoFilters filters = new PhotoFilters();

Action<Photo> PhotoFilterAnalogue = filters.ApplyBrightness;
PhotoFilterAnalogue += filters.ApplyBrightness;
PhotoFilterAnalogue += filters.ApplyContrast;
PhotoFilterAnalogue += filters.ApplyResize;

PhotoFilterHandler filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyContrast;
filterHandler += filters.ApplyResize;
filterHandler += filters.ApplyContrast;
filterHandler += RemoveRedEye;


static void RemoveRedEye(Photo photo)
{
    Console.WriteLine("Apply red eye removing");
}

PhotoProcessor processor = new PhotoProcessor();

processor.Process("...", PhotoFilterAnalogue);

Console.ReadLine();
ReturnNumDelegate fd = new ReturnNumDelegate();
ReturnStringDelegate returnStringDelegate = new ReturnStringDelegate();

delegate void PhotoFilterHandler(Photo photo);
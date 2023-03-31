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

FuncDelegate fd = new FuncDelegate();

static void RemoveRedEye(Photo photo)
{
    Console.WriteLine("Apply red eye removing");
}

PhotoProcessor processor = new PhotoProcessor();

processor.Process("...", PhotoFilterAnalogue);

Console.ReadLine();

delegate void PhotoFilterHandler(Photo photo);
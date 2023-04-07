using Delegates;

PhotoProcessor processor = new PhotoProcessor();


Photo dogPhoto = new Photo();
PhotoFilters filters = new PhotoFilters();

Action<Photo> PhotoFilterAnalogue = filters.ApplyBrightness;
PhotoFilterAnalogue += filters.ApplyBrightness;
PhotoFilterAnalogue += filters.ApplyContrast;
PhotoFilterAnalogue += filters.ApplyResize;
PhotoFilterAnalogue += RemoveRedEye;

processor.Process("...", PhotoFilterAnalogue);

static void RemoveRedEye(Photo photo)
{
    Console.WriteLine("Apply red eye removing");
}

Console.ReadLine();

ReturnNumDelegate fd = new ReturnNumDelegate();
ReturnStringDelegate returnStringDelegate = new ReturnStringDelegate();
CalculatorDelegates calculatorDelegates = new CalculatorDelegates();

delegate void PhotoFilterHandler(Photo photo);
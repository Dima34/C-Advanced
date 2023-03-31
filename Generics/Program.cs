

T Max<T>(T a, T b) where T : IComparable
{ 
    return a.CompareTo(b) > 0 ? a : b; 
}

T CreateInstance<T>() where T : new()
{ 
    return new T();
}

void MakeTransportWroom<T>(T transport) where T : Car
{
    transport.MakeWroom();
}

MakeTransportWroom<Tractor>(new Tractor());
MakeTransportWroom<Bus>(new Bus());
CreateInstance<Tractor>(); 

class Tractor : Car { }

class Bus : Car { }

class Car
{
    public Car()
    {
        
    }
    
    public void MakeWroom()
    {
        Console.WriteLine("Wroom!");
    }
}
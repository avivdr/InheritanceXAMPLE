using System;

namespace InheritanceXAMPLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Mammals m=new Mammals(200, "Mammel",150,"Kuku");
            Mammals m1 = new Mammals(400);
           Otter o = new Otter(50, 100, "Otter",25, "Charlie");
            
           Console.WriteLine(o);

        }
    }
}

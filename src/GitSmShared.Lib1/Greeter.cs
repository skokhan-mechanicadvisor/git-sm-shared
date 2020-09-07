using System;

namespace GitSmShared.Lib1
{
    public class Greeter
    {
        public void Do()
        {
            Console.WriteLine($"{DateTime.Now}::Feature1::Hello From GitSmShared.Lib1 + Main");
        }
    }
}
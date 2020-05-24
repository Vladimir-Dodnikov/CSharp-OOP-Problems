using System;
using VehicleExtension.Core;

namespace VehicleExtension
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();

            engine.Run();
        }
    }
}

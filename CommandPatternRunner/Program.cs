using System;
using  CommandPattern.Commands;
using CommandPattern.Invokers;
using CommandPattern.Receivers;

namespace CommandPatternRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            // remote -> invoker
            // light -> receiver
            // LightOn -> command
            
            // Example: pre-instanced commands
            Remote r = new Remote();
            Light light = new Light();
            r.SetCommand('A', new LightOn(light));
            r.SetCommand('L', new LightOff(light));
            r.Press('A');
            Console.WriteLine(light.State);
            r.Press('L');
            Console.WriteLine(light.State);

            // Example: pass value to command
            DimmingLight dimLight = new DimmingLight();
            RemoteWithSlider rw = new RemoteWithSlider();
            rw.SetCommand('A', new DimLight(dimLight));
            rw.Press('A', 6f);
            Console.WriteLine(dimLight);

            // Ecample: create new instance per invocation
            OnDemandRemote onDemandRemote = new OnDemandRemote();
            onDemandRemote.Press('A', new DimLight(dimLight, 10));
            Console.WriteLine(dimLight);
            onDemandRemote.Press('A', new DimLight(dimLight, 0));
            Console.WriteLine(dimLight);
            
            Console.ReadLine();
        }
    }
}

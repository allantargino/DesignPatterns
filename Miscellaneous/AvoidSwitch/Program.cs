using AvoidSwitch.Interfaces;
using AvoidSwitch.Models;
using System;

namespace AvoidSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            IRulesFactory rulesFactory = new CommonRulesFactory();
            var rules = rulesFactory.GetRules(SayWillRepair, SayWontRepair);

            rules[DeviceStatus.WorkingFine().CircuitryFailed().CircuitryReplaced()].Invoke(ByeMessage);
            Console.ReadLine();
        }

        private static void SayWillRepair(Action callback)
        {
            Console.WriteLine("I will repair!");
            callback.Invoke();
        }

        private static void SayWontRepair(Action callback)
        {
            Console.WriteLine("I won't repair!");
            callback.Invoke();
        }

        private static void ByeMessage()
        {
            Console.WriteLine("Bye!");
        }
    }
}

using AvoidSwitch.Models;
using System;
using System.Collections.Generic;

namespace AvoidSwitch.Interfaces
{
    interface IRulesFactory
    {
        IReadOnlyDictionary<DeviceStatus, Action<Action>> GetRules(Action<Action> willRepair, Action<Action> wontRepair);
    }
}
using AvoidSwitch.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvoidSwitch.Models
{
    class CommonRulesFactory : IRulesFactory
    {
        public IReadOnlyDictionary<DeviceStatus, Action<Action>> GetRules(Action<Action> willRepair, Action<Action> wontRepair)
        {
            return new Dictionary<DeviceStatus, Action<Action>>()
            {
                [DeviceStatus.WorkingFine()]
                = { },
                [DeviceStatus.WorkingFine().CircuitryFailed()]
                = willRepair,
                [DeviceStatus.WorkingFine().CircuitryFailed().CircuitryReplaced()]
                = wontRepair,
                [DeviceStatus.WorkingFine().NotOperational()]
                = willRepair,
                [DeviceStatus.WorkingFine().WithVisibleDamage()]
                = willRepair
            };
        }
    }
}

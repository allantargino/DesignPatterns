using System;
using System.Collections.Generic;
using System.Text;

namespace AvoidSwitch.Models
{
    public class DeviceStatus : IEquatable<DeviceStatus>
    {
        [Flags]
        private enum WorkingStatusRepresentation
        {
            WorkingFine = 0,
            NotOperational = 1,
            VisibleDamage = 2,
            CircuitryDamage = 4
        }

        private WorkingStatusRepresentation Representation { get;}

        private DeviceStatus(WorkingStatusRepresentation status)
        {
            Representation = status;
        }

        public static DeviceStatus WorkingFine()
        {
            return new DeviceStatus(WorkingStatusRepresentation.WorkingFine);
        }

        public DeviceStatus NotOperational()
        {
            return new DeviceStatus(this.Representation | WorkingStatusRepresentation.NotOperational);
        }

        public DeviceStatus WithVisibleDamage()
        {
            return new DeviceStatus(this.Representation | WorkingStatusRepresentation.VisibleDamage);
        }

        public DeviceStatus Repaired()
        {
            return new DeviceStatus(this.Representation | ~WorkingStatusRepresentation.NotOperational);
        }

        public DeviceStatus CircuitryFailed()
        {
            return new DeviceStatus(this.Representation | WorkingStatusRepresentation.CircuitryDamage);
        }

        public DeviceStatus CircuitryReplaced()
        {
            return new DeviceStatus(this.Representation | ~WorkingStatusRepresentation.CircuitryDamage);
        }

        public bool Equals(DeviceStatus other)
        {
           return other != null && this.Representation == other.Representation;
        }

        public override int GetHashCode()
        {
            return (int) this.Representation;
        }
    }
}

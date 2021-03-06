﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Celarix.Cix.Compiler.Lowering.Models
{
    public sealed class HardwareDevice
    {
        private readonly List<HardwareCall> hardwareCalls;

        public string DeviceName { get; }
        public IReadOnlyList<HardwareCall> HardwareCalls => hardwareCalls.AsReadOnly();

        public HardwareDevice(string deviceName, IList<HardwareCall> hardwareCalls)
        {
            DeviceName = deviceName;
            this.hardwareCalls = (List<HardwareCall>) hardwareCalls;
        }
    }
}

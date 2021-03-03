﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celarix.Cix.Compiler.Parse.Models.AST.v1
{
    public sealed class HardwareCallReturnsInternal : Expression
    {
        public string CallName { get; set; }
        public DataType ReturnType { get; set; }
        public List<DataType> ParameterTypes { get; set; }

        public override string PrettyPrint() => $"0 /* hardware call: {CallName} */";
    }
}

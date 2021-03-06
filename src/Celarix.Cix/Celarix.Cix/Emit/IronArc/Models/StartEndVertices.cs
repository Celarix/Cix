﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Celarix.Cix.Compiler.Emit.IronArc.Models
{
    internal sealed class StartEndVertices : IConnectable
    {
        public ControlFlowVertex Start { get; set; }
        public ControlFlowVertex End { get; set; }

        public ControlFlowVertex ConnectionTarget => Start;

        public StartEndVertices(ControlFlowVertex start, ControlFlowVertex end)
        {
            Start = start;
            End = end;
        }

        public static StartEndVertices MakePair(ControlFlowVertex vertex) => new StartEndVertices(vertex, vertex);
        
        public void ConnectTo(IConnectable other, FlowEdgeType flowEdgeType)
        {
            End.ConnectTo(other, flowEdgeType);
        }

        public void ConnectTo(GeneratedFlow other, FlowEdgeType flowEdgeType) =>
            End.ConnectTo(other.ControlFlow.Start, flowEdgeType);
    }
}
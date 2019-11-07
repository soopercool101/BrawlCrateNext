﻿using BrawlLib.Internal;
using BrawlLib.SSBB.ResourceNodes;
using BrawlLib.SSBB.ResourceNodes.MDL0;
using BrawlLib.Wii.Models;
using System;
using System.Collections.Generic;

namespace BrawlLib.Modeling
{
    public interface IMatrixNode
    {
        List<IMatrixNodeUser> Users { get; set; }
        int NodeIndex { get; }
        Matrix Matrix { get; }
        Matrix InverseMatrix { get; }
        bool IsPrimaryNode { get; }
        List<BoneWeight> Weights { get; }
    }
}
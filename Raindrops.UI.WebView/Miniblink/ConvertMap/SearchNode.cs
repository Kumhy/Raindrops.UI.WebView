﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public struct SearchNode
{
    public int Deep;
    public int ParentIndex;
    public int LostWeight;
    public int ConsumptionWeight;
    public Type Inherit;
    public Type Target;
    public ConvertItem ConvertItem;
}
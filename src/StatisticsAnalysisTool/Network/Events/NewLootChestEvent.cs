﻿using StatisticsAnalysisTool.Diagnostics;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace StatisticsAnalysisTool.Network.Events;

public class NewLootChestEvent
{
    public int ObjectId { get; set; }
    public string UniqueName { get; set; }
    public string UniqueNameWithLocation { get; set; }

    public NewLootChestEvent(Dictionary<byte, object> parameters)
    {
        try
        {
            if (parameters.ContainsKey(0) && int.TryParse(parameters[0].ToString(), out var objectId))
            {
                ObjectId = objectId;
            }

            if (parameters.ContainsKey(3))
            {
                UniqueName = string.IsNullOrEmpty(parameters[3].ToString()) ? string.Empty : parameters[3].ToString();
            }

            if (parameters.ContainsKey(4))
            {
                UniqueNameWithLocation = string.IsNullOrEmpty(parameters[4].ToString()) ? string.Empty : parameters[4].ToString();
            }
        }
        catch (Exception e)
        {
            DebugConsole.WriteError(MethodBase.GetCurrentMethod()?.DeclaringType, e);
        }
    }
}
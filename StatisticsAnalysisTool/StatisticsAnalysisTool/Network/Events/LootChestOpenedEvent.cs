﻿using Albion.Network;
using Newtonsoft.Json;
using StatisticsAnalysisTool.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace StatisticsAnalysisTool.Network.Events
{
    public class LootChestOpenedEvent : BaseEvent
    {
        public LootChestOpenedEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            Console.WriteLine($@"[{DateTime.UtcNow}] {GetType().Name}: {JsonConvert.SerializeObject(parameters)}");

            try
            {
                if (parameters.ContainsKey(0))
                {
                    Id = parameters.ObjectToInt();
                }
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
            }
        }

        public int Id { get; set; }
    }
}
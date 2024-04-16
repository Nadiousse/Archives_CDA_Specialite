using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_classes_interfaces_DungeonAdventurer
{
    public class Characteristic
    {
        public Characteristics Type { get; set; }
        public int Value { get; set; }

        public Characteristic(Characteristics initType, int initEffectValue)
        {
            Type = initType;
            Value = initEffectValue;
        }
    }
}
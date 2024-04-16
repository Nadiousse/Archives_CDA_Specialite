using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_GungeonExplorer
{
    public class Characteristics
    {
        public EffectTypes EffectType { get; set; }
        public int EffectValue { get; set; }

        public Characteristics(EffectTypes initEffectType, int initEffectValue)
        {
            EffectType = initEffectType;
            EffectValue = initEffectValue;
        }

        public void LaunchEffect(Adventurer adventurer)
        {
            switch (EffectType)
            {
                case EffectTypes.AddHP:
                    adventurer.Health += EffectValue;
                    break;

                case EffectTypes.DecreaseHP:
                    adventurer.Health -= EffectValue;
                    break;

                case EffectTypes.AddAttack:
                    adventurer.Attack += EffectValue;
                    break;

                case EffectTypes.DecreaseAttack:
                    adventurer.Attack -= EffectValue;
                    break;
            }
        }

        public void LaunchEffect(Encounter monster)
        {
            switch (EffectType)
            {
                case EffectTypes.AddHP:
                    monster.Characteristics += EffectValue;
                    break;

                case EffectTypes.DecreaseHP:
                    monster.Health -= EffectValue;
                    break;
            }
        }
    }
}
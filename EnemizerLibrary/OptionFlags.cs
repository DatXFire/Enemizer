﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemizerLibrary
{
    public class OptionFlags
    {
        public bool RandomizeEnemies { get; set; }
        public RandomizeEnemiesType RandomizeEnemiesType { get; set; } = RandomizeEnemiesType.Chaos; // default to Chaos

        public bool RandomizeEnemyHealthRange { get; set; }
        public int RandomizeEnemyHealthRangeAmount { get; set; }

        public bool RandomizeEnemyDamage { get; set; }
        public bool AllowEnemyZeroDamage { get; set; }

        public bool EnemiesAbsorbable { get; set; }
        public int AbsorbableSpawnRate { get; set; }
        public Dictionary<AbsorbableTypes, bool> AbsorbableTypes { get; set; } = new Dictionary<EnemizerLibrary.AbsorbableTypes, bool>();

        public bool BossMadness { get; set; }

        public bool RandomizeBosses { get; set; }
        public RandomizeBossesType RandomizeBossesType { get; set; }
    }

    public enum RandomizeEnemiesType
    {
        Basic,
        Normal,
        Hard,
        Chaos,
        Insanity
    }

    public enum RandomizeBossesType
    {
        Basic,
        Normal,
        Chaos
    }

    public enum AbsorbableTypes
    {
        [Description("Heart")]
        Heart,
        [Description("Green Rupee")]
        GreenRupee,
        [Description("Blue Rupee")]
        BlueRupee,
        [Description("Red Rupee")]
        RedRupee,
        [Description("Bomb (1)")]
        Bomb_1,
        [Description("Bomb (4)")]
        Bomb_4,
        [Description("Bomb (8)")]
        Bomb_8,
        [Description("Small Magic")]
        SmallMagic,
        [Description("Full Maigc")]
        FullMaigc,
        [Description("Arrow (5)")]
        Arrow_5,
        [Description("Arrow (10)")]
        Arrow_10,
        [Description("Fairy")]
        Fairy,
        [Description("Key")]
        Key,
        [Description("Big Key(Test)")]
        BigKey
    }
}

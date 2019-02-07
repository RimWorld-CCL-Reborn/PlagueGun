using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace Plague
{
    public class ThingDef_PlagueBullet : ThingDef
    {
        public float AddHediffChance = 0.05f;
        public HediffDef HediffToAdd;

        public override void ResolveReferences()
        {
            HediffToAdd = HediffDefOf.Plague;
        }
    }
}

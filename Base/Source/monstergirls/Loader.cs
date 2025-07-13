using RimWorld;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using UnityEngine;
using Verse;

namespace monstergirlsbase
{
    [DefOf]
    public class MilkDefOf
    {
        public static ThingDef Milk;
        public static ThingDef MMG_CentaurMilk;
        public static ThingDef MMG_CowgirlMilk;
        public static ThingDef MMG_DryadMilk;
        public static ThingDef MMG_ImpmotherMilk;
        public static ThingDef MMG_DragonMilk;
        public static ThingDef MMG_BaphometMilk;
        public static ThingDef MMG_ThrumbogirlMilk;
    }

    [StaticConstructorOnStartup]
    public static class Loader
    {
        static Loader()
        {
            LongEventHandler.QueueLongEvent(new Action(Init), "LibraryStartup", false, null);
        }

        private static void Init()
        {
            SetMilk();
            SetProd();
        }

        public static void SetMilk()
        {
            if (Settings.UseMonsterGirlMilk)
            {
                DefDatabase<ThingDef>.GetNamed("MMG_Centaur").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.MMG_CentaurMilk;
                DefDatabase<ThingDef>.GetNamed("MMG_Cowgirl").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.MMG_CowgirlMilk;
                DefDatabase<ThingDef>.GetNamed("MMG_Impmother").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.MMG_ImpmotherMilk;
                DefDatabase<ThingDef>.GetNamed("MMG_Dragongirl").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.MMG_DragonMilk;
                DefDatabase<ThingDef>.GetNamed("MMG_Dryad").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.MMG_DryadMilk;
                DefDatabase<ThingDef>.GetNamed("MMG_Baphomet").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.MMG_BaphometMilk;
                DefDatabase<ThingDef>.GetNamed("MMG_Thrumbomorph").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.MMG_ThrumbogirlMilk;
            }
            else
            {
                DefDatabase<ThingDef>.GetNamed("MMG_Centaur").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
                DefDatabase<ThingDef>.GetNamed("MMG_Cowgirl").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
                DefDatabase<ThingDef>.GetNamed("MMG_Impmother").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
                DefDatabase<ThingDef>.GetNamed("MMG_Dragongirl").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
                DefDatabase<ThingDef>.GetNamed("MMG_Dryad").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
                DefDatabase<ThingDef>.GetNamed("MMG_Baphomet").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
                DefDatabase<ThingDef>.GetNamed("MMG_Thrumbomorph").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
            }
        }
        public static void SetProd()
        {
            SettingsController.SetProductions();
        }
    }
}

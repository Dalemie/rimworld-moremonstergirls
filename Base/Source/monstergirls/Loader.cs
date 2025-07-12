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
        public static ThingDef CentaurMilk;
        public static ThingDef CowgirlMilk;
        public static ThingDef DryadMilk;
        public static ThingDef ImpmotherMilk;
        public static ThingDef DragonMilk;
        public static ThingDef BaphometMilk;
        public static ThingDef ThrumbogirlMilk;
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
                DefDatabase<ThingDef>.GetNamed("Centaur").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.CentaurMilk;
                DefDatabase<ThingDef>.GetNamed("Cowgirl").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.CowgirlMilk;
                DefDatabase<ThingDef>.GetNamed("Impmother").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.ImpmotherMilk;
                DefDatabase<ThingDef>.GetNamed("Dragongirl").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.DragonMilk;
                DefDatabase<ThingDef>.GetNamed("Dryad").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.DryadMilk;
                DefDatabase<ThingDef>.GetNamed("Baphomet").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.BaphometMilk;
                DefDatabase<ThingDef>.GetNamed("Thrumbomorph").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.ThrumbogirlMilk;
            }
            else
            {
                DefDatabase<ThingDef>.GetNamed("Centaur").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
                DefDatabase<ThingDef>.GetNamed("Cowgirl").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
                DefDatabase<ThingDef>.GetNamed("Impmother").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
                DefDatabase<ThingDef>.GetNamed("Dragongirl").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
                DefDatabase<ThingDef>.GetNamed("Dryad").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
                DefDatabase<ThingDef>.GetNamed("Baphomet").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
                DefDatabase<ThingDef>.GetNamed("Thrumbomorph").GetCompProperties<CompProperties_Milkable>().milkDef = MilkDefOf.Milk;
            }
        }
        public static void SetProd()
        {
            SettingsController.SetProductions();
        }
    }
}

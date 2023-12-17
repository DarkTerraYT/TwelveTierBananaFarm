using Il2CppAssets.Scripts.Models.Towers;
using PathsPlusPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveTierBananaFarm.Tiers
{
    internal class Path : PathPlusPlus
    {
        public override string Tower => TowerType.BananaFarm;

        public override int ExtendVanillaPath => Top;

        public override int UpgradeCount => 12; // WOW
    }

    abstract class UpgradesPlusPlus<T> : UpgradePlusPlus<T> where T : PathPlusPlus
    {
        public override string Icon => Name + "-Icon";

        public override string? Portrait => Name + "-Icon";
    }
}

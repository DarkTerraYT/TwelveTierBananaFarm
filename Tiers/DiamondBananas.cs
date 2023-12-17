using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwelveTierBananaFarm.Display;

namespace TwelveTierBananaFarm.Tiers
{
    internal class DiamondBananas : UpgradesPlusPlus<Path>
    {
        public override int Cost => 5650000;

        public override int Tier => 9;

        public override string Description => "Ultra-Valuable Diamond Bananas";

        public override string? Container => GetTextureGUID<TwelveTierBananaFarm>("UpgradeContainerDiamond");

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<BIGBananaDisplay>();

            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().bonusMultiplier += 15;

            towerModel.GetBehavior<BananaCentralBuffModel>().multiplier += 4;

            towerModel.GetWeapon().projectile.ApplyDisplay<MonkeyBrandedCrate>();
        }
    }
}

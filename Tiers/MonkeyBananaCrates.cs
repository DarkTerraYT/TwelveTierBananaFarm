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
    internal class MonkeyBananaCrates : UpgradesPlusPlus<Path>
    {
        public override int Cost => 1250000;

        public override int Tier => 8;

        public override string Description => "Monkey Branding Makes the Bananas Worth More, and increases the banana central buff again.";

        public override string? Container => GetTextureGUID<TwelveTierBananaFarm>("UpgradeContainerMonkey");

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<BIGBananaDisplay>();

            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().bonusMultiplier += 2;


            towerModel.GetBehavior<BananaCentralBuffModel>().multiplier += 1;

            towerModel.GetWeapon().projectile.ApplyDisplay<MonkeyBrandedCrate>();
        }
    }
}

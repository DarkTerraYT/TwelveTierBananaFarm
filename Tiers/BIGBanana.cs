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
    internal class BIGBanana : UpgradesPlusPlus<Path>
    {
        public override int Cost => 655000;

        public override int Tier => 7;

        public override string Description => "Bananas are worth 2x more. Also improves the buff from banana central.";
        public override string DisplayName => "BIG Banana";

        public override string? Container => GetTextureGUID<TwelveTierBananaFarm>("UpgradeContainerBIG");

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.scale *= 2;
            towerModel.GetWeapon().projectile.radius *= 2;
            towerModel.GetWeapon().projectile.ApplyDisplay<BIGCrate>();

            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().bonusMultiplier += 1;

            towerModel.ApplyDisplay<BIGBananaDisplay>();

            towerModel.GetBehavior<BananaCentralBuffModel>().multiplier += 1;
        }
    }
}

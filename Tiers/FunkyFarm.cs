using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers;
using PathsPlusPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Extensions;
using TwelveTierBananaFarm.Display;

namespace TwelveTierBananaFarm.Tiers
{

    internal class FunkyFarm : UpgradesPlusPlus<Path>
    {
        public override int Cost => 355600;

        public override int Tier => 6;

        public override string Description => "The OG T6 Banana Farm";

        public override string? Container => GetTextureGUID<TwelveTierBananaFarm>("UpgradeContainerFunky");

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<FunkyFarmDisplay>();

            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().minimum = 13000;
            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().maximum = 13000;
            towerModel.GetWeapon().projectile.ApplyDisplay<FunkyCrate>();
        }
    }

}

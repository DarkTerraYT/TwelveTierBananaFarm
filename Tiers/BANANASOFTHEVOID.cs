using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;

using TwelveTierBananaFarm.Display;

namespace TwelveTierBananaFarm.Tiers
{
    internal class BANANASOFTHEVOID : UpgradesPlusPlus<Path>
    {
        public override int Cost => 32000000;

        public override int Tier => 11;

        public override string Description => "Guys? I think we should stop with the bananas.";
        public override string DisplayName => "BANANAS OF THE VOID";

        public override string? Container => GetTextureGUID<TwelveTierBananaFarm>("UpgradeContainerVoid");

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<VoidDisplay>();
            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().minimum *= 6;
            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().maximum *= 6;

            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().bonusMultiplier += 40;

            towerModel.GetWeapon().projectile.ApplyDisplay<BANANAOFTHEVOID>();
        }
    }
}

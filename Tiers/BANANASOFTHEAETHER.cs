using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;

using TwelveTierBananaFarm.Display;

namespace TwelveTierBananaFarm.Tiers
{
    internal class BANANASOFTHEAETHER : UpgradesPlusPlus<Path>
    {
        public override int Cost => 15000000;

        public override int Tier => 10;

        public override string Description => "I AM GOD!";
        public override string DisplayName => "BANANAS OF THE AETHER";

        public override string? Container => GetTextureGUID<TwelveTierBananaFarm>("UpgradeContainerAether");

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<AetherDisplay>();
            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().minimum *= 6;
            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().maximum *= 6;

            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().bonusMultiplier += 30;

            towerModel.GetWeapon().projectile.ApplyDisplay<BANANAOFTHEAETHER>();
        }
    }
}

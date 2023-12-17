using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;

using TwelveTierBananaFarm.Display;

namespace TwelveTierBananaFarm.Tiers
{
    internal class Null : UpgradesPlusPlus<Path>
    {
        public override int Cost => 100000000;

        public override int Tier => 12;

        public override string Description => "E̷͙͕̥̟̋̎͛̑̔R̴͉͆̌̀͒̓̇̋͠Ṟ̴̘̆̉̀̓̑̈̅̌̑R̶̛̬͖͉̹̩͖͓̘̗̞̜̐̽̈́̆̈͂̃͝Ọ̴̡͈̘̥̠̦̱͎̜̟̺̇̅̿̓͐̃̍̑̊̑̉̒͘͝͠R̷̢̢͍̳̩̮̠͎͇̦͚͚͗̐̃̀͘͝:̴͉̣̼̞̖͈̳̘̀͊́̂̇̚͝ ̴̡͙͈͎͍͕̞̟͙̽̿͒Ň̵̫̟̱̋̍̑̆̔͋Ų̴̡̧̢̮̜̖̜͔̭͔̝͕̹̇́͐̈͐͗̾̄̽̒̄͆̕̚͝L̵̡͊̏͐̉͝L̴͚͍̱̯̟̹͉̪̐̌̑͂̀̆́̏̄̆̄̆̈́͜";

        public override string DisplayName => "[null]";

        public override string? Container => GetTextureGUID<TwelveTierBananaFarm>("UpgradeContainerNull");

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<VoidDisplay>();

            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().minimum *= 6;
            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().maximum *= 6;

            towerModel.GetWeapon().projectile.GetBehavior<CashModel>().bonusMultiplier += 40;

            towerModel.GetWeapon().projectile.ApplyDisplay<NullBanana>();
        }
    }
}

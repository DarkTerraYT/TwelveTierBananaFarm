using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveTierBananaFarm.Display
{
    internal class FunkyFarmDisplay : ModDisplay
    {
        public override string BaseDisplay => GetDisplay("BananaFarm", 5);

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
        }
    }

    internal class BIGBananaDisplay : ModDisplay
    {
        public override string BaseDisplay => GetDisplay("BananaFarm", 5);

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
        }
    }

    internal class DiamondBananasDisplay : ModDisplay
    {
        public override string BaseDisplay => GetDisplay("BananaFarm", 5);

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
        }
    }

    internal class AetherDisplay : ModDisplay
    {
        public override string BaseDisplay => GetDisplay("BananaFarm", 5);

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
        }
    }

    internal class VoidDisplay : ModDisplay
    {
        public override string BaseDisplay => GetDisplay("BananaFarm", 5);

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
        }
    }
    internal class NullDisplay : ModDisplay
    {
        public override string BaseDisplay => GetDisplay("BananaFarm", 5);

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
            SetMeshOutlineColor(node, new(1, 0.8f, 0));
        }
    }

    internal class FunkyCrate : ModDisplay
    {
        public override string BaseDisplay => Game.instance.model.GetTowerFromId("BananaFarm-500").GetWeapon().projectile.display.GUID;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
        }
    }


    internal class BIGCrate : ModDisplay
    {
        public override string BaseDisplay => Game.instance.model.GetTowerFromId("BananaFarm-500").GetWeapon().projectile.display.GUID;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
        }
    }

    internal class MonkeyBrandedCrate : ModDisplay
    {
        public override string BaseDisplay => Game.instance.model.GetTowerFromId("BananaFarm-500").GetWeapon().projectile.display.GUID;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
        }
    }

    internal class DiamondCrates : ModDisplay
    {
        public override string BaseDisplay => Game.instance.model.GetTowerFromId("BananaFarm-500").GetWeapon().projectile.display.GUID;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
        }
    }

    internal class BANANAOFTHEAETHER : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, Name);
        }
    }

    internal class BANANAOFTHEVOID : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, Name);
        }
    }

    internal class NullBanana : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoidMod.Items
{
    public class RasonantNightsEdge : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Resonant Night's Edge")
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.rare = ItemRarityID.LightRed;
            item.value = Item.buyPrice(gold: 20);
            item.maxStack = 1;
        }
    }
}

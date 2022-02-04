using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace SkyblockDungeons.Content.Items.Weapons
{
	
	public class deeznuts : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meowmere V2");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			
		}

		public override void SetDefaults()
		{
			
			Item.CloneDefaults(ItemID.Meowmere);

			

			

			Item.damage *= 2; 
			Item.shootSpeed *= 2f;
			Items.usetime = 1;
		}


	
	}
}
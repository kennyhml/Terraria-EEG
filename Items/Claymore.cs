
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EasyEarlyGame.Items
{
	public class Claymore : ModItem
	{
		public override void SetStaticDefaults()
		{

			DisplayName.SetDefault("Claymore");
			Tooltip.SetDefault("A heavy sword suited for weaker enemies.");

		}

		public override void SetDefaults()
		{
			Item.damage = 40;
			Item.width = 70;
			Item.height = 70;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.knockBack = 10;
			Item.value = 500;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.DamageType = DamageClass.Melee;
			Item.useStyle = 1;
			Item.shoot = ProjectileID.AmberBolt;
			Item.shootSpeed = 6f;
			Item.useTurn = true;

		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Amber, 7);
			recipe.AddRecipeGroup(RecipeGroupID.IronBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}

	}

}




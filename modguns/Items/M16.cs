using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace modguns.Items
{
	public class M16 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("M-16");
			Tooltip.SetDefault("Standard Issue U.S Combat Rifle From 1967-1994");
		}

		public override void SetDefaults()
		{
			Item.damage = 28;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 10;
			Item.useAnimation =10;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.shoot = 1;
			Item.useAmmo = AmmoID.Bullet;
			Item.shootSpeed = 16.5f;
			Item.noMelee = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CobaltBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
			
			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.PalladiumBar, 15);
			recipe2.AddTile(TileID.Anvils);
			recipe2.Register();
		}
	}
}
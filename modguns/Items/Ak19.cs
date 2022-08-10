using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace modguns.Items
{
	public class Ak19 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ak-19");
			Tooltip.SetDefault("Standard Issue Russian Combat Rifle 2020");
		}

		public override void SetDefaults()
		{
			Item.damage = 38;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = 50000;
			Item.rare = 5
				;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.shoot = 1;
			Item.useAmmo = AmmoID.Bullet;
			Item.shootSpeed = 17;
			Item.noMelee = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TitaniumBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

			Recipe recipe4 = CreateRecipe();
			recipe4.AddIngredient(ItemID.AdamantiteBar, 15);
			recipe4.AddTile(TileID.Anvils);
			recipe4.Register();
		}
	}
}
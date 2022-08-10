using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace modguns.Items
{
	public class Scar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("FN Scar");
			Tooltip.SetDefault("Standard Issue Special Operations Forces Combat Assault Rifle");
		}

		public override void SetDefaults()
		{
			Item.damage = 47;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 9;
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
			recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}
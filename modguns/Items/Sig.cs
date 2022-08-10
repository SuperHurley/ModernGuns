using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace modguns.Items
{
	public class Sig : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sig MXC");
			Tooltip.SetDefault("Standard Issue U.S Combat Rifle");
		}

		public override void SetDefaults()
		{
			Item.damage = 42;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 10;
			Item.useAnimation = 8;
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
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}
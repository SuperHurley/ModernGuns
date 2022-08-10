using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace modguns.Items
{
	public class M1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("M-1-Garand");
			Tooltip.SetDefault("Standard Issue U.S Combat Rifle From WW2");
		}

		public override void SetDefaults()
		{
			Item.damage = 11;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 15;
			Item.useAnimation =12;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = false;
			Item.shoot = 1;
			Item.useAmmo = AmmoID.Bullet;
			Item.shootSpeed = 3.5f;
			Item.noMelee = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TungstenBar, 15);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
			
			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.SilverBar, 15);
			recipe2.AddIngredient(ItemID.Wood, 5);
			recipe2.AddTile(TileID.Anvils);
			recipe2.Register();
		}
	}
}
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace modguns.Items
{
	public class M14 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("M-14");
			Tooltip.SetDefault("Standard Issue U.S Combat Rifle From 1958-1967");
		}

		public override void SetDefaults()
		{
			Item.damage = 14;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 15;
			Item.useAnimation =10;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.shoot = 1;
			Item.useAmmo = AmmoID.Bullet;
			Item.shootSpeed = 3.5f;
			Item.noMelee = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldBar, 15);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
			
			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.PlatinumBar, 15);
			recipe2.AddIngredient(ItemID.Wood, 5);
			recipe2.AddTile(TileID.Anvils);
			recipe2.Register();
		}
	}
}
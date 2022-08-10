using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace modguns.Items
{
	public class Kabar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kabar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Standard Issue USMC combat knife.");
		}

		public override void SetDefaults()
		{
			Item.damage = 21;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddIngredient(ItemID.Wood, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
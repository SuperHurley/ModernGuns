using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace modguns.Items
{
	public class AA12 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("AA-12"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Full Auto Shotgun, Full Awesomeness");
		}

		public override void SetDefaults()
		{
			Item.damage = 28;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 10;
			Item.useAnimation = 8;
			Item.useStyle = 5;
			Item.knockBack = 0.1f;
			Item.value = 3500;
			Item.rare = 1;
			Item.UseSound = SoundID.Item36;
			Item.autoReuse = true;
			Item.shoot = 1;
			Item.useAmmo = AmmoID.Bullet;
			Item.shootSpeed = 17;
			Item.noMelee = true;
		}

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			Vector2 offset = velocity;
			position += offset;
			if (type == ProjectileID.Bullet)
			{
				type = Mod.Find<ModProjectile>("Pellet").Type;
			}
			for (var i = 0; i < Main.rand.Next(3, 4); i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedByRandom(MathHelper.ToRadians(25));
				Projectile.NewProjectile(Projectile.GetSource_NaturalSpawn(), position, perturbedSpeed, type, damage, knockback, player.whoAmI);
			}
			return false;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.LihzahrdBrick, 25);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}

		public override Vector2? HoldoutOffset()
		{
			Vector2 offset = new Vector2(6, 0);
			return offset;
		}

	}
}
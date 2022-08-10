using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace modguns.Projectiles
{
	public class Pellet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shotgun Pellet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.

		}

		public override void SetDefaults()
		{
			Projectile.damage = 7;
			Projectile.height = 6;
			Projectile.width = 6;
			Projectile.aiStyle = 0;
			Projectile.friendly = true;
			Projectile.hostile = false;
			Projectile.timeLeft = 600;
			Projectile.light = 1;
			Projectile.ignoreWater = true;
			Projectile.tileCollide = true;

		}

		public override void AI()
        {
			int dust = Dust.NewDust(Projectile.Center, 1, 1, 231, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].velocity *= 0.2f;
			Main.dust[dust].scale = (float)Main.rand.Next(50, 70) * 0.013f;
			Main.dust[dust].noGravity = true;

		}
	}
}
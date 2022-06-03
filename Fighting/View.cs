using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Fighting
{
    class View : Form
    {
        public static void PlayOnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            switch (Play_form.player1.CurrentAnimation)
            {
                case 0:
                    PlayAnimation(g, Play_form.player1, 196, 248);
                    break;
                case 1:
                    PlayAnimation(g, Play_form.player1, 196, 274);
                    break;
                case 2:
                    PlayAnimation(g, Play_form.player1, 196, 274);
                    break;
                case 3:
                    PlayAnimation(g, Play_form.player1, 196, 340);
                    break;
            }

            switch (Play_form.player2.CurrentAnimation)
            {
                case 0:
                    PlayAnimation(g, Play_form.player2, 196, 248);
                    break;
                case 1:
                    PlayAnimation(g, Play_form.player2, 196, 274);
                    break;
                case 2:
                    PlayAnimation(g, Play_form.player2, 196, 274);
                    break;
                case 3:
                    PlayAnimation(g, Play_form.player2, 196, 340);
                    break;
            }
        }

        public static void SetAnimation(Entity player, int currentAnimation)
        {
            player.CurrentAnimation = currentAnimation;

            switch (currentAnimation)
            {
                case 0:
                    player.CurrentLimit = 41;
                    break;
                case 1:
                    player.CurrentLimit = 13;
                    break;
                case 2:
                    player.CurrentLimit = 13;
                    break;
                case 3:
                    player.CurrentLimit = 30;
                    break;
            }
        }

        public static void PlayAnimation(Graphics g, Entity player, int height, int width)
        {
            g.DrawImage(player.sprites,
                new Rectangle(new Point(player.PosX, player.posY),
                new Size(width, height)),
                width * player.CurrentFrame,
                height * player.CurrentAnimation,
                width, height,
                GraphicsUnit.Pixel);

            if (player.isAttacking && player.CurrentFrame >= 20)
                player.isAttacking = false;

            if (player.CurrentFrame < player.CurrentLimit - 1)
                player.CurrentFrame++;
            else
            {
                player.CurrentFrame = 0;
                player.isMoving = false;
                SetAnimation(player, 0);
            }
        }
    }
}

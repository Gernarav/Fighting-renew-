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
            switch (Play_form.player1.currentAnimation)
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

            switch (Play_form.player2.currentAnimation)
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

        public static void PlayAnimation(Graphics g, Entity player, int height, int width)
        {
            g.DrawImage(player.sprites,
                new Rectangle(new Point(player.posX, player.posY),
                new Size(width, height)),
                width * player.currentFrame,
                height * player.currentAnimation,
                width, height,
                GraphicsUnit.Pixel);

            if (player.isAttacking && player.currentFrame >= 20)
                player.isAttacking = false;

            if (player.currentFrame < player.currentLimit - 1)
                player.currentFrame++;
            else
            {
                player.currentFrame = 0;
                player.isMoving = false;
                player.SetAnimation(0);
            }
        }
    }
}

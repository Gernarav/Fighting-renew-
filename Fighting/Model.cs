using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fighting
{
    public class Entity
    {
        public int posX;
        public int posY;
        public int side;

        public int dirX;
        public bool isMoving;
        public bool isAttacking;

        public int idleFrames;
        public int walkFrames;
        public int attackFrames;

        public int currentAnimation;
        public int currentFrame;
        public int currentLimit;

        public Image sprites;
        public PictureBox hurtBox;
        public PictureBox hitBox;

        public Entity(int posX, int posY, int side, int idleFrames, int walkFrames, int attackFrames, Image sprites, PictureBox hurtBox, PictureBox hitBox)
        {
            this.posX = posX;
            this.side = side;
            this.idleFrames = idleFrames;
            this.walkFrames = walkFrames;
            this.attackFrames = attackFrames;
            this.sprites = sprites;
            this.hurtBox = hurtBox;
            this.hitBox = hitBox;
            currentLimit = idleFrames;
        }

        public void SetAnimation(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;

            switch(currentAnimation)
            {
                case 0:
                    currentLimit = idleFrames;
                    break;
                case 1:
                    currentLimit = walkFrames;
                    break;
                case 2:
                    currentLimit = walkFrames;
                    break;
                case 3:
                    currentLimit = attackFrames;
                    break;
            }
        }
    }

    public static class Hero
    {
        public static int idleFrames = 41;
        public static int walkFrames = 13;
        public static int attackFrames = 30;
    }
}

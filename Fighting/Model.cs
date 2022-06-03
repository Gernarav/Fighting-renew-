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
        private int posX;
        public int PosX
        {
            get { return posX; }
            set 
            {
                    posX += dirX; 
            }
        }
        public int dirX;
        public readonly int posY;
        public readonly int side;

        public bool isMoving;
        public bool isAttacking;

        private int currentAnimation;
        public int CurrentAnimation
        {
            get { return currentAnimation; }
            set
            {
                if (value >= 0 && value <= 3)
                    currentAnimation = value;
            }
        }

        private int currentFrame;
        public int CurrentFrame
        {
            get { return currentFrame; }
            set
            {
                if (value >= 0 && value <= 41)
                    currentFrame = value;
            }
        }

        private int currentLimit;
        public int CurrentLimit
        {
            get { return currentLimit; }
            set
                {
                if (value >= 0 && value <= 41)
                    currentLimit = value;
                }
        }

        public Image sprites;
        public PictureBox hurtBox;
        public PictureBox hitBox;

        public Entity(int posX, int posY, int side, Image sprites, PictureBox hurtBox, PictureBox hitBox)
        {
            this.posX = posX;
            this.posY = posY;
            this.side = side;
            this.sprites = sprites;
            this.hurtBox = hurtBox;
            this.hitBox = hitBox;
            currentLimit = 41;
        }
    }
}

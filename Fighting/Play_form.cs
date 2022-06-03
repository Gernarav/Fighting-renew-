using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Fighting
{
    public partial class Play_form : Form
    {
        private int lastAttacker;
        private bool roundIsOver;
        private string winnerName;
        public static Entity player1;
        public static Entity player2;
        private Bitmap hero1;
        private Bitmap hero2;

        public Play_form(Bitmap player1Skin, Bitmap player2Skin)
        {
            InitializeComponent();

            KeyPreview = true;

            SetSkins(player1Skin, player2Skin);

            roundIsOver = false;
            timer1.Interval = 30;
            timer1.Tick += new EventHandler(Update);
            timer1.Start();

            CreatePlayers();

            KeyDown += new KeyEventHandler(OnPress);

            Invalidate();
        }

        private void SetSkins(Bitmap player1Skin, Bitmap player2Skin)
        {
            hero1 = player1Skin;
            hero2 = player2Skin;
        }

        private void CreatePlayers()
        {
            player1 = new Entity
                (310, 365, 1,
                hero1,
                player1_hurtBox,
                player1_hitBox);

            player2 = new Entity
                (767, 365, 2,
                hero2,
                player2_hurtBox,
                player2_hitBox);
        }

        private void OnPress(object sender, KeyEventArgs e)
        {
            if(!roundIsOver)
            {
                if (!player1.isMoving)
                    switch (e.KeyCode)
                    {
                        case Keys.D:
                            SetMove(player1, 15, 1);
                            break;
                        case Keys.A:
                            SetMove(player1, -15, 2);
                            break;
                        case Keys.F:
                            SetMove(player1, 10, 3);
                            break;
                    }

                if (!player2.isMoving)
                    switch (e.KeyCode)
                    {
                        case Keys.L:
                            SetMove(player2, 15, 1);
                            break;
                        case Keys.J:
                            SetMove(player2, -15, 2);
                            break;
                        case Keys.I:
                            SetMove(player2, -10, 3);
                            break;
                    }
            }
            
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
        }

        private void Update(object sender, EventArgs e)
        {
            if(!roundIsOver)
            {
                WinnerStatus();

                if (player1.isMoving)
                    MakeMove(player1);

                if (player2.isMoving)
                    MakeMove(player2);

                Invalidate();
                return;
            }


            timer1.Stop();
            timer1.Dispose();
            Thread.Sleep(500);

            DialogResult gameOver = MessageBox.Show(
                winnerName, "Play again?", 
                MessageBoxButtons.YesNo);

            switch (gameOver)
            {
                case DialogResult.Yes:
                    this.Hide();
                    Play_form formToSwitch = new Play_form(hero1, hero2);
                    formToSwitch.ShowDialog();
                    this.Close();
                    break;
                case DialogResult.No:
                    openForm1();
                    break;
            }
        }

        private void SetMove(Entity player, int dirX, int SetAnimation)
        {
            if (SetAnimation == 3)
            {
                player.isAttacking = true;
                lastAttacker = player.side;
            }
                
            player.isMoving = true;
            player.dirX = dirX;
            View.SetAnimation(player, SetAnimation);
        }

        private bool InBorders(Entity player)
        {
            switch(player.side)
            {
                case 1:
                    if (player1.PosX + player1.dirX > 0 && player1.hurtBox.Right + player1.dirX + 50 < player2.hurtBox.Left)
                        return true;
                    return false;
                case 2:
                    if (player2.hurtBox.Left + player2.dirX - 50 > player1_hurtBox.Right && player2.hurtBox.Right + player2.dirX + 50 < ClientSize.Width)
                        return true;
                    return false;
            }
            return false;
        }

        private void MakeMove(Entity player)
        {
            if (InBorders(player))
            {
                player.PosX = player.dirX;
                player.hurtBox.Left += player.dirX;
                player.hitBox.Left += player.dirX;
            }
        }

        private void WinnerStatus()
        {
            if (player1.isAttacking && lastAttacker == 1 && player1_hitBox.Right >= player2_hurtBox.Left)
            {
                RoundOver("Player1 won");
            }


            if (player2.isAttacking && lastAttacker == 2 && player2_hitBox.Left <= player1_hurtBox.Right)
            {
                RoundOver("Player2 won");
            }
        }

        private void RoundOver(string winner)
        {
            roundIsOver = true;
            winnerName = winner;
        }

        private void openForm1()
        {
            this.Hide();
            Main_menu_form formToSwitch = new Main_menu_form();
            formToSwitch.ShowDialog();
            this.Close();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            View.PlayOnPaint(sender, e);
        }
    }
}

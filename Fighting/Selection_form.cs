using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fighting
{
    public partial class Selection_form : Form
    {
        public static string player1Skin = "Left_Blue_Sprites";
        public static string player2Skin = "Right_Red_Sprites";
        public Selection_form()
        {
            InitializeComponent();
            KeyPreview = true;

            timer1.Interval = 50;
            timer1.Tick += new EventHandler(Update);
            timer1.Start();

            KeyDown += new KeyEventHandler(OnPress);
            Invalidate();
        }


        public void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    openForm1();
                    break;
            }
        }

        public void Update(object sender, EventArgs e)
        {
            Invalidate();
        }

        public void openForm1()
        {
            this.Hide();
            Main_menu_form formToSwitch = new Main_menu_form();
            formToSwitch.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openForm1();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            openForm1();
        }

        private void Left_Select_Blue_Click(object sender, EventArgs e)
        {
            player1Skin = "Left_Blue_Sprites";
        }

        private void Left_Select_Red_Click(object sender, EventArgs e)
        {
            player1Skin = "Left_Red_Sprites";
        }

        private void Left_Select_Green_Click(object sender, EventArgs e)
        {
            player1Skin = "Left_Green_Sprites";
        }

        private void Left_Select_Yellow_Click(object sender, EventArgs e)
        {
            player1Skin = "Left_Yellow_Sprites";
        }

        private void Right_Select_Blue_Click(object sender, EventArgs e)
        {
            player2Skin = "Right_Blue_Sprites";
        }

        private void Right_Select_Red_Click(object sender, EventArgs e)
        {
            player2Skin = "Right_Red_Sprites";
        }

        private void Right_Select_Green_Click(object sender, EventArgs e)
        {
            player2Skin = "Right_Green_Sprites";
        }

        private void Right_Select_Yellow_Click(object sender, EventArgs e)
        {
            player2Skin = "Right_Yellow_Sprites";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Bitmap hero1 = SelectSkin(player1Skin);
            Bitmap hero2 = SelectSkin(player2Skin);
            this.Hide();
            Play_form formToSwitch = new Play_form(hero1, hero2);
            formToSwitch.ShowDialog();
            this.Close();
        }

        public Bitmap SelectSkin(string skinName)
        {
            switch (skinName)
            {
                case "Left_Blue_Sprites":
                    return new Bitmap(Resource1.Left_Blue_Sprites);
                case "Left_Red_Sprites":
                    return new Bitmap(Resource1.Left_Red_Sprites);
                case "Left_Green_Sprites":
                    return new Bitmap(Resource1.Left_Green_Sprites);
                case "Left_Yellow_Sprites":
                    return new Bitmap(Resource1.Left_Yellow_Sprites);
                case "Right_Blue_Sprites":
                    return new Bitmap(Resource1.Right_Blue_Sprites);
                case "Right_Red_Sprites":
                    return new Bitmap(Resource1.Right_Red_Sprites);
                case "Right_Green_Sprites":
                    return new Bitmap(Resource1.Right_Green_Sprites);
                case "Right_Yellow_Sprites":
                    return new Bitmap(Resource1.Right_Yellow_Sprites);
            }
            return new Bitmap(Resource1.Left_Yellow_Sprites);
        }

        private void Selection_form_Load(object sender, EventArgs e)
        {

        }
    }
}

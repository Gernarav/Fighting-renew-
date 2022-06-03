
using System.Windows.Forms;

namespace Fighting
{
    partial class Play_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player1_hurtBox = new System.Windows.Forms.PictureBox();
            this.player1_hitBox = new System.Windows.Forms.PictureBox();
            this.player2_hurtBox = new System.Windows.Forms.PictureBox();
            this.player2_hitBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player1_hurtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_hitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_hurtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_hitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // player1_hurtBox
            // 
            this.player1_hurtBox.BackColor = System.Drawing.Color.Transparent;
            this.player1_hurtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1_hurtBox.Location = new System.Drawing.Point(394, 389);
            this.player1_hurtBox.Name = "player1_hurtBox";
            this.player1_hurtBox.Size = new System.Drawing.Size(74, 180);
            this.player1_hurtBox.TabIndex = 6;
            this.player1_hurtBox.TabStop = false;
            // 
            // player1_hitBox
            // 
            this.player1_hitBox.BackColor = System.Drawing.Color.Transparent;
            this.player1_hitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1_hitBox.Location = new System.Drawing.Point(467, 479);
            this.player1_hitBox.Name = "player1_hitBox";
            this.player1_hitBox.Size = new System.Drawing.Size(125, 16);
            this.player1_hitBox.TabIndex = 7;
            this.player1_hitBox.TabStop = false;
            // 
            // player2_hurtBox
            // 
            this.player2_hurtBox.BackColor = System.Drawing.Color.Transparent;
            this.player2_hurtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2_hurtBox.Location = new System.Drawing.Point(919, 401);
            this.player2_hurtBox.Name = "player2_hurtBox";
            this.player2_hurtBox.Size = new System.Drawing.Size(74, 180);
            this.player2_hurtBox.TabIndex = 8;
            this.player2_hurtBox.TabStop = false;
            // 
            // player2_hitBox
            // 
            this.player2_hitBox.BackColor = System.Drawing.Color.Transparent;
            this.player2_hitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2_hitBox.Location = new System.Drawing.Point(795, 444);
            this.player2_hitBox.Name = "player2_hitBox";
            this.player2_hitBox.Size = new System.Drawing.Size(125, 16);
            this.player2_hitBox.TabIndex = 9;
            this.player2_hitBox.TabStop = false;
            // 
            // Play_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.player2_hitBox);
            this.Controls.Add(this.player2_hurtBox);
            this.Controls.Add(this.player1_hitBox);
            this.Controls.Add(this.player1_hurtBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Play_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play_form";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            ((System.ComponentModel.ISupportInitialize)(this.player1_hurtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_hitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_hurtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_hitBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Timer timer1;
        public PictureBox player1_hurtBox;
        public PictureBox player1_hitBox;
        public PictureBox player2_hurtBox;
        public PictureBox player2_hitBox;
    }
}
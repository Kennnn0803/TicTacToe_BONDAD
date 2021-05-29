
namespace TicTacToe
{
    partial class body
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(body));
            this.panel1 = new System.Windows.Forms.Panel();
            this.score2 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.exitb = new System.Windows.Forms.Button();
            this.resetb = new System.Windows.Forms.Button();
            this.newgameb = new System.Windows.Forms.Button();
            this.ticbutton1 = new System.Windows.Forms.Button();
            this.ticbutton5 = new System.Windows.Forms.Button();
            this.ticbutton4 = new System.Windows.Forms.Button();
            this.ticbutton2 = new System.Windows.Forms.Button();
            this.ticbutton3 = new System.Windows.Forms.Button();
            this.ticbutton6 = new System.Windows.Forms.Button();
            this.ticbutton7 = new System.Windows.Forms.Button();
            this.ticbutton8 = new System.Windows.Forms.Button();
            this.ticbutton9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.score2);
            this.panel1.Controls.Add(this.score1);
            this.panel1.Controls.Add(this.player2);
            this.panel1.Controls.Add(this.player1);
            this.panel1.Controls.Add(this.exitb);
            this.panel1.Controls.Add(this.resetb);
            this.panel1.Controls.Add(this.newgameb);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 112);
            this.panel1.TabIndex = 0;
            // 
            // score2
            // 
            this.score2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.score2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score2.Location = new System.Drawing.Point(376, 62);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(133, 34);
            this.score2.TabIndex = 12;
            this.score2.Text = "0";
            this.score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score1
            // 
            this.score1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.score1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score1.Location = new System.Drawing.Point(377, 13);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(133, 34);
            this.score1.TabIndex = 11;
            this.score1.Text = "0";
            this.score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2.Location = new System.Drawing.Point(235, 62);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(133, 34);
            this.player2.TabIndex = 10;
            this.player2.Text = "Player 2 :";
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1.Location = new System.Drawing.Point(235, 13);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(133, 34);
            this.player1.TabIndex = 9;
            this.player1.Text = "Player 1 :";
            // 
            // exitb
            // 
            this.exitb.BackColor = System.Drawing.SystemColors.Highlight;
            this.exitb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitb.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitb.Location = new System.Drawing.Point(111, 62);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(101, 46);
            this.exitb.TabIndex = 8;
            this.exitb.Text = "EXIT";
            this.exitb.UseVisualStyleBackColor = false;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // resetb
            // 
            this.resetb.BackColor = System.Drawing.SystemColors.Highlight;
            this.resetb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.resetb.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetb.Location = new System.Drawing.Point(17, 62);
            this.resetb.Name = "resetb";
            this.resetb.Size = new System.Drawing.Size(88, 46);
            this.resetb.TabIndex = 7;
            this.resetb.Text = "RESET";
            this.resetb.UseVisualStyleBackColor = false;
            this.resetb.Click += new System.EventHandler(this.resetb_Click);
            // 
            // newgameb
            // 
            this.newgameb.BackColor = System.Drawing.SystemColors.Highlight;
            this.newgameb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newgameb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newgameb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.newgameb.Location = new System.Drawing.Point(17, 10);
            this.newgameb.Name = "newgameb";
            this.newgameb.Size = new System.Drawing.Size(195, 46);
            this.newgameb.TabIndex = 6;
            this.newgameb.Text = "NEW GAME";
            this.newgameb.UseVisualStyleBackColor = false;
            this.newgameb.Click += new System.EventHandler(this.newgameb_Click);
            // 
            // ticbutton1
            // 
            this.ticbutton1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ticbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ticbutton1.Font = new System.Drawing.Font("Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticbutton1.Location = new System.Drawing.Point(92, 141);
            this.ticbutton1.Name = "ticbutton1";
            this.ticbutton1.Size = new System.Drawing.Size(112, 111);
            this.ticbutton1.TabIndex = 1;
            this.ticbutton1.UseVisualStyleBackColor = false;
            this.ticbutton1.Click += new System.EventHandler(this.buttonclick);
            // 
            // ticbutton5
            // 
            this.ticbutton5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ticbutton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ticbutton5.Font = new System.Drawing.Font("Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticbutton5.Location = new System.Drawing.Point(206, 253);
            this.ticbutton5.Name = "ticbutton5";
            this.ticbutton5.Size = new System.Drawing.Size(112, 111);
            this.ticbutton5.TabIndex = 2;
            this.ticbutton5.UseVisualStyleBackColor = false;
            this.ticbutton5.Click += new System.EventHandler(this.buttonclick5);
            // 
            // ticbutton4
            // 
            this.ticbutton4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ticbutton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ticbutton4.Font = new System.Drawing.Font("Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticbutton4.Location = new System.Drawing.Point(92, 253);
            this.ticbutton4.Name = "ticbutton4";
            this.ticbutton4.Size = new System.Drawing.Size(112, 111);
            this.ticbutton4.TabIndex = 3;
            this.ticbutton4.UseVisualStyleBackColor = false;
            this.ticbutton4.Click += new System.EventHandler(this.buttonclick4);
            // 
            // ticbutton2
            // 
            this.ticbutton2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ticbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ticbutton2.Font = new System.Drawing.Font("Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticbutton2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ticbutton2.Location = new System.Drawing.Point(206, 141);
            this.ticbutton2.Name = "ticbutton2";
            this.ticbutton2.Size = new System.Drawing.Size(112, 111);
            this.ticbutton2.TabIndex = 4;
            this.ticbutton2.UseVisualStyleBackColor = false;
            this.ticbutton2.Click += new System.EventHandler(this.buttonclick2);
            // 
            // ticbutton3
            // 
            this.ticbutton3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ticbutton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ticbutton3.Font = new System.Drawing.Font("Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticbutton3.Location = new System.Drawing.Point(320, 141);
            this.ticbutton3.Name = "ticbutton3";
            this.ticbutton3.Size = new System.Drawing.Size(112, 111);
            this.ticbutton3.TabIndex = 5;
            this.ticbutton3.UseVisualStyleBackColor = false;
            this.ticbutton3.Click += new System.EventHandler(this.buttonclick3);
            // 
            // ticbutton6
            // 
            this.ticbutton6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ticbutton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ticbutton6.Font = new System.Drawing.Font("Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticbutton6.Location = new System.Drawing.Point(320, 253);
            this.ticbutton6.Name = "ticbutton6";
            this.ticbutton6.Size = new System.Drawing.Size(112, 111);
            this.ticbutton6.TabIndex = 6;
            this.ticbutton6.UseVisualStyleBackColor = false;
            this.ticbutton6.Click += new System.EventHandler(this.buttonclick6);
            // 
            // ticbutton7
            // 
            this.ticbutton7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ticbutton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ticbutton7.Font = new System.Drawing.Font("Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticbutton7.Location = new System.Drawing.Point(92, 365);
            this.ticbutton7.Name = "ticbutton7";
            this.ticbutton7.Size = new System.Drawing.Size(112, 111);
            this.ticbutton7.TabIndex = 7;
            this.ticbutton7.UseVisualStyleBackColor = false;
            this.ticbutton7.Click += new System.EventHandler(this.buttonclick7);
            // 
            // ticbutton8
            // 
            this.ticbutton8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ticbutton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ticbutton8.Font = new System.Drawing.Font("Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticbutton8.Location = new System.Drawing.Point(206, 365);
            this.ticbutton8.Name = "ticbutton8";
            this.ticbutton8.Size = new System.Drawing.Size(112, 111);
            this.ticbutton8.TabIndex = 8;
            this.ticbutton8.UseVisualStyleBackColor = false;
            this.ticbutton8.Click += new System.EventHandler(this.buttonclick8);
            // 
            // ticbutton9
            // 
            this.ticbutton9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ticbutton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ticbutton9.Font = new System.Drawing.Font("Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticbutton9.Location = new System.Drawing.Point(320, 365);
            this.ticbutton9.Name = "ticbutton9";
            this.ticbutton9.Size = new System.Drawing.Size(112, 111);
            this.ticbutton9.TabIndex = 9;
            this.ticbutton9.UseVisualStyleBackColor = false;
            this.ticbutton9.Click += new System.EventHandler(this.buttonclick9);
            // 
            // body
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(554, 495);
            this.Controls.Add(this.ticbutton9);
            this.Controls.Add(this.ticbutton8);
            this.Controls.Add(this.ticbutton7);
            this.Controls.Add(this.ticbutton6);
            this.Controls.Add(this.ticbutton3);
            this.Controls.Add(this.ticbutton2);
            this.Controls.Add(this.ticbutton4);
            this.Controls.Add(this.ticbutton5);
            this.Controls.Add(this.ticbutton1);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "body";
            this.Text = "Tic Tac Toe!";
            this.Load += new System.EventHandler(this.body_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ticbutton1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Button resetb;
        private System.Windows.Forms.Button newgameb;
        private System.Windows.Forms.Button ticbutton5;
        private System.Windows.Forms.Button ticbutton4;
        private System.Windows.Forms.Button ticbutton2;
        private System.Windows.Forms.Button ticbutton3;
        private System.Windows.Forms.Button ticbutton6;
        private System.Windows.Forms.Button ticbutton7;
        private System.Windows.Forms.Button ticbutton8;
        private System.Windows.Forms.Button ticbutton9;
    }
}


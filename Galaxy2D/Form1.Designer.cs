namespace Galaxy2D
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerStation = new System.Windows.Forms.Timer(this.components);
            this.playerShip = new System.Windows.Forms.PictureBox();
            this.playerRocket = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy5 = new System.Windows.Forms.PictureBox();
            this.station1 = new System.Windows.Forms.PictureBox();
            this.station2 = new System.Windows.Forms.PictureBox();
            this.station3 = new System.Windows.Forms.PictureBox();
            this.timerEnemy1 = new System.Windows.Forms.Timer(this.components);
            this.timerRocket = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.scoreLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startBt = new DevComponents.DotNetBar.LabelX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helth1 = new System.Windows.Forms.PictureBox();
            this.helth2 = new System.Windows.Forms.PictureBox();
            this.helth3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerEnemy2 = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy3 = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy4 = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy5 = new System.Windows.Forms.Timer(this.components);
            this.boomPic = new System.Windows.Forms.PictureBox();
            this.timerBoom = new System.Windows.Forms.Timer(this.components);
            this.timerRest = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.station1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.station2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.station3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomPic)).BeginInit();
            this.SuspendLayout();
            // 
            // timerStation
            // 
            this.timerStation.Interval = 10;
            this.timerStation.Tick += new System.EventHandler(this.timerStation_Tick);
            // 
            // playerShip
            // 
            this.playerShip.BackColor = System.Drawing.Color.Transparent;
            this.playerShip.Image = ((System.Drawing.Image)(resources.GetObject("playerShip.Image")));
            this.playerShip.Location = new System.Drawing.Point(12, 140);
            this.playerShip.Name = "playerShip";
            this.playerShip.Size = new System.Drawing.Size(53, 61);
            this.playerShip.TabIndex = 0;
            this.playerShip.TabStop = false;
            // 
            // playerRocket
            // 
            this.playerRocket.BackColor = System.Drawing.Color.Transparent;
            this.playerRocket.Image = ((System.Drawing.Image)(resources.GetObject("playerRocket.Image")));
            this.playerRocket.Location = new System.Drawing.Point(66, 162);
            this.playerRocket.Name = "playerRocket";
            this.playerRocket.Size = new System.Drawing.Size(37, 22);
            this.playerRocket.TabIndex = 1;
            this.playerRocket.TabStop = false;
            this.playerRocket.Visible = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(529, 56);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(39, 45);
            this.enemy1.TabIndex = 2;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(500, 214);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(122, 50);
            this.enemy2.TabIndex = 3;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(396, 291);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(188, 72);
            this.enemy3.TabIndex = 4;
            this.enemy3.TabStop = false;
            // 
            // enemy4
            // 
            this.enemy4.BackColor = System.Drawing.Color.Transparent;
            this.enemy4.Image = ((System.Drawing.Image)(resources.GetObject("enemy4.Image")));
            this.enemy4.Location = new System.Drawing.Point(690, 63);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(37, 121);
            this.enemy4.TabIndex = 5;
            this.enemy4.TabStop = false;
            // 
            // enemy5
            // 
            this.enemy5.BackColor = System.Drawing.Color.Transparent;
            this.enemy5.Image = ((System.Drawing.Image)(resources.GetObject("enemy5.Image")));
            this.enemy5.Location = new System.Drawing.Point(549, 120);
            this.enemy5.Name = "enemy5";
            this.enemy5.Size = new System.Drawing.Size(122, 37);
            this.enemy5.TabIndex = 6;
            this.enemy5.TabStop = false;
            // 
            // station1
            // 
            this.station1.BackColor = System.Drawing.Color.Transparent;
            this.station1.Image = ((System.Drawing.Image)(resources.GetObject("station1.Image")));
            this.station1.Location = new System.Drawing.Point(12, 214);
            this.station1.Name = "station1";
            this.station1.Size = new System.Drawing.Size(73, 203);
            this.station1.TabIndex = 7;
            this.station1.TabStop = false;
            // 
            // station2
            // 
            this.station2.BackColor = System.Drawing.Color.Transparent;
            this.station2.Image = ((System.Drawing.Image)(resources.GetObject("station2.Image")));
            this.station2.Location = new System.Drawing.Point(321, 0);
            this.station2.Name = "station2";
            this.station2.Size = new System.Drawing.Size(133, 222);
            this.station2.TabIndex = 8;
            this.station2.TabStop = false;
            // 
            // station3
            // 
            this.station3.BackColor = System.Drawing.Color.Transparent;
            this.station3.Image = ((System.Drawing.Image)(resources.GetObject("station3.Image")));
            this.station3.Location = new System.Drawing.Point(648, 205);
            this.station3.Name = "station3";
            this.station3.Size = new System.Drawing.Size(146, 212);
            this.station3.TabIndex = 9;
            this.station3.TabStop = false;
            // 
            // timerEnemy1
            // 
            this.timerEnemy1.Interval = 10;
            this.timerEnemy1.Tick += new System.EventHandler(this.timerEnemy1_Tick);
            // 
            // timerRocket
            // 
            this.timerRocket.Interval = 10;
            this.timerRocket.Tick += new System.EventHandler(this.timerRocket_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.scoreLb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.startBt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.helth1);
            this.panel1.Controls.Add(this.helth2);
            this.panel1.Controls.Add(this.helth3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(800, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 417);
            this.panel1.TabIndex = 10;
            // 
            // scoreLb
            // 
            this.scoreLb.AutoSize = true;
            this.scoreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLb.Location = new System.Drawing.Point(20, 221);
            this.scoreLb.Name = "scoreLb";
            this.scoreLb.Size = new System.Drawing.Size(44, 16);
            this.scoreLb.TabIndex = 11;
            this.scoreLb.Text = "            ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Score:";
            // 
            // startBt
            // 
            // 
            // 
            // 
            this.startBt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.startBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBt.Image = ((System.Drawing.Image)(resources.GetObject("startBt.Image")));
            this.startBt.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.startBt.Location = new System.Drawing.Point(14, 12);
            this.startBt.Name = "startBt";
            this.startBt.Size = new System.Drawing.Size(50, 45);
            this.startBt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.startBt.TabIndex = 9;
            this.startBt.Text = "Start";
            this.startBt.TextAlignment = System.Drawing.StringAlignment.Center;
            this.startBt.Click += new System.EventHandler(this.startBt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "SPACE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Shoot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "← ↑ → ↓";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Move:";
            // 
            // helth1
            // 
            this.helth1.Image = ((System.Drawing.Image)(resources.GetObject("helth1.Image")));
            this.helth1.Location = new System.Drawing.Point(40, 385);
            this.helth1.Name = "helth1";
            this.helth1.Size = new System.Drawing.Size(24, 20);
            this.helth1.TabIndex = 0;
            this.helth1.TabStop = false;
            // 
            // helth2
            // 
            this.helth2.Image = ((System.Drawing.Image)(resources.GetObject("helth2.Image")));
            this.helth2.Location = new System.Drawing.Point(40, 359);
            this.helth2.Name = "helth2";
            this.helth2.Size = new System.Drawing.Size(24, 20);
            this.helth2.TabIndex = 1;
            this.helth2.TabStop = false;
            // 
            // helth3
            // 
            this.helth3.Image = ((System.Drawing.Image)(resources.GetObject("helth3.Image")));
            this.helth3.Location = new System.Drawing.Point(40, 333);
            this.helth3.Name = "helth3";
            this.helth3.Size = new System.Drawing.Size(24, 20);
            this.helth3.TabIndex = 2;
            this.helth3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Left:";
            // 
            // timerEnemy2
            // 
            this.timerEnemy2.Interval = 10;
            this.timerEnemy2.Tick += new System.EventHandler(this.timerEnemy2_Tick);
            // 
            // timerEnemy3
            // 
            this.timerEnemy3.Interval = 10;
            this.timerEnemy3.Tick += new System.EventHandler(this.timerEnemy3_Tick);
            // 
            // timerEnemy4
            // 
            this.timerEnemy4.Interval = 10;
            this.timerEnemy4.Tick += new System.EventHandler(this.timerEnemy4_Tick);
            // 
            // timerEnemy5
            // 
            this.timerEnemy5.Interval = 10;
            this.timerEnemy5.Tick += new System.EventHandler(this.timerEnemy5_Tick);
            // 
            // boomPic
            // 
            this.boomPic.BackColor = System.Drawing.Color.Transparent;
            this.boomPic.Image = ((System.Drawing.Image)(resources.GetObject("boomPic.Image")));
            this.boomPic.Location = new System.Drawing.Point(133, 140);
            this.boomPic.Name = "boomPic";
            this.boomPic.Size = new System.Drawing.Size(43, 40);
            this.boomPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boomPic.TabIndex = 11;
            this.boomPic.TabStop = false;
            // 
            // timerBoom
            // 
            this.timerBoom.Interval = 10;
            this.timerBoom.Tick += new System.EventHandler(this.timerBoom_Tick);
            // 
            // timerRest
            // 
            this.timerRest.Interval = 10;
            this.timerRest.Tick += new System.EventHandler(this.timerRest_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(876, 417);
            this.Controls.Add(this.boomPic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerShip);
            this.Controls.Add(this.playerRocket);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy5);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.station2);
            this.Controls.Add(this.station3);
            this.Controls.Add(this.station1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "GalaxyWar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shoot);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.playerMove);
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.station1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.station2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.station3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerStation;
        private System.Windows.Forms.PictureBox playerShip;
        private System.Windows.Forms.PictureBox playerRocket;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy5;
        private System.Windows.Forms.PictureBox station1;
        private System.Windows.Forms.PictureBox station2;
        private System.Windows.Forms.PictureBox station3;
        private System.Windows.Forms.Timer timerEnemy1;
        private System.Windows.Forms.Timer timerRocket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox helth3;
        private System.Windows.Forms.PictureBox helth2;
        private System.Windows.Forms.PictureBox helth1;
        private System.Windows.Forms.Timer timerEnemy2;
        private System.Windows.Forms.Timer timerEnemy3;
        private System.Windows.Forms.Timer timerEnemy4;
        private System.Windows.Forms.Timer timerEnemy5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.LabelX startBt;
        private System.Windows.Forms.PictureBox boomPic;
        private System.Windows.Forms.Label scoreLb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerBoom;
        private System.Windows.Forms.Timer timerRest;
    }
}


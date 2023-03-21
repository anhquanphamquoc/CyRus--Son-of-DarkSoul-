namespace WindowsFormsApp10
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.Box = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.panelPauseGame = new System.Windows.Forms.Panel();
            this.buttonExitGame = new System.Windows.Forms.Button();
            this.mana = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panelPauseGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.DarkRed;
            this.player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player.Image = global::WindowsFormsApp10.Properties.Resources.truoc;
            this.player.Location = new System.Drawing.Point(379, 194);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 800;
            this.timer2.Tick += new System.EventHandler(this.TimerEvent2);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.TimerEvent3);
            // 
            // timer4
            // 
            this.timer4.Interval = 40;
            this.timer4.Tick += new System.EventHandler(this.TimerEvent4);
            // 
            // timer5
            // 
            this.timer5.Interval = 1;
            this.timer5.Tick += new System.EventHandler(this.TimerEvent5);
            // 
            // timer6
            // 
            this.timer6.Enabled = true;
            this.timer6.Interval = 10;
            this.timer6.Tick += new System.EventHandler(this.TimerEvent6);
            // 
            // timer7
            // 
            this.timer7.Enabled = true;
            this.timer7.Interval = 1;
            this.timer7.Tick += new System.EventHandler(this.TimerEvent7);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer8
            // 
            this.timer8.Enabled = true;
            this.timer8.Tick += new System.EventHandler(this.TimerEvent8);
            // 
            // Box
            // 
            this.Box.AutoSize = true;
            this.Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box.ForeColor = System.Drawing.Color.Red;
            this.Box.Location = new System.Drawing.Point(7, 9);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(0, 25);
            this.Box.TabIndex = 1;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.Color.Yellow;
            this.buttonContinue.Location = new System.Drawing.Point(529, 188);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(125, 55);
            this.buttonContinue.TabIndex = 1;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinueGameClick);
            // 
            // NewGame
            // 
            this.NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.ForeColor = System.Drawing.Color.YellowGreen;
            this.NewGame.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewGame.Location = new System.Drawing.Point(143, 188);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(125, 55);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "NewGame";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.buttonNewGameClick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.ScoreLabel.Location = new System.Drawing.Point(333, 118);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(0, 25);
            this.ScoreLabel.TabIndex = 8;
            // 
            // panelPauseGame
            // 
            this.panelPauseGame.Controls.Add(this.buttonExitGame);
            this.panelPauseGame.Controls.Add(this.ScoreLabel);
            this.panelPauseGame.Controls.Add(this.NewGame);
            this.panelPauseGame.Controls.Add(this.buttonContinue);
            this.panelPauseGame.Location = new System.Drawing.Point(13, 9);
            this.panelPauseGame.Name = "panelPauseGame";
            this.panelPauseGame.Size = new System.Drawing.Size(776, 435);
            this.panelPauseGame.TabIndex = 5;
            // 
            // buttonExitGame
            // 
            this.buttonExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitGame.ForeColor = System.Drawing.Color.Coral;
            this.buttonExitGame.Location = new System.Drawing.Point(338, 187);
            this.buttonExitGame.Name = "buttonExitGame";
            this.buttonExitGame.Size = new System.Drawing.Size(125, 55);
            this.buttonExitGame.TabIndex = 9;
            this.buttonExitGame.Text = "ExitGame";
            this.buttonExitGame.UseVisualStyleBackColor = true;
            this.buttonExitGame.Click += new System.EventHandler(this.buttonExitGame_Click_1);
            // 
            // mana
            // 
            this.mana.AutoSize = true;
            this.mana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mana.ForeColor = System.Drawing.Color.SkyBlue;
            this.mana.Location = new System.Drawing.Point(7, 34);
            this.mana.Name = "mana";
            this.mana.Size = new System.Drawing.Size(0, 25);
            this.mana.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPauseGame);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mana);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.player);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Name = "Form1";
            this.Text = "CyRus(Son of DarkSoul)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panelPauseGame.ResumeLayout(false);
            this.panelPauseGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Label Box;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Panel panelPauseGame;
        private System.Windows.Forms.Label mana;
        private System.Windows.Forms.Button buttonExitGame;
    }
}


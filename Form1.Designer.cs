namespace Keypord_typing_project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmType = new System.Windows.Forms.ComboBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbKepoardPassed = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.kepoard = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.cmLevel = new System.Windows.Forms.ComboBox();
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.startGameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnKepoard = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmType);
            this.panel1.Controls.Add(this.cmbLanguage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lbScore);
            this.panel1.Controls.Add(this.lbKepoardPassed);
            this.panel1.Controls.Add(this.lbTimer);
            this.panel1.Controls.Add(this.Score);
            this.panel1.Controls.Add(this.kepoard);
            this.panel1.Controls.Add(this.Timer);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Controls.Add(this.cmLevel);
            this.panel1.Controls.Add(this.lbLevel);
            this.panel1.Controls.Add(this.lbType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 551);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1472, 316);
            this.panel1.TabIndex = 0;
            // 
            // cmType
            // 
            this.cmType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmType.FormattingEnabled = true;
            this.cmType.Items.AddRange(new object[] {
            "characters",
            "numbers"});
            this.cmType.Location = new System.Drawing.Point(257, 31);
            this.cmType.Name = "cmType";
            this.cmType.Size = new System.Drawing.Size(138, 27);
            this.cmType.TabIndex = 16;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "Arabic",
            "English"});
            this.cmbLanguage.Location = new System.Drawing.Point(257, 155);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(138, 27);
            this.cmbLanguage.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose language:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(1053, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 316);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textBox5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox5.Location = new System.Drawing.Point(6, 192);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(383, 36);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "Score <= 25 : Bad";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textBox4.ForeColor = System.Drawing.Color.Magenta;
            this.textBox4.Location = new System.Drawing.Point(6, 150);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(383, 36);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "Score > 25 : Good";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox3.Location = new System.Drawing.Point(6, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(383, 36);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Score > 40 : Very Good";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Location = new System.Drawing.Point(6, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(383, 36);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Score > 50 : Excellent";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(156, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(98, 46);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Rules";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbScore.Location = new System.Drawing.Point(748, 154);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(34, 39);
            this.lbScore.TabIndex = 12;
            this.lbScore.Text = "0";
            // 
            // lbKepoardPassed
            // 
            this.lbKepoardPassed.AutoSize = true;
            this.lbKepoardPassed.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbKepoardPassed.Location = new System.Drawing.Point(832, 94);
            this.lbKepoardPassed.Name = "lbKepoardPassed";
            this.lbKepoardPassed.Size = new System.Drawing.Size(0, 39);
            this.lbKepoardPassed.TabIndex = 11;
            // 
            // lbTimer
            // 
            this.lbTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbTimer.Location = new System.Drawing.Point(832, 21);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(96, 39);
            this.lbTimer.TabIndex = 10;
            this.lbTimer.Text = "00:00";
            // 
            // Score
            // 
            this.Score.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Score.Location = new System.Drawing.Point(596, 154);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(94, 34);
            this.Score.TabIndex = 9;
            this.Score.Text = "Score:";
            // 
            // kepoard
            // 
            this.kepoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kepoard.AutoSize = true;
            this.kepoard.Font = new System.Drawing.Font("Tahoma", 14F);
            this.kepoard.Location = new System.Drawing.Point(596, 94);
            this.kepoard.Name = "kepoard";
            this.kepoard.Size = new System.Drawing.Size(221, 34);
            this.kepoard.TabIndex = 8;
            this.kepoard.Text = "Kepoard Passed:";
            // 
            // Timer
            // 
            this.Timer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Timer.Location = new System.Drawing.Point(596, 21);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(96, 34);
            this.Timer.TabIndex = 7;
            this.Timer.Text = "Timer:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Navy;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(400, 212);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 81);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseClick);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Navy;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(213, 212);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(147, 81);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPause_MouseClick);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Navy;
            this.btnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            this.btnStartGame.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(6, 212);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(179, 81);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnStartGame_MouseClick);
            // 
            // cmLevel
            // 
            this.cmLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmLevel.FormattingEnabled = true;
            this.cmLevel.Items.AddRange(new object[] {
            "Easy",
            "Medeium",
            "Hard"});
            this.cmLevel.Location = new System.Drawing.Point(257, 94);
            this.cmLevel.Name = "cmLevel";
            this.cmLevel.Size = new System.Drawing.Size(138, 27);
            this.cmLevel.TabIndex = 3;
            // 
            // lbLevel
            // 
            this.lbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbLevel.Location = new System.Drawing.Point(12, 85);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(181, 34);
            this.lbLevel.TabIndex = 2;
            this.lbLevel.Text = "Choose level:";
            // 
            // lbType
            // 
            this.lbType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbType.AutoSize = true;
            this.lbType.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbType.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbType.Location = new System.Drawing.Point(12, 23);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(185, 34);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "Choose Type:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // startGameTimer
            // 
            this.startGameTimer.Interval = 1000;
            this.startGameTimer.Tick += new System.EventHandler(this.startGameTimer_Tick);
            // 
            // btnKepoard
            // 
            this.btnKepoard.BackColor = System.Drawing.SystemColors.Control;
            this.btnKepoard.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKepoard.ForeColor = System.Drawing.Color.Black;
            this.btnKepoard.Location = new System.Drawing.Point(1070, 60);
            this.btnKepoard.Name = "btnKepoard";
            this.btnKepoard.Size = new System.Drawing.Size(91, 70);
            this.btnKepoard.TabIndex = 1;
            this.btnKepoard.UseVisualStyleBackColor = false;
            this.btnKepoard.Visible = false;
            this.btnKepoard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnKepoard_KeyDown);
            this.btnKepoard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnKepoard_KeyPress);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnKepoard;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1472, 867);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKepoard);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kepoard Typing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbKepoardPassed;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label kepoard;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.ComboBox cmLevel;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer startGameTimer;
        private System.Windows.Forms.Button btnKepoard;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmType;
    }
}


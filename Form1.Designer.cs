namespace MyClicker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_Click = new System.Windows.Forms.Label();
            this.l_Missed = new System.Windows.Forms.Label();
            this.labBitcoin = new System.Windows.Forms.Label();
            this.labOver = new System.Windows.Forms.Label();
            this.labUpgCount = new System.Windows.Forms.Label();
            this.labUpgCost = new System.Windows.Forms.Label();
            this.cButUpgrade = new MyClicker.CircularButton();
            this.pB3 = new MyClicker.UserPictureBox();
            this.pB2 = new MyClicker.UserPictureBox();
            this.pB1 = new MyClicker.UserPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l_Click
            // 
            this.l_Click.AutoSize = true;
            this.l_Click.BackColor = System.Drawing.Color.Transparent;
            this.l_Click.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Click.ForeColor = System.Drawing.Color.Gold;
            this.l_Click.Location = new System.Drawing.Point(86, 9);
            this.l_Click.Name = "l_Click";
            this.l_Click.Size = new System.Drawing.Size(67, 17);
            this.l_Click.TabIndex = 1;
            this.l_Click.Text = "Clicked: 0";
            // 
            // l_Missed
            // 
            this.l_Missed.AutoSize = true;
            this.l_Missed.BackColor = System.Drawing.Color.Transparent;
            this.l_Missed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Missed.ForeColor = System.Drawing.Color.Gold;
            this.l_Missed.Location = new System.Drawing.Point(12, 9);
            this.l_Missed.Name = "l_Missed";
            this.l_Missed.Size = new System.Drawing.Size(66, 17);
            this.l_Missed.TabIndex = 2;
            this.l_Missed.Text = "Missed: 0";
            // 
            // labBitcoin
            // 
            this.labBitcoin.AutoSize = true;
            this.labBitcoin.BackColor = System.Drawing.Color.Transparent;
            this.labBitcoin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labBitcoin.ForeColor = System.Drawing.Color.Gold;
            this.labBitcoin.Location = new System.Drawing.Point(315, 9);
            this.labBitcoin.Name = "labBitcoin";
            this.labBitcoin.Size = new System.Drawing.Size(134, 17);
            this.labBitcoin.TabIndex = 4;
            this.labBitcoin.Text = "Money Per Click: 0 $";
            // 
            // labOver
            // 
            this.labOver.AutoSize = true;
            this.labOver.BackColor = System.Drawing.Color.Transparent;
            this.labOver.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labOver.ForeColor = System.Drawing.Color.OrangeRed;
            this.labOver.Location = new System.Drawing.Point(158, 248);
            this.labOver.Name = "labOver";
            this.labOver.Size = new System.Drawing.Size(130, 30);
            this.labOver.TabIndex = 5;
            this.labOver.Text = "Game-Over!";
            this.labOver.Visible = false;
            // 
            // labUpgCount
            // 
            this.labUpgCount.AutoSize = true;
            this.labUpgCount.BackColor = System.Drawing.Color.Transparent;
            this.labUpgCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labUpgCount.ForeColor = System.Drawing.Color.Gold;
            this.labUpgCount.Location = new System.Drawing.Point(172, 9);
            this.labUpgCount.Name = "labUpgCount";
            this.labUpgCount.Size = new System.Drawing.Size(122, 17);
            this.labUpgCount.TabIndex = 7;
            this.labUpgCount.Text = "Upgrades Count: 0";
            // 
            // labUpgCost
            // 
            this.labUpgCost.AutoSize = true;
            this.labUpgCost.BackColor = System.Drawing.Color.Transparent;
            this.labUpgCost.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labUpgCost.ForeColor = System.Drawing.Color.Gold;
            this.labUpgCost.Location = new System.Drawing.Point(387, 345);
            this.labUpgCost.Name = "labUpgCost";
            this.labUpgCost.Size = new System.Drawing.Size(81, 39);
            this.labUpgCost.TabIndex = 7;
            this.labUpgCost.Text = "Upgrade Cost:\r\n 5 cl\r\n\r\n";
            this.labUpgCost.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cButUpgrade
            // 
            this.cButUpgrade.BackColor = System.Drawing.Color.OrangeRed;
            this.cButUpgrade.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.cButUpgrade.FlatAppearance.BorderSize = 0;
            this.cButUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButUpgrade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cButUpgrade.ForeColor = System.Drawing.Color.SeaShell;
            this.cButUpgrade.Location = new System.Drawing.Point(408, 387);
            this.cButUpgrade.Name = "cButUpgrade";
            this.cButUpgrade.Size = new System.Drawing.Size(60, 58);
            this.cButUpgrade.TabIndex = 6;
            this.cButUpgrade.Text = "Upgrade";
            this.cButUpgrade.UseVisualStyleBackColor = false;
            this.cButUpgrade.Click += new System.EventHandler(this.cButUpgrade_Click);
            // 
            // pB3
            // 
            this.pB3.BackColor = System.Drawing.Color.Transparent;
            this.pB3.Image = global::MyClicker.Properties.Resources._1;
            this.pB3.Location = new System.Drawing.Point(321, 69);
            this.pB3.Name = "pB3";
            this.pB3.Size = new System.Drawing.Size(67, 66);
            this.pB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB3.TabIndex = 0;
            this.pB3.TabStop = false;
            this.pB3.Tag = "";
            this.pB3.Click += new System.EventHandler(this.pB3_Click);
            // 
            // pB2
            // 
            this.pB2.BackColor = System.Drawing.Color.Transparent;
            this.pB2.Image = global::MyClicker.Properties.Resources._1;
            this.pB2.Location = new System.Drawing.Point(186, 69);
            this.pB2.Name = "pB2";
            this.pB2.Size = new System.Drawing.Size(67, 66);
            this.pB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB2.TabIndex = 0;
            this.pB2.TabStop = false;
            this.pB2.Tag = "";
            this.pB2.Click += new System.EventHandler(this.pB2_Click);
            // 
            // pB1
            // 
            this.pB1.BackColor = System.Drawing.Color.Transparent;
            this.pB1.Image = global::MyClicker.Properties.Resources._1;
            this.pB1.Location = new System.Drawing.Point(62, 69);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(67, 66);
            this.pB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB1.TabIndex = 0;
            this.pB1.TabStop = false;
            this.pB1.Tag = "";
            this.pB1.Click += new System.EventHandler(this.pB1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(480, 457);
            this.Controls.Add(this.labUpgCount);
            this.Controls.Add(this.cButUpgrade);
            this.Controls.Add(this.labOver);
            this.Controls.Add(this.labBitcoin);
            this.Controls.Add(this.l_Missed);
            this.Controls.Add(this.l_Click);
            this.Controls.Add(this.pB3);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.labUpgCost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyClicker";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private UserPictureBox pB1;
        private UserPictureBox pB2;
        private UserPictureBox pB3;
        private System.Windows.Forms.Label l_Click;
        private System.Windows.Forms.Label l_Missed;
        private System.Windows.Forms.Label labBitcoin;
        private System.Windows.Forms.Label labOver;
        private CircularButton cButUpgrade;
        private System.Windows.Forms.Label labUpgCount;
        private System.Windows.Forms.Label labUpgCost;
    }
}


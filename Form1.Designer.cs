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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_Click = new System.Windows.Forms.Label();
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
            this.l_Click.Location = new System.Drawing.Point(13, 13);
            this.l_Click.Name = "l_Click";
            this.l_Click.Size = new System.Drawing.Size(67, 17);
            this.l_Click.TabIndex = 1;
            this.l_Click.Text = "Clicked: 0";
            // 
            // pB3
            // 
            this.pB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(103)))), ((int)(((byte)(26)))));
            this.pB3.Image = global::MyClicker.Properties.Resources._1;
            this.pB3.Location = new System.Drawing.Point(321, 69);
            this.pB3.Name = "pB3";
            this.pB3.Size = new System.Drawing.Size(67, 66);
            this.pB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB3.TabIndex = 0;
            this.pB3.TabStop = false;
            this.pB3.Tag = "monet";
            this.pB3.Click += new System.EventHandler(this.pB3_Click);
            // 
            // pB2
            // 
            this.pB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(103)))), ((int)(((byte)(26)))));
            this.pB2.Image = global::MyClicker.Properties.Resources._1;
            this.pB2.Location = new System.Drawing.Point(186, 69);
            this.pB2.Name = "pB2";
            this.pB2.Size = new System.Drawing.Size(67, 66);
            this.pB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB2.TabIndex = 0;
            this.pB2.TabStop = false;
            this.pB2.Tag = "monet";
            this.pB2.Click += new System.EventHandler(this.pB2_Click);
            // 
            // pB1
            // 
            this.pB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(103)))), ((int)(((byte)(26)))));
            this.pB1.Image = global::MyClicker.Properties.Resources._1;
            this.pB1.Location = new System.Drawing.Point(62, 69);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(67, 66);
            this.pB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB1.TabIndex = 0;
            this.pB1.TabStop = false;
            this.pB1.Tag = "monet";
            this.pB1.Click += new System.EventHandler(this.pB1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(480, 457);
            this.Controls.Add(this.l_Click);
            this.Controls.Add(this.pB3);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.pB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyClicker";
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
    }
}


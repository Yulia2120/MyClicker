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
            this.pB1 = new MyClicker.UserPictureBox();
            this.pB2 = new MyClicker.UserPictureBox();
            this.pB3 = new MyClicker.UserPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(480, 457);
            this.Controls.Add(this.pB3);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.pB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyClicker";
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private UserPictureBox pB1;
        private UserPictureBox pB2;
        private UserPictureBox pB3;
    }
}


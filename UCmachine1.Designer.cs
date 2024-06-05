namespace LaundryManagementSystem
{
    partial class UCmachine1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCmachine1));
            this.panelmachine = new System.Windows.Forms.Panel();
            this.confirmButton1 = new System.Windows.Forms.Button();
            this.BackButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chooseAct = new System.Windows.Forms.ComboBox();
            this.panelmachine.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmachine
            // 
            this.panelmachine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelmachine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelmachine.BackgroundImage")));
            this.panelmachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelmachine.Controls.Add(this.confirmButton1);
            this.panelmachine.Controls.Add(this.BackButton1);
            this.panelmachine.Controls.Add(this.label1);
            this.panelmachine.Controls.Add(this.panel1);
            this.panelmachine.Controls.Add(this.pictureBox1);
            this.panelmachine.Location = new System.Drawing.Point(0, 0);
            this.panelmachine.Name = "panelmachine";
            this.panelmachine.Size = new System.Drawing.Size(725, 558);
            this.panelmachine.TabIndex = 0;
            this.panelmachine.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmachine_Paint);
            // 
            // confirmButton1
            // 
            this.confirmButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton1.Location = new System.Drawing.Point(554, 386);
            this.confirmButton1.Name = "confirmButton1";
            this.confirmButton1.Size = new System.Drawing.Size(105, 33);
            this.confirmButton1.TabIndex = 8;
            this.confirmButton1.Text = "Confirm";
            this.confirmButton1.UseVisualStyleBackColor = true;
            // 
            // BackButton1
            // 
            this.BackButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton1.Location = new System.Drawing.Point(3, 3);
            this.BackButton1.Name = "BackButton1";
            this.BackButton1.Size = new System.Drawing.Size(93, 31);
            this.BackButton1.TabIndex = 4;
            this.BackButton1.Text = "Back";
            this.BackButton1.UseVisualStyleBackColor = false;
            this.BackButton1.Click += new System.EventHandler(this.BackButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Laundry Machine 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.chooseAct);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(260, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 274);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Action:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 322);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // chooseAct
            // 
            this.chooseAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseAct.FormattingEnabled = true;
            this.chooseAct.Location = new System.Drawing.Point(7, 46);
            this.chooseAct.Name = "chooseAct";
            this.chooseAct.Size = new System.Drawing.Size(146, 28);
            this.chooseAct.TabIndex = 2;
            this.chooseAct.Text = "    -Action Here-";
            // 
            // UCmachine1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelmachine);
            this.Name = "UCmachine1";
            this.Size = new System.Drawing.Size(725, 558);
            this.panelmachine.ResumeLayout(false);
            this.panelmachine.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton1;
        private System.Windows.Forms.Button confirmButton1;
        private System.Windows.Forms.Panel panelmachine;
        private System.Windows.Forms.ComboBox chooseAct;
    }
}

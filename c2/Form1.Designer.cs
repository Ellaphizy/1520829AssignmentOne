namespace c2
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
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.Listbox = new System.Windows.Forms.ListBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Level0 = new System.Windows.Forms.Button();
            this.Level1 = new System.Windows.Forms.Button();
            this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(720, 319);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(75, 23);
            this.down.TabIndex = 1;
            this.down.Text = "down";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(679, 385);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 23);
            this.up.TabIndex = 2;
            this.up.Text = "up";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(-2, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 230);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(135, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 230);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(-2, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 233);
            this.panel4.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PictureBox);
            this.panel1.Location = new System.Drawing.Point(307, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 469);
            this.panel1.TabIndex = 0;
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::c2.Properties.Resources.Rect;
            this.PictureBox.Location = new System.Drawing.Point(-2, 290);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(271, 177);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Location = new System.Drawing.Point(444, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(134, 233);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Listbox
            // 
            this.Listbox.FormattingEnabled = true;
            this.Listbox.Location = new System.Drawing.Point(691, 49);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(226, 160);
            this.Listbox.TabIndex = 5;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(609, 459);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(34, 59);
            this.ProgressBar.TabIndex = 6;
            // 
            // timer5
            // 
            this.timer5.Interval = 10;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 10;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label);
            this.flowLayoutPanel1.Controls.Add(this.Level0);
            this.flowLayoutPanel1.Controls.Add(this.Level1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(145, 170);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control Panel";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(3, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 32);
            this.label.TabIndex = 8;
            // 
            // Level0
            // 
            this.Level0.Location = new System.Drawing.Point(3, 59);
            this.Level0.Name = "Level0";
            this.Level0.Size = new System.Drawing.Size(75, 23);
            this.Level0.TabIndex = 8;
            this.Level0.Text = "0";
            this.Level0.UseVisualStyleBackColor = true;
            // 
            // Level1
            // 
            this.Level1.Location = new System.Drawing.Point(3, 88);
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(75, 23);
            this.Level1.TabIndex = 9;
            this.Level1.Text = "1";
            this.Level1.UseVisualStyleBackColor = true;
            this.Level1.Click += new System.EventHandler(this.Level1_Click);
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.Location = new System.Drawing.Point(252, 49);
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.Size = new System.Drawing.Size(34, 59);
            this.ProgressBar2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 601);
            this.Controls.Add(this.ProgressBar2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Listbox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.up);
            this.Controls.Add(this.down);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "li";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.ListBox Listbox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Level0;
        private System.Windows.Forms.Button Level1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ProgressBar2;
    }
}


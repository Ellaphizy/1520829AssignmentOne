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
            this.FloorOne = new System.Windows.Forms.Button();
            this.FloorZero = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Floor0Doors = new System.Windows.Forms.Timer(this.components);
            this.LiftUp = new System.Windows.Forms.Timer(this.components);
            this.Floor1Doors = new System.Windows.Forms.Timer(this.components);
            this.LiftDown = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.FloorOneDoors = new System.Windows.Forms.Timer(this.components);
            this.FloorZeroDoors = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Level0 = new System.Windows.Forms.Button();
            this.Level1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Listview = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Showtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowDirection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventLog = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FloorOne
            // 
            this.FloorOne.Location = new System.Drawing.Point(656, 189);
            this.FloorOne.Name = "FloorOne";
            this.FloorOne.Size = new System.Drawing.Size(75, 23);
            this.FloorOne.TabIndex = 1;
            this.FloorOne.Text = "Floor 1";
            this.FloorOne.UseVisualStyleBackColor = true;
            this.FloorOne.Click += new System.EventHandler(this.down_Click);
            // 
            // FloorZero
            // 
            this.FloorZero.Location = new System.Drawing.Point(656, 495);
            this.FloorZero.Name = "FloorZero";
            this.FloorZero.Size = new System.Drawing.Size(75, 23);
            this.FloorZero.TabIndex = 2;
            this.FloorZero.Text = "Floor 0";
            this.FloorZero.UseVisualStyleBackColor = true;
            this.FloorZero.Click += new System.EventHandler(this.up_Click);
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
            // Floor0Doors
            // 
            this.Floor0Doors.Interval = 10;
            this.Floor0Doors.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LiftUp
            // 
            this.LiftUp.Interval = 10;
            this.LiftUp.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Floor1Doors
            // 
            this.Floor1Doors.Interval = 10;
            this.Floor1Doors.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // LiftDown
            // 
            this.LiftDown.Interval = 10;
            this.LiftDown.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // ProgressBar
            // 
            this.ProgressBar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProgressBar.Location = new System.Drawing.Point(594, 459);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(23, 59);
            this.ProgressBar.TabIndex = 6;
            // 
            // FloorOneDoors
            // 
            this.FloorOneDoors.Interval = 10;
            this.FloorOneDoors.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // FloorZeroDoors
            // 
            this.FloorZeroDoors.Interval = 10;
            this.FloorZeroDoors.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label);
            this.flowLayoutPanel1.Controls.Add(this.Level0);
            this.flowLayoutPanel1.Controls.Add(this.Level1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(95, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(125, 170);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control Panel";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(3, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 32);
            this.label.TabIndex = 8;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Level0
            // 
            this.Level0.Location = new System.Drawing.Point(3, 55);
            this.Level0.Name = "Level0";
            this.Level0.Size = new System.Drawing.Size(75, 23);
            this.Level0.TabIndex = 8;
            this.Level0.Text = "0";
            this.Level0.UseVisualStyleBackColor = true;
            this.Level0.Click += new System.EventHandler(this.Level0_Click);
            // 
            // Level1
            // 
            this.Level1.Location = new System.Drawing.Point(3, 84);
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(75, 23);
            this.Level1.TabIndex = 9;
            this.Level1.Text = "1";
            this.Level1.UseVisualStyleBackColor = true;
            this.Level1.Click += new System.EventHandler(this.Level1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(888, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Display Events";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1100, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Listview
            // 
            this.Listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Status,
            this.Showtime,
            this.ShowDate,
            this.ShowDirection});
            this.Listview.Location = new System.Drawing.Point(748, 68);
            this.Listview.Name = "Listview";
            this.Listview.Size = new System.Drawing.Size(462, 369);
            this.Listview.TabIndex = 12;
            this.Listview.UseCompatibleStateImageBehavior = false;
            this.Listview.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 71;
            // 
            // Showtime
            // 
            this.Showtime.Text = "Time";
            this.Showtime.Width = 91;
            // 
            // ShowDate
            // 
            this.ShowDate.Text = "Date";
            this.ShowDate.Width = 122;
            // 
            // ShowDirection
            // 
            this.ShowDirection.Text = "Direction";
            this.ShowDirection.Width = 118;
            // 
            // EventLog
            // 
            this.EventLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLog.Location = new System.Drawing.Point(851, 18);
            this.EventLog.Name = "EventLog";
            this.EventLog.Size = new System.Drawing.Size(238, 38);
            this.EventLog.TabIndex = 13;
            this.EventLog.Text = "Event Log";
            this.EventLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1231, 601);
            this.Controls.Add(this.EventLog);
            this.Controls.Add(this.Listview);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.FloorZero);
            this.Controls.Add(this.FloorOne);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Elevator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FloorOne;
        private System.Windows.Forms.Button FloorZero;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Timer Floor0Doors;
        private System.Windows.Forms.Timer LiftUp;
        private System.Windows.Forms.Timer Floor1Doors;
        private System.Windows.Forms.Timer LiftDown;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Timer FloorOneDoors;
        private System.Windows.Forms.Timer FloorZeroDoors;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Level0;
        private System.Windows.Forms.Button Level1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView Listview;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Showtime;
        private System.Windows.Forms.ColumnHeader ShowDate;
        private System.Windows.Forms.ColumnHeader ShowDirection;
        private System.Windows.Forms.Label EventLog;
    }
}


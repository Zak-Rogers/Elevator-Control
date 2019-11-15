namespace Elevator_Control
{
    partial class ElevatorSystem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtF1Display = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnF1Request = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtF0Display = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnF0Request = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEDisplay = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnFloor0 = new System.Windows.Forms.Button();
            this.btnFloor1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pBoxDoorR = new System.Windows.Forms.PictureBox();
            this.pBoxDoorL = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pBoxElevator = new System.Windows.Forms.PictureBox();
            this.gBoxLog = new System.Windows.Forms.GroupBox();
            this.dataViewLog = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDoorR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDoorL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxElevator)).BeginInit();
            this.gBoxLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtF1Display);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnF1Request);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Floor 1";
            // 
            // txtF1Display
            // 
            this.txtF1Display.Enabled = false;
            this.txtF1Display.Location = new System.Drawing.Point(117, 48);
            this.txtF1Display.Name = "txtF1Display";
            this.txtF1Display.Size = new System.Drawing.Size(26, 20);
            this.txtF1Display.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elevator on floor: ";
            // 
            // btnF1Request
            // 
            this.btnF1Request.BackColor = System.Drawing.Color.LightGray;
            this.btnF1Request.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnF1Request.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnF1Request.Location = new System.Drawing.Point(52, 74);
            this.btnF1Request.Name = "btnF1Request";
            this.btnF1Request.Size = new System.Drawing.Size(91, 68);
            this.btnF1Request.TabIndex = 0;
            this.btnF1Request.Text = "Request";
            this.btnF1Request.UseVisualStyleBackColor = false;
            this.btnF1Request.Click += new System.EventHandler(this.Floor1Btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtF0Display);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnF0Request);
            this.groupBox2.Location = new System.Drawing.Point(12, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ground Floor";
            // 
            // txtF0Display
            // 
            this.txtF0Display.Enabled = false;
            this.txtF0Display.Location = new System.Drawing.Point(117, 39);
            this.txtF0Display.Name = "txtF0Display";
            this.txtF0Display.Size = new System.Drawing.Size(26, 20);
            this.txtF0Display.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elevator on floor: ";
            // 
            // btnF0Request
            // 
            this.btnF0Request.BackColor = System.Drawing.Color.LightGray;
            this.btnF0Request.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnF0Request.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnF0Request.Location = new System.Drawing.Point(52, 65);
            this.btnF0Request.Name = "btnF0Request";
            this.btnF0Request.Size = new System.Drawing.Size(91, 68);
            this.btnF0Request.TabIndex = 0;
            this.btnF0Request.Text = "Request";
            this.btnF0Request.UseVisualStyleBackColor = false;
            this.btnF0Request.Click += new System.EventHandler(this.Floor0Btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEDisplay);
            this.groupBox3.Controls.Add(this.btnLog);
            this.groupBox3.Controls.Add(this.btnFloor0);
            this.groupBox3.Controls.Add(this.btnFloor1);
            this.groupBox3.Location = new System.Drawing.Point(449, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 194);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elevator Control Panel";
            // 
            // txtEDisplay
            // 
            this.txtEDisplay.Enabled = false;
            this.txtEDisplay.Location = new System.Drawing.Point(34, 57);
            this.txtEDisplay.Name = "txtEDisplay";
            this.txtEDisplay.Size = new System.Drawing.Size(94, 20);
            this.txtEDisplay.TabIndex = 1;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.LightGray;
            this.btnLog.Location = new System.Drawing.Point(34, 165);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // btnFloor0
            // 
            this.btnFloor0.BackColor = System.Drawing.Color.LightGray;
            this.btnFloor0.Location = new System.Drawing.Point(34, 112);
            this.btnFloor0.Name = "btnFloor0";
            this.btnFloor0.Size = new System.Drawing.Size(94, 23);
            this.btnFloor0.TabIndex = 0;
            this.btnFloor0.Text = "Ground Floor";
            this.btnFloor0.UseVisualStyleBackColor = false;
            this.btnFloor0.Click += new System.EventHandler(this.Floor0Btn_Click);
            // 
            // btnFloor1
            // 
            this.btnFloor1.BackColor = System.Drawing.Color.LightGray;
            this.btnFloor1.Location = new System.Drawing.Point(34, 83);
            this.btnFloor1.Name = "btnFloor1";
            this.btnFloor1.Size = new System.Drawing.Size(94, 23);
            this.btnFloor1.TabIndex = 0;
            this.btnFloor1.Text = "Floor 1";
            this.btnFloor1.UseVisualStyleBackColor = false;
            this.btnFloor1.Click += new System.EventHandler(this.Floor1Btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pBoxDoorR);
            this.groupBox4.Controls.Add(this.pBoxDoorL);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.pBoxElevator);
            this.groupBox4.Location = new System.Drawing.Point(449, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 250);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Animation";
            // 
            // pBoxDoorR
            // 
            this.pBoxDoorR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxDoorR.Image = global::Elevator_Control.Properties.Resources.Elevator_Door;
            this.pBoxDoorR.Location = new System.Drawing.Point(140, 120);
            this.pBoxDoorR.Name = "pBoxDoorR";
            this.pBoxDoorR.Size = new System.Drawing.Size(50, 100);
            this.pBoxDoorR.TabIndex = 4;
            this.pBoxDoorR.TabStop = false;
            // 
            // pBoxDoorL
            // 
            this.pBoxDoorL.BackColor = System.Drawing.Color.Gray;
            this.pBoxDoorL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxDoorL.Image = global::Elevator_Control.Properties.Resources.Elevator_Door;
            this.pBoxDoorL.Location = new System.Drawing.Point(90, 120);
            this.pBoxDoorL.Name = "pBoxDoorL";
            this.pBoxDoorL.Size = new System.Drawing.Size(50, 100);
            this.pBoxDoorL.TabIndex = 3;
            this.pBoxDoorL.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ground Floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Floor 1";
            // 
            // pBoxElevator
            // 
            this.pBoxElevator.BackColor = System.Drawing.Color.Gray;
            this.pBoxElevator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxElevator.Image = global::Elevator_Control.Properties.Resources.Elevator_Open;
            this.pBoxElevator.Location = new System.Drawing.Point(90, 120);
            this.pBoxElevator.Name = "pBoxElevator";
            this.pBoxElevator.Size = new System.Drawing.Size(100, 100);
            this.pBoxElevator.TabIndex = 1;
            this.pBoxElevator.TabStop = false;
            // 
            // gBoxLog
            // 
            this.gBoxLog.Controls.Add(this.dataViewLog);
            this.gBoxLog.Location = new System.Drawing.Point(220, 13);
            this.gBoxLog.Name = "gBoxLog";
            this.gBoxLog.Size = new System.Drawing.Size(223, 503);
            this.gBoxLog.TabIndex = 4;
            this.gBoxLog.TabStop = false;
            this.gBoxLog.Text = "Log";
            this.gBoxLog.Visible = false;
            // 
            // dataViewLog
            // 
            this.dataViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewLog.Location = new System.Drawing.Point(6, 19);
            this.dataViewLog.Name = "dataViewLog";
            this.dataViewLog.Size = new System.Drawing.Size(211, 478);
            this.dataViewLog.TabIndex = 0;
            // 
            // ElevatorSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 604);
            this.Controls.Add(this.gBoxLog);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ElevatorSystem";
            this.Text = "Elevator System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDoorR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDoorL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxElevator)).EndInit();
            this.gBoxLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnF1Request;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnF0Request;
        private System.Windows.Forms.Button btnFloor0;
        private System.Windows.Forms.Button btnFloor1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.TextBox txtF1Display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtF0Display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtEDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pBoxElevator;
        private System.Windows.Forms.GroupBox gBoxLog;
        private System.Windows.Forms.DataGridView dataViewLog;
        private System.Windows.Forms.PictureBox pBoxDoorL;
        private System.Windows.Forms.PictureBox pBoxDoorR;
    }
}


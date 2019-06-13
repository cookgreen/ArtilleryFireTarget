namespace BallisticSimulator
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRandomize = new System.Windows.Forms.RadioButton();
            this.rbFixedValue = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRandomizeAngleUp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRandomizeAngleDown = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRandomizeSpeedDown = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRandomizeGravity = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGravity = new System.Windows.Forms.TextBox();
            this.lbMouseY = new System.Windows.Forms.Label();
            this.lbMouseX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.txtRandomizeSpeedUp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 563);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRandomize);
            this.groupBox1.Controls.Add(this.rbFixedValue);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lbMouseY);
            this.groupBox1.Controls.Add(this.lbMouseX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(484, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 557);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // rbRandomize
            // 
            this.rbRandomize.AutoSize = true;
            this.rbRandomize.Location = new System.Drawing.Point(12, 152);
            this.rbRandomize.Name = "rbRandomize";
            this.rbRandomize.Size = new System.Drawing.Size(77, 16);
            this.rbRandomize.TabIndex = 15;
            this.rbRandomize.Text = "Randomize";
            this.rbRandomize.UseVisualStyleBackColor = true;
            this.rbRandomize.CheckedChanged += new System.EventHandler(this.rbRandomize_CheckedChanged);
            // 
            // rbFixedValue
            // 
            this.rbFixedValue.AutoSize = true;
            this.rbFixedValue.Checked = true;
            this.rbFixedValue.Location = new System.Drawing.Point(12, 21);
            this.rbFixedValue.Name = "rbFixedValue";
            this.rbFixedValue.Size = new System.Drawing.Size(89, 16);
            this.rbFixedValue.TabIndex = 14;
            this.rbFixedValue.TabStop = true;
            this.rbFixedValue.Text = "Fixed Value";
            this.rbFixedValue.UseVisualStyleBackColor = true;
            this.rbFixedValue.CheckedChanged += new System.EventHandler(this.rbFixedValue_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtRandomizeSpeedUp);
            this.groupBox4.Controls.Add(this.txtInterval);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtDura);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtAmount);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtRandomizeAngleUp);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtRandomizeAngleDown);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtRandomizeSpeedDown);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtRandomizeGravity);
            this.groupBox4.Location = new System.Drawing.Point(6, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 220);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // txtInterval
            // 
            this.txtInterval.Enabled = false;
            this.txtInterval.Location = new System.Drawing.Point(78, 182);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(198, 21);
            this.txtInterval.TabIndex = 13;
            this.txtInterval.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "Interval";
            // 
            // txtDura
            // 
            this.txtDura.Enabled = false;
            this.txtDura.Location = new System.Drawing.Point(78, 146);
            this.txtDura.Name = "txtDura";
            this.txtDura.Size = new System.Drawing.Size(198, 21);
            this.txtDura.TabIndex = 11;
            this.txtDura.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "Duration:";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(78, 114);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(198, 21);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.Text = "20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "Amount:";
            // 
            // txtRandomizeAngleUp
            // 
            this.txtRandomizeAngleUp.Enabled = false;
            this.txtRandomizeAngleUp.Location = new System.Drawing.Point(208, 14);
            this.txtRandomizeAngleUp.Name = "txtRandomizeAngleUp";
            this.txtRandomizeAngleUp.Size = new System.Drawing.Size(68, 21);
            this.txtRandomizeAngleUp.TabIndex = 7;
            this.txtRandomizeAngleUp.Text = "120";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Angle:";
            // 
            // txtRandomizeAngleDown
            // 
            this.txtRandomizeAngleDown.Enabled = false;
            this.txtRandomizeAngleDown.Location = new System.Drawing.Point(78, 14);
            this.txtRandomizeAngleDown.Name = "txtRandomizeAngleDown";
            this.txtRandomizeAngleDown.Size = new System.Drawing.Size(67, 21);
            this.txtRandomizeAngleDown.TabIndex = 1;
            this.txtRandomizeAngleDown.Text = "45";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Speed:";
            // 
            // txtRandomizeSpeedDown
            // 
            this.txtRandomizeSpeedDown.Enabled = false;
            this.txtRandomizeSpeedDown.Location = new System.Drawing.Point(78, 47);
            this.txtRandomizeSpeedDown.Name = "txtRandomizeSpeedDown";
            this.txtRandomizeSpeedDown.Size = new System.Drawing.Size(67, 21);
            this.txtRandomizeSpeedDown.TabIndex = 3;
            this.txtRandomizeSpeedDown.Text = "50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Gravity:";
            // 
            // txtRandomizeGravity
            // 
            this.txtRandomizeGravity.Enabled = false;
            this.txtRandomizeGravity.Location = new System.Drawing.Point(78, 80);
            this.txtRandomizeGravity.Name = "txtRandomizeGravity";
            this.txtRandomizeGravity.Size = new System.Drawing.Size(198, 21);
            this.txtRandomizeGravity.TabIndex = 5;
            this.txtRandomizeGravity.Text = "9.8";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtAngle);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtSpeed);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtGravity);
            this.groupBox3.Location = new System.Drawing.Point(6, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 112);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angle:";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(78, 14);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(198, 21);
            this.txtAngle.TabIndex = 1;
            this.txtAngle.Text = "45";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speed:";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(78, 47);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(198, 21);
            this.txtSpeed.TabIndex = 3;
            this.txtSpeed.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gravity:";
            // 
            // txtGravity
            // 
            this.txtGravity.Location = new System.Drawing.Point(78, 80);
            this.txtGravity.Name = "txtGravity";
            this.txtGravity.Size = new System.Drawing.Size(198, 21);
            this.txtGravity.TabIndex = 5;
            this.txtGravity.Text = "9.8";
            // 
            // lbMouseY
            // 
            this.lbMouseY.AutoSize = true;
            this.lbMouseY.Location = new System.Drawing.Point(82, 432);
            this.lbMouseY.Name = "lbMouseY";
            this.lbMouseY.Size = new System.Drawing.Size(11, 12);
            this.lbMouseY.TabIndex = 9;
            this.lbMouseY.Text = "0";
            // 
            // lbMouseX
            // 
            this.lbMouseX.AutoSize = true;
            this.lbMouseX.Location = new System.Drawing.Point(82, 401);
            this.lbMouseX.Name = "lbMouseX";
            this.lbMouseX.Size = new System.Drawing.Size(11, 12);
            this.lbMouseX.TabIndex = 8;
            this.lbMouseX.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mouse Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mouse X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.canvas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 557);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Render";
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(3, 17);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(469, 537);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // txtRandomizeSpeedUp
            // 
            this.txtRandomizeSpeedUp.Enabled = false;
            this.txtRandomizeSpeedUp.Location = new System.Drawing.Point(208, 47);
            this.txtRandomizeSpeedUp.Name = "txtRandomizeSpeedUp";
            this.txtRandomizeSpeedUp.Size = new System.Drawing.Size(68, 21);
            this.txtRandomizeSpeedUp.TabIndex = 14;
            this.txtRandomizeSpeedUp.Text = "100";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "-";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ballistic Simulator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtGravity;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMouseY;
        private System.Windows.Forms.Label lbMouseX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRandomizeAngleDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRandomizeSpeedDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRandomizeGravity;
        private System.Windows.Forms.TextBox txtRandomizeAngleUp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDura;
        private System.Windows.Forms.RadioButton rbFixedValue;
        private System.Windows.Forms.RadioButton rbRandomize;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRandomizeSpeedUp;
        private System.Windows.Forms.Label label13;
    }
}


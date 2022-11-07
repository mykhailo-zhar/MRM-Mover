
namespace MPM_Lab_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Command = new System.Windows.Forms.TextBox();
            this.IdentifyButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProgramRB = new System.Windows.Forms.RadioButton();
            this.ManualRB = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.ShowGrep = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShowU2 = new System.Windows.Forms.TextBox();
            this.ShowU1 = new System.Windows.Forms.TextBox();
            this.ShowZx = new System.Windows.Forms.TextBox();
            this.ShowY = new System.Windows.Forms.TextBox();
            this.ShowX = new System.Windows.Forms.TextBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_Y = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.UI_X = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UI_Uz = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.UI_U2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.UI_U1 = new System.Windows.Forms.NumericUpDown();
            this.Grep = new System.Windows.Forms.Button();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Uz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_U2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_U1)).BeginInit();
            this.SuspendLayout();
            // 
            // Command
            // 
            this.Command.Location = new System.Drawing.Point(31, 27);
            this.Command.Multiline = true;
            this.Command.Name = "Command";
            this.Command.PlaceholderText = "Enter the value";
            this.Command.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Command.Size = new System.Drawing.Size(152, 84);
            this.Command.TabIndex = 0;
            // 
            // IdentifyButton
            // 
            this.IdentifyButton.Location = new System.Drawing.Point(31, 146);
            this.IdentifyButton.Name = "IdentifyButton";
            this.IdentifyButton.Size = new System.Drawing.Size(70, 23);
            this.IdentifyButton.TabIndex = 1;
            this.IdentifyButton.Text = "Identify";
            this.IdentifyButton.UseVisualStyleBackColor = true;
            this.IdentifyButton.Click += new System.EventHandler(this.IdentifyButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(6, 391);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(95, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(31, 175);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(70, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(112, 146);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(71, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProgramRB);
            this.groupBox1.Controls.Add(this.ManualRB);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ShowGrep);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ShowU2);
            this.groupBox1.Controls.Add(this.ShowU1);
            this.groupBox1.Controls.Add(this.ShowZx);
            this.groupBox1.Controls.Add(this.ShowY);
            this.groupBox1.Controls.Add(this.ShowX);
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Controls.Add(this.Info);
            this.groupBox1.Controls.Add(this.LoadButton);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.Command);
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.IdentifyButton);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(270, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 450);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // ProgramRB
            // 
            this.ProgramRB.AutoSize = true;
            this.ProgramRB.Checked = true;
            this.ProgramRB.Location = new System.Drawing.Point(107, 419);
            this.ProgramRB.Name = "ProgramRB";
            this.ProgramRB.Size = new System.Drawing.Size(71, 19);
            this.ProgramRB.TabIndex = 34;
            this.ProgramRB.TabStop = true;
            this.ProgramRB.Text = "Program";
            this.ProgramRB.UseVisualStyleBackColor = true;
            this.ProgramRB.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
            // 
            // ManualRB
            // 
            this.ManualRB.AutoSize = true;
            this.ManualRB.Location = new System.Drawing.Point(6, 419);
            this.ManualRB.Name = "ManualRB";
            this.ManualRB.Size = new System.Drawing.Size(65, 19);
            this.ManualRB.TabIndex = 33;
            this.ManualRB.Text = "Manual";
            this.ManualRB.UseVisualStyleBackColor = true;
            this.ManualRB.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 32;
            this.label13.Text = "Grep:";
            // 
            // ShowGrep
            // 
            this.ShowGrep.Location = new System.Drawing.Point(68, 362);
            this.ShowGrep.Name = "ShowGrep";
            this.ShowGrep.ReadOnly = true;
            this.ShowGrep.Size = new System.Drawing.Size(126, 23);
            this.ShowGrep.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "U2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "U1:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "C:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "X:";
            // 
            // ShowU2
            // 
            this.ShowU2.BackColor = System.Drawing.Color.White;
            this.ShowU2.Location = new System.Drawing.Point(31, 333);
            this.ShowU2.Name = "ShowU2";
            this.ShowU2.ReadOnly = true;
            this.ShowU2.Size = new System.Drawing.Size(163, 23);
            this.ShowU2.TabIndex = 14;
            this.ShowU2.Text = "0.00";
            this.ShowU2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowU1
            // 
            this.ShowU1.BackColor = System.Drawing.Color.White;
            this.ShowU1.Location = new System.Drawing.Point(31, 304);
            this.ShowU1.Name = "ShowU1";
            this.ShowU1.ReadOnly = true;
            this.ShowU1.Size = new System.Drawing.Size(163, 23);
            this.ShowU1.TabIndex = 13;
            this.ShowU1.Text = "0.00";
            this.ShowU1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowZx
            // 
            this.ShowZx.BackColor = System.Drawing.Color.White;
            this.ShowZx.Location = new System.Drawing.Point(31, 275);
            this.ShowZx.Name = "ShowZx";
            this.ShowZx.ReadOnly = true;
            this.ShowZx.Size = new System.Drawing.Size(163, 23);
            this.ShowZx.TabIndex = 12;
            this.ShowZx.Text = "0.00";
            this.ShowZx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowY
            // 
            this.ShowY.BackColor = System.Drawing.Color.White;
            this.ShowY.Location = new System.Drawing.Point(31, 246);
            this.ShowY.Name = "ShowY";
            this.ShowY.ReadOnly = true;
            this.ShowY.Size = new System.Drawing.Size(163, 23);
            this.ShowY.TabIndex = 11;
            this.ShowY.Text = "0.00";
            this.ShowY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowX
            // 
            this.ShowX.BackColor = System.Drawing.Color.White;
            this.ShowX.Location = new System.Drawing.Point(31, 217);
            this.ShowX.Name = "ShowX";
            this.ShowX.ReadOnly = true;
            this.ShowX.Size = new System.Drawing.Size(163, 23);
            this.ShowX.TabIndex = 10;
            this.ShowX.Text = "0.00";
            this.ShowX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(107, 391);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(87, 23);
            this.StopButton.TabIndex = 8;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(31, 117);
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Size = new System.Drawing.Size(152, 23);
            this.Info.TabIndex = 7;
            this.Info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(113, 175);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(70, 23);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(90, 27);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(115, 23);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Movement speed:";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Y:";
            // 
            // UI_Y
            // 
            this.UI_Y.DecimalPlaces = 2;
            this.UI_Y.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.UI_Y.Location = new System.Drawing.Point(90, 157);
            this.UI_Y.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.UI_Y.Name = "UI_Y";
            this.UI_Y.Size = new System.Drawing.Size(115, 23);
            this.UI_Y.TabIndex = 16;
            this.UI_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "X:";
            // 
            // UI_X
            // 
            this.UI_X.DecimalPlaces = 2;
            this.UI_X.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.UI_X.Location = new System.Drawing.Point(90, 128);
            this.UI_X.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.UI_X.Name = "UI_X";
            this.UI_X.Size = new System.Drawing.Size(115, 23);
            this.UI_X.TabIndex = 14;
            this.UI_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(90, 71);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(115, 23);
            this.numericUpDown2.TabIndex = 18;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Rotation speed:";
            this.label2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "C:";
            // 
            // UI_Uz
            // 
            this.UI_Uz.DecimalPlaces = 2;
            this.UI_Uz.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.UI_Uz.Location = new System.Drawing.Point(90, 186);
            this.UI_Uz.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.UI_Uz.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.UI_Uz.Name = "UI_Uz";
            this.UI_Uz.Size = new System.Drawing.Size(115, 23);
            this.UI_Uz.TabIndex = 20;
            this.UI_Uz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "U2:";
            // 
            // UI_U2
            // 
            this.UI_U2.DecimalPlaces = 2;
            this.UI_U2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.UI_U2.Location = new System.Drawing.Point(90, 272);
            this.UI_U2.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.UI_U2.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.UI_U2.Name = "UI_U2";
            this.UI_U2.Size = new System.Drawing.Size(115, 23);
            this.UI_U2.TabIndex = 24;
            this.UI_U2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "U1:";
            // 
            // UI_U1
            // 
            this.UI_U1.DecimalPlaces = 2;
            this.UI_U1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.UI_U1.Location = new System.Drawing.Point(90, 243);
            this.UI_U1.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.UI_U1.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.UI_U1.Name = "UI_U1";
            this.UI_U1.Size = new System.Drawing.Size(115, 23);
            this.UI_U1.TabIndex = 22;
            this.UI_U1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Grep
            // 
            this.Grep.Location = new System.Drawing.Point(90, 361);
            this.Grep.Name = "Grep";
            this.Grep.Size = new System.Drawing.Size(115, 23);
            this.Grep.TabIndex = 26;
            this.Grep.Text = "Grep";
            this.Grep.UseVisualStyleBackColor = true;
            this.Grep.Click += new System.EventHandler(this.Grep_Click);
            // 
            // Clock
            // 
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(12, 415);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 36;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Grep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UI_U2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UI_U1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UI_Uz);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_Y);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_X);
            this.Location = new System.Drawing.Point(1920, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MPM Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Uz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_U2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_U1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.Button IdentifyButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UI_Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown UI_X;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown UI_Uz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown UI_U2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown UI_U1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ShowU2;
        private System.Windows.Forms.TextBox ShowU1;
        private System.Windows.Forms.TextBox ShowZx;
        private System.Windows.Forms.TextBox ShowY;
        private System.Windows.Forms.TextBox ShowX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ShowGrep;
        private System.Windows.Forms.Button Grep;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.RadioButton ProgramRB;
        private System.Windows.Forms.RadioButton ManualRB;
        private System.Windows.Forms.Button Reset;
    }
}


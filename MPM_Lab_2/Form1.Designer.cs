
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
            this.Command = new System.Windows.Forms.TextBox();
            this.IdentifyButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Command
            // 
            this.Command.Location = new System.Drawing.Point(31, 27);
            this.Command.Multiline = true;
            this.Command.Name = "Command";
            this.Command.PlaceholderText = "Enter the value";
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
            this.StartButton.Location = new System.Drawing.Point(6, 230);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(55, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.ResumeButton);
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Controls.Add(this.Info);
            this.groupBox1.Controls.Add(this.LoadButton);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.Command);
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.IdentifyButton);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 450);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(68, 230);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(65, 23);
            this.ResumeButton.TabIndex = 9;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(139, 230);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(55, 23);
            this.StopButton.TabIndex = 8;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MPM Console";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Button StopButton;
    }
}


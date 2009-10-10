namespace Tester
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceScriptsFolderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceServerNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceDatabaseNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sourceDbUserNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sourcePasswordTextBox = new System.Windows.Forms.TextBox();
            this.destinationPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.destinationDbUserNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.destinationDbNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.destinationServerNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.executeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sourcePasswordTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sourceDbUserNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sourceDatabaseNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sourceServerNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sourceScriptsFolderTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.destinationPasswordTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.destinationDbUserNameTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.destinationDbNameTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.destinationServerNameTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(13, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 208);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scripts Folder:";
            // 
            // sourceScriptsFolderTextBox
            // 
            this.sourceScriptsFolderTextBox.Location = new System.Drawing.Point(10, 37);
            this.sourceScriptsFolderTextBox.Name = "sourceScriptsFolderTextBox";
            this.sourceScriptsFolderTextBox.Size = new System.Drawing.Size(243, 20);
            this.sourceScriptsFolderTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Name:";
            // 
            // sourceServerNameTextBox
            // 
            this.sourceServerNameTextBox.Location = new System.Drawing.Point(10, 81);
            this.sourceServerNameTextBox.Name = "sourceServerNameTextBox";
            this.sourceServerNameTextBox.Size = new System.Drawing.Size(243, 20);
            this.sourceServerNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Database Name:";
            // 
            // sourceDatabaseNameTextBox
            // 
            this.sourceDatabaseNameTextBox.Location = new System.Drawing.Point(10, 125);
            this.sourceDatabaseNameTextBox.Name = "sourceDatabaseNameTextBox";
            this.sourceDatabaseNameTextBox.Size = new System.Drawing.Size(243, 20);
            this.sourceDatabaseNameTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "User Name:";
            // 
            // sourceDbUserNameTextBox
            // 
            this.sourceDbUserNameTextBox.Location = new System.Drawing.Point(10, 169);
            this.sourceDbUserNameTextBox.Name = "sourceDbUserNameTextBox";
            this.sourceDbUserNameTextBox.Size = new System.Drawing.Size(243, 20);
            this.sourceDbUserNameTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password:";
            // 
            // sourcePasswordTextBox
            // 
            this.sourcePasswordTextBox.Location = new System.Drawing.Point(10, 216);
            this.sourcePasswordTextBox.Name = "sourcePasswordTextBox";
            this.sourcePasswordTextBox.Size = new System.Drawing.Size(243, 20);
            this.sourcePasswordTextBox.TabIndex = 9;
            // 
            // destinationPasswordTextBox
            // 
            this.destinationPasswordTextBox.Location = new System.Drawing.Point(6, 176);
            this.destinationPasswordTextBox.Name = "destinationPasswordTextBox";
            this.destinationPasswordTextBox.Size = new System.Drawing.Size(243, 20);
            this.destinationPasswordTextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password:";
            // 
            // destinationDbUserNameTextBox
            // 
            this.destinationDbUserNameTextBox.Location = new System.Drawing.Point(6, 129);
            this.destinationDbUserNameTextBox.Name = "destinationDbUserNameTextBox";
            this.destinationDbUserNameTextBox.Size = new System.Drawing.Size(243, 20);
            this.destinationDbUserNameTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "User Name:";
            // 
            // destinationDbNameTextBox
            // 
            this.destinationDbNameTextBox.Location = new System.Drawing.Point(6, 85);
            this.destinationDbNameTextBox.Name = "destinationDbNameTextBox";
            this.destinationDbNameTextBox.Size = new System.Drawing.Size(243, 20);
            this.destinationDbNameTextBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Database Name:";
            // 
            // destinationServerNameTextBox
            // 
            this.destinationServerNameTextBox.Location = new System.Drawing.Point(6, 41);
            this.destinationServerNameTextBox.Name = "destinationServerNameTextBox";
            this.destinationServerNameTextBox.Size = new System.Drawing.Size(243, 20);
            this.destinationServerNameTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Server Name:";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(103, 489);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 6;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 524);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sourcePasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sourceDbUserNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sourceDatabaseNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sourceServerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sourceScriptsFolderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox destinationPasswordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox destinationDbUserNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox destinationDbNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox destinationServerNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button executeButton;


    }
}


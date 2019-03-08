namespace MinecraftModHelperGUI
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.BlockFilePath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.NeededSubmitButton = new System.Windows.Forms.Button();
			this.AssetPathBox = new System.Windows.Forms.TextBox();
			this.AssetPathLabel = new System.Windows.Forms.Label();
			this.ModIDLabel = new System.Windows.Forms.Label();
			this.ModIDBox = new System.Windows.Forms.TextBox();
			this.ConfigGP = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.ConfigFilePathButton = new System.Windows.Forms.Button();
			this.ConfigFilePathBox = new System.Windows.Forms.TextBox();
			this.ConfigPathLabel = new System.Windows.Forms.Label();
			this.ItemFilePathLabel = new System.Windows.Forms.Label();
			this.ItemFilePathBox = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.ConfigGP.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 49);
			this.button1.TabIndex = 0;
			this.button1.Text = "Create Block";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(5, 70);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(122, 50);
			this.button2.TabIndex = 1;
			this.button2.Text = "Create Item";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(137, 126);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Creation";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox2.Controls.Add(this.ItemFilePathBox);
			this.groupBox2.Controls.Add(this.ItemFilePathLabel);
			this.groupBox2.Controls.Add(this.BlockFilePath);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.NeededSubmitButton);
			this.groupBox2.Controls.Add(this.AssetPathBox);
			this.groupBox2.Controls.Add(this.AssetPathLabel);
			this.groupBox2.Controls.Add(this.ModIDLabel);
			this.groupBox2.Controls.Add(this.ModIDBox);
			this.groupBox2.Location = new System.Drawing.Point(12, 144);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(398, 222);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Needed Values";
			// 
			// BlockFilePath
			// 
			this.BlockFilePath.Location = new System.Drawing.Point(10, 118);
			this.BlockFilePath.Name = "BlockFilePath";
			this.BlockFilePath.Size = new System.Drawing.Size(381, 20);
			this.BlockFilePath.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Block File Path";
			// 
			// NeededSubmitButton
			// 
			this.NeededSubmitButton.Location = new System.Drawing.Point(6, 188);
			this.NeededSubmitButton.Name = "NeededSubmitButton";
			this.NeededSubmitButton.Size = new System.Drawing.Size(75, 23);
			this.NeededSubmitButton.TabIndex = 4;
			this.NeededSubmitButton.Text = "Submit";
			this.NeededSubmitButton.UseVisualStyleBackColor = true;
			this.NeededSubmitButton.Click += new System.EventHandler(this.NeededSubmitButton_Click);
			// 
			// AssetPathBox
			// 
			this.AssetPathBox.Location = new System.Drawing.Point(10, 74);
			this.AssetPathBox.Name = "AssetPathBox";
			this.AssetPathBox.Size = new System.Drawing.Size(381, 20);
			this.AssetPathBox.TabIndex = 3;
			// 
			// AssetPathLabel
			// 
			this.AssetPathLabel.AutoSize = true;
			this.AssetPathLabel.Location = new System.Drawing.Point(7, 57);
			this.AssetPathLabel.Name = "AssetPathLabel";
			this.AssetPathLabel.Size = new System.Drawing.Size(63, 13);
			this.AssetPathLabel.TabIndex = 2;
			this.AssetPathLabel.Text = "Assets Path";
			// 
			// ModIDLabel
			// 
			this.ModIDLabel.AutoSize = true;
			this.ModIDLabel.Location = new System.Drawing.Point(7, 20);
			this.ModIDLabel.Name = "ModIDLabel";
			this.ModIDLabel.Size = new System.Drawing.Size(42, 13);
			this.ModIDLabel.TabIndex = 1;
			this.ModIDLabel.Text = "Mod ID";
			// 
			// ModIDBox
			// 
			this.ModIDBox.Location = new System.Drawing.Point(10, 34);
			this.ModIDBox.Name = "ModIDBox";
			this.ModIDBox.Size = new System.Drawing.Size(381, 20);
			this.ModIDBox.TabIndex = 0;
			// 
			// ConfigGP
			// 
			this.ConfigGP.BackColor = System.Drawing.SystemColors.Control;
			this.ConfigGP.Controls.Add(this.button3);
			this.ConfigGP.Controls.Add(this.ConfigFilePathButton);
			this.ConfigGP.Controls.Add(this.ConfigFilePathBox);
			this.ConfigGP.Controls.Add(this.ConfigPathLabel);
			this.ConfigGP.Location = new System.Drawing.Point(155, 12);
			this.ConfigGP.Name = "ConfigGP";
			this.ConfigGP.Size = new System.Drawing.Size(255, 126);
			this.ConfigGP.TabIndex = 4;
			this.ConfigGP.TabStop = false;
			this.ConfigGP.Text = "Config";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(92, 64);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Save Config";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// ConfigFilePathButton
			// 
			this.ConfigFilePathButton.Location = new System.Drawing.Point(11, 64);
			this.ConfigFilePathButton.Name = "ConfigFilePathButton";
			this.ConfigFilePathButton.Size = new System.Drawing.Size(75, 23);
			this.ConfigFilePathButton.TabIndex = 2;
			this.ConfigFilePathButton.Text = "Load Config";
			this.ConfigFilePathButton.UseVisualStyleBackColor = true;
			this.ConfigFilePathButton.Click += new System.EventHandler(this.ConfigFilePathButton_Click);
			// 
			// ConfigFilePathBox
			// 
			this.ConfigFilePathBox.Location = new System.Drawing.Point(11, 37);
			this.ConfigFilePathBox.Name = "ConfigFilePathBox";
			this.ConfigFilePathBox.Size = new System.Drawing.Size(237, 20);
			this.ConfigFilePathBox.TabIndex = 1;
			// 
			// ConfigPathLabel
			// 
			this.ConfigPathLabel.AutoSize = true;
			this.ConfigPathLabel.Location = new System.Drawing.Point(11, 20);
			this.ConfigPathLabel.Name = "ConfigPathLabel";
			this.ConfigPathLabel.Size = new System.Drawing.Size(81, 13);
			this.ConfigPathLabel.TabIndex = 0;
			this.ConfigPathLabel.Text = "Config File Path";
			// 
			// ItemFilePathLabel
			// 
			this.ItemFilePathLabel.AutoSize = true;
			this.ItemFilePathLabel.Location = new System.Drawing.Point(10, 145);
			this.ItemFilePathLabel.Name = "ItemFilePathLabel";
			this.ItemFilePathLabel.Size = new System.Drawing.Size(71, 13);
			this.ItemFilePathLabel.TabIndex = 7;
			this.ItemFilePathLabel.Text = "Item File Path";
			// 
			// ItemFilePathBox
			// 
			this.ItemFilePathBox.Location = new System.Drawing.Point(10, 162);
			this.ItemFilePathBox.Name = "ItemFilePathBox";
			this.ItemFilePathBox.Size = new System.Drawing.Size(381, 20);
			this.ItemFilePathBox.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(424, 380);
			this.Controls.Add(this.ConfigGP);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Minecraft Mod Helper";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ConfigGP.ResumeLayout(false);
			this.ConfigGP.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button NeededSubmitButton;
		private System.Windows.Forms.TextBox AssetPathBox;
		private System.Windows.Forms.Label AssetPathLabel;
		private System.Windows.Forms.Label ModIDLabel;
		private System.Windows.Forms.TextBox ModIDBox;
		private System.Windows.Forms.TextBox BlockFilePath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox ConfigGP;
		private System.Windows.Forms.TextBox ConfigFilePathBox;
		private System.Windows.Forms.Label ConfigPathLabel;
		private System.Windows.Forms.Button ConfigFilePathButton;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox ItemFilePathBox;
		private System.Windows.Forms.Label ItemFilePathLabel;
	}
}


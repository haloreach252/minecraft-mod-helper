namespace MinecraftModHelperGUI
{
	partial class Form2
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
			this.BlockNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.RegularBlockRadio = new System.Windows.Forms.RadioButton();
			this.VaultBlockRadio = new System.Windows.Forms.RadioButton();
			this.BlockModelLocDialogBox = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BlockNameTextBox
			// 
			this.BlockNameTextBox.Location = new System.Drawing.Point(13, 32);
			this.BlockNameTextBox.Name = "BlockNameTextBox";
			this.BlockNameTextBox.Size = new System.Drawing.Size(178, 20);
			this.BlockNameTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Block Name";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.GenerateButton);
			this.groupBox1.Controls.Add(this.RegularBlockRadio);
			this.groupBox1.Controls.Add(this.VaultBlockRadio);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.BlockNameTextBox);
			this.groupBox1.Location = new System.Drawing.Point(3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(202, 125);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New Block";
			// 
			// GenerateButton
			// 
			this.GenerateButton.Location = new System.Drawing.Point(57, 82);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(88, 28);
			this.GenerateButton.TabIndex = 4;
			this.GenerateButton.Text = "Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// RegularBlockRadio
			// 
			this.RegularBlockRadio.AutoSize = true;
			this.RegularBlockRadio.Location = new System.Drawing.Point(99, 59);
			this.RegularBlockRadio.Name = "RegularBlockRadio";
			this.RegularBlockRadio.Size = new System.Drawing.Size(92, 17);
			this.RegularBlockRadio.TabIndex = 3;
			this.RegularBlockRadio.TabStop = true;
			this.RegularBlockRadio.Text = "Regular Block";
			this.RegularBlockRadio.UseVisualStyleBackColor = true;
			// 
			// VaultBlockRadio
			// 
			this.VaultBlockRadio.AutoSize = true;
			this.VaultBlockRadio.Location = new System.Drawing.Point(13, 59);
			this.VaultBlockRadio.Name = "VaultBlockRadio";
			this.VaultBlockRadio.Size = new System.Drawing.Size(79, 17);
			this.VaultBlockRadio.TabIndex = 2;
			this.VaultBlockRadio.TabStop = true;
			this.VaultBlockRadio.Text = "Vault Block";
			this.VaultBlockRadio.UseVisualStyleBackColor = true;
			// 
			// BlockModelLocDialogBox
			// 
			this.BlockModelLocDialogBox.SelectedPath = "C:\\Users\\Nathan\\Desktop";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(208, 133);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form2";
			this.Text = "Create Block";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox BlockNameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton RegularBlockRadio;
		private System.Windows.Forms.RadioButton VaultBlockRadio;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.FolderBrowserDialog BlockModelLocDialogBox;
	}
}
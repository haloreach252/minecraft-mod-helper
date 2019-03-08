namespace MinecraftModHelperGUI
{
	partial class Form3
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
			this.GenerateButton = new System.Windows.Forms.Button();
			this.ItemNameLabel = new System.Windows.Forms.Label();
			this.ItemNameBox = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.GenerateButton);
			this.groupBox1.Controls.Add(this.ItemNameLabel);
			this.groupBox1.Controls.Add(this.ItemNameBox);
			this.groupBox1.Location = new System.Drawing.Point(6, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(157, 125);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New Block";
			// 
			// GenerateButton
			// 
			this.GenerateButton.Location = new System.Drawing.Point(13, 58);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(128, 35);
			this.GenerateButton.TabIndex = 4;
			this.GenerateButton.Text = "Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// ItemNameLabel
			// 
			this.ItemNameLabel.AutoSize = true;
			this.ItemNameLabel.Location = new System.Drawing.Point(10, 16);
			this.ItemNameLabel.Name = "ItemNameLabel";
			this.ItemNameLabel.Size = new System.Drawing.Size(58, 13);
			this.ItemNameLabel.TabIndex = 1;
			this.ItemNameLabel.Text = "Item Name";
			// 
			// ItemNameBox
			// 
			this.ItemNameBox.Location = new System.Drawing.Point(13, 32);
			this.ItemNameBox.Name = "ItemNameBox";
			this.ItemNameBox.Size = new System.Drawing.Size(128, 20);
			this.ItemNameBox.TabIndex = 0;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(171, 138);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form3";
			this.Text = "Create Item";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.Label ItemNameLabel;
		private System.Windows.Forms.TextBox ItemNameBox;
	}
}
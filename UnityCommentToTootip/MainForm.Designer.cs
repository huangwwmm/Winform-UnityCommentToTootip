namespace UnityCommentToTootip
{
	partial class MainForm
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
			this.m_ConvertButton = new System.Windows.Forms.Button();
			this.m_TextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// m_ConvertButton
			// 
			this.m_ConvertButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_ConvertButton.Font = new System.Drawing.Font("SimSun", 12F);
			this.m_ConvertButton.Location = new System.Drawing.Point(0, 147);
			this.m_ConvertButton.Name = "m_ConvertButton";
			this.m_ConvertButton.Size = new System.Drawing.Size(345, 38);
			this.m_ConvertButton.TabIndex = 0;
			this.m_ConvertButton.Text = "Convert";
			this.m_ConvertButton.UseVisualStyleBackColor = true;
			this.m_ConvertButton.Click += new System.EventHandler(this.OnConvertButton_Click);
			// 
			// m_TextBox
			// 
			this.m_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_TextBox.Font = new System.Drawing.Font("SimSun", 11F);
			this.m_TextBox.Location = new System.Drawing.Point(0, 0);
			this.m_TextBox.Multiline = true;
			this.m_TextBox.Name = "m_TextBox";
			this.m_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.m_TextBox.Size = new System.Drawing.Size(345, 147);
			this.m_TextBox.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 185);
			this.Controls.Add(this.m_TextBox);
			this.Controls.Add(this.m_ConvertButton);
			this.Name = "MainForm";
			this.Text = "Unity Comment To Tootip";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_ConvertButton;
		private System.Windows.Forms.TextBox m_TextBox;
	}
}


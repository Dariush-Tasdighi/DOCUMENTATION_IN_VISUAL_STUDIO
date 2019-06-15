namespace MY_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.sourceTextBox = new System.Windows.Forms.TextBox();
			this.convertButton = new System.Windows.Forms.Button();
			this.targetTextBox = new System.Windows.Forms.TextBox();
			this.copyButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// sourceTextBox
			// 
			this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceTextBox.Location = new System.Drawing.Point(12, 12);
			this.sourceTextBox.Multiline = true;
			this.sourceTextBox.Name = "sourceTextBox";
			this.sourceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.sourceTextBox.Size = new System.Drawing.Size(630, 100);
			this.sourceTextBox.TabIndex = 0;
			this.sourceTextBox.Text = "برای اینکه یک Field به صورت Private‌ تعریف نماییم باید آنرا به صورت camelCase تعر" +
    "یف کنیم";
			// 
			// convertButton
			// 
			this.convertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.convertButton.Location = new System.Drawing.Point(12, 118);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new System.Drawing.Size(630, 25);
			this.convertButton.TabIndex = 1;
			this.convertButton.Text = "&Convert";
			this.convertButton.UseVisualStyleBackColor = true;
			this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
			// 
			// targetTextBox
			// 
			this.targetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.targetTextBox.Location = new System.Drawing.Point(12, 149);
			this.targetTextBox.Multiline = true;
			this.targetTextBox.Name = "targetTextBox";
			this.targetTextBox.Size = new System.Drawing.Size(630, 87);
			this.targetTextBox.TabIndex = 2;
			// 
			// copyButton
			// 
			this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.copyButton.Location = new System.Drawing.Point(12, 242);
			this.copyButton.Name = "copyButton";
			this.copyButton.Size = new System.Drawing.Size(630, 27);
			this.copyButton.TabIndex = 3;
			this.copyButton.Text = "Copy";
			this.copyButton.UseVisualStyleBackColor = true;
			this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 281);
			this.Controls.Add(this.copyButton);
			this.Controls.Add(this.targetTextBox);
			this.Controls.Add(this.convertButton);
			this.Controls.Add(this.sourceTextBox);
			this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(495, 320);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Convert Mix Text For Left To Right Documentation!";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox sourceTextBox;
		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.TextBox targetTextBox;
		private System.Windows.Forms.Button copyButton;
	}
}

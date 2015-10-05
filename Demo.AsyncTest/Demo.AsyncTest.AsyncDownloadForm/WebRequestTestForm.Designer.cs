namespace Demo.AsyncTest.AsyncDownloadForm
{
	partial class WebRequestTestForm
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
			this.closeButton = new System.Windows.Forms.Button();
			this.processButton = new System.Windows.Forms.Button();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.Location = new System.Drawing.Point(370, 292);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 0;
			this.closeButton.Text = "&Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// processButton
			// 
			this.processButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.processButton.Location = new System.Drawing.Point(289, 292);
			this.processButton.Name = "processButton";
			this.processButton.Size = new System.Drawing.Size(75, 23);
			this.processButton.TabIndex = 1;
			this.processButton.Text = "&Process";
			this.processButton.UseVisualStyleBackColor = true;
			this.processButton.Click += new System.EventHandler(this.processButton_Click);
			// 
			// resultTextBox
			// 
			this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultTextBox.Location = new System.Drawing.Point(13, 13);
			this.resultTextBox.Multiline = true;
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.resultTextBox.Size = new System.Drawing.Size(432, 273);
			this.resultTextBox.TabIndex = 2;
			// 
			// WebRequestTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 327);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.processButton);
			this.Controls.Add(this.closeButton);
			this.Name = "WebRequestTestForm";
			this.Text = "WebRequestTestForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button processButton;
		private System.Windows.Forms.TextBox resultTextBox;
	}
}
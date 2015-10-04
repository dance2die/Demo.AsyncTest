namespace Demo.AsyncTest.AsyncDownloadForm
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
			this.closeButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.exceptionButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.Location = new System.Drawing.Point(388, 345);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 0;
			this.closeButton.Text = "&Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(288, 345);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "downloadButton";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.downloadButton_Click);
			// 
			// resultTextBox
			// 
			this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultTextBox.Location = new System.Drawing.Point(17, 18);
			this.resultTextBox.Multiline = true;
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.Size = new System.Drawing.Size(445, 315);
			this.resultTextBox.TabIndex = 2;
			// 
			// exceptionButton
			// 
			this.exceptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exceptionButton.Location = new System.Drawing.Point(207, 345);
			this.exceptionButton.Name = "exceptionButton";
			this.exceptionButton.Size = new System.Drawing.Size(75, 23);
			this.exceptionButton.TabIndex = 3;
			this.exceptionButton.Text = "Exception";
			this.exceptionButton.UseVisualStyleBackColor = true;
			this.exceptionButton.Click += new System.EventHandler(this.exceptionButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 380);
			this.Controls.Add(this.exceptionButton);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.closeButton);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox resultTextBox;
		private System.Windows.Forms.Button exceptionButton;
	}
}


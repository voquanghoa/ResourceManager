namespace ResourceManager
{
	partial class ResourceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDataPath = new System.Windows.Forms.TextBox();
            this.BtnSelectDataPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtJsonPath = new System.Windows.Forms.TextBox();
            this.DialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.DialogSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnLoadData = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Root folder";
            // 
            // TxtDataPath
            // 
            this.TxtDataPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDataPath.Location = new System.Drawing.Point(152, 33);
            this.TxtDataPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtDataPath.Name = "TxtDataPath";
            this.TxtDataPath.Size = new System.Drawing.Size(826, 31);
            this.TxtDataPath.TabIndex = 0;
            this.TxtDataPath.Text = "\\\\Mac\\Home\\Desktop\\Chines";
            this.TxtDataPath.TextChanged += new System.EventHandler(this.TxtDataPath_TextChanged);
            // 
            // BtnSelectDataPath
            // 
            this.BtnSelectDataPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectDataPath.Location = new System.Drawing.Point(1006, 27);
            this.BtnSelectDataPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnSelectDataPath.Name = "BtnSelectDataPath";
            this.BtnSelectDataPath.Size = new System.Drawing.Size(150, 44);
            this.BtnSelectDataPath.TabIndex = 2;
            this.BtnSelectDataPath.Text = "Open";
            this.BtnSelectDataPath.UseVisualStyleBackColor = true;
            this.BtnSelectDataPath.Click += new System.EventHandler(this.BtnSelectDataPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Json";
            // 
            // TxtJsonPath
            // 
            this.TxtJsonPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtJsonPath.Location = new System.Drawing.Point(152, 94);
            this.TxtJsonPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtJsonPath.Name = "TxtJsonPath";
            this.TxtJsonPath.ReadOnly = true;
            this.TxtJsonPath.Size = new System.Drawing.Size(826, 31);
            this.TxtJsonPath.TabIndex = 1;
            this.TxtJsonPath.TabStop = false;
            // 
            // DialogOpenFile
            // 
            this.DialogOpenFile.CheckFileExists = false;
            this.DialogOpenFile.CheckPathExists = false;
            this.DialogOpenFile.Filter = "Json file (*.json)|*.json";
            // 
            // BtnLoadData
            // 
            this.BtnLoadData.Location = new System.Drawing.Point(842, 154);
            this.BtnLoadData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnLoadData.Name = "BtnLoadData";
            this.BtnLoadData.Size = new System.Drawing.Size(314, 69);
            this.BtnLoadData.TabIndex = 4;
            this.BtnLoadData.Text = "Process";
            this.BtnLoadData.UseVisualStyleBackColor = true;
            this.BtnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(42, 175);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(357, 29);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Distinct and no extendsion mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 246);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BtnLoadData);
            this.Controls.Add(this.BtnSelectDataPath);
            this.Controls.Add(this.TxtJsonPath);
            this.Controls.Add(this.TxtDataPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ResourceForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtDataPath;
		private System.Windows.Forms.Button BtnSelectDataPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtJsonPath;
		private System.Windows.Forms.OpenFileDialog DialogOpenFile;
		private System.Windows.Forms.FolderBrowserDialog DialogSelectFolder;
		private System.Windows.Forms.Button BtnLoadData;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}


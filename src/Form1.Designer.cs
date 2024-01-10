namespace KeyboardInputSwitch
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.fakePictureBox = new System.Windows.Forms.PictureBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.lstWindows = new System.Windows.Forms.ComboBox();
            this.btnTargetWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fakePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.Location = new System.Drawing.Point(498, 93);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // fakePictureBox
            // 
            this.fakePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fakePictureBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fakePictureBox.Location = new System.Drawing.Point(228, 122);
            this.fakePictureBox.Name = "fakePictureBox";
            this.fakePictureBox.Size = new System.Drawing.Size(345, 205);
            this.fakePictureBox.TabIndex = 9;
            this.fakePictureBox.TabStop = false;
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.image.Location = new System.Drawing.Point(228, 122);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(345, 205);
            this.image.TabIndex = 10;
            this.image.TabStop = false;
            // 
            // lstWindows
            // 
            this.lstWindows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lstWindows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstWindows.FormattingEnabled = true;
            this.lstWindows.Location = new System.Drawing.Point(228, 95);
            this.lstWindows.Name = "lstWindows";
            this.lstWindows.Size = new System.Drawing.Size(260, 21);
            this.lstWindows.TabIndex = 8;
            // 
            // btnTargetWindow
            // 
            this.btnTargetWindow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTargetWindow.Location = new System.Drawing.Point(579, 144);
            this.btnTargetWindow.Name = "btnTargetWindow";
            this.btnTargetWindow.Size = new System.Drawing.Size(83, 34);
            this.btnTargetWindow.TabIndex = 12;
            this.btnTargetWindow.Text = "Selected Window";
            this.btnTargetWindow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTargetWindow);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.fakePictureBox);
            this.Controls.Add(this.image);
            this.Controls.Add(this.lstWindows);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fakePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox fakePictureBox;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.ComboBox lstWindows;
        private System.Windows.Forms.Button btnTargetWindow;
    }
}


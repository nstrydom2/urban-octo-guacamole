namespace WindowsFormsApp2
{
    partial class MainWindow
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
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.hookButton = new System.Windows.Forms.Button();
            this.unhookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputBox.Location = new System.Drawing.Point(9, 11);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(357, 288);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "";
            // 
            // hookButton
            // 
            this.hookButton.Location = new System.Drawing.Point(222, 305);
            this.hookButton.Name = "hookButton";
            this.hookButton.Size = new System.Drawing.Size(63, 23);
            this.hookButton.TabIndex = 1;
            this.hookButton.Text = "Hook";
            this.hookButton.UseVisualStyleBackColor = true;
            this.hookButton.Click += new System.EventHandler(this.hookButton_Click);
            // 
            // unhookButton
            // 
            this.unhookButton.Location = new System.Drawing.Point(301, 305);
            this.unhookButton.Name = "unhookButton";
            this.unhookButton.Size = new System.Drawing.Size(63, 23);
            this.unhookButton.TabIndex = 2;
            this.unhookButton.Text = "Unhook";
            this.unhookButton.UseVisualStyleBackColor = true;
            this.unhookButton.Click += new System.EventHandler(this.unhookButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 340);
            this.Controls.Add(this.unhookButton);
            this.Controls.Add(this.hookButton);
            this.Controls.Add(this.outputBox);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button hookButton;
        private System.Windows.Forms.Button unhookButton;
    }
}


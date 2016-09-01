namespace DisplacerBeast
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
            this.MainOutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainOutputTextBox
            // 
            this.MainOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainOutputTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainOutputTextBox.Location = new System.Drawing.Point(0, 0);
            this.MainOutputTextBox.Multiline = true;
            this.MainOutputTextBox.Name = "MainOutputTextBox";
            this.MainOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MainOutputTextBox.Size = new System.Drawing.Size(801, 607);
            this.MainOutputTextBox.TabIndex = 0;
            this.MainOutputTextBox.Text = "Hello World";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 607);
            this.Controls.Add(this.MainOutputTextBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainOutputTextBox;
    }
}


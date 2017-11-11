namespace TradeGeckoExample
{
    partial class AuthentificationCodeForm
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
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(-1, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(572, 60);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(-1, 57);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(572, 28);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.Close);
            // 
            // AuthentificationCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 86);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textBox);
            this.Name = "AuthentificationCodeForm";
            this.Text = "Authentification Code";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button okButton;
    }
}
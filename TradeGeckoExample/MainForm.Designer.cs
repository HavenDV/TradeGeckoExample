namespace TradeGeckoExample
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
            this.connectButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.applicationIdLabel = new System.Windows.Forms.Label();
            this.applicationIdTextBox = new System.Windows.Forms.TextBox();
            this.applicationSecretTextBox = new System.Windows.Forms.TextBox();
            this.applicationSecretLabel = new System.Windows.Forms.Label();
            this.callbackUrlTextBox = new System.Windows.Forms.TextBox();
            this.callbackUrlLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(1, 355);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(685, 32);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.Connect);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Location = new System.Drawing.Point(1, -1);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(685, 271);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // applicationIdLabel
            // 
            this.applicationIdLabel.AutoSize = true;
            this.applicationIdLabel.Location = new System.Drawing.Point(12, 278);
            this.applicationIdLabel.Name = "applicationIdLabel";
            this.applicationIdLabel.Size = new System.Drawing.Size(74, 13);
            this.applicationIdLabel.TabIndex = 3;
            this.applicationIdLabel.Text = "Application Id:";
            // 
            // applicationIdTextBox
            // 
            this.applicationIdTextBox.Location = new System.Drawing.Point(114, 275);
            this.applicationIdTextBox.Name = "applicationIdTextBox";
            this.applicationIdTextBox.Size = new System.Drawing.Size(572, 20);
            this.applicationIdTextBox.TabIndex = 4;
            this.applicationIdTextBox.Text = "a95005b278ce780e20480b976747170f1089a242f65288c4f442d7c1a1a6a462";
            // 
            // applicationSecretTextBox
            // 
            this.applicationSecretTextBox.Location = new System.Drawing.Point(114, 300);
            this.applicationSecretTextBox.Name = "applicationSecretTextBox";
            this.applicationSecretTextBox.Size = new System.Drawing.Size(572, 20);
            this.applicationSecretTextBox.TabIndex = 6;
            this.applicationSecretTextBox.Text = "7df9cfd236e632dcb84318992eb9ffc379d100e9f1e9333fb414d05d15deba53";
            // 
            // applicationSecretLabel
            // 
            this.applicationSecretLabel.AutoSize = true;
            this.applicationSecretLabel.Location = new System.Drawing.Point(12, 303);
            this.applicationSecretLabel.Name = "applicationSecretLabel";
            this.applicationSecretLabel.Size = new System.Drawing.Size(96, 13);
            this.applicationSecretLabel.TabIndex = 5;
            this.applicationSecretLabel.Text = "Application Secret:";
            // 
            // callbackUrlTextBox
            // 
            this.callbackUrlTextBox.Location = new System.Drawing.Point(114, 324);
            this.callbackUrlTextBox.Name = "callbackUrlTextBox";
            this.callbackUrlTextBox.Size = new System.Drawing.Size(572, 20);
            this.callbackUrlTextBox.TabIndex = 8;
            this.callbackUrlTextBox.Text = "urn:ietf:wg:oauth:2.0:oob";
            // 
            // callbackUrlLabel
            // 
            this.callbackUrlLabel.AutoSize = true;
            this.callbackUrlLabel.Location = new System.Drawing.Point(12, 327);
            this.callbackUrlLabel.Name = "callbackUrlLabel";
            this.callbackUrlLabel.Size = new System.Drawing.Size(64, 13);
            this.callbackUrlLabel.TabIndex = 7;
            this.callbackUrlLabel.Text = "CallbackUrl:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 387);
            this.Controls.Add(this.callbackUrlTextBox);
            this.Controls.Add(this.callbackUrlLabel);
            this.Controls.Add(this.applicationSecretTextBox);
            this.Controls.Add(this.applicationSecretLabel);
            this.Controls.Add(this.applicationIdTextBox);
            this.Controls.Add(this.applicationIdLabel);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.connectButton);
            this.Name = "MainForm";
            this.Text = "Trade Gecko Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox applicationIdTextBox;
        private System.Windows.Forms.Label applicationIdLabel;
        private System.Windows.Forms.TextBox applicationSecretTextBox;
        private System.Windows.Forms.Label applicationSecretLabel;
        private System.Windows.Forms.TextBox callbackUrlTextBox;
        private System.Windows.Forms.Label callbackUrlLabel;
    }
}


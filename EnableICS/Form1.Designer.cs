namespace EnableICS
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStopSharing = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.cbHomeConnection = new System.Windows.Forms.ComboBox();
            this.cbSharedConnection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Home connection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Shared connection";
            // 
            // buttonStopSharing
            // 
            this.buttonStopSharing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStopSharing.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonStopSharing.Location = new System.Drawing.Point(9, 91);
            this.buttonStopSharing.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStopSharing.Name = "buttonStopSharing";
            this.buttonStopSharing.Size = new System.Drawing.Size(83, 24);
            this.buttonStopSharing.TabIndex = 8;
            this.buttonStopSharing.Text = "Stop sharing";
            this.buttonStopSharing.UseVisualStyleBackColor = true;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonClose.Location = new System.Drawing.Point(234, 91);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(56, 24);
            this.ButtonClose.TabIndex = 9;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // ButtonApply
            // 
            this.ButtonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonApply.Location = new System.Drawing.Point(177, 91);
            this.ButtonApply.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(56, 24);
            this.ButtonApply.TabIndex = 7;
            this.ButtonApply.Text = "Apply";
            this.ButtonApply.UseVisualStyleBackColor = true;
            // 
            // cbHomeConnection
            // 
            this.cbHomeConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHomeConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHomeConnection.FormattingEnabled = true;
            this.cbHomeConnection.Location = new System.Drawing.Point(11, 61);
            this.cbHomeConnection.Margin = new System.Windows.Forms.Padding(2);
            this.cbHomeConnection.Name = "cbHomeConnection";
            this.cbHomeConnection.Size = new System.Drawing.Size(279, 21);
            this.cbHomeConnection.TabIndex = 6;
            // 
            // cbSharedConnection
            // 
            this.cbSharedConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSharedConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSharedConnection.FormattingEnabled = true;
            this.cbSharedConnection.Location = new System.Drawing.Point(11, 23);
            this.cbSharedConnection.Margin = new System.Windows.Forms.Padding(2);
            this.cbSharedConnection.Name = "cbSharedConnection";
            this.cbSharedConnection.Size = new System.Drawing.Size(279, 21);
            this.cbSharedConnection.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStopSharing);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.cbHomeConnection);
            this.Controls.Add(this.cbSharedConnection);
            this.Name = "Form1";
            this.Text = "Enable Sharing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStopSharing;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.ComboBox cbHomeConnection;
        private System.Windows.Forms.ComboBox cbSharedConnection;
    }
}


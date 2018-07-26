namespace SignalRClient2
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
            this.TbMessage = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.RichTbShow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TbMessage
            // 
            this.TbMessage.Location = new System.Drawing.Point(12, 14);
            this.TbMessage.Multiline = true;
            this.TbMessage.Name = "TbMessage";
            this.TbMessage.Size = new System.Drawing.Size(269, 21);
            this.TbMessage.TabIndex = 0;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(287, 12);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 1;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // RichTbShow
            // 
            this.RichTbShow.Location = new System.Drawing.Point(12, 46);
            this.RichTbShow.Name = "RichTbShow";
            this.RichTbShow.ReadOnly = true;
            this.RichTbShow.Size = new System.Drawing.Size(350, 321);
            this.RichTbShow.TabIndex = 2;
            this.RichTbShow.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 386);
            this.Controls.Add(this.RichTbShow);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TbMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbMessage;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.RichTextBox RichTbShow;
    }
}


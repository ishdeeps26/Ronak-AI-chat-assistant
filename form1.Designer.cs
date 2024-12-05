namespace personal_assistant
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtuserinput = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.pnlchathistory = new System.Windows.Forms.FlowLayoutPanel();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(356, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chat Assistant";
            // 
            // txtuserinput
            // 
            this.txtuserinput.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserinput.Location = new System.Drawing.Point(37, 497);
            this.txtuserinput.Name = "txtuserinput";
            this.txtuserinput.Size = new System.Drawing.Size(772, 28);
            this.txtuserinput.TabIndex = 2;
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.Location = new System.Drawing.Point(827, 497);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 28);
            this.btnsend.TabIndex = 3;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // pnlchathistory
            // 
            this.pnlchathistory.AutoScroll = true;
            this.pnlchathistory.BackgroundImage = global::personal_assistant.Properties.Resources.Untitled_design__4_;
            this.pnlchathistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlchathistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlchathistory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlchathistory.Location = new System.Drawing.Point(24, 81);
            this.pnlchathistory.Name = "pnlchathistory";
            this.pnlchathistory.Size = new System.Drawing.Size(865, 388);
            this.pnlchathistory.TabIndex = 4;
            this.pnlchathistory.WrapContents = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(413, 539);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(89, 35);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::personal_assistant.Properties.Resources.pexels_photo_305816;
            this.ClientSize = new System.Drawing.Size(914, 586);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.pnlchathistory);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtuserinput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "personal assistant ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuserinput;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.FlowLayoutPanel pnlchathistory;
        private System.Windows.Forms.Button btnexit;
    }
}


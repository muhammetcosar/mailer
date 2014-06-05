namespace Tgs
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
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.cbactivities = new System.Windows.Forms.ComboBox();
            this.lbMail = new System.Windows.Forms.ListBox();
            this.mailgonder = new System.Windows.Forms.Button();
            this.lbMailCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbProgram
            // 
            this.cbProgram.DisplayMember = "PROGRAMNAME";
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(12, 28);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(189, 21);
            this.cbProgram.TabIndex = 0;
            this.cbProgram.ValueMember = "PROGRAMID";
            this.cbProgram.SelectedIndexChanged += new System.EventHandler(this.cbProgram_SelectedIndexChanged);
            // 
            // cbactivities
            // 
            this.cbactivities.DisplayMember = "ACTIVITYNAME";
            this.cbactivities.FormattingEnabled = true;
            this.cbactivities.Location = new System.Drawing.Point(12, 74);
            this.cbactivities.Name = "cbactivities";
            this.cbactivities.Size = new System.Drawing.Size(189, 21);
            this.cbactivities.TabIndex = 1;
            this.cbactivities.ValueMember = "ACTIVITYID";
            this.cbactivities.SelectedIndexChanged += new System.EventHandler(this.cbactivities_SelectedIndexChanged);
            // 
            // lbMail
            // 
            this.lbMail.DisplayMember = "EMAIL";
            this.lbMail.FormattingEnabled = true;
            this.lbMail.Location = new System.Drawing.Point(2, 122);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(486, 251);
            this.lbMail.TabIndex = 2;
            // 
            // mailgonder
            // 
            this.mailgonder.Location = new System.Drawing.Point(413, 379);
            this.mailgonder.Name = "mailgonder";
            this.mailgonder.Size = new System.Drawing.Size(75, 23);
            this.mailgonder.TabIndex = 3;
            this.mailgonder.Text = "Gönder";
            this.mailgonder.UseVisualStyleBackColor = true;
            this.mailgonder.Click += new System.EventHandler(this.mailgonder_Click);
            // 
            // lbMailCount
            // 
            this.lbMailCount.AutoSize = true;
            this.lbMailCount.Location = new System.Drawing.Point(74, 388);
            this.lbMailCount.Name = "lbMailCount";
            this.lbMailCount.Size = new System.Drawing.Size(0, 13);
            this.lbMailCount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MailSayısı :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMailCount);
            this.Controls.Add(this.mailgonder);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.cbactivities);
            this.Controls.Add(this.cbProgram);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.ComboBox cbactivities;
        private System.Windows.Forms.ListBox lbMail;
        private System.Windows.Forms.Button mailgonder;
        private System.Windows.Forms.Label lbMailCount;
        private System.Windows.Forms.Label label1;
    }
}


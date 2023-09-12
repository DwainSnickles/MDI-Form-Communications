namespace FormCommunications
{
    partial class FrmChild
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendImageToParentFForm = new System.Windows.Forms.Button();
            this.picReceivedFromParent = new System.Windows.Forms.PictureBox();
            this.picSentToParent = new System.Windows.Forms.PictureBox();
            this.btnChangeChildImage = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picReceivedFromParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSentToParent)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "This Is The MDI Child Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Image To Send To Parent Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Image To Receive From Parent Form";
            // 
            // btnSendImageToParentFForm
            // 
            this.btnSendImageToParentFForm.Location = new System.Drawing.Point(215, 219);
            this.btnSendImageToParentFForm.Name = "btnSendImageToParentFForm";
            this.btnSendImageToParentFForm.Size = new System.Drawing.Size(189, 23);
            this.btnSendImageToParentFForm.TabIndex = 7;
            this.btnSendImageToParentFForm.Text = "Send Image To MDI Parent Form";
            this.btnSendImageToParentFForm.UseVisualStyleBackColor = true;
            this.btnSendImageToParentFForm.Click += new System.EventHandler(this.btnSendImageToParentFForm_Click);
            // 
            // picReceivedFromParent
            // 
            this.picReceivedFromParent.Location = new System.Drawing.Point(10, 62);
            this.picReceivedFromParent.Name = "picReceivedFromParent";
            this.picReceivedFromParent.Size = new System.Drawing.Size(190, 180);
            this.picReceivedFromParent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReceivedFromParent.TabIndex = 8;
            this.picReceivedFromParent.TabStop = false;
            // 
            // picSentToParent
            // 
            this.picSentToParent.Image = global::FormCommunications.Properties.Resources.Lion1;
            this.picSentToParent.Location = new System.Drawing.Point(212, 62);
            this.picSentToParent.Name = "picSentToParent";
            this.picSentToParent.Size = new System.Drawing.Size(199, 124);
            this.picSentToParent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSentToParent.TabIndex = 6;
            this.picSentToParent.TabStop = false;
            // 
            // btnChangeChildImage
            // 
            this.btnChangeChildImage.Location = new System.Drawing.Point(235, 189);
            this.btnChangeChildImage.Name = "btnChangeChildImage";
            this.btnChangeChildImage.Size = new System.Drawing.Size(153, 23);
            this.btnChangeChildImage.TabIndex = 12;
            this.btnChangeChildImage.Text = "Change Child Image";
            this.btnChangeChildImage.UseVisualStyleBackColor = true;
            this.btnChangeChildImage.Click += new System.EventHandler(this.btnChangeChildImage_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // FrmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 254);
            this.Controls.Add(this.btnChangeChildImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picReceivedFromParent);
            this.Controls.Add(this.btnSendImageToParentFForm);
            this.Controls.Add(this.picSentToParent);
            this.Name = "FrmChild";
            this.Text = "FrmChild";
            ((System.ComponentModel.ISupportInitialize)(this.picReceivedFromParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSentToParent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picReceivedFromParent;
        private System.Windows.Forms.Button btnSendImageToParentFForm;
        private System.Windows.Forms.PictureBox picSentToParent;
        private System.Windows.Forms.Button btnChangeChildImage;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}
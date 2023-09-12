namespace FormCommunications
{
    partial class FrmParent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetImageFromChild = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendImageToChildForm = new System.Windows.Forms.Button();
            this.lblChildCount = new System.Windows.Forms.Label();
            this.picReceivedFromChild = new System.Windows.Forms.PictureBox();
            this.picToSendToChild = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReceivedFromChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToSendToChild)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGetImageFromChild);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSendImageToChildForm);
            this.panel1.Controls.Add(this.lblChildCount);
            this.panel1.Controls.Add(this.picReceivedFromChild);
            this.panel1.Controls.Add(this.picToSendToChild);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(595, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 450);
            this.panel1.TabIndex = 1;
            // 
            // btnGetImageFromChild
            // 
            this.btnGetImageFromChild.Location = new System.Drawing.Point(41, 415);
            this.btnGetImageFromChild.Name = "btnGetImageFromChild";
            this.btnGetImageFromChild.Size = new System.Drawing.Size(136, 23);
            this.btnGetImageFromChild.TabIndex = 10;
            this.btnGetImageFromChild.Text = "Get Image From Child";
            this.btnGetImageFromChild.UseVisualStyleBackColor = true;
            this.btnGetImageFromChild.Click += new System.EventHandler(this.btnGetImageFromChild_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Imagre TReceived From Child Form";
            // 
            // btnSendImageToChildForm
            // 
            this.btnSendImageToChildForm.Location = new System.Drawing.Point(29, 167);
            this.btnSendImageToChildForm.Name = "btnSendImageToChildForm";
            this.btnSendImageToChildForm.Size = new System.Drawing.Size(136, 23);
            this.btnSendImageToChildForm.TabIndex = 9;
            this.btnSendImageToChildForm.Text = "Send Image To Child";
            this.btnSendImageToChildForm.UseVisualStyleBackColor = true;
            this.btnSendImageToChildForm.Click += new System.EventHandler(this.btnSendImageToChildForm_Click);
            // 
            // lblChildCount
            // 
            this.lblChildCount.AutoSize = true;
            this.lblChildCount.Location = new System.Drawing.Point(26, 8);
            this.lblChildCount.Name = "lblChildCount";
            this.lblChildCount.Size = new System.Drawing.Size(151, 13);
            this.lblChildCount.TabIndex = 5;
            this.lblChildCount.Text = "Imagre To Send To Child Form";
            // 
            // picReceivedFromChild
            // 
            this.picReceivedFromChild.Location = new System.Drawing.Point(3, 218);
            this.picReceivedFromChild.Name = "picReceivedFromChild";
            this.picReceivedFromChild.Size = new System.Drawing.Size(199, 124);
            this.picReceivedFromChild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReceivedFromChild.TabIndex = 8;
            this.picReceivedFromChild.TabStop = false;
            // 
            // picToSendToChild
            // 
            this.picToSendToChild.Image = global::FormCommunications.Properties.Resources.SkyReflection;
            this.picToSendToChild.Location = new System.Drawing.Point(29, 24);
            this.picToSendToChild.Name = "picToSendToChild";
            this.picToSendToChild.Size = new System.Drawing.Size(136, 137);
            this.picToSendToChild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picToSendToChild.TabIndex = 6;
            this.picToSendToChild.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "Create a new instance of Child Form \r\nto get image without showing the \r\nactual f" +
    "orm. \r\nTo get the child forms image";
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FrmParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Parent Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReceivedFromChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToSendToChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendImageToChildForm;
        private System.Windows.Forms.Label lblChildCount;
        private System.Windows.Forms.PictureBox picReceivedFromChild;
        private System.Windows.Forms.PictureBox picToSendToChild;
        private System.Windows.Forms.Button btnGetImageFromChild;
        private System.Windows.Forms.Label label2;
    }
}


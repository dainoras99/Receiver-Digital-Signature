
namespace Receiver_Digital_Signature_
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.messageFromTheSender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.digitalSignatureFromTheSender = new System.Windows.Forms.TextBox();
            this.confirmTheSignatureButton = new System.Windows.Forms.Button();
            this.signatureConfirmedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "RECEIVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-25, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "________________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message from the sender";
            // 
            // messageFromTheSender
            // 
            this.messageFromTheSender.Location = new System.Drawing.Point(12, 78);
            this.messageFromTheSender.Name = "messageFromTheSender";
            this.messageFromTheSender.Size = new System.Drawing.Size(339, 20);
            this.messageFromTheSender.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digital signature value from the sender";
            // 
            // digitalSignatureFromTheSender
            // 
            this.digitalSignatureFromTheSender.Location = new System.Drawing.Point(12, 129);
            this.digitalSignatureFromTheSender.Name = "digitalSignatureFromTheSender";
            this.digitalSignatureFromTheSender.Size = new System.Drawing.Size(339, 20);
            this.digitalSignatureFromTheSender.TabIndex = 6;
            // 
            // confirmTheSignatureButton
            // 
            this.confirmTheSignatureButton.Location = new System.Drawing.Point(114, 174);
            this.confirmTheSignatureButton.Name = "confirmTheSignatureButton";
            this.confirmTheSignatureButton.Size = new System.Drawing.Size(131, 23);
            this.confirmTheSignatureButton.TabIndex = 8;
            this.confirmTheSignatureButton.Text = "Confirm the signature";
            this.confirmTheSignatureButton.UseVisualStyleBackColor = true;
            // 
            // signatureConfirmedLabel
            // 
            this.signatureConfirmedLabel.AutoSize = true;
            this.signatureConfirmedLabel.Location = new System.Drawing.Point(159, 217);
            this.signatureConfirmedLabel.Name = "signatureConfirmedLabel";
            this.signatureConfirmedLabel.Size = new System.Drawing.Size(35, 13);
            this.signatureConfirmedLabel.TabIndex = 9;
            this.signatureConfirmedLabel.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(363, 239);
            this.Controls.Add(this.signatureConfirmedLabel);
            this.Controls.Add(this.confirmTheSignatureButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.digitalSignatureFromTheSender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.messageFromTheSender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Receiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox messageFromTheSender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox digitalSignatureFromTheSender;
        private System.Windows.Forms.Button confirmTheSignatureButton;
        private System.Windows.Forms.Label signatureConfirmedLabel;
    }
}


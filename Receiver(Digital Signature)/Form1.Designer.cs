
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
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
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
            this.label3.Location = new System.Drawing.Point(111, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message from the sender";
            // 
            // messageFromTheSender
            // 
            this.messageFromTheSender.Location = new System.Drawing.Point(12, 168);
            this.messageFromTheSender.Name = "messageFromTheSender";
            this.messageFromTheSender.Size = new System.Drawing.Size(339, 20);
            this.messageFromTheSender.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digital signature value from the sender";
            // 
            // digitalSignatureFromTheSender
            // 
            this.digitalSignatureFromTheSender.Location = new System.Drawing.Point(12, 219);
            this.digitalSignatureFromTheSender.Name = "digitalSignatureFromTheSender";
            this.digitalSignatureFromTheSender.Size = new System.Drawing.Size(339, 20);
            this.digitalSignatureFromTheSender.TabIndex = 6;
            // 
            // confirmTheSignatureButton
            // 
            this.confirmTheSignatureButton.Location = new System.Drawing.Point(114, 264);
            this.confirmTheSignatureButton.Name = "confirmTheSignatureButton";
            this.confirmTheSignatureButton.Size = new System.Drawing.Size(131, 23);
            this.confirmTheSignatureButton.TabIndex = 8;
            this.confirmTheSignatureButton.Text = "Confirm the signature";
            this.confirmTheSignatureButton.UseVisualStyleBackColor = true;
            // 
            // signatureConfirmedLabel
            // 
            this.signatureConfirmedLabel.AutoSize = true;
            this.signatureConfirmedLabel.Location = new System.Drawing.Point(159, 307);
            this.signatureConfirmedLabel.Name = "signatureConfirmedLabel";
            this.signatureConfirmedLabel.Size = new System.Drawing.Size(35, 13);
            this.signatureConfirmedLabel.TabIndex = 9;
            this.signatureConfirmedLabel.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-34, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "________________________________________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Port:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(247, 62);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(77, 20);
            this.portTextBox.TabIndex = 21;
            this.portTextBox.Text = "8087";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "IP:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(46, 62);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(158, 20);
            this.ipTextBox.TabIndex = 19;
            this.ipTextBox.Text = "127.0.0.1";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(195, 88);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 18;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(102, 88);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 17;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(363, 339);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label5);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
    }
}


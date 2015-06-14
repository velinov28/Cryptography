namespace ManyAlphabeticallySubstitution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtEncryptedTextRes = new System.Windows.Forms.TextBox();
            this.btnEncryptText = new System.Windows.Forms.Button();
            this.txtOrigText = new System.Windows.Forms.TextBox();
            this.lblOrigText = new System.Windows.Forms.Label();
            this.lblEncryptedTextRes = new System.Windows.Forms.Label();
            this.gbEncryption = new System.Windows.Forms.GroupBox();
            this.txtOrigTextRes = new System.Windows.Forms.TextBox();
            this.btnDecryptText = new System.Windows.Forms.Button();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.lblEncryptedText = new System.Windows.Forms.Label();
            this.lblOrigTextRes = new System.Windows.Forms.Label();
            this.gbDecryption = new System.Windows.Forms.GroupBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbEncryption.SuspendLayout();
            this.gbDecryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEncryptedTextRes
            // 
            this.txtEncryptedTextRes.Location = new System.Drawing.Point(87, 67);
            this.txtEncryptedTextRes.MaxLength = 300;
            this.txtEncryptedTextRes.Multiline = true;
            this.txtEncryptedTextRes.Name = "txtEncryptedTextRes";
            this.txtEncryptedTextRes.Size = new System.Drawing.Size(760, 35);
            this.txtEncryptedTextRes.TabIndex = 1;
            this.txtEncryptedTextRes.Visible = false;
            // 
            // btnEncryptText
            // 
            this.btnEncryptText.Location = new System.Drawing.Point(9, 126);
            this.btnEncryptText.Name = "btnEncryptText";
            this.btnEncryptText.Size = new System.Drawing.Size(99, 23);
            this.btnEncryptText.TabIndex = 2;
            this.btnEncryptText.Text = "Шифрирай";
            this.btnEncryptText.UseVisualStyleBackColor = true;
            this.btnEncryptText.Click += new System.EventHandler(this.btnEncryptText_Click);
            // 
            // txtOrigText
            // 
            this.txtOrigText.Location = new System.Drawing.Point(87, 26);
            this.txtOrigText.MaxLength = 300;
            this.txtOrigText.Multiline = true;
            this.txtOrigText.Name = "txtOrigText";
            this.txtOrigText.Size = new System.Drawing.Size(760, 35);
            this.txtOrigText.TabIndex = 1;
            // 
            // lblOrigText
            // 
            this.lblOrigText.AutoSize = true;
            this.lblOrigText.Location = new System.Drawing.Point(18, 26);
            this.lblOrigText.Name = "lblOrigText";
            this.lblOrigText.Size = new System.Drawing.Size(69, 15);
            this.lblOrigText.TabIndex = 0;
            this.lblOrigText.Text = "Явен текст:";
            // 
            // lblEncryptedTextRes
            // 
            this.lblEncryptedTextRes.AutoSize = true;
            this.lblEncryptedTextRes.Location = new System.Drawing.Point(3, 67);
            this.lblEncryptedTextRes.Name = "lblEncryptedTextRes";
            this.lblEncryptedTextRes.Size = new System.Drawing.Size(84, 15);
            this.lblEncryptedTextRes.TabIndex = 0;
            this.lblEncryptedTextRes.Text = "Криптограма:";
            this.lblEncryptedTextRes.Visible = false;
            // 
            // gbEncryption
            // 
            this.gbEncryption.Controls.Add(this.lblEncryptedTextRes);
            this.gbEncryption.Controls.Add(this.lblOrigText);
            this.gbEncryption.Controls.Add(this.txtOrigText);
            this.gbEncryption.Controls.Add(this.btnEncryptText);
            this.gbEncryption.Controls.Add(this.txtEncryptedTextRes);
            this.gbEncryption.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEncryption.Location = new System.Drawing.Point(42, 44);
            this.gbEncryption.Name = "gbEncryption";
            this.gbEncryption.Size = new System.Drawing.Size(872, 155);
            this.gbEncryption.TabIndex = 3;
            this.gbEncryption.TabStop = false;
            this.gbEncryption.Text = " Режим шифроване ";
            // 
            // txtOrigTextRes
            // 
            this.txtOrigTextRes.Location = new System.Drawing.Point(87, 64);
            this.txtOrigTextRes.MaxLength = 300;
            this.txtOrigTextRes.Multiline = true;
            this.txtOrigTextRes.Name = "txtOrigTextRes";
            this.txtOrigTextRes.Size = new System.Drawing.Size(760, 35);
            this.txtOrigTextRes.TabIndex = 1;
            this.txtOrigTextRes.Visible = false;
            // 
            // btnDecryptText
            // 
            this.btnDecryptText.Location = new System.Drawing.Point(9, 115);
            this.btnDecryptText.Name = "btnDecryptText";
            this.btnDecryptText.Size = new System.Drawing.Size(99, 23);
            this.btnDecryptText.TabIndex = 2;
            this.btnDecryptText.Text = "Дешифрирай";
            this.btnDecryptText.UseVisualStyleBackColor = true;
            this.btnDecryptText.Click += new System.EventHandler(this.btnDecryptText_Click);
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Location = new System.Drawing.Point(87, 23);
            this.txtEncryptedText.MaxLength = 300;
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.Size = new System.Drawing.Size(760, 35);
            this.txtEncryptedText.TabIndex = 1;
            // 
            // lblEncryptedText
            // 
            this.lblEncryptedText.AutoSize = true;
            this.lblEncryptedText.Location = new System.Drawing.Point(3, 23);
            this.lblEncryptedText.Name = "lblEncryptedText";
            this.lblEncryptedText.Size = new System.Drawing.Size(84, 15);
            this.lblEncryptedText.TabIndex = 0;
            this.lblEncryptedText.Text = "Криптограма:";
            // 
            // lblOrigTextRes
            // 
            this.lblOrigTextRes.AutoSize = true;
            this.lblOrigTextRes.Location = new System.Drawing.Point(18, 64);
            this.lblOrigTextRes.Name = "lblOrigTextRes";
            this.lblOrigTextRes.Size = new System.Drawing.Size(69, 15);
            this.lblOrigTextRes.TabIndex = 0;
            this.lblOrigTextRes.Text = "Явен текст:";
            this.lblOrigTextRes.Visible = false;
            // 
            // gbDecryption
            // 
            this.gbDecryption.Controls.Add(this.lblOrigTextRes);
            this.gbDecryption.Controls.Add(this.lblEncryptedText);
            this.gbDecryption.Controls.Add(this.txtEncryptedText);
            this.gbDecryption.Controls.Add(this.btnDecryptText);
            this.gbDecryption.Controls.Add(this.txtOrigTextRes);
            this.gbDecryption.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbDecryption.Location = new System.Drawing.Point(42, 237);
            this.gbDecryption.Name = "gbDecryption";
            this.gbDecryption.Size = new System.Drawing.Size(872, 144);
            this.gbDecryption.TabIndex = 4;
            this.gbDecryption.TabStop = false;
            this.gbDecryption.Text = " Режим дешифриране ";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCounter.Location = new System.Drawing.Point(12, 9);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(0, 15);
            this.lblCounter.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.5F);
            this.btnClear.Location = new System.Drawing.Point(207, 208);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Изчисти полетата";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.5F);
            this.btnExit.Location = new System.Drawing.Point(355, 208);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Изход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 415);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.gbDecryption);
            this.Controls.Add(this.gbEncryption);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Многоазбучно заместване";
            this.gbEncryption.ResumeLayout(false);
            this.gbEncryption.PerformLayout();
            this.gbDecryption.ResumeLayout(false);
            this.gbDecryption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncryptedTextRes;
        private System.Windows.Forms.Button btnEncryptText;
        private System.Windows.Forms.TextBox txtOrigText;
        private System.Windows.Forms.Label lblOrigText;
        private System.Windows.Forms.Label lblEncryptedTextRes;
        private System.Windows.Forms.GroupBox gbEncryption;
        private System.Windows.Forms.TextBox txtOrigTextRes;
        private System.Windows.Forms.Button btnDecryptText;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Label lblEncryptedText;
        private System.Windows.Forms.Label lblOrigTextRes;
        private System.Windows.Forms.GroupBox gbDecryption;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

    }
}


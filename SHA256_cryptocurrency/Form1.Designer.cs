namespace SHA256_cryptocurrency
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetSHA256 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cboZeroHeader = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsedtime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetSHA256
            // 
            this.btnGetSHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSHA256.Location = new System.Drawing.Point(406, 9);
            this.btnGetSHA256.Name = "btnGetSHA256";
            this.btnGetSHA256.Size = new System.Drawing.Size(123, 32);
            this.btnGetSHA256.TabIndex = 0;
            this.btnGetSHA256.Text = "Get SHA 256";
            this.btnGetSHA256.UseVisualStyleBackColor = true;
            this.btnGetSHA256.Click += new System.EventHandler(this.btnGetSHA256_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 187);
            this.textBox1.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Enabled = false;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(639, 9);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(138, 32);
            this.txtInput.TabIndex = 2;
            // 
            // cboZeroHeader
            // 
            this.cboZeroHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboZeroHeader.FormattingEnabled = true;
            this.cboZeroHeader.Location = new System.Drawing.Point(138, 11);
            this.cboZeroHeader.Name = "cboZeroHeader";
            this.cboZeroHeader.Size = new System.Drawing.Size(81, 28);
            this.cboZeroHeader.TabIndex = 3;
            this.cboZeroHeader.SelectedIndexChanged += new System.EventHandler(this.cboZeroHeader_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "多少0在前面";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Work proof:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "使用時間:";
            // 
            // lblUsedtime
            // 
            this.lblUsedtime.AutoSize = true;
            this.lblUsedtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedtime.Location = new System.Drawing.Point(505, 237);
            this.lblUsedtime.Name = "lblUsedtime";
            this.lblUsedtime.Size = new System.Drawing.Size(30, 20);
            this.lblUsedtime.TabIndex = 7;
            this.lblUsedtime.Text = "ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.lblUsedtime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboZeroHeader);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGetSHA256);
            this.Name = "Form1";
            this.Text = "Workproof generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSHA256;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cboZeroHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsedtime;
    }
}


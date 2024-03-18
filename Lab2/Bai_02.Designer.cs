namespace Lab2
{
    partial class Bai_02
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
            this.btnRead = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUrl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.tbName_File = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbLine = new System.Windows.Forms.TextBox();
            this.tbTu = new System.Windows.Forms.TextBox();
            this.tbChar = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(49, 53);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(130, 65);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "ĐỌC FILE";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(45, 154);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tên File";
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUrl.Location = new System.Drawing.Point(45, 198);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(31, 20);
            this.lbUrl.TabIndex = 2;
            this.lbUrl.Text = "Url";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Dòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số Từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Kí Tự";
            // 
            // rtbShow
            // 
            this.rtbShow.Location = new System.Drawing.Point(365, 12);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.ReadOnly = true;
            this.rtbShow.Size = new System.Drawing.Size(423, 426);
            this.rtbShow.TabIndex = 6;
            this.rtbShow.Text = "";
            // 
            // tbName_File
            // 
            this.tbName_File.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbName_File.Location = new System.Drawing.Point(165, 152);
            this.tbName_File.Name = "tbName_File";
            this.tbName_File.ReadOnly = true;
            this.tbName_File.Size = new System.Drawing.Size(166, 22);
            this.tbName_File.TabIndex = 7;
            // 
            // tbUrl
            // 
            this.tbUrl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbUrl.Location = new System.Drawing.Point(165, 198);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.ReadOnly = true;
            this.tbUrl.Size = new System.Drawing.Size(166, 22);
            this.tbUrl.TabIndex = 8;
            // 
            // tbLine
            // 
            this.tbLine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbLine.Location = new System.Drawing.Point(165, 242);
            this.tbLine.Name = "tbLine";
            this.tbLine.ReadOnly = true;
            this.tbLine.Size = new System.Drawing.Size(166, 22);
            this.tbLine.TabIndex = 9;
            // 
            // tbTu
            // 
            this.tbTu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbTu.Location = new System.Drawing.Point(165, 288);
            this.tbTu.Name = "tbTu";
            this.tbTu.ReadOnly = true;
            this.tbTu.Size = new System.Drawing.Size(166, 22);
            this.tbTu.TabIndex = 10;
            // 
            // tbChar
            // 
            this.tbChar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbChar.Location = new System.Drawing.Point(165, 331);
            this.tbChar.Name = "tbChar";
            this.tbChar.ReadOnly = true;
            this.tbChar.Size = new System.Drawing.Size(166, 22);
            this.tbChar.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(49, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 57);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(854, 492);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbChar);
            this.Controls.Add(this.tbTu);
            this.Controls.Add(this.tbLine);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbName_File);
            this.Controls.Add(this.rtbShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnRead);
            this.Name = "Bai_02";
            this.Text = "Bai_02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.TextBox tbName_File;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbLine;
        private System.Windows.Forms.TextBox tbTu;
        private System.Windows.Forms.TextBox tbChar;
        private System.Windows.Forms.Button btnExit;
    }
}
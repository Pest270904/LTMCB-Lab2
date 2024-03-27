namespace Lab2
{
    partial class Bai_03
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
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.ReadRTB = new System.Windows.Forms.RichTextBox();
            this.OutputRTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Read
            // 
            this.btn_Read.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Read.Location = new System.Drawing.Point(186, 419);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(110, 48);
            this.btn_Read.TabIndex = 0;
            this.btn_Read.Text = "Đọc";
            this.btn_Read.UseVisualStyleBackColor = false;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_Calc
            // 
            this.btn_Calc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Calc.Location = new System.Drawing.Point(720, 419);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(110, 48);
            this.btn_Calc.TabIndex = 1;
            this.btn_Calc.Text = "Tính";
            this.btn_Calc.UseVisualStyleBackColor = false;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Exit.Location = new System.Drawing.Point(453, 513);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(110, 48);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ReadRTB
            // 
            this.ReadRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadRTB.Location = new System.Drawing.Point(56, 42);
            this.ReadRTB.Name = "ReadRTB";
            this.ReadRTB.Size = new System.Drawing.Size(387, 345);
            this.ReadRTB.TabIndex = 3;
            this.ReadRTB.Text = "";
            // 
            // OutputRTB
            // 
            this.OutputRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputRTB.Location = new System.Drawing.Point(569, 42);
            this.OutputRTB.Name = "OutputRTB";
            this.OutputRTB.ReadOnly = true;
            this.OutputRTB.Size = new System.Drawing.Size(387, 345);
            this.OutputRTB.TabIndex = 4;
            this.OutputRTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "input_3.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "output_3.txt";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Clear.Location = new System.Drawing.Point(453, 419);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 48);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Xóa";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Bai_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1008, 573);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputRTB);
            this.Controls.Add(this.ReadRTB);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.btn_Read);
            this.Name = "Bai_03";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.RichTextBox ReadRTB;
        private System.Windows.Forms.RichTextBox OutputRTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Clear;
    }
}
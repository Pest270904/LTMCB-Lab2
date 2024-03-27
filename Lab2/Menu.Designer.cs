namespace Lab2
{
    partial class Menu
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
            this.btn_Bai1 = new System.Windows.Forms.Button();
            this.btn_Bai2 = new System.Windows.Forms.Button();
            this.btn_Bai3 = new System.Windows.Forms.Button();
            this.btn_Bai5 = new System.Windows.Forms.Button();
            this.btn_Bai4 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Bai1
            // 
            this.btn_Bai1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Bai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai1.Location = new System.Drawing.Point(69, 75);
            this.btn_Bai1.Name = "btn_Bai1";
            this.btn_Bai1.Size = new System.Drawing.Size(142, 60);
            this.btn_Bai1.TabIndex = 0;
            this.btn_Bai1.Text = "Bài 1";
            this.btn_Bai1.UseVisualStyleBackColor = false;
            this.btn_Bai1.Click += new System.EventHandler(this.btn_Bai1_Click);
            // 
            // btn_Bai2
            // 
            this.btn_Bai2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Bai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai2.Location = new System.Drawing.Point(294, 75);
            this.btn_Bai2.Name = "btn_Bai2";
            this.btn_Bai2.Size = new System.Drawing.Size(142, 60);
            this.btn_Bai2.TabIndex = 1;
            this.btn_Bai2.Text = "Bài 2";
            this.btn_Bai2.UseVisualStyleBackColor = false;
            this.btn_Bai2.Click += new System.EventHandler(this.btn_Bai2_Click);
            // 
            // btn_Bai3
            // 
            this.btn_Bai3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Bai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai3.Location = new System.Drawing.Point(544, 75);
            this.btn_Bai3.Name = "btn_Bai3";
            this.btn_Bai3.Size = new System.Drawing.Size(142, 60);
            this.btn_Bai3.TabIndex = 2;
            this.btn_Bai3.Text = "Bài 3";
            this.btn_Bai3.UseVisualStyleBackColor = false;
            this.btn_Bai3.Click += new System.EventHandler(this.btn_Bai3_Click);
            // 
            // btn_Bai5
            // 
            this.btn_Bai5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Bai5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai5.Location = new System.Drawing.Point(437, 195);
            this.btn_Bai5.Name = "btn_Bai5";
            this.btn_Bai5.Size = new System.Drawing.Size(142, 60);
            this.btn_Bai5.TabIndex = 3;
            this.btn_Bai5.Text = "Bài 4";
            this.btn_Bai5.UseVisualStyleBackColor = false;
            this.btn_Bai5.Click += new System.EventHandler(this.btn_Bai5_Click);
            // 
            // btn_Bai4
            // 
            this.btn_Bai4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Bai4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai4.Location = new System.Drawing.Point(175, 195);
            this.btn_Bai4.Name = "btn_Bai4";
            this.btn_Bai4.Size = new System.Drawing.Size(142, 60);
            this.btn_Bai4.TabIndex = 4;
            this.btn_Bai4.Text = "Bài 5";
            this.btn_Bai4.UseVisualStyleBackColor = false;
            this.btn_Bai4.Click += new System.EventHandler(this.btn_Bai4_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(294, 331);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(142, 60);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Bai4);
            this.Controls.Add(this.btn_Bai5);
            this.Controls.Add(this.btn_Bai3);
            this.Controls.Add(this.btn_Bai2);
            this.Controls.Add(this.btn_Bai1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Bai1;
        private System.Windows.Forms.Button btn_Bai2;
        private System.Windows.Forms.Button btn_Bai3;
        private System.Windows.Forms.Button btn_Bai5;
        private System.Windows.Forms.Button btn_Bai4;
        private System.Windows.Forms.Button btn_Exit;
    }
}
namespace Client
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnSoChan = new System.Windows.Forms.Button();
            this.btnSoLe = new System.Windows.Forms.Button();
            this.btnSNT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH KHÔNG TÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(81, 41);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số thứ hai:";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(81, 67);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số thứ ba:";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(81, 95);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số thứ tư:";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(81, 121);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số thứ năm:";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(81, 147);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 20);
            this.txt5.TabIndex = 2;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(204, 41);
            this.txtKq.Multiline = true;
            this.txtKq.Name = "txtKq";
            this.txtKq.ReadOnly = true;
            this.txtKq.Size = new System.Drawing.Size(192, 39);
            this.txtKq.TabIndex = 3;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(204, 115);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(42, 23);
            this.btnMax.TabIndex = 4;
            this.btnMax.Text = "max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(256, 115);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(34, 23);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(299, 115);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(34, 23);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(341, 115);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(55, 23);
            this.btnAverage.TabIndex = 4;
            this.btnAverage.Text = "average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnSoChan
            // 
            this.btnSoChan.Location = new System.Drawing.Point(250, 144);
            this.btnSoChan.Name = "btnSoChan";
            this.btnSoChan.Size = new System.Drawing.Size(57, 23);
            this.btnSoChan.TabIndex = 5;
            this.btnSoChan.Text = "Số chẵn";
            this.btnSoChan.UseVisualStyleBackColor = true;
            this.btnSoChan.Click += new System.EventHandler(this.btnSoChan_Click);
            // 
            // btnSoLe
            // 
            this.btnSoLe.Location = new System.Drawing.Point(204, 144);
            this.btnSoLe.Name = "btnSoLe";
            this.btnSoLe.Size = new System.Drawing.Size(42, 23);
            this.btnSoLe.TabIndex = 6;
            this.btnSoLe.Text = "Số lẻ";
            this.btnSoLe.UseVisualStyleBackColor = true;
            this.btnSoLe.Click += new System.EventHandler(this.btnSoLe_Click);
            // 
            // btnSNT
            // 
            this.btnSNT.Location = new System.Drawing.Point(311, 144);
            this.btnSNT.Name = "btnSNT";
            this.btnSNT.Size = new System.Drawing.Size(85, 23);
            this.btnSNT.TabIndex = 5;
            this.btnSNT.Text = "Số nguyên tố";
            this.btnSNT.UseVisualStyleBackColor = true;
            this.btnSNT.Click += new System.EventHandler(this.btnSNT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 190);
            this.Controls.Add(this.btnSNT);
            this.Controls.Add(this.btnSoChan);
            this.Controls.Add(this.btnSoLe);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnSoChan;
        private System.Windows.Forms.Button btnSoLe;
        private System.Windows.Forms.Button btnSNT;
    }
}


namespace WindowsFormsApp1
{
    partial class Form2
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
            this.tbSox = new System.Windows.Forms.TextBox();
            this.tbSoy = new System.Windows.Forms.TextBox();
            this.tbLuu = new System.Windows.Forms.Button();
            this.tbThoat = new System.Windows.Forms.Button();
            this.tbCong = new System.Windows.Forms.Button();
            this.tbNhan = new System.Windows.Forms.Button();
            this.So = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKetQua = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbSox
            // 
            this.tbSox.Location = new System.Drawing.Point(81, 23);
            this.tbSox.Name = "tbSox";
            this.tbSox.Size = new System.Drawing.Size(548, 20);
            this.tbSox.TabIndex = 0;
            this.tbSox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbSoy
            // 
            this.tbSoy.Location = new System.Drawing.Point(81, 64);
            this.tbSoy.Name = "tbSoy";
            this.tbSoy.Size = new System.Drawing.Size(548, 20);
            this.tbSoy.TabIndex = 1;
            // 
            // tbLuu
            // 
            this.tbLuu.Location = new System.Drawing.Point(12, 415);
            this.tbLuu.Name = "tbLuu";
            this.tbLuu.Size = new System.Drawing.Size(75, 23);
            this.tbLuu.TabIndex = 3;
            this.tbLuu.Text = "Lưu";
            this.tbLuu.UseVisualStyleBackColor = true;
            this.tbLuu.Click += new System.EventHandler(this.tbLuu_Click);
            // 
            // tbThoat
            // 
            this.tbThoat.Location = new System.Drawing.Point(554, 415);
            this.tbThoat.Name = "tbThoat";
            this.tbThoat.Size = new System.Drawing.Size(75, 23);
            this.tbThoat.TabIndex = 4;
            this.tbThoat.Text = "Thoát";
            this.tbThoat.UseVisualStyleBackColor = true;
            this.tbThoat.Click += new System.EventHandler(this.tbThoat_Click);
            // 
            // tbCong
            // 
            this.tbCong.Location = new System.Drawing.Point(363, 415);
            this.tbCong.Name = "tbCong";
            this.tbCong.Size = new System.Drawing.Size(75, 23);
            this.tbCong.TabIndex = 5;
            this.tbCong.Text = "Cộng";
            this.tbCong.UseVisualStyleBackColor = true;
            this.tbCong.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbNhan
            // 
            this.tbNhan.Location = new System.Drawing.Point(457, 415);
            this.tbNhan.Name = "tbNhan";
            this.tbNhan.Size = new System.Drawing.Size(75, 23);
            this.tbNhan.TabIndex = 6;
            this.tbNhan.Text = "Nhân";
            this.tbNhan.UseVisualStyleBackColor = true;
            this.tbNhan.Click += new System.EventHandler(this.tbNhan_Click);
            // 
            // So
            // 
            this.So.AutoSize = true;
            this.So.Location = new System.Drawing.Point(34, 30);
            this.So.Name = "So";
            this.So.Size = new System.Drawing.Size(28, 13);
            this.So.TabIndex = 8;
            this.So.Text = "Số x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kết quả";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(81, 107);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(548, 290);
            this.tbKetQua.TabIndex = 11;
            this.tbKetQua.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.So);
            this.Controls.Add(this.tbNhan);
            this.Controls.Add(this.tbCong);
            this.Controls.Add(this.tbThoat);
            this.Controls.Add(this.tbLuu);
            this.Controls.Add(this.tbSoy);
            this.Controls.Add(this.tbSox);
            this.Name = "Form2";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSox;
        private System.Windows.Forms.TextBox tbSoy;
        private System.Windows.Forms.Button tbLuu;
        private System.Windows.Forms.Button tbThoat;
        private System.Windows.Forms.Button tbCong;
        private System.Windows.Forms.Button tbNhan;
        private System.Windows.Forms.Label So;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbKetQua;
    }
}
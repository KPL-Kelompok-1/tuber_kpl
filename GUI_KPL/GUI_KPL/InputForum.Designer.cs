namespace GUI_KPL
{
    partial class InputForum
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
            this.input_nama = new System.Windows.Forms.TextBox();
            this.input_desa = new System.Windows.Forms.TextBox();
            this.input_pertanyaan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama            :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asal Desa    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pertanyaan :";
            // 
            // input_nama
            // 
            this.input_nama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.input_nama.Location = new System.Drawing.Point(157, 50);
            this.input_nama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_nama.Name = "input_nama";
            this.input_nama.Size = new System.Drawing.Size(362, 22);
            this.input_nama.TabIndex = 3;
            // 
            // input_desa
            // 
            this.input_desa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.input_desa.Location = new System.Drawing.Point(157, 106);
            this.input_desa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_desa.Name = "input_desa";
            this.input_desa.Size = new System.Drawing.Size(362, 22);
            this.input_desa.TabIndex = 4;
            // 
            // input_pertanyaan
            // 
            this.input_pertanyaan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.input_pertanyaan.Location = new System.Drawing.Point(157, 175);
            this.input_pertanyaan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_pertanyaan.Name = "input_pertanyaan";
            this.input_pertanyaan.Size = new System.Drawing.Size(362, 22);
            this.input_pertanyaan.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(410, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_kembali.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.ForeColor = System.Drawing.Color.White;
            this.btn_kembali.Location = new System.Drawing.Point(295, 221);
            this.btn_kembali.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(109, 38);
            this.btn_kembali.TabIndex = 7;
            this.btn_kembali.Text = "kembali";
            this.btn_kembali.UseVisualStyleBackColor = false;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // InputForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 284);
            this.Controls.Add(this.btn_kembali);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input_pertanyaan);
            this.Controls.Add(this.input_desa);
            this.Controls.Add(this.input_nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InputForum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.InputForum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_nama;
        private System.Windows.Forms.TextBox input_desa;
        private System.Windows.Forms.TextBox input_pertanyaan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_kembali;
    }
}
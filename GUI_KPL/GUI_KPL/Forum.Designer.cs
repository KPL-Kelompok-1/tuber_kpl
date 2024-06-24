namespace GUI_KPL
{
    partial class Forum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forum));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.list_forum = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_profile);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 430);
            this.panel1.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(39, 74);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 34);
            this.button3.TabIndex = 17;
            this.button3.Text = "Dashboard";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_profile.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.Location = new System.Drawing.Point(39, 38);
            this.btn_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(144, 34);
            this.btn_profile.TabIndex = 16;
            this.btn_profile.Text = "Profile";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_logout.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(39, 346);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(144, 34);
            this.btn_logout.TabIndex = 15;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_sub.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.ForeColor = System.Drawing.Color.White;
            this.btn_sub.Location = new System.Drawing.Point(556, 345);
            this.btn_sub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(152, 34);
            this.btn_sub.TabIndex = 13;
            this.btn_sub.Text = "Mulai Diskusi Baru";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_del.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Location = new System.Drawing.Point(415, 345);
            this.btn_del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(122, 34);
            this.btn_del.TabIndex = 15;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(420, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "FORUM";
            // 
            // list_forum
            // 
            this.list_forum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.list_forum.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_forum.FormattingEnabled = true;
            this.list_forum.ItemHeight = 17;
            this.list_forum.Location = new System.Drawing.Point(249, 82);
            this.list_forum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_forum.Name = "list_forum";
            this.list_forum.Size = new System.Drawing.Size(460, 225);
            this.list_forum.TabIndex = 12;
            this.list_forum.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Forum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 426);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.list_forum);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Forum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_forum;
        private System.Windows.Forms.Button button3;
    }
}

namespace CheckedListBox
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
            this.tümünüsec = new System.Windows.Forms.Button();
            this.secilenikaldir = new System.Windows.Forms.Button();
            this.listboxekle = new System.Windows.Forms.Button();
            this.elemanekle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tümünüsec
            // 
            this.tümünüsec.BackColor = System.Drawing.Color.LightGreen;
            this.tümünüsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tümünüsec.Location = new System.Drawing.Point(309, 59);
            this.tümünüsec.Name = "tümünüsec";
            this.tümünüsec.Size = new System.Drawing.Size(173, 37);
            this.tümünüsec.TabIndex = 0;
            this.tümünüsec.Text = "Tümünü Seç";
            this.tümünüsec.UseVisualStyleBackColor = false;
            this.tümünüsec.Click += new System.EventHandler(this.tümünüsec_Click);
            // 
            // secilenikaldir
            // 
            this.secilenikaldir.BackColor = System.Drawing.Color.Tomato;
            this.secilenikaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secilenikaldir.Location = new System.Drawing.Point(309, 118);
            this.secilenikaldir.Name = "secilenikaldir";
            this.secilenikaldir.Size = new System.Drawing.Size(173, 37);
            this.secilenikaldir.TabIndex = 1;
            this.secilenikaldir.Text = "Seçileni Kaldır";
            this.secilenikaldir.UseVisualStyleBackColor = false;
            this.secilenikaldir.Click += new System.EventHandler(this.secilenikaldir_Click);
            // 
            // listboxekle
            // 
            this.listboxekle.BackColor = System.Drawing.Color.Pink;
            this.listboxekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listboxekle.Location = new System.Drawing.Point(309, 248);
            this.listboxekle.Name = "listboxekle";
            this.listboxekle.Size = new System.Drawing.Size(173, 37);
            this.listboxekle.TabIndex = 2;
            this.listboxekle.Text = "ListBox\'a Aktar";
            this.listboxekle.UseVisualStyleBackColor = false;
            this.listboxekle.Click += new System.EventHandler(this.listboxekle_Click);
            // 
            // elemanekle
            // 
            this.elemanekle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.elemanekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elemanekle.Location = new System.Drawing.Point(309, 183);
            this.elemanekle.Name = "elemanekle";
            this.elemanekle.Size = new System.Drawing.Size(173, 37);
            this.elemanekle.TabIndex = 3;
            this.elemanekle.Text = "Eleman Ekle";
            this.elemanekle.UseVisualStyleBackColor = false;
            this.elemanekle.Click += new System.EventHandler(this.elemanekle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(546, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 228);
            this.listBox1.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Ankara",
            "Amasya",
            "Samsun",
            "İstanbul",
            "Konya",
            "Bursa",
            "Rize"});
            this.checkedListBox1.Location = new System.Drawing.Point(29, 61);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(210, 229);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(53, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toplam Eleman Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(53, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seçilen Eleman Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label3.Location = new System.Drawing.Point(54, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.elemanekle);
            this.Controls.Add(this.listboxekle);
            this.Controls.Add(this.secilenikaldir);
            this.Controls.Add(this.tümünüsec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tümünüsec;
        private System.Windows.Forms.Button secilenikaldir;
        private System.Windows.Forms.Button listboxekle;
        private System.Windows.Forms.Button elemanekle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


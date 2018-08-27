namespace DomowaApteczka
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
            this.ButonSzukaj = new System.Windows.Forms.Button();
            this.ButtonZawartosc = new System.Windows.Forms.Button();
            this.ButtonEdytuj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonDrukuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButonSzukaj
            // 
            this.ButonSzukaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButonSzukaj.Location = new System.Drawing.Point(748, 182);
            this.ButonSzukaj.Name = "ButonSzukaj";
            this.ButonSzukaj.Size = new System.Drawing.Size(155, 23);
            this.ButonSzukaj.TabIndex = 3;
            this.ButonSzukaj.Text = "Szukaj leku";
            this.ButonSzukaj.UseVisualStyleBackColor = true;
            // 
            // ButtonZawartosc
            // 
            this.ButtonZawartosc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonZawartosc.Location = new System.Drawing.Point(748, 125);
            this.ButtonZawartosc.Name = "ButtonZawartosc";
            this.ButtonZawartosc.Size = new System.Drawing.Size(155, 23);
            this.ButtonZawartosc.TabIndex = 4;
            this.ButtonZawartosc.Text = "Zawartość apteczki";
            this.ButtonZawartosc.UseVisualStyleBackColor = true;
            // 
            // ButtonEdytuj
            // 
            this.ButtonEdytuj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEdytuj.Location = new System.Drawing.Point(748, 241);
            this.ButtonEdytuj.Name = "ButtonEdytuj";
            this.ButtonEdytuj.Size = new System.Drawing.Size(155, 23);
            this.ButtonEdytuj.TabIndex = 2;
            this.ButtonEdytuj.Text = "Edytuj zawartość apteczki";
            this.ButtonEdytuj.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(683, 594);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(827, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zalogowany:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonDrukuj
            // 
            this.ButtonDrukuj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDrukuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDrukuj.Location = new System.Drawing.Point(748, 310);
            this.ButtonDrukuj.Name = "ButtonDrukuj";
            this.ButtonDrukuj.Size = new System.Drawing.Size(155, 23);
            this.ButtonDrukuj.TabIndex = 8;
            this.ButtonDrukuj.Text = "Drukuj";
            this.ButtonDrukuj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonDrukuj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 618);
            this.Controls.Add(this.ButtonDrukuj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonZawartosc);
            this.Controls.Add(this.ButonSzukaj);
            this.Controls.Add(this.ButtonEdytuj);
            this.Name = "Form1";
            this.Text = "Domowa Apteczka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButonSzukaj;
        private System.Windows.Forms.Button ButtonZawartosc;
        private System.Windows.Forms.Button ButtonEdytuj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonDrukuj;
    }
}


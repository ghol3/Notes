namespace Notes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lista = new System.Windows.Forms.PictureBox();
            this.Neviditelne = new System.Windows.Forms.PictureBox();
            this.poznamka0 = new System.Windows.Forms.TextBox();
            this.poznamka1 = new System.Windows.Forms.TextBox();
            this.poznamka2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Neviditelne)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Notes.Properties.Resources.notes_plus;
            this.pictureBox1.Location = new System.Drawing.Point(414, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 22);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lista
            // 
            this.Lista.BackgroundImage = global::Notes.Properties.Resources.notes_lista;
            this.Lista.Location = new System.Drawing.Point(231, 0);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(210, 25);
            this.Lista.TabIndex = 1;
            this.Lista.TabStop = false;
            this.Lista.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lista_MouseDown);
            this.Lista.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lista_MouseMove);
            this.Lista.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lista_MouseUp);
            // 
            // Neviditelne
            // 
            this.Neviditelne.BackColor = System.Drawing.Color.Fuchsia;
            this.Neviditelne.Location = new System.Drawing.Point(-7, 0);
            this.Neviditelne.Name = "Neviditelne";
            this.Neviditelne.Size = new System.Drawing.Size(238, 25);
            this.Neviditelne.TabIndex = 0;
            this.Neviditelne.TabStop = false;
            // 
            // poznamka0
            // 
            this.poznamka0.Location = new System.Drawing.Point(12, 34);
            this.poznamka0.Multiline = true;
            this.poznamka0.Name = "poznamka0";
            this.poznamka0.Size = new System.Drawing.Size(44, 40);
            this.poznamka0.TabIndex = 5;
            this.poznamka0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.poznamka0_MouseDown);
            this.poznamka0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.poznamka0_MouseMove);
            this.poznamka0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.poznamka0_MouseUp);
            // 
            // poznamka1
            // 
            this.poznamka1.Location = new System.Drawing.Point(62, 34);
            this.poznamka1.Multiline = true;
            this.poznamka1.Name = "poznamka1";
            this.poznamka1.Size = new System.Drawing.Size(44, 40);
            this.poznamka1.TabIndex = 6;
            // 
            // poznamka2
            // 
            this.poznamka2.Location = new System.Drawing.Point(112, 34);
            this.poznamka2.Multiline = true;
            this.poznamka2.Name = "poznamka2";
            this.poznamka2.Size = new System.Drawing.Size(44, 40);
            this.poznamka2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(441, 279);
            this.Controls.Add(this.poznamka2);
            this.Controls.Add(this.poznamka1);
            this.Controls.Add(this.poznamka0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.Neviditelne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Neviditelne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Neviditelne;
        private System.Windows.Forms.PictureBox Lista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox poznamka0;
        private System.Windows.Forms.TextBox poznamka1;
        private System.Windows.Forms.TextBox poznamka2;
    }
}


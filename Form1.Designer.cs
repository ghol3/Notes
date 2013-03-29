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
            this.Neviditelne = new System.Windows.Forms.PictureBox();
            this.Lista = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Neviditelne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Notes.Properties.Resources.notes_minus;
            this.pictureBox2.Location = new System.Drawing.Point(414, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 22);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Notes.Properties.Resources.notes_edit;
            this.pictureBox3.Location = new System.Drawing.Point(414, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 22);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 279);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.Neviditelne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.Neviditelne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Neviditelne;
        private System.Windows.Forms.PictureBox Lista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}


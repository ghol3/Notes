namespace Notes
{
    partial class ColorForm
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
            this.red = new System.Windows.Forms.TrackBar();
            this.green = new System.Windows.Forms.TrackBar();
            this.blue = new System.Windows.Forms.TrackBar();
            this.Barva = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barva)).BeginInit();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(12, 29);
            this.red.Maximum = 255;
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(195, 45);
            this.red.TabIndex = 0;
            this.red.Scroll += new System.EventHandler(this.red_Scroll);
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(12, 80);
            this.green.Maximum = 255;
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(195, 45);
            this.green.TabIndex = 1;
            this.green.Scroll += new System.EventHandler(this.green_Scroll);
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(12, 131);
            this.blue.Maximum = 255;
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(195, 45);
            this.blue.TabIndex = 2;
            this.blue.Scroll += new System.EventHandler(this.blue_Scroll);
            // 
            // Barva
            // 
            this.Barva.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Barva.Location = new System.Drawing.Point(213, 29);
            this.Barva.Name = "Barva";
            this.Barva.Size = new System.Drawing.Size(59, 58);
            this.Barva.TabIndex = 3;
            this.Barva.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "RED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "GREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "BLUE";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(213, 141);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(59, 23);
            this.OK.TabIndex = 7;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Barva);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColorForm";
            this.Text = "Color";
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar red;
        private System.Windows.Forms.TrackBar green;
        private System.Windows.Forms.TrackBar blue;
        private System.Windows.Forms.PictureBox Barva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OK;
    }
}
namespace Notes
{
    partial class EditForm
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
            this.druh = new System.Windows.Forms.ComboBox();
            this.sirka = new System.Windows.Forms.TextBox();
            this.vyska = new System.Windows.Forms.TextBox();
            this.barva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.ColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // druh
            // 
            this.druh.FormattingEnabled = true;
            this.druh.Items.AddRange(new object[] {
            "Poznamka",
            "Obrazek"});
            this.druh.Location = new System.Drawing.Point(61, 90);
            this.druh.Name = "druh";
            this.druh.Size = new System.Drawing.Size(135, 21);
            this.druh.TabIndex = 0;
            // 
            // sirka
            // 
            this.sirka.Location = new System.Drawing.Point(61, 12);
            this.sirka.Name = "sirka";
            this.sirka.Size = new System.Drawing.Size(85, 20);
            this.sirka.TabIndex = 1;
            // 
            // vyska
            // 
            this.vyska.Location = new System.Drawing.Point(61, 38);
            this.vyska.Name = "vyska";
            this.vyska.Size = new System.Drawing.Size(85, 20);
            this.vyska.TabIndex = 2;
            // 
            // barva
            // 
            this.barva.Location = new System.Drawing.Point(61, 64);
            this.barva.Name = "barva";
            this.barva.Size = new System.Drawing.Size(85, 20);
            this.barva.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sirka : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vyska :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Barva : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Druh : ";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(121, 117);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 8;
            this.Save.Text = "Ulozit";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(152, 61);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(32, 23);
            this.ColorButton.TabIndex = 9;
            this.ColorButton.Text = "...";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 152);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barva);
            this.Controls.Add(this.vyska);
            this.Controls.Add(this.sirka);
            this.Controls.Add(this.druh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditForm";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox druh;
        private System.Windows.Forms.TextBox sirka;
        private System.Windows.Forms.TextBox vyska;
        private System.Windows.Forms.TextBox barva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button ColorButton;
    }
}
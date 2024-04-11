namespace Adatbáziskezelő
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
            this.save = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.save_firstname = new System.Windows.Forms.TextBox();
            this.save_lastname = new System.Windows.Forms.TextBox();
            this.save_address = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(34, 308);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(205, 70);
            this.save.TabIndex = 0;
            this.save.Text = "Mentés";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(267, 308);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(205, 70);
            this.exit.TabIndex = 1;
            this.exit.Text = "Vissza";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save_firstname
            // 
            this.save_firstname.Location = new System.Drawing.Point(80, 163);
            this.save_firstname.Name = "save_firstname";
            this.save_firstname.Size = new System.Drawing.Size(257, 27);
            this.save_firstname.TabIndex = 2;
            // 
            // save_lastname
            // 
            this.save_lastname.Location = new System.Drawing.Point(80, 92);
            this.save_lastname.Name = "save_lastname";
            this.save_lastname.Size = new System.Drawing.Size(257, 27);
            this.save_lastname.TabIndex = 3;
            // 
            // save_address
            // 
            this.save_address.Location = new System.Drawing.Point(80, 234);
            this.save_address.Name = "save_address";
            this.save_address.Size = new System.Drawing.Size(257, 27);
            this.save_address.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.save_address);
            this.groupBox1.Controls.Add(this.save_lastname);
            this.groupBox1.Controls.Add(this.save_firstname);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 290);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatok megadása";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lakhely";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Keresztnév";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vezetéknév";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adat hozzáadása";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button save;
        private Button exit;
        private TextBox save_firstname;
        private TextBox save_lastname;
        private TextBox save_address;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
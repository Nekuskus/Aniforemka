namespace Aniforemka
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OgólneBox = new System.Windows.Forms.GroupBox();
            this.KontoBox = new System.Windows.Forms.GroupBox();
            this.CzarnyMotywSwitch = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OgólneBox.SuspendLayout();
            this.KontoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Ogólne",
            "Konto"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 420);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // OgólneBox
            // 
            this.OgólneBox.Controls.Add(this.CzarnyMotywSwitch);
            this.OgólneBox.Location = new System.Drawing.Point(220, 12);
            this.OgólneBox.Name = "OgólneBox";
            this.OgólneBox.Size = new System.Drawing.Size(568, 420);
            this.OgólneBox.TabIndex = 1;
            this.OgólneBox.TabStop = false;
            this.OgólneBox.Text = "Ogólne";
            this.OgólneBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // KontoBox
            // 
            this.KontoBox.Controls.Add(this.button1);
            this.KontoBox.Controls.Add(this.label1);
            this.KontoBox.Controls.Add(this.textBox1);
            this.KontoBox.Location = new System.Drawing.Point(220, 12);
            this.KontoBox.Name = "KontoBox";
            this.KontoBox.Size = new System.Drawing.Size(568, 420);
            this.KontoBox.TabIndex = 2;
            this.KontoBox.TabStop = false;
            this.KontoBox.Text = "Konto";
            // 
            // CzarnyMotywSwitch
            // 
            this.CzarnyMotywSwitch.AutoSize = true;
            this.CzarnyMotywSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CzarnyMotywSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.CzarnyMotywSwitch.Location = new System.Drawing.Point(10, 16);
            this.CzarnyMotywSwitch.Name = "CzarnyMotywSwitch";
            this.CzarnyMotywSwitch.Size = new System.Drawing.Size(181, 20);
            this.CzarnyMotywSwitch.TabIndex = 0;
            this.CzarnyMotywSwitch.Text = "Używaj ciemnego motywu";
            this.CzarnyMotywSwitch.UseVisualStyleBackColor = true;
            this.CzarnyMotywSwitch.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(10, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa konta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zapisz i zsynchronizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KontoBox);
            this.Controls.Add(this.OgólneBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Ustawienia";
            this.OgólneBox.ResumeLayout(false);
            this.OgólneBox.PerformLayout();
            this.KontoBox.ResumeLayout(false);
            this.KontoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox OgólneBox;
        private System.Windows.Forms.CheckBox CzarnyMotywSwitch;
        private System.Windows.Forms.GroupBox KontoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
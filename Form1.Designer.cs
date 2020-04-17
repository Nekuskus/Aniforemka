namespace Aniforemka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Przycisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Przycisk
            // 
            this.Przycisk.BackColor = System.Drawing.Color.White;
            this.Przycisk.BackgroundImage = global::Aniforemka.Properties.Resources.woomy;
            this.Przycisk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Przycisk.Location = new System.Drawing.Point(156, 12);
            this.Przycisk.Name = "Przycisk";
            this.Przycisk.Size = new System.Drawing.Size(466, 396);
            this.Przycisk.TabIndex = 0;
            this.Przycisk.Text = "Woomy Button";
            this.Przycisk.UseVisualStyleBackColor = false;
            this.Przycisk.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Przycisk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Przycisk;
    }
}


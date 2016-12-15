namespace Snake_uno
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
            this.plansza_gry = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wyswietlacz_wyniku = new System.Windows.Forms.Label();
            this.KomunikatKoncaGry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plansza_gry)).BeginInit();
            this.SuspendLayout();
            // 
            // plansza_gry
            // 
            this.plansza_gry.Cursor = System.Windows.Forms.Cursors.Default;
            this.plansza_gry.Location = new System.Drawing.Point(12, 12);
            this.plansza_gry.Name = "plansza_gry";
            this.plansza_gry.Size = new System.Drawing.Size(438, 344);
            this.plansza_gry.TabIndex = 0;
            this.plansza_gry.TabStop = false;
            this.plansza_gry.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(473, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wynik:";
            // 
            // wyswietlacz_wyniku
            // 
            this.wyswietlacz_wyniku.AutoSize = true;
            this.wyswietlacz_wyniku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyswietlacz_wyniku.Location = new System.Drawing.Point(508, 99);
            this.wyswietlacz_wyniku.Name = "wyswietlacz_wyniku";
            this.wyswietlacz_wyniku.Size = new System.Drawing.Size(0, 31);
            this.wyswietlacz_wyniku.TabIndex = 2;
            // 
            // KomunikatKoncaGry
            // 
            this.KomunikatKoncaGry.AutoSize = true;
            this.KomunikatKoncaGry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KomunikatKoncaGry.Location = new System.Drawing.Point(31, 35);
            this.KomunikatKoncaGry.Name = "KomunikatKoncaGry";
            this.KomunikatKoncaGry.Size = new System.Drawing.Size(0, 31);
            this.KomunikatKoncaGry.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 417);
            this.Controls.Add(this.KomunikatKoncaGry);
            this.Controls.Add(this.wyswietlacz_wyniku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plansza_gry);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.plansza_gry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox plansza_gry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wyswietlacz_wyniku;
        private System.Windows.Forms.Label KomunikatKoncaGry;
    }
}


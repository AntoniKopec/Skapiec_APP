namespace Skapiec_APP
{
    partial class HomeItem
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeItem));
            this.home_picture = new System.Windows.Forms.PictureBox();
            this.home_title_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.home_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // home_picture
            // 
            this.home_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_picture.BackgroundImage")));
            this.home_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.home_picture.Location = new System.Drawing.Point(47, 15);
            this.home_picture.Name = "home_picture";
            this.home_picture.Size = new System.Drawing.Size(140, 154);
            this.home_picture.TabIndex = 1;
            this.home_picture.TabStop = false;
            // 
            // home_title_label
            // 
            this.home_title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.home_title_label.Location = new System.Drawing.Point(3, 180);
            this.home_title_label.Name = "home_title_label";
            this.home_title_label.Size = new System.Drawing.Size(229, 47);
            this.home_title_label.TabIndex = 2;
            this.home_title_label.Text = "Title";
            this.home_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price_label
            // 
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.price_label.Location = new System.Drawing.Point(3, 243);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(229, 47);
            this.price_label.TabIndex = 3;
            this.price_label.Text = "Price";
            this.price_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(3, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 1);
            this.panel1.TabIndex = 4;
            // 
            // HomeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.home_title_label);
            this.Controls.Add(this.home_picture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeItem";
            this.Size = new System.Drawing.Size(235, 294);
            ((System.ComponentModel.ISupportInitialize)(this.home_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox home_picture;
        private System.Windows.Forms.Label home_title_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Panel panel1;
    }
}

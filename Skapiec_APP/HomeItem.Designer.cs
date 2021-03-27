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
            this.home_picture = new System.Windows.Forms.PictureBox();
            this.home_title_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.home_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // home_picture
            // 
            this.home_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.home_picture.Location = new System.Drawing.Point(63, 18);
            this.home_picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.home_picture.Name = "home_picture";
            this.home_picture.Size = new System.Drawing.Size(187, 260);
            this.home_picture.TabIndex = 1;
            this.home_picture.TabStop = false;
            // 
            // home_title_label
            // 
            this.home_title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.home_title_label.Location = new System.Drawing.Point(4, 320);
            this.home_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.home_title_label.Name = "home_title_label";
            this.home_title_label.Size = new System.Drawing.Size(305, 58);
            this.home_title_label.TabIndex = 2;
            this.home_title_label.Text = "Title";
            this.home_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price_label
            // 
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.price_label.Location = new System.Drawing.Point(4, 398);
            this.price_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(305, 58);
            this.price_label.TabIndex = 3;
            this.price_label.Text = "Price";
            this.price_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(4, 388);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 1);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "IDZ DO SKLEPU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.home_title_label);
            this.Controls.Add(this.home_picture);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeItem";
            this.Size = new System.Drawing.Size(313, 457);
            ((System.ComponentModel.ISupportInitialize)(this.home_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox home_picture;
        private System.Windows.Forms.Label home_title_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

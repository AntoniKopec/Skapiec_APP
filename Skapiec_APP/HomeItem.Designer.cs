﻿namespace Skapiec_APP
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
            this.price_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title_label = new System.Windows.Forms.Label();
            this.history_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.history_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // price_label
            // 
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.price_label.Location = new System.Drawing.Point(3, 244);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(229, 38);
            this.price_label.TabIndex = 8;
            this.price_label.Text = "Price";
            this.price_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(3, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 1);
            this.panel1.TabIndex = 7;
            // 
            // title_label
            // 
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title_label.Location = new System.Drawing.Point(3, 169);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(229, 47);
            this.title_label.TabIndex = 6;
            this.title_label.Text = "Title";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // history_picture
            // 
            this.history_picture.Location = new System.Drawing.Point(47, 12);
            this.history_picture.Name = "history_picture";
            this.history_picture.Size = new System.Drawing.Size(140, 154);
            this.history_picture.TabIndex = 5;
            this.history_picture.TabStop = false;
            // 
            // HomeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.history_picture);
            this.Name = "HomeItem";
            this.Size = new System.Drawing.Size(235, 294);
            ((System.ComponentModel.ISupportInitialize)(this.history_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox history_picture;
    }
}

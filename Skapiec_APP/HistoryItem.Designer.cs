﻿namespace Skapiec_APP
{
    partial class HistoryItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryItem));
            this.title_label = new System.Windows.Forms.Label();
            this.history_picture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title_btn_hist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.history_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title_label.Location = new System.Drawing.Point(3, 180);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(229, 47);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Title";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // history_picture
            // 
            this.history_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("history_picture.BackgroundImage")));
            this.history_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.history_picture.Location = new System.Drawing.Point(47, 15);
            this.history_picture.Name = "history_picture";
            this.history_picture.Size = new System.Drawing.Size(140, 154);
            this.history_picture.TabIndex = 0;
            this.history_picture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(3, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 1);
            this.panel1.TabIndex = 2;
            // 
            // title_btn_hist
            // 
            this.title_btn_hist.Location = new System.Drawing.Point(79, 230);
            this.title_btn_hist.Name = "title_btn_hist";
            this.title_btn_hist.Size = new System.Drawing.Size(75, 23);
            this.title_btn_hist.TabIndex = 3;
            this.title_btn_hist.Text = "button1";
            this.title_btn_hist.UseVisualStyleBackColor = true;
            this.title_btn_hist.Click += new System.EventHandler(this.title_btn_hist_Click);
            // 
            // HistoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.title_btn_hist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.history_picture);
            this.Name = "HistoryItem";
            this.Size = new System.Drawing.Size(235, 297);
            ((System.ComponentModel.ISupportInitialize)(this.history_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox history_picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button title_btn_hist;
    }
}

namespace Skapiec_APP
{
    partial class Home
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
            this.search = new System.Windows.Forms.TextBox();
            this.test = new System.Windows.Forms.ListBox();
            this.history_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(341, 15);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(625, 56);
            this.search.TabIndex = 0;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // test
            // 
            this.test.FormattingEnabled = true;
            this.test.ItemHeight = 16;
            this.test.Location = new System.Drawing.Point(481, 94);
            this.test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(159, 116);
            this.test.TabIndex = 1;
            this.test.SelectedIndexChanged += new System.EventHandler(this.test_SelectedIndexChanged);
            // 
            // history_btn
            // 
            this.history_btn.Location = new System.Drawing.Point(1021, 28);
            this.history_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.history_btn.Name = "history_btn";
            this.history_btn.Size = new System.Drawing.Size(113, 30);
            this.history_btn.TabIndex = 2;
            this.history_btn.Text = "Historia";
            this.history_btn.UseVisualStyleBackColor = true;
            this.history_btn.Click += new System.EventHandler(this.history_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.history_btn);
            this.panel1.Controls.Add(this.search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 84);
            this.panel1.TabIndex = 4;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Transparent;
            this.search_btn.BackgroundImage = global::Skapiec_APP.Properties.Resources.search;
            this.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.Location = new System.Drawing.Point(904, 14);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(64, 59);
            this.search_btn.TabIndex = 4;
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Skapiec_APP.Properties.Resources.skapiec_logo1;
            this.panel2.Location = new System.Drawing.Point(16, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 52);
            this.panel2.TabIndex = 3;
            // 
            // home_panel
            // 
            this.home_panel.AutoScroll = true;
            this.home_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.home_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.home_panel.Location = new System.Drawing.Point(0, 224);
            this.home_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(1309, 580);
            this.home_panel.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 804);
            this.Controls.Add(this.home_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.test);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1327, 851);
            this.MinimumSize = new System.Drawing.Size(1327, 851);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ListBox test;
        private System.Windows.Forms.Button history_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.FlowLayoutPanel home_panel;
    }
}


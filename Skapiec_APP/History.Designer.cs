namespace Skapiec_APP
{
    partial class History
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
            this.history_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.history_btn = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // history_panel
            // 
            this.history_panel.AutoScroll = true;
            this.history_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.history_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.history_panel.Location = new System.Drawing.Point(0, 147);
            this.history_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.history_panel.Name = "history_panel";
            this.history_panel.Size = new System.Drawing.Size(1309, 657);
            this.history_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.history_btn);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 84);
            this.panel1.TabIndex = 1;
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
            this.search_btn.TabIndex = 2;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // history_btn
            // 
            this.history_btn.Location = new System.Drawing.Point(1021, 28);
            this.history_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.history_btn.Name = "history_btn";
            this.history_btn.Size = new System.Drawing.Size(113, 30);
            this.history_btn.TabIndex = 3;
            this.history_btn.Text = "Historia";
            this.history_btn.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(341, 15);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(625, 56);
            this.search.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Skapiec_APP.Properties.Resources.skapiec_logo1;
            this.panel2.Location = new System.Drawing.Point(16, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 52);
            this.panel2.TabIndex = 0;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1309, 804);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.history_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1327, 851);
            this.MinimumSize = new System.Drawing.Size(1327, 851);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel history_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button history_btn;
        private System.Windows.Forms.Button search_btn;
    }
}
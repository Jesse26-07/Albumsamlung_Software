namespace Albumsammlung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_songcover = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_details = new System.Windows.Forms.ListBox();
            this.lb_Song = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Reload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Search_Input = new System.Windows.Forms.ToolStripTextBox();
            this.btn_Search = new System.Windows.Forms.ToolStripButton();
            this.btn_Chart = new System.Windows.Forms.ToolStripButton();
            this.btn_Change = new System.Windows.Forms.ToolStripButton();
            this.btn_delete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_songcover)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_songcover
            // 
            this.pb_songcover.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb_songcover.Location = new System.Drawing.Point(313, 410);
            this.pb_songcover.Name = "pb_songcover";
            this.pb_songcover.Size = new System.Drawing.Size(238, 245);
            this.pb_songcover.TabIndex = 15;
            this.pb_songcover.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // lb_details
            // 
            this.lb_details.FormattingEnabled = true;
            this.lb_details.Location = new System.Drawing.Point(313, 40);
            this.lb_details.Name = "lb_details";
            this.lb_details.Size = new System.Drawing.Size(238, 355);
            this.lb_details.TabIndex = 10;
            this.lb_details.SelectedIndexChanged += new System.EventHandler(this.lb_details_SelectedIndexChanged);
            // 
            // lb_Song
            // 
            this.lb_Song.FormattingEnabled = true;
            this.lb_Song.Location = new System.Drawing.Point(12, 40);
            this.lb_Song.Name = "lb_Song";
            this.lb_Song.Size = new System.Drawing.Size(286, 615);
            this.lb_Song.TabIndex = 11;
            this.lb_Song.SelectedIndexChanged += new System.EventHandler(this.lb_Song_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.tb_Search_Input,
            this.btn_Search,
            this.btn_Chart,
            this.btn_Change,
            this.btn_delete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(566, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Load,
            this.btn_Save,
            this.btn_Reload});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(110, 22);
            this.btn_Load.Text = "Load";
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 22);
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(110, 22);
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Search_Input
            // 
            this.tb_Search_Input.Name = "tb_Search_Input";
            this.tb_Search_Input.Size = new System.Drawing.Size(100, 25);
            this.tb_Search_Input.Click += new System.EventHandler(this.tb_Search_Input_Click);
            this.tb_Search_Input.TextChanged += new System.EventHandler(this.tb_Search_Input_TextChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(46, 22);
            this.btn_Search.Text = "Search";
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Chart
            // 
            this.btn_Chart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Chart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Chart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Chart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Chart.Name = "btn_Chart";
            this.btn_Chart.Size = new System.Drawing.Size(40, 22);
            this.btn_Chart.Text = "Chart";
            this.btn_Chart.Click += new System.EventHandler(this.btn_Chart_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Change.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Change.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(52, 22);
            this.btn_Change.Text = "Change";
            this.btn_Change.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Change.ToolTipText = "Change";
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(44, 22);
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(566, 668);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pb_songcover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_details);
            this.Controls.Add(this.lb_Song);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_songcover)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_songcover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_details;
        private System.Windows.Forms.ListBox lb_Song;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btn_Load;
        private System.Windows.Forms.ToolStripMenuItem btn_Save;
        private System.Windows.Forms.ToolStripTextBox tb_Search_Input;
        private System.Windows.Forms.ToolStripButton btn_Change;
        private System.Windows.Forms.ToolStripButton btn_Search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btn_Reload;
        private System.Windows.Forms.ToolStripButton btn_Chart;
        private System.Windows.Forms.ToolStripButton btn_delete;
    }
}


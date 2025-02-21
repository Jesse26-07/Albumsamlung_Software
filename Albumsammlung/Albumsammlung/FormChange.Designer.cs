namespace Albumsammlung
{
    partial class FormChange
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
            this.lb_data = new System.Windows.Forms.ListBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.tb_change_data = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_data
            // 
            this.lb_data.FormattingEnabled = true;
            this.lb_data.Location = new System.Drawing.Point(12, 12);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(294, 420);
            this.lb_data.TabIndex = 0;
            this.lb_data.SelectedIndexChanged += new System.EventHandler(this.lb_data_SelectedIndexChanged);
            // 
            // tb_change_data
            // 
            this.tb_change_data.Location = new System.Drawing.Point(312, 12);
            this.tb_change_data.Name = "tb_change_data";
            this.tb_change_data.Size = new System.Drawing.Size(175, 20);
            this.tb_change_data.TabIndex = 1;
            this.tb_change_data.TextChanged += new System.EventHandler(this.tb_change_data_TextChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(412, 38);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FormChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_change_data);
            this.Controls.Add(this.lb_data);
            this.Name = "FormChange";
            this.Text = "FormChange";
            this.Load += new System.EventHandler(this.FormChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_data;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TextBox tb_change_data;
        private System.Windows.Forms.Button btn_Save;
    }
}
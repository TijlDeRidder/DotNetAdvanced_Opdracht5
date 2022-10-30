namespace Oefening2
{
    partial class NieuwGetalDialog
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
            this.tb_waarde = new System.Windows.Forms.TextBox();
            this.l_waarde = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_waarde
            // 
            this.tb_waarde.Location = new System.Drawing.Point(70, 43);
            this.tb_waarde.Name = "tb_waarde";
            this.tb_waarde.Size = new System.Drawing.Size(100, 23);
            this.tb_waarde.TabIndex = 0;
            // 
            // l_waarde
            // 
            this.l_waarde.AutoSize = true;
            this.l_waarde.Location = new System.Drawing.Point(17, 43);
            this.l_waarde.Name = "l_waarde";
            this.l_waarde.Size = new System.Drawing.Size(47, 15);
            this.l_waarde.TabIndex = 1;
            this.l_waarde.Text = "Waarde";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(17, 107);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(135, 107);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // NieuwGetalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 142);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.l_waarde);
            this.Controls.Add(this.tb_waarde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NieuwGetalDialog";
            this.Text = "NieuwGetalDialog";
            this.Load += new System.EventHandler(this.NieuwGetalDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_waarde;
        private Label l_waarde;
        private Button btn_ok;
        private Button btn_cancel;
    }
}
namespace Oefening2
{
    partial class GemiddeldeMDI
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_add_number = new System.Windows.Forms.Button();
            this.tb_gemiddelde = new System.Windows.Forms.TextBox();
            this.l_gemiddelde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 0;
            // 
            // btn_add_number
            // 
            this.btn_add_number.Location = new System.Drawing.Point(12, 123);
            this.btn_add_number.Name = "btn_add_number";
            this.btn_add_number.Size = new System.Drawing.Size(85, 23);
            this.btn_add_number.TabIndex = 1;
            this.btn_add_number.Text = "Nieuw Getal";
            this.btn_add_number.UseVisualStyleBackColor = true;
            this.btn_add_number.Click += new System.EventHandler(this.btn_add_number_Click);
            // 
            // tb_gemiddelde
            // 
            this.tb_gemiddelde.Location = new System.Drawing.Point(253, 23);
            this.tb_gemiddelde.Name = "tb_gemiddelde";
            this.tb_gemiddelde.Size = new System.Drawing.Size(100, 23);
            this.tb_gemiddelde.TabIndex = 2;
            // 
            // l_gemiddelde
            // 
            this.l_gemiddelde.AutoSize = true;
            this.l_gemiddelde.Location = new System.Drawing.Point(173, 23);
            this.l_gemiddelde.Name = "l_gemiddelde";
            this.l_gemiddelde.Size = new System.Drawing.Size(74, 15);
            this.l_gemiddelde.TabIndex = 3;
            this.l_gemiddelde.Text = "Gemiddelde:";
            // 
            // GemiddeldeMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_gemiddelde);
            this.Controls.Add(this.tb_gemiddelde);
            this.Controls.Add(this.btn_add_number);
            this.Controls.Add(this.listBox1);
            this.Name = "GemiddeldeMDI";
            this.Text = "GemiddeldeMDI";
            this.Load += new System.EventHandler(this.GemiddeldeMDI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button btn_add_number;
        private TextBox tb_gemiddelde;
        private Label l_gemiddelde;
    }
}
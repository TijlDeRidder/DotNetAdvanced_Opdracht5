namespace Oefening3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Rechthoek_Add = new System.Windows.Forms.Button();
            this.btn_Rechthoek_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Rechthoek_Add
            // 
            this.btn_Rechthoek_Add.Location = new System.Drawing.Point(12, 12);
            this.btn_Rechthoek_Add.Name = "btn_Rechthoek_Add";
            this.btn_Rechthoek_Add.Size = new System.Drawing.Size(136, 23);
            this.btn_Rechthoek_Add.TabIndex = 0;
            this.btn_Rechthoek_Add.Text = "Rechthoek Toevoegen";
            this.btn_Rechthoek_Add.UseVisualStyleBackColor = true;
            this.btn_Rechthoek_Add.Click += new System.EventHandler(this.btn_Rechthoek_Add_Click);
            // 
            // btn_Rechthoek_Delete
            // 
            this.btn_Rechthoek_Delete.Location = new System.Drawing.Point(154, 12);
            this.btn_Rechthoek_Delete.Name = "btn_Rechthoek_Delete";
            this.btn_Rechthoek_Delete.Size = new System.Drawing.Size(138, 23);
            this.btn_Rechthoek_Delete.TabIndex = 1;
            this.btn_Rechthoek_Delete.Text = "Rechthoek Verwijderen";
            this.btn_Rechthoek_Delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Rechthoek_Delete);
            this.Controls.Add(this.btn_Rechthoek_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Rechthoek_Add;
        private Button btn_Rechthoek_Delete;
    }
}
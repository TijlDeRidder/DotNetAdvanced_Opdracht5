namespace Oefening1
{
    partial class Menus
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Color_Red = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Color_Green = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Color_Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem_BackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_BackColor_Red = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_BackColor_Green = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_BackColor_Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Font_Small = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Font_Normal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Font_Large = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_TextVeld = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_File,
            this.toolStripMenuItem_Format});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem_Exit});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem_File.Text = "File";
            // 
            // exitToolStripMenuItem_Exit
            // 
            this.exitToolStripMenuItem_Exit.Name = "exitToolStripMenuItem_Exit";
            this.exitToolStripMenuItem_Exit.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem_Exit.Text = "Exit";
            this.exitToolStripMenuItem_Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Exit_Click);
            // 
            // toolStripMenuItem_Format
            // 
            this.toolStripMenuItem_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem_Color,
            this.backgroundColorToolStripMenuItem_BackColor,
            this.fontToolStripMenuItem});
            this.toolStripMenuItem_Format.Name = "toolStripMenuItem_Format";
            this.toolStripMenuItem_Format.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem_Format.Text = "Format";
            // 
            // colorToolStripMenuItem_Color
            // 
            this.colorToolStripMenuItem_Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Color_Red,
            this.tsmi_Color_Green,
            this.tsmi_Color_Blue});
            this.colorToolStripMenuItem_Color.Name = "colorToolStripMenuItem_Color";
            this.colorToolStripMenuItem_Color.Size = new System.Drawing.Size(170, 22);
            this.colorToolStripMenuItem_Color.Text = "Color";
            // 
            // tsmi_Color_Red
            // 
            this.tsmi_Color_Red.Name = "tsmi_Color_Red";
            this.tsmi_Color_Red.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmi_Color_Red.Size = new System.Drawing.Size(147, 22);
            this.tsmi_Color_Red.Text = "Red";
            this.tsmi_Color_Red.Click += new System.EventHandler(this.tsmi_Color_Red_Click);
            // 
            // tsmi_Color_Green
            // 
            this.tsmi_Color_Green.Name = "tsmi_Color_Green";
            this.tsmi_Color_Green.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmi_Color_Green.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tsmi_Color_Green.Size = new System.Drawing.Size(147, 22);
            this.tsmi_Color_Green.Text = "Green";
            this.tsmi_Color_Green.Click += new System.EventHandler(this.tsmi_Color_Green_Click);
            // 
            // tsmi_Color_Blue
            // 
            this.tsmi_Color_Blue.Name = "tsmi_Color_Blue";
            this.tsmi_Color_Blue.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.tsmi_Color_Blue.Size = new System.Drawing.Size(147, 22);
            this.tsmi_Color_Blue.Text = "Blue";
            this.tsmi_Color_Blue.Click += new System.EventHandler(this.tsmi_Color_Blue_Click);
            // 
            // backgroundColorToolStripMenuItem_BackColor
            // 
            this.backgroundColorToolStripMenuItem_BackColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_BackColor_Red,
            this.tsmi_BackColor_Green,
            this.tsmi_BackColor_Blue});
            this.backgroundColorToolStripMenuItem_BackColor.Name = "backgroundColorToolStripMenuItem_BackColor";
            this.backgroundColorToolStripMenuItem_BackColor.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem_BackColor.Text = "Background Color";
            // 
            // tsmi_BackColor_Red
            // 
            this.tsmi_BackColor_Red.Name = "tsmi_BackColor_Red";
            this.tsmi_BackColor_Red.Size = new System.Drawing.Size(105, 22);
            this.tsmi_BackColor_Red.Text = "Red";
            this.tsmi_BackColor_Red.Click += new System.EventHandler(this.tsmi_BackColor_Red_Click);
            // 
            // tsmi_BackColor_Green
            // 
            this.tsmi_BackColor_Green.Name = "tsmi_BackColor_Green";
            this.tsmi_BackColor_Green.Size = new System.Drawing.Size(105, 22);
            this.tsmi_BackColor_Green.Text = "Green";
            this.tsmi_BackColor_Green.Click += new System.EventHandler(this.tsmi_BackColor_Green_Click);
            // 
            // tsmi_BackColor_Blue
            // 
            this.tsmi_BackColor_Blue.Name = "tsmi_BackColor_Blue";
            this.tsmi_BackColor_Blue.Size = new System.Drawing.Size(105, 22);
            this.tsmi_BackColor_Blue.Text = "Blue";
            this.tsmi_BackColor_Blue.Click += new System.EventHandler(this.tsmi_BackColor_Blue_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Font_Small,
            this.tsmi_Font_Normal,
            this.tsmi_Font_Large});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // tsmi_Font_Small
            // 
            this.tsmi_Font_Small.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmi_Font_Small.Name = "tsmi_Font_Small";
            this.tsmi_Font_Small.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmi_Font_Small.Size = new System.Drawing.Size(190, 30);
            this.tsmi_Font_Small.Text = "Small";
            this.tsmi_Font_Small.Click += new System.EventHandler(this.tsmi_Font_Small_Click);
            // 
            // tsmi_Font_Normal
            // 
            this.tsmi_Font_Normal.Name = "tsmi_Font_Normal";
            this.tsmi_Font_Normal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmi_Font_Normal.Size = new System.Drawing.Size(190, 30);
            this.tsmi_Font_Normal.Text = "Normal";
            this.tsmi_Font_Normal.Click += new System.EventHandler(this.tsmi_Font_Normal_Click);
            // 
            // tsmi_Font_Large
            // 
            this.tsmi_Font_Large.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmi_Font_Large.Name = "tsmi_Font_Large";
            this.tsmi_Font_Large.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmi_Font_Large.Size = new System.Drawing.Size(190, 30);
            this.tsmi_Font_Large.Text = "Large";
            this.tsmi_Font_Large.Click += new System.EventHandler(this.tsmi_Font_Large_Click);
            // 
            // rtb_TextVeld
            // 
            this.rtb_TextVeld.Location = new System.Drawing.Point(0, 27);
            this.rtb_TextVeld.Name = "rtb_TextVeld";
            this.rtb_TextVeld.Size = new System.Drawing.Size(800, 425);
            this.rtb_TextVeld.TabIndex = 1;
            this.rtb_TextVeld.Text = "";
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_TextVeld);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menus";
            this.Text = "Menus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem_File;
        private ToolStripMenuItem exitToolStripMenuItem_Exit;
        private ToolStripMenuItem toolStripMenuItem_Format;
        private ToolStripMenuItem colorToolStripMenuItem_Color;
        private ToolStripMenuItem tsmi_Color_Red;
        private ToolStripMenuItem tsmi_Color_Green;
        private ToolStripMenuItem tsmi_Color_Blue;
        private ToolStripMenuItem backgroundColorToolStripMenuItem_BackColor;
        private ToolStripMenuItem tsmi_BackColor_Red;
        private ToolStripMenuItem tsmi_BackColor_Green;
        private ToolStripMenuItem tsmi_BackColor_Blue;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem tsmi_Font_Small;
        private ToolStripMenuItem tsmi_Font_Normal;
        private ToolStripMenuItem tsmi_Font_Large;
        private RichTextBox rtb_TextVeld;
    }
}
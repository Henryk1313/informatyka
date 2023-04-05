
namespace sprawdzian29_03
{
    partial class aplikacjaOkienkowa
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_szyfr = new System.Windows.Forms.TextBox();
            this.numud1 = new System.Windows.Forms.NumericUpDown();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.checkWielkie = new System.Windows.Forms.CheckBox();
            this.checkCyfry = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioszyfr = new System.Windows.Forms.RadioButton();
            this.radiodeszyfr = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt1.Location = new System.Drawing.Point(136, 37);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(497, 80);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "SZYFR CEZARA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(30, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(237, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Tekst do szyfrowania:";
            // 
            // txt_szyfr
            // 
            this.txt_szyfr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_szyfr.Location = new System.Drawing.Point(273, 192);
            this.txt_szyfr.Name = "txt_szyfr";
            this.txt_szyfr.Size = new System.Drawing.Size(451, 35);
            this.txt_szyfr.TabIndex = 3;
            this.txt_szyfr.TextChanged += new System.EventHandler(this.txt_szyfr_TextChanged);
            // 
            // numud1
            // 
            this.numud1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numud1.Location = new System.Drawing.Point(45, 308);
            this.numud1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numud1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numud1.Name = "numud1";
            this.numud1.Size = new System.Drawing.Size(48, 35);
            this.numud1.TabIndex = 4;
            this.numud1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numud1.ValueChanged += new System.EventHandler(this.numud1_ValueChanged);
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkMale.Location = new System.Drawing.Point(150, 308);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(76, 33);
            this.checkMale.TabIndex = 5;
            this.checkMale.Text = "a - z";
            this.checkMale.UseVisualStyleBackColor = true;
            this.checkMale.CheckedChanged += new System.EventHandler(this.checkMale_CheckedChanged);
            // 
            // checkWielkie
            // 
            this.checkWielkie.AutoSize = true;
            this.checkWielkie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkWielkie.Location = new System.Drawing.Point(273, 308);
            this.checkWielkie.Name = "checkWielkie";
            this.checkWielkie.Size = new System.Drawing.Size(81, 33);
            this.checkWielkie.TabIndex = 6;
            this.checkWielkie.Text = "A - Z";
            this.checkWielkie.UseVisualStyleBackColor = true;
            this.checkWielkie.CheckedChanged += new System.EventHandler(this.checkWielkie_CheckedChanged);
            // 
            // checkCyfry
            // 
            this.checkCyfry.AutoSize = true;
            this.checkCyfry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkCyfry.Location = new System.Drawing.Point(385, 308);
            this.checkCyfry.Name = "checkCyfry";
            this.checkCyfry.Size = new System.Drawing.Size(78, 33);
            this.checkCyfry.TabIndex = 7;
            this.checkCyfry.Text = "0 - 9";
            this.checkCyfry.UseVisualStyleBackColor = true;
            this.checkCyfry.CheckedChanged += new System.EventHandler(this.checkCyfry_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(505, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "SZYFRUJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioszyfr
            // 
            this.radioszyfr.AutoSize = true;
            this.radioszyfr.Checked = true;
            this.radioszyfr.Location = new System.Drawing.Point(488, 256);
            this.radioszyfr.Name = "radioszyfr";
            this.radioszyfr.Size = new System.Drawing.Size(56, 17);
            this.radioszyfr.TabIndex = 9;
            this.radioszyfr.TabStop = true;
            this.radioszyfr.Text = "Szyfruj";
            this.radioszyfr.UseVisualStyleBackColor = true;
            // 
            // radiodeszyfr
            // 
            this.radiodeszyfr.AutoSize = true;
            this.radiodeszyfr.Location = new System.Drawing.Point(576, 256);
            this.radiodeszyfr.Name = "radiodeszyfr";
            this.radiodeszyfr.Size = new System.Drawing.Size(68, 17);
            this.radiodeszyfr.TabIndex = 8;
            this.radiodeszyfr.TabStop = true;
            this.radiodeszyfr.Text = "Deszyfruj";
            this.radiodeszyfr.UseVisualStyleBackColor = true;
            // 
            // aplikacjaOkienkowa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 358);
            this.Controls.Add(this.radiodeszyfr);
            this.Controls.Add(this.radioszyfr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkCyfry);
            this.Controls.Add(this.checkWielkie);
            this.Controls.Add(this.checkMale);
            this.Controls.Add(this.numud1);
            this.Controls.Add(this.txt_szyfr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "aplikacjaOkienkowa";
            this.Text = "szyfr cezara";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_szyfr;
        private System.Windows.Forms.NumericUpDown numud1;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.CheckBox checkWielkie;
        private System.Windows.Forms.CheckBox checkCyfry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioszyfr;
        private System.Windows.Forms.RadioButton radiodeszyfr;
    }
}


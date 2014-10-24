namespace szyfr2
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tekstJawny = new System.Windows.Forms.TextBox();
            this.tekstZaszyfrowany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstJawnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzZPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDoPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstZaszyfrowanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzZPlikuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDoPlikuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Utwórz alfabet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tekstJawny
            // 
            this.tekstJawny.Location = new System.Drawing.Point(117, 72);
            this.tekstJawny.Multiline = true;
            this.tekstJawny.Name = "tekstJawny";
            this.tekstJawny.Size = new System.Drawing.Size(729, 279);
            this.tekstJawny.TabIndex = 2;
            // 
            // tekstZaszyfrowany
            // 
            this.tekstZaszyfrowany.Location = new System.Drawing.Point(117, 357);
            this.tekstZaszyfrowany.Multiline = true;
            this.tekstZaszyfrowany.Name = "tekstZaszyfrowany";
            this.tekstZaszyfrowany.Size = new System.Drawing.Size(729, 273);
            this.tekstZaszyfrowany.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tekst jawny:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tekst zaszyfrowany:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(878, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Poziomo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(878, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Góra-dól";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(878, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Dół-góra";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Klucz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(875, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Szyfruj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(875, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Odszyfruj";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(878, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Poziomo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(878, 396);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Góra-dół";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(878, 425);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Dół - góra";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tekstJawnyToolStripMenuItem,
            this.tekstZaszyfrowanyToolStripMenuItem,
            this.zakończProgramToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // tekstJawnyToolStripMenuItem
            // 
            this.tekstJawnyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzZPlikuToolStripMenuItem,
            this.zapiszDoPlikuToolStripMenuItem});
            this.tekstJawnyToolStripMenuItem.Name = "tekstJawnyToolStripMenuItem";
            this.tekstJawnyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tekstJawnyToolStripMenuItem.Text = "Tekst jawny";
            // 
            // otwórzZPlikuToolStripMenuItem
            // 
            this.otwórzZPlikuToolStripMenuItem.Name = "otwórzZPlikuToolStripMenuItem";
            this.otwórzZPlikuToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.otwórzZPlikuToolStripMenuItem.Text = "Otwórz z pliku";
            this.otwórzZPlikuToolStripMenuItem.Click += new System.EventHandler(this.otwórzZPlikuToolStripMenuItem_Click);
            // 
            // zapiszDoPlikuToolStripMenuItem
            // 
            this.zapiszDoPlikuToolStripMenuItem.Name = "zapiszDoPlikuToolStripMenuItem";
            this.zapiszDoPlikuToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.zapiszDoPlikuToolStripMenuItem.Text = "Zapisz do pliku";
            this.zapiszDoPlikuToolStripMenuItem.Click += new System.EventHandler(this.zapiszDoPlikuToolStripMenuItem_Click);
            // 
            // tekstZaszyfrowanyToolStripMenuItem
            // 
            this.tekstZaszyfrowanyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzZPlikuToolStripMenuItem1,
            this.zapiszDoPlikuToolStripMenuItem1});
            this.tekstZaszyfrowanyToolStripMenuItem.Name = "tekstZaszyfrowanyToolStripMenuItem";
            this.tekstZaszyfrowanyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tekstZaszyfrowanyToolStripMenuItem.Text = "Tekst zaszyfrowany";
            // 
            // otwórzZPlikuToolStripMenuItem1
            // 
            this.otwórzZPlikuToolStripMenuItem1.Name = "otwórzZPlikuToolStripMenuItem1";
            this.otwórzZPlikuToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.otwórzZPlikuToolStripMenuItem1.Text = "Otwórz z pliku";
            this.otwórzZPlikuToolStripMenuItem1.Click += new System.EventHandler(this.otwórzZPlikuToolStripMenuItem1_Click);
            // 
            // zapiszDoPlikuToolStripMenuItem1
            // 
            this.zapiszDoPlikuToolStripMenuItem1.Name = "zapiszDoPlikuToolStripMenuItem1";
            this.zapiszDoPlikuToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.zapiszDoPlikuToolStripMenuItem1.Text = "Zapisz do pliku";
            this.zapiszDoPlikuToolStripMenuItem1.Click += new System.EventHandler(this.zapiszDoPlikuToolStripMenuItem1_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.autorToolStripMenuItem.Text = "Autor";
            // 
            // zakończProgramToolStripMenuItem
            // 
            this.zakończProgramToolStripMenuItem.Name = "zakończProgramToolStripMenuItem";
            this.zakończProgramToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.zakończProgramToolStripMenuItem.Text = "Zakończ program";
            this.zakończProgramToolStripMenuItem.Click += new System.EventHandler(this.zakończProgramToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 645);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tekstZaszyfrowany);
            this.Controls.Add(this.tekstJawny);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tekstJawny;
        private System.Windows.Forms.TextBox tekstZaszyfrowany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekstJawnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzZPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszDoPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekstZaszyfrowanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzZPlikuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zapiszDoPlikuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończProgramToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}


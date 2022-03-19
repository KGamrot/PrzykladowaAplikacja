namespace PrzykladowaAplikacja
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.studenciListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wyświetl info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwisko";
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImieTextBox.Location = new System.Drawing.Point(95, 87);
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(168, 29);
            this.ImieTextBox.TabIndex = 5;
            this.ImieTextBox.TextChanged += new System.EventHandler(this.ImieTextBox_TextChanged);
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwiskoTextBox.Location = new System.Drawing.Point(95, 136);
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(168, 29);
            this.NazwiskoTextBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = " Dodaj studenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // studenciListBox
            // 
            this.studenciListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studenciListBox.FormattingEnabled = true;
            this.studenciListBox.ItemHeight = 21;
            this.studenciListBox.Location = new System.Drawing.Point(371, 87);
            this.studenciListBox.Name = "studenciListBox";
            this.studenciListBox.Size = new System.Drawing.Size(240, 235);
            this.studenciListBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(371, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lista studentów";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studenciListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NazwiskoTextBox);
            this.Controls.Add(this.ImieTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lista studentów";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem zakończToolStripMenuItem;
        private ToolStripMenuItem edycjaToolStripMenuItem;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox ImieTextBox;
        private TextBox NazwiskoTextBox;
        private Button button2;
        private ListBox studenciListBox;
        private Label label3;
    }
}
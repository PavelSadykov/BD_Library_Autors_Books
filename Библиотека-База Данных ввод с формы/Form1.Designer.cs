namespace Библиотека_База_Данных_ввод_с_формы
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DgAutors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgBooks = new System.Windows.Forms.DataGridView();
            this.comboBoxAutors = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgAutors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(867, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьБДToolStripMenuItem,
            this.создатьБДToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.выбратьБДToolStripMenuItem_Click);
            // 
            // выбратьБДToolStripMenuItem
            // 
            this.выбратьБДToolStripMenuItem.Name = "выбратьБДToolStripMenuItem";
            this.выбратьБДToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.выбратьБДToolStripMenuItem.Text = "выбрать БД";
            this.выбратьБДToolStripMenuItem.Click += new System.EventHandler(this.выбратьБДToolStripMenuItem_Click);
            // 
            // создатьБДToolStripMenuItem
            // 
            this.создатьБДToolStripMenuItem.Name = "создатьБДToolStripMenuItem";
            this.создатьБДToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.создатьБДToolStripMenuItem.Text = "создать БД";
            this.создатьБДToolStripMenuItem.Click += new System.EventHandler(this.создатьБДToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьИзмененияToolStripMenuItem,
            this.выбратьТаблицыToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // сохранитьИзмененияToolStripMenuItem
            // 
            this.сохранитьИзмененияToolStripMenuItem.Name = "сохранитьИзмененияToolStripMenuItem";
            this.сохранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.сохранитьИзмененияToolStripMenuItem.Text = "Сохранить изменения";
            this.сохранитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзмененияToolStripMenuItem_Click);
            // 
            // выбратьТаблицыToolStripMenuItem
            // 
            this.выбратьТаблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorsToolStripMenuItem,
            this.booksToolStripMenuItem});
            this.выбратьТаблицыToolStripMenuItem.Name = "выбратьТаблицыToolStripMenuItem";
            this.выбратьТаблицыToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.выбратьТаблицыToolStripMenuItem.Text = "Выбрать таблицы";
            // 
            // autorsToolStripMenuItem
            // 
            this.autorsToolStripMenuItem.Name = "autorsToolStripMenuItem";
            this.autorsToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.autorsToolStripMenuItem.Text = "Autors";
            this.autorsToolStripMenuItem.Click += new System.EventHandler(this.autorsToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DgAutors
            // 
            this.DgAutors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgAutors.Location = new System.Drawing.Point(16, 72);
            this.DgAutors.Name = "DgAutors";
            this.DgAutors.Size = new System.Drawing.Size(374, 222);
            this.DgAutors.TabIndex = 1;
            this.DgAutors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgAutors_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "АВТОРЫ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "КНИГИ";
            // 
            // DgBooks
            // 
            this.DgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgBooks.Location = new System.Drawing.Point(408, 72);
            this.DgBooks.Name = "DgBooks";
            this.DgBooks.Size = new System.Drawing.Size(380, 222);
            this.DgBooks.TabIndex = 2;
            // 
            // comboBoxAutors
            // 
            this.comboBoxAutors.FormattingEnabled = true;
            this.comboBoxAutors.Location = new System.Drawing.Point(16, 336);
            this.comboBoxAutors.Name = "comboBoxAutors";
            this.comboBoxAutors.Size = new System.Drawing.Size(215, 21);
            this.comboBoxAutors.TabIndex = 5;
            this.comboBoxAutors.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutors_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выберите Автора";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAutors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgBooks);
            this.Controls.Add(this.DgAutors);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgAutors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView DgAutors;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgBooks;
        private System.Windows.Forms.ToolStripMenuItem создатьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьТаблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxAutors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}


namespace CrmUi
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerAddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerAddToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.itemsToolStripMenuItem1,
            this.modelingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // itemsToolStripMenuItem1
            // 
            this.itemsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem1,
            this.sellerToolStripMenuItem1,
            this.customerToolStripMenuItem1,
            this.checkToolStripMenuItem1});
            this.itemsToolStripMenuItem1.Name = "itemsToolStripMenuItem1";
            this.itemsToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem1.Text = "Items";
            // 
            // productToolStripMenuItem1
            // 
            this.productToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productAddToolStripMenuItem});
            this.productToolStripMenuItem1.Name = "productToolStripMenuItem1";
            this.productToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.productToolStripMenuItem1.Text = "Product";
            this.productToolStripMenuItem1.Click += new System.EventHandler(this.productToolStripMenuItem1_Click);
            // 
            // productAddToolStripMenuItem
            // 
            this.productAddToolStripMenuItem.Name = "productAddToolStripMenuItem";
            this.productAddToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.productAddToolStripMenuItem.Text = "Добавить";
            this.productAddToolStripMenuItem.Click += new System.EventHandler(this.productAddToolStripMenuItem_Click);
            // 
            // sellerToolStripMenuItem1
            // 
            this.sellerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellerAddToolStripMenuItem1});
            this.sellerToolStripMenuItem1.Name = "sellerToolStripMenuItem1";
            this.sellerToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.sellerToolStripMenuItem1.Text = "Seller";
            this.sellerToolStripMenuItem1.Click += new System.EventHandler(this.sellerToolStripMenuItem1_Click);
            // 
            // sellerAddToolStripMenuItem1
            // 
            this.sellerAddToolStripMenuItem1.Name = "sellerAddToolStripMenuItem1";
            this.sellerAddToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.sellerAddToolStripMenuItem1.Text = "Добавить";
            this.sellerAddToolStripMenuItem1.Click += new System.EventHandler(this.sellerAddToolStripMenuItem1_Click);
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerAddToolStripMenuItem2});
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.customerToolStripMenuItem1.Text = "Customer";
            this.customerToolStripMenuItem1.Click += new System.EventHandler(this.customerToolStripMenuItem1_Click);
            // 
            // customerAddToolStripMenuItem2
            // 
            this.customerAddToolStripMenuItem2.Name = "customerAddToolStripMenuItem2";
            this.customerAddToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.customerAddToolStripMenuItem2.Text = "Добавить";
            this.customerAddToolStripMenuItem2.Click += new System.EventHandler(this.customerAddToolStripMenuItem2_Click);
            // 
            // checkToolStripMenuItem1
            // 
            this.checkToolStripMenuItem1.Name = "checkToolStripMenuItem1";
            this.checkToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.checkToolStripMenuItem1.Text = "Check";
            this.checkToolStripMenuItem1.Click += new System.EventHandler(this.checkToolStripMenuItem1_Click);
            // 
            // modelingToolStripMenuItem
            // 
            this.modelingToolStripMenuItem.Name = "modelingToolStripMenuItem";
            this.modelingToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modelingToolStripMenuItem.Text = "Modeling";
            this.modelingToolStripMenuItem.Click += new System.EventHandler(this.modelingToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // sellerToolStripMenuItem
            // 
            this.sellerToolStripMenuItem.Name = "sellerToolStripMenuItem";
            this.sellerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sellerToolStripMenuItem.Text = "Продавец";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem.Text = "Покупатель";
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkToolStripMenuItem.Text = "Чек";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(23, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 532);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список продуктов";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(451, 67);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(263, 537);
            this.listBox2.TabIndex = 3;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 611);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Общая стоимость: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Оплатить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(916, 24);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Здравствуй, гость!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 666);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sellerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerAddToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerAddToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modelingToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


namespace WindowsFormsApp02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.Content = new System.Windows.Forms.Label();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.toolStripDropDownButtonMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.OpenBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1252, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 100);
            this.panel1.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(249, 37);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить запись";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 34);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 502);
            this.listBox1.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Location = new System.Drawing.Point(252, 34);
            this.labelName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(126, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Наименование:";
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxName.Location = new System.Drawing.Point(252, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(1000, 26);
            this.textBoxName.TabIndex = 4;
            // 
            // Content
            // 
            this.Content.AutoSize = true;
            this.Content.Dock = System.Windows.Forms.DockStyle.Top;
            this.Content.Location = new System.Drawing.Point(252, 80);
            this.Content.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(77, 20);
            this.Content.TabIndex = 5;
            this.Content.Text = "Контент:";
            // 
            // textBoxContent
            // 
            this.textBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContent.Location = new System.Drawing.Point(252, 100);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(1000, 436);
            this.textBoxContent.TabIndex = 6;
            // 
            // toolStripDropDownButtonMenu
            // 
            this.toolStripDropDownButtonMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenBaseToolStripMenuItem,
            this.CreateBaseToolStripMenuItem,
            this.CloseBaseToolStripMenuItem});
            this.toolStripDropDownButtonMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonMenu.Image")));
            this.toolStripDropDownButtonMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonMenu.Name = "toolStripDropDownButtonMenu";
            this.toolStripDropDownButtonMenu.Size = new System.Drawing.Size(80, 29);
            this.toolStripDropDownButtonMenu.Text = "Меню";
            // 
            // OpenBaseToolStripMenuItem
            // 
            this.OpenBaseToolStripMenuItem.Name = "OpenBaseToolStripMenuItem";
            this.OpenBaseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.OpenBaseToolStripMenuItem.Text = "Открыть базу";
            // 
            // CreateBaseToolStripMenuItem
            // 
            this.CreateBaseToolStripMenuItem.Name = "CreateBaseToolStripMenuItem";
            this.CreateBaseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.CreateBaseToolStripMenuItem.Text = "Создать базу";
            // 
            // CloseBaseToolStripMenuItem
            // 
            this.CloseBaseToolStripMenuItem.Name = "CloseBaseToolStripMenuItem";
            this.CloseBaseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.CloseBaseToolStripMenuItem.Text = "Закрыть базу";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 636);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label Content;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseBaseToolStripMenuItem;
    }
}


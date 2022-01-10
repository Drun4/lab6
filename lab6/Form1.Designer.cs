
namespace lab6
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
            this.WayButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.wayTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intDoubleStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.intDoubleStringToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.intListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.personListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WayButton
            // 
            this.WayButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.WayButton.Location = new System.Drawing.Point(427, 207);
            this.WayButton.Name = "WayButton";
            this.WayButton.Size = new System.Drawing.Size(102, 20);
            this.WayButton.TabIndex = 0;
            this.WayButton.Text = "Choose Way";
            this.WayButton.UseVisualStyleBackColor = false;
            this.WayButton.Click += new System.EventHandler(this.WayButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 172);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(393, 20);
            this.textBox.TabIndex = 1;
            // 
            // wayTextBox
            // 
            this.wayTextBox.Location = new System.Drawing.Point(12, 208);
            this.wayTextBox.Name = "wayTextBox";
            this.wayTextBox.Size = new System.Drawing.Size(393, 20);
            this.wayTextBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeToolStripMenuItem,
            this.readToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intToolStripMenuItem,
            this.doubleToolStripMenuItem,
            this.intDoubleStringToolStripMenuItem,
            this.personToolStripMenuItem,
            this.personToolStripMenuItem1,
            this.personListToolStripMenuItem});
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.writeToolStripMenuItem.Text = "Write";
            // 
            // intToolStripMenuItem
            // 
            this.intToolStripMenuItem.Name = "intToolStripMenuItem";
            this.intToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.intToolStripMenuItem.Text = "int";
            this.intToolStripMenuItem.Click += new System.EventHandler(this.intToolStripMenuItem_Click);
            // 
            // doubleToolStripMenuItem
            // 
            this.doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
            this.doubleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doubleToolStripMenuItem.Text = "double";
            this.doubleToolStripMenuItem.Click += new System.EventHandler(this.doubleToolStripMenuItem_Click);
            // 
            // intDoubleStringToolStripMenuItem
            // 
            this.intDoubleStringToolStripMenuItem.Name = "intDoubleStringToolStripMenuItem";
            this.intDoubleStringToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.intDoubleStringToolStripMenuItem.Text = "int, double, string";
            this.intDoubleStringToolStripMenuItem.Click += new System.EventHandler(this.intDoubleStringToolStripMenuItem_Click);
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personToolStripMenuItem.Text = "int list, double list";
            this.personToolStripMenuItem.Click += new System.EventHandler(this.personToolStripMenuItem_Click);
            // 
            // personToolStripMenuItem1
            // 
            this.personToolStripMenuItem1.Name = "personToolStripMenuItem1";
            this.personToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.personToolStripMenuItem1.Text = "person";
            this.personToolStripMenuItem1.Click += new System.EventHandler(this.personToolStripMenuItem1_Click);
            // 
            // personListToolStripMenuItem
            // 
            this.personListToolStripMenuItem.Name = "personListToolStripMenuItem";
            this.personListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personListToolStripMenuItem.Text = "person list";
            this.personListToolStripMenuItem.Click += new System.EventHandler(this.personListToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intToolStripMenuItem1,
            this.doubleToolStripMenuItem1,
            this.intDoubleStringToolStripMenuItem1,
            this.intListToolStripMenuItem,
            this.personToolStripMenuItem2,
            this.personListToolStripMenuItem1});
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // intToolStripMenuItem1
            // 
            this.intToolStripMenuItem1.Name = "intToolStripMenuItem1";
            this.intToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.intToolStripMenuItem1.Text = "int";
            this.intToolStripMenuItem1.Click += new System.EventHandler(this.intToolStripMenuItem1_Click);
            // 
            // doubleToolStripMenuItem1
            // 
            this.doubleToolStripMenuItem1.Name = "doubleToolStripMenuItem1";
            this.doubleToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.doubleToolStripMenuItem1.Text = "double";
            this.doubleToolStripMenuItem1.Click += new System.EventHandler(this.doubleToolStripMenuItem1_Click);
            // 
            // intDoubleStringToolStripMenuItem1
            // 
            this.intDoubleStringToolStripMenuItem1.Name = "intDoubleStringToolStripMenuItem1";
            this.intDoubleStringToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.intDoubleStringToolStripMenuItem1.Text = "int, double, string";
            this.intDoubleStringToolStripMenuItem1.Click += new System.EventHandler(this.intDoubleStringToolStripMenuItem1_Click);
            // 
            // intListToolStripMenuItem
            // 
            this.intListToolStripMenuItem.Name = "intListToolStripMenuItem";
            this.intListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.intListToolStripMenuItem.Text = "int list, double list";
            this.intListToolStripMenuItem.Click += new System.EventHandler(this.intListToolStripMenuItem_Click);
            // 
            // personToolStripMenuItem2
            // 
            this.personToolStripMenuItem2.Name = "personToolStripMenuItem2";
            this.personToolStripMenuItem2.Size = new System.Drawing.Size(167, 22);
            this.personToolStripMenuItem2.Text = "person";
            this.personToolStripMenuItem2.Click += new System.EventHandler(this.personToolStripMenuItem2_Click);
            // 
            // personListToolStripMenuItem1
            // 
            this.personListToolStripMenuItem1.Name = "personListToolStripMenuItem1";
            this.personListToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.personListToolStripMenuItem1.Text = "person list";
            this.personListToolStripMenuItem1.Click += new System.EventHandler(this.personListToolStripMenuItem1_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clearButton.Location = new System.Drawing.Point(427, 172);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 20);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Person characteristics:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "- name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "- surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "- year of birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "- height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "- weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 238);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.wayTextBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.WayButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pliki binarne";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WayButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox wayTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intDoubleStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doubleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem intDoubleStringToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem intListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem personListToolStripMenuItem1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


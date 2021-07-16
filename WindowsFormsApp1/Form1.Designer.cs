
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Earlier = new System.Windows.Forms.Button();
            this.Later = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3434 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MenueBtn = new System.Windows.Forms.Button();
            this.Card0 = new System.Windows.Forms.Button();
            this.Card1 = new System.Windows.Forms.Button();
            this.Card2 = new System.Windows.Forms.Button();
            this.Card3 = new System.Windows.Forms.Button();
            this.Card4 = new System.Windows.Forms.Button();
            this.Card5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Событие";
            // 
            // Earlier
            // 
            this.Earlier.Location = new System.Drawing.Point(401, 289);
            this.Earlier.Margin = new System.Windows.Forms.Padding(4);
            this.Earlier.Name = "Earlier";
            this.Earlier.Size = new System.Drawing.Size(100, 28);
            this.Earlier.TabIndex = 2;
            this.Earlier.Text = "Раньше";
            this.Earlier.UseVisualStyleBackColor = true;
            this.Earlier.Click += new System.EventHandler(this.Earlier_Click);
            // 
            // Later
            // 
            this.Later.Location = new System.Drawing.Point(534, 289);
            this.Later.Margin = new System.Windows.Forms.Padding(4);
            this.Later.Name = "Later";
            this.Later.Size = new System.Drawing.Size(100, 28);
            this.Later.TabIndex = 3;
            this.Later.Text = "Позже";
            this.Later.UseVisualStyleBackColor = true;
            this.Later.Click += new System.EventHandler(this.Later_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Карт в колоде:";
            // 
            // button3434
            // 
            this.button3434.Location = new System.Drawing.Point(883, 238);
            this.button3434.Margin = new System.Windows.Forms.Padding(4);
            this.button3434.Name = "button3434";
            this.button3434.Size = new System.Drawing.Size(100, 64);
            this.button3434.TabIndex = 5;
            this.button3434.Text = "Показать свойства игрока";
            this.button3434.UseVisualStyleBackColor = true;
            this.button3434.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Игрок: 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 155);
            this.textBox1.TabIndex = 7;
            // 
            // MenueBtn
            // 
            this.MenueBtn.Location = new System.Drawing.Point(955, 503);
            this.MenueBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MenueBtn.Name = "MenueBtn";
            this.MenueBtn.Size = new System.Drawing.Size(100, 28);
            this.MenueBtn.TabIndex = 8;
            this.MenueBtn.Text = "Меню";
            this.MenueBtn.UseVisualStyleBackColor = true;
            this.MenueBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Card0
            // 
            this.Card0.Location = new System.Drawing.Point(166, 355);
            this.Card0.Margin = new System.Windows.Forms.Padding(4);
            this.Card0.Name = "Card0";
            this.Card0.Size = new System.Drawing.Size(100, 108);
            this.Card0.TabIndex = 9;
            this.Card0.Text = "[карта 1]";
            this.Card0.UseVisualStyleBackColor = true;
            this.Card0.Click += new System.EventHandler(this.button5_Click);
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(298, 355);
            this.Card1.Margin = new System.Windows.Forms.Padding(4);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(100, 108);
            this.Card1.TabIndex = 10;
            this.Card1.Text = "[карта 2]";
            this.Card1.UseVisualStyleBackColor = true;
            this.Card1.Click += new System.EventHandler(this.Card1_Click_1);
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(430, 355);
            this.Card2.Margin = new System.Windows.Forms.Padding(4);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(100, 108);
            this.Card2.TabIndex = 11;
            this.Card2.Text = "[карта 3]";
            this.Card2.UseVisualStyleBackColor = true;
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // Card3
            // 
            this.Card3.Location = new System.Drawing.Point(559, 355);
            this.Card3.Margin = new System.Windows.Forms.Padding(4);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(100, 108);
            this.Card3.TabIndex = 12;
            this.Card3.Text = "[карта 4]";
            this.Card3.UseVisualStyleBackColor = true;
            this.Card3.Click += new System.EventHandler(this.Card3_Click_1);
            // 
            // Card4
            // 
            this.Card4.Location = new System.Drawing.Point(687, 355);
            this.Card4.Margin = new System.Windows.Forms.Padding(4);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(100, 108);
            this.Card4.TabIndex = 13;
            this.Card4.Text = "[карта 5]";
            this.Card4.UseVisualStyleBackColor = true;
            this.Card4.Click += new System.EventHandler(this.Card4_Click_1);
            // 
            // Card5
            // 
            this.Card5.Location = new System.Drawing.Point(811, 355);
            this.Card5.Margin = new System.Windows.Forms.Padding(4);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(100, 108);
            this.Card5.TabIndex = 14;
            this.Card5.Text = "[карта 6]";
            this.Card5.UseVisualStyleBackColor = true;
            this.Card5.Click += new System.EventHandler(this.Card5_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(796, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 199);
            this.textBox2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Карты на столе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 477);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Карты в руке";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Card5);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.Card0);
            this.Controls.Add(this.MenueBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Later);
            this.Controls.Add(this.Earlier);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Earlier;
        private System.Windows.Forms.Button Later;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3434;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button MenueBtn;
        private System.Windows.Forms.Button Card0;
        private System.Windows.Forms.Button Card1;
        private System.Windows.Forms.Button Card2;
        private System.Windows.Forms.Button Card3;
        private System.Windows.Forms.Button Card4;
        private System.Windows.Forms.Button Card5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


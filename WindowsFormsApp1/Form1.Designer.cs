
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
            this.button324 = new System.Windows.Forms.Button();
            this.button234 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3434 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button435345 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button324
            // 
            this.button324.Location = new System.Drawing.Point(401, 289);
            this.button324.Margin = new System.Windows.Forms.Padding(4);
            this.button324.Name = "button324";
            this.button324.Size = new System.Drawing.Size(100, 28);
            this.button324.TabIndex = 2;
            this.button324.Text = "Раньше";
            this.button324.UseVisualStyleBackColor = true;
            this.button324.Click += new System.EventHandler(this.button1_Click);
            // 
            // button234
            // 
            this.button234.Location = new System.Drawing.Point(534, 289);
            this.button234.Margin = new System.Windows.Forms.Padding(4);
            this.button234.Name = "button234";
            this.button234.Size = new System.Drawing.Size(100, 28);
            this.button234.TabIndex = 3;
            this.button234.Text = "Позже";
            this.button234.UseVisualStyleBackColor = true;
            this.button234.Click += new System.EventHandler(this.button234_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // button435345
            // 
            this.button435345.Location = new System.Drawing.Point(955, 503);
            this.button435345.Margin = new System.Windows.Forms.Padding(4);
            this.button435345.Name = "button435345";
            this.button435345.Size = new System.Drawing.Size(100, 28);
            this.button435345.TabIndex = 8;
            this.button435345.Text = "Выход";
            this.button435345.UseVisualStyleBackColor = true;
            this.button435345.Click += new System.EventHandler(this.button4_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(166, 355);
            this.button0.Margin = new System.Windows.Forms.Padding(4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(100, 108);
            this.button0.TabIndex = 9;
            this.button0.Text = "button5";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 108);
            this.button1.TabIndex = 10;
            this.button1.Text = "button6";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 355);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 108);
            this.button2.TabIndex = 11;
            this.button2.Text = "button7";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(559, 355);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 108);
            this.button3.TabIndex = 12;
            this.button3.Text = "button8";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(687, 355);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 108);
            this.button4.TabIndex = 13;
            this.button4.Text = "button9";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(811, 355);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 108);
            this.button5.TabIndex = 14;
            this.button5.Text = "button10";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
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
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button435345);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button234);
            this.Controls.Add(this.button324);
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
        private System.Windows.Forms.Button button324;
        private System.Windows.Forms.Button button234;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3434;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button435345;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


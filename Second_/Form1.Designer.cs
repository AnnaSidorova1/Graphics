namespace КГ_лаба2
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
            this.components = new System.ComponentModel.Container();
            this.zgc = new ZedGraph.ZedGraphControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbX = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.fi1 = new System.Windows.Forms.TextBox();
            this.fi2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zgc
            // 
            this.zgc.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.zgc.Location = new System.Drawing.Point(33, 35);
            this.zgc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zgc.Name = "zgc";
            this.zgc.ScrollGrace = 0D;
            this.zgc.ScrollMaxX = 0D;
            this.zgc.ScrollMaxY = 0D;
            this.zgc.ScrollMaxY2 = 0D;
            this.zgc.ScrollMinX = 0D;
            this.zgc.ScrollMinY = 0D;
            this.zgc.ScrollMinY2 = 0D;
            this.zgc.Size = new System.Drawing.Size(600, 600);
            this.zgc.TabIndex = 0;
            this.zgc.UseExtendedPrintDialog = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Построить исходную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(668, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Перенос вдоль Ох";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(918, 35);
            this.tbX.Multiline = true;
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(101, 50);
            this.tbX.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "Перенос вдоль Оy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(668, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 53);
            this.button4.TabIndex = 5;
            this.button4.Text = "Отражение относительно Ох";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(668, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 53);
            this.button5.TabIndex = 6;
            this.button5.Text = "Отражение относительно Оу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(668, 416);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(217, 70);
            this.button6.TabIndex = 7;
            this.button6.Text = "Отражение относительно прямой y = x";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(668, 506);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(217, 53);
            this.button7.TabIndex = 8;
            this.button7.Text = "Масштабирование по Ох\r\n";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(668, 582);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(217, 53);
            this.button8.TabIndex = 9;
            this.button8.Text = "Масштабирование по Оу\r\n";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(918, 193);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(202, 77);
            this.button9.TabIndex = 10;
            this.button9.Text = "Поворот на угол относительно начала координат";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(918, 301);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(202, 77);
            this.button10.TabIndex = 11;
            this.button10.Text = "Поворот на угол относительно заданной точки";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // fi1
            // 
            this.fi1.Location = new System.Drawing.Point(1156, 224);
            this.fi1.Name = "fi1";
            this.fi1.Size = new System.Drawing.Size(100, 22);
            this.fi1.TabIndex = 12;
            // 
            // fi2
            // 
            this.fi2.Location = new System.Drawing.Point(1156, 328);
            this.fi2.Name = "fi2";
            this.fi2.Size = new System.Drawing.Size(100, 22);
            this.fi2.TabIndex = 13;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(1156, 440);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(100, 22);
            this.y2.TabIndex = 14;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(1156, 386);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(100, 22);
            this.x2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1153, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Угол:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1156, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Угол:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1156, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Х:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1156, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Y:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 664);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.fi2);
            this.Controls.Add(this.fi1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zgc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zgc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox fi1;
        private System.Windows.Forms.TextBox fi2;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


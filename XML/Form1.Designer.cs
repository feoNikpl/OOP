namespace XML
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
            this.Products = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Subj = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.GenderT = new System.Windows.Forms.ComboBox();
            this.AgeT = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.Period = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TopicB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.FormatB = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.TextBox();
            this.GenerB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CostB = new System.Windows.Forms.TextBox();
            this.NameBook = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.HideSelection = false;
            this.Products.Location = new System.Drawing.Point(12, 38);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(406, 262);
            this.Products.TabIndex = 0;
            this.Products.UseCompatibleStateImageBehavior = false;
            this.Products.View = System.Windows.Forms.View.List;
            this.Products.SelectedIndexChanged += new System.EventHandler(this.Products_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Товары";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Информация о товаре";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(12, 332);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(406, 166);
            this.info.TabIndex = 16;
            this.info.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CostB);
            this.panel1.Controls.Add(this.NameBook);
            this.panel1.Location = new System.Drawing.Point(450, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 484);
            this.panel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Subj);
            this.panel4.Location = new System.Drawing.Point(11, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 83);
            this.panel4.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Tag = "3";
            this.button3.Text = "добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "учебная литература";
            // 
            // Subj
            // 
            this.Subj.Location = new System.Drawing.Point(3, 40);
            this.Subj.Name = "Subj";
            this.Subj.Size = new System.Drawing.Size(100, 20);
            this.Subj.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.GenderT);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.AgeT);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TopicB);
            this.panel3.Location = new System.Drawing.Point(11, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 196);
            this.panel3.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Tag = "4";
            this.button4.Text = "добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenderT
            // 
            this.GenderT.FormattingEnabled = true;
            this.GenderT.Items.AddRange(new object[] {
            "все",
            "мужчины",
            "женщины"});
            this.GenderT.Location = new System.Drawing.Point(5, 131);
            this.GenderT.Name = "GenderT";
            this.GenderT.Size = new System.Drawing.Size(100, 21);
            this.GenderT.TabIndex = 18;
            // 
            // AgeT
            // 
            this.AgeT.FormattingEnabled = true;
            this.AgeT.Items.AddRange(new object[] {
            "для всех",
            "для детей",
            "18+"});
            this.AgeT.Location = new System.Drawing.Point(5, 90);
            this.AgeT.Name = "AgeT";
            this.AgeT.Size = new System.Drawing.Size(101, 21);
            this.AgeT.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.Color);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(114, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(209, 188);
            this.panel6.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Tag = "5";
            this.button5.Text = "добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // Color
            // 
            this.Color.FormattingEnabled = true;
            this.Color.Items.AddRange(new object[] {
            "Черно-белые",
            "Цветные"});
            this.Color.Location = new System.Drawing.Point(17, 42);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(121, 21);
            this.Color.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.Period);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(3, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 85);
            this.panel5.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(37, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 22;
            this.button6.Tag = "6";
            this.button6.Text = "добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // Period
            // 
            this.Period.FormattingEnabled = true;
            this.Period.Items.AddRange(new object[] {
            "ежедневно",
            "еженедельно",
            "ежемесячно",
            "другое"});
            this.Period.Location = new System.Drawing.Point(13, 26);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(121, 21);
            this.Period.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Газеты";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Комиксы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "журналы";
            // 
            // TopicB
            // 
            this.TopicB.Location = new System.Drawing.Point(5, 46);
            this.TopicB.Name = "TopicB";
            this.TopicB.Size = new System.Drawing.Size(100, 20);
            this.TopicB.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.GenerB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(11, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 126);
            this.panel2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Tag = "1";
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.FormatB);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.Size);
            this.panel7.Location = new System.Drawing.Point(111, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(209, 113);
            this.panel7.TabIndex = 11;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // FormatB
            // 
            this.FormatB.FormattingEnabled = true;
            this.FormatB.Items.AddRange(new object[] {
            "PDF",
            "EPUB",
            "FB2",
            "MOBI"});
            this.FormatB.Location = new System.Drawing.Point(17, 87);
            this.FormatB.Name = "FormatB";
            this.FormatB.Size = new System.Drawing.Size(100, 21);
            this.FormatB.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Tag = "2";
            this.button2.Text = "добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Электронная книга";
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(17, 45);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(100, 20);
            this.Size.TabIndex = 3;
            // 
            // GenerB
            // 
            this.GenerB.Location = new System.Drawing.Point(6, 49);
            this.GenerB.Name = "GenerB";
            this.GenerB.Size = new System.Drawing.Size(100, 20);
            this.GenerB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Книга";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "основные данные";
            // 
            // CostB
            // 
            this.CostB.Location = new System.Drawing.Point(130, 51);
            this.CostB.Name = "CostB";
            this.CostB.Size = new System.Drawing.Size(100, 20);
            this.CostB.TabIndex = 17;
            // 
            // NameBook
            // 
            this.NameBook.Location = new System.Drawing.Point(15, 51);
            this.NameBook.Name = "NameBook";
            this.NameBook.Size = new System.Drawing.Size(100, 20);
            this.NameBook.TabIndex = 16;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(837, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "редактировать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(837, 48);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 23);
            this.button8.TabIndex = 19;
            this.button8.Text = " Удалить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(837, 77);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 23);
            this.button9.TabIndex = 20;
            this.button9.Text = "сохранить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(838, 106);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(97, 23);
            this.button10.TabIndex = 21;
            this.button10.Text = "открыть";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "цветовая гамма";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "гендерный тип";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "возрастной тип";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "тема";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "преиодичность издания";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "предмет";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "жанр";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "размер(мб)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "формат";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "название ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(141, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "стоимость";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 510);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Products);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Subj;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox GenderT;
        private System.Windows.Forms.ComboBox AgeT;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox Color;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox Period;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TopicB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox FormatB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.TextBox GenerB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CostB;
        private System.Windows.Forms.TextBox NameBook;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}


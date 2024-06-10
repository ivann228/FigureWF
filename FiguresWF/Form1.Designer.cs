namespace FiguresWF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.size2_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.size1_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.figure_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.square_button = new System.Windows.Forms.Button();
            this.protocol_listBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.perimetr_button = new System.Windows.Forms.Button();
            this.size4_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.size3_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.size5_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size2_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size1_numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size4_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size3_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size5_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фигура";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.size5_numericUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.size4_numericUpDown);
            this.groupBox1.Controls.Add(this.size3_numericUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.size2_numericUpDown);
            this.groupBox1.Controls.Add(this.size1_numericUpDown);
            this.groupBox1.Controls.Add(this.figure_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(297, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // size2_numericUpDown
            // 
            this.size2_numericUpDown.Location = new System.Drawing.Point(93, 84);
            this.size2_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.size2_numericUpDown.Name = "size2_numericUpDown";
            this.size2_numericUpDown.Size = new System.Drawing.Size(100, 22);
            this.size2_numericUpDown.TabIndex = 2;
            // 
            // size1_numericUpDown
            // 
            this.size1_numericUpDown.Location = new System.Drawing.Point(93, 52);
            this.size1_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.size1_numericUpDown.Name = "size1_numericUpDown";
            this.size1_numericUpDown.Size = new System.Drawing.Size(100, 22);
            this.size1_numericUpDown.TabIndex = 2;
            // 
            // figure_comboBox
            // 
            this.figure_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.figure_comboBox.FormattingEnabled = true;
            this.figure_comboBox.Items.AddRange(new object[] {
            "Прямоугольник",
            "Окружность",
            "Квадрат",
            "Трапеция"});
            this.figure_comboBox.Location = new System.Drawing.Point(93, 20);
            this.figure_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.figure_comboBox.Name = "figure_comboBox";
            this.figure_comboBox.Size = new System.Drawing.Size(160, 24);
            this.figure_comboBox.TabIndex = 1;
            this.figure_comboBox.SelectedIndexChanged += new System.EventHandler(this.figure_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Длина";
            // 
            // square_button
            // 
            this.square_button.Location = new System.Drawing.Point(64, 237);
            this.square_button.Margin = new System.Windows.Forms.Padding(4);
            this.square_button.Name = "square_button";
            this.square_button.Size = new System.Drawing.Size(145, 28);
            this.square_button.TabIndex = 2;
            this.square_button.Text = "Расчет площади";
            this.square_button.UseVisualStyleBackColor = true;
            this.square_button.Click += new System.EventHandler(this.square_button_Click);
            // 
            // protocol_listBox
            // 
            this.protocol_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.protocol_listBox.FormattingEnabled = true;
            this.protocol_listBox.HorizontalScrollbar = true;
            this.protocol_listBox.ItemHeight = 16;
            this.protocol_listBox.Location = new System.Drawing.Point(4, 19);
            this.protocol_listBox.Margin = new System.Windows.Forms.Padding(4);
            this.protocol_listBox.Name = "protocol_listBox";
            this.protocol_listBox.Size = new System.Drawing.Size(495, 263);
            this.protocol_listBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.protocol_listBox);
            this.groupBox2.Location = new System.Drawing.Point(321, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(503, 286);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Протокол расчетов";
            // 
            // perimetr_button
            // 
            this.perimetr_button.Location = new System.Drawing.Point(64, 273);
            this.perimetr_button.Margin = new System.Windows.Forms.Padding(4);
            this.perimetr_button.Name = "perimetr_button";
            this.perimetr_button.Size = new System.Drawing.Size(145, 28);
            this.perimetr_button.TabIndex = 2;
            this.perimetr_button.Text = "Расчет периметра";
            this.perimetr_button.UseVisualStyleBackColor = true;
            this.perimetr_button.Click += new System.EventHandler(this.perimetr_button_Click);
            // 
            // size4_numericUpDown
            // 
            this.size4_numericUpDown.Location = new System.Drawing.Point(93, 146);
            this.size4_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.size4_numericUpDown.Name = "size4_numericUpDown";
            this.size4_numericUpDown.Size = new System.Drawing.Size(100, 22);
            this.size4_numericUpDown.TabIndex = 5;
            // 
            // size3_numericUpDown
            // 
            this.size3_numericUpDown.Location = new System.Drawing.Point(93, 114);
            this.size3_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.size3_numericUpDown.Name = "size3_numericUpDown";
            this.size3_numericUpDown.Size = new System.Drawing.Size(100, 22);
            this.size3_numericUpDown.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ширина 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Длина 2";
            // 
            // size5_numericUpDown
            // 
            this.size5_numericUpDown.Location = new System.Drawing.Point(93, 176);
            this.size5_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.size5_numericUpDown.Name = "size5_numericUpDown";
            this.size5_numericUpDown.Size = new System.Drawing.Size(100, 22);
            this.size5_numericUpDown.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "высота";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.perimetr_button);
            this.Controls.Add(this.square_button);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Демо";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size2_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size1_numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.size4_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size3_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size5_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown size2_numericUpDown;
        private System.Windows.Forms.NumericUpDown size1_numericUpDown;
        private System.Windows.Forms.ComboBox figure_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button square_button;
        private System.Windows.Forms.ListBox protocol_listBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button perimetr_button;
        private System.Windows.Forms.NumericUpDown size4_numericUpDown;
        private System.Windows.Forms.NumericUpDown size3_numericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown size5_numericUpDown;
        private System.Windows.Forms.Label label6;
    }
}


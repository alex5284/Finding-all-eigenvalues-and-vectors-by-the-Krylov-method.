namespace lab5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.dgMatrix = new System.Windows.Forms.DataGridView();
            this.btnKrulov = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnVectors = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(818, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "Для вводу мого варіанту натисніть Test\r\nДля вводу будь-якої матриці натісніть Cre" +
    "ate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Розмір матриці";
            // 
            // btnMatrix
            // 
            this.btnMatrix.Location = new System.Drawing.Point(821, 78);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(84, 30);
            this.btnMatrix.TabIndex = 21;
            this.btnMatrix.Text = "Create";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(920, 78);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(84, 30);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(850, 41);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(100, 22);
            this.tbSize.TabIndex = 19;
            this.tbSize.Text = "4";
            // 
            // dgMatrix
            // 
            this.dgMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatrix.Location = new System.Drawing.Point(24, 26);
            this.dgMatrix.Name = "dgMatrix";
            this.dgMatrix.RowHeadersWidth = 51;
            this.dgMatrix.RowTemplate.Height = 24;
            this.dgMatrix.Size = new System.Drawing.Size(776, 262);
            this.dgMatrix.TabIndex = 18;
            // 
            // btnKrulov
            // 
            this.btnKrulov.Location = new System.Drawing.Point(830, 211);
            this.btnKrulov.Name = "btnKrulov";
            this.btnKrulov.Size = new System.Drawing.Size(84, 34);
            this.btnKrulov.TabIndex = 24;
            this.btnKrulov.Text = "Krulov";
            this.btnKrulov.UseVisualStyleBackColor = true;
            this.btnKrulov.Click += new System.EventHandler(this.btnKrulov_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(984, 220);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 276);
            this.listBox1.TabIndex = 25;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(698, 292);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(252, 228);
            this.listBox2.TabIndex = 26;
            // 
            // btnVectors
            // 
            this.btnVectors.Location = new System.Drawing.Point(585, 309);
            this.btnVectors.Name = "btnVectors";
            this.btnVectors.Size = new System.Drawing.Size(84, 34);
            this.btnVectors.TabIndex = 27;
            this.btnVectors.Text = "Vectors";
            this.btnVectors.UseVisualStyleBackColor = true;
            this.btnVectors.Click += new System.EventHandler(this.btnVectors_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(917, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 34);
            this.label3.TabIndex = 28;
            this.label3.Text = "Для знаходження власних чисел \r\nметодом Крилова натисніть Krulov";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 34);
            this.label4.TabIndex = 29;
            this.label4.Text = "Для знаходження власних векторів \r\nметодом Крилова натисніть Vectors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 532);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVectors);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKrulov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.dgMatrix);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatrix;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.DataGridView dgMatrix;
        private System.Windows.Forms.Button btnKrulov;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnVectors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

